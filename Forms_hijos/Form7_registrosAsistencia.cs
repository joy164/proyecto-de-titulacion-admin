using CENDI_admin.Clases.Entidades;
using CENDI_admin.Forms_dialogos;
using CENDI_admin.Clases.Utils;
using System.Data;
using SpreadsheetLight;
using System.Diagnostics;
using DocumentFormat.OpenXml.Spreadsheet;
using Npgsql;
using System.Globalization;
using CENDI_admin.Clases.Cache;

namespace CENDI_admin.Forms_hijos
{
    public partial class Form7_registrosAsistencia : Form
    {
        private int modo;
        private DataTable? grupos;
        private bool cargaCompleta = false;



        public Form7_registrosAsistencia(int modo)
        {
            InitializeComponent();
            GenerarCBGrupos();

            label1.Text += (modo == (int)Asistencia.Tipo.entrada) ? " entrada" : " salida";
            
            this.modo = modo;
            
            LlenarTabla(DateTime.Today, (int)cb_grupo.SelectedValue);

            if (DatosUsuario.TipoUsuario == (int)DatosUsuario.Tipo.Usuario)
                btn_eliminar.Visible = false;
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0) return;

            int noReg = (int)dataGridView1.SelectedRows[0].Cells[0].Value;

            Dialogo10_edicionAsistencia form = new(modo, noReg);

            form.ShowDialog();

            LlenarTabla(dtp_fecha.Value, (int)cb_grupo.SelectedValue);
        }
        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0) return;

            DialogResult res = MessageBox.Show("¿Esta seguro que quiere eliminar el registro seleccionado?", "Eliminando registro...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (res == DialogResult.No) return;

            int noReg = (int)dataGridView1.SelectedRows[0].Cells[0].Value;

            try
            {
                Asistencia.DeleteAsistencia(modo, noReg);
                MessageBox.Show("Registro eliminado con exito", "Registro eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LlenarTabla(dtp_fecha.Value, (int)cb_grupo.SelectedValue);
            }
            catch (NpgsqlException ex)
            {

                MessageBox.Show("Error de baja, intente mas tarde o revise la conexion a internet " + ex.Message, "Error de baja", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btn_exportar_Click(object sender, EventArgs e)
        {
            DateTime fecha = dtp_fecha.Value;
            string path;

            if (checkBoxGrupoActual.Checked)
            {

                string nomSalon = cb_grupo.GetItemText(cb_grupo.SelectedItem);
                int noSalon = (int)cb_grupo.SelectedValue;

                DataTable? res = Asistencia.GetReporteAsistencia(fecha, noSalon);
                DataTable dt_aux = InicializarTablaAuxiliar(nomSalon);

                if (res == null) return;

                foreach (DataRow row in res.Rows)
                {
                    Nombre nomInfante = new((string)row["NOM_INFANTE"], (string)row["AP_INFANTE"], (string)row["AM_INFANTE"]);
                    Nombre nomTutorEntrada = new((string)row["NOM_TUTOR_ENTREGA"], (string)row["AP_TUTOR_ENTREGA"], (string)row["AM_TUTOR_ENTREGA"]);
                    Nombre nomTutorSalida = new((string)row["NOM_TUTOR_RECOGE"], (string)row["AP_TUTOR_RECOGE"], (string)row["AM_TUTOR_RECOGE"]);

                    TimeSpan horaEntrada = (TimeSpan)row["HORA_ENTRADA"];
                    TimeSpan horaSalida = (TimeSpan)row["HORA_SALIDA"];

                    string notaEntrada = (string)row["OBSERVACIONES_ENTRADA"];
                    string notaSalida = (string)row["OBSERVACIONES_SALIDA"];

                    dt_aux.Rows.Add(horaEntrada.ToString(@"hh\:mm"), nomInfante.ToString(), nomTutorEntrada.ToString("NOM_AP"), notaEntrada, horaSalida.ToString(@"hh\:mm"), nomTutorSalida.ToString("NOM_AP"), notaSalida);
                }

                SaveFileDialog saveFileDialog1 = new SaveFileDialog
                {
                    Filter = "Libro de Excel (*.xlsx)|*.xlsx",
                    Title = "Guardando archivo de registro",
                    FileName = string.Format("Reporte de asistencia {0} {1}", nomSalon, fecha.ToString("dd-MM-yyyy")),
                    RestoreDirectory = true
                };

                if (saveFileDialog1.ShowDialog() != DialogResult.OK) return;
                if (string.IsNullOrEmpty(saveFileDialog1.FileName)) return;

                path = saveFileDialog1.FileName;

                //pasar las tablas al excel
                SLDocument doc = new();

                FormatearHojaExcel(ref doc, nomSalon, fecha, dt_aux);
                doc.DeleteWorksheet("Sheet1");
                doc.SaveAs(path);

                AbrirArchivo(path);
            }
            else
            {
                if (grupos == null) return;

                DataSet ds_aux = new();

                foreach (DataRow grupo in grupos.Rows)
                {
                    DataTable? res = Asistencia.GetReporteAsistencia(fecha, (int)grupo["clave"]);
                    DataTable dt_aux = InicializarTablaAuxiliar((string)grupo["texto"]);

                    if (res != null)
                    {
                        foreach (DataRow row in res.Rows)
                        {
                            Nombre nomInfante = new((string)row["NOM_INFANTE"], (string)row["AP_INFANTE"], (string)row["AM_INFANTE"]);
                            Nombre nomTutorEntrada = new((string)row["NOM_TUTOR_ENTREGA"], (string)row["AP_TUTOR_ENTREGA"], (string)row["AM_TUTOR_ENTREGA"]);
                            Nombre nomTutorSalida = new((string)row["NOM_TUTOR_RECOGE"], (string)row["AP_TUTOR_RECOGE"], (string)row["AM_TUTOR_RECOGE"]);

                            TimeSpan horaEntrada = (TimeSpan)row["HORA_ENTRADA"];
                            TimeSpan horaSalida = (TimeSpan)row["HORA_SALIDA"];

                            string notaEntrada = (string)row["OBSERVACIONES_ENTRADA"];
                            string notaSalida = (string)row["OBSERVACIONES_SALIDA"];

                            dt_aux.Rows.Add(horaEntrada.ToString(@"hh\:mm"), nomInfante.ToString(), nomTutorEntrada.ToString("NOM_AP"), notaEntrada, horaSalida.ToString(@"hh\:mm"), nomTutorSalida.ToString("NOM_AP"), notaSalida);
                        }

                        ds_aux.Tables.Add(dt_aux);
                    }
                    else
                        ds_aux.Tables.Add(dt_aux);
                }

                SaveFileDialog saveFileDialog1 = new SaveFileDialog
                {
                    Filter = "Libro de Excel (*.xlsx)|*.xlsx",
                    Title = "Guardando archivo de registro",
                    FileName = string.Format("Reporte de asistencia {0}", fecha.ToString("dd-MM-yyyy")),
                    RestoreDirectory = true
                };

                if (saveFileDialog1.ShowDialog() != DialogResult.OK) return;
                if (string.IsNullOrEmpty(saveFileDialog1.FileName)) return;

                path = saveFileDialog1.FileName;

                //pasar las tablas al excel
                SLDocument doc = new();

                foreach (DataTable tabla in ds_aux.Tables)
                    FormatearHojaExcel(ref doc, tabla.TableName, fecha, tabla);

                doc.DeleteWorksheet("Sheet1");
                doc.SaveAs(path);

                AbrirArchivo(path);
            }
        }

        private void cb_grupo_SelectedValueChanged(object sender, EventArgs e)
        {
            if (!cargaCompleta) return;

            int noSalon = (int)cb_grupo.SelectedValue;
            DateTime fecha = dtp_fecha.Value;

            LlenarTabla(fecha, noSalon);

        }
        private void dtp_fecha_ValueChanged(object sender, EventArgs e)
        {
            if (!cargaCompleta) return;

            int noSalon = (int)cb_grupo.SelectedValue;
            DateTime fecha = dtp_fecha.Value;

            LlenarTabla(fecha, noSalon);
        }

        private void FormatearHojaExcel(ref SLDocument doc, string nomHoja, DateTime fecha, DataTable dt)
        {
            SLStyle style = doc.CreateStyle();
            style.SetHorizontalAlignment(HorizontalAlignmentValues.Center);

            doc.AddWorksheet(nomHoja);
            doc.SetColumnWidth("A", 15);
            doc.SetColumnWidth("B", 25);
            doc.SetColumnWidth("C", 25);
            doc.SetColumnWidth("D", 30);
            doc.SetColumnWidth("E", 15);
            doc.SetColumnWidth("F", 25);
            doc.SetColumnWidth("G", 30);

            doc.MergeWorksheetCells("A1", "G1");
            doc.SetCellValue("A1", string.Format("Reporte de asistencia {0}", nomHoja));
            doc.SetCellStyle("A1", style);

            
            doc.SetCellValue("A2", string.Format("Fecha: {0} {1}", fecha.ToString("dddd", new CultureInfo("es-ES")), fecha.ToString("dd-MM-yyyy")));

            doc.SetCellValue("A3", "Entradas");
            doc.SetCellValue("D3", "Salidas");

            doc.SetCellValue("A1", string.Format("Reporte de asistencia {0}", nomHoja));

            doc.ImportDataTable("A4", dt, true);

        }
        private void LlenarTabla(DateTime fechaConsulta, int noSalon)
        {
            DataTable? res = Asistencia.GetAsistencia(modo, noSalon, fechaConsulta);

            dataGridView1.Rows.Clear();

            if (res == null || res.Rows.Count == 0) return;

            foreach (DataRow row in res.Rows)
            {
                Nombre nomInfante = new((string)row["NOM_INFANTE"], (string)row["AP_INFANTE"], (string)row["AM_INFANTE"]);
                Nombre nomTutor = new((string)row["NOM_TUTOR"], (string)row["AP_TUTOR"], (string)row["AM_TUTOR"]);
                int noReg = modo == 1 ? (int)row["NO_REG_ENTRADA"] : (int)row["NO_REG_SALIDA"];
                string observaciones = (string)row["OBSERVACIONES"];
                TimeSpan hora = (TimeSpan)row["HORA"];

                dataGridView1.Rows.Add(noReg, hora.ToString(@"hh\:mm"), nomInfante.ToString(), nomTutor.ToString(), observaciones);
            }
        }
        private DataTable InicializarTablaAuxiliar(string nombre)
        {
            DataTable dt_aux = new(nombre);

            dt_aux.Columns.Add("Hora entrada", typeof(string));
            dt_aux.Columns.Add("Nombre de infante", typeof(string));
            
            dt_aux.Columns.Add("Tutor entrada", typeof(string));
            dt_aux.Columns.Add("Observaciones entrada", typeof(string));

            dt_aux.Columns.Add("Hora salida", typeof(string));
            
            dt_aux.Columns.Add("Tutor salida", typeof(string));
            dt_aux.Columns.Add("Observaciones salida", typeof(string));

            return dt_aux;
        }
        private void AbrirArchivo(string path)
        {
            try
            {
                if (File.Exists(path))
                {
                    var p = new Process
                    {
                        StartInfo = new ProcessStartInfo(path)
                        {
                            UseShellExecute = true
                        }
                    };

                    p.Start();
                }
                else
                {
                    MessageBox.Show("Error al generar Excel, intente mas tarde", "Archivo no generado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show("Error al generar Excel, intente mas tarde" + ex.Message, "Archivo no generado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void GenerarCBGrupos()
        {
            try
            {
                grupos = Salon.GetAllSalon(true);

                if (grupos == null)
                {
                    MessageBox.Show("No hay grupos registrados, debe registrar al menos un grupo para hacer inscripciones o reinscripciones", "Error de consulta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cargaCompleta = false;
                    return;
                }

                grupos.Rows.RemoveAt(0);

                cb_grupo.DataSource = grupos;
                cb_grupo.ValueMember = "clave";
                cb_grupo.DisplayMember = "texto";
                cargaCompleta = true;
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show("Error al cargar los grupos registrados " + ex.Message, "Error de consulta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cargaCompleta = false;
            }
        }

    }
}
