using CENDI_admin.Clases.Entidades;
using CENDI_admin.Clases.Utils;
using CENDI_admin.Forms_dialogos;
using DocumentFormat.OpenXml.Spreadsheet;
using Npgsql;
using SpreadsheetLight;
using System.Data;
using System.Diagnostics;

namespace CENDI_admin.Forms_hijos
{
    public partial class Form4_infantes : Form
    {
        private bool fechaValida = false, reiniciandoFormulario = false;
        private int infanteID;

        public Form4_infantes()
        {
            InitializeComponent();

            GenerarCBEntidades();
            GenerarCBGrupos();
            GenerarCBSexo();
            GenerarCBAños();
            GenerarCBMes();
        }

        private void btn_tomarFoto_Click(object sender, EventArgs e)
        {
            Dialogo6_foto form = new();

            if (form.ShowDialog() == DialogResult.OK)
                pb_imgInfante.Image = form.FotoCapturada;
        }
        private void btn_cargarFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "jpg (*.jpg)|*.jpg|png (*.png)|*.png|gif (*.gif)|*.gif",
                RestoreDirectory = true
            };

            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
                pb_imgInfante.ImageLocation = openFileDialog.FileName;
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            if (!ValidacionCampos.ValidarEntradasTexto(tb_busqueda)) return;

            try
            {
                infanteID = Infante.GetInfanteID(tb_busqueda.Text);

                if (infanteID == 0)
                {
                    MessageBox.Show("El Infante no ha sido encotrado o no existe", "Error de consulta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DataTable? infante = Infante.GetInfante(infanteID);

                if (infante == null)
                {
                    MessageBox.Show("El Infante no ha sido encotrado o no existe", "Error de consulta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                
                tb_busqueda.Enabled = false;
                btn_buscar.Enabled = false;

                gb_asistencia.Enabled = true;
                gb_acciones.Enabled = true;
                gb_datos.Enabled = true;
                gb_foto.Enabled = true;
                
                pb_imgInfante.Image = Imagenes.ByteArrayToImagen((byte[])infante.Rows[0]["IMG_INFANTE"]);

                tb_nombre.Text = (string)infante.Rows[0]["NOMBRES"];
                tb_curp.Text = (string)infante.Rows[0]["CURP"];
                tb_ap.Text = (string)infante.Rows[0]["AP_PAT"];
                tb_am.Text = (string)infante.Rows[0]["AP_MAT"];

                dtp_fechaNac.Value = (DateTime)infante.Rows[0]["FECHA_NAC"];

                cb_sexo.SelectedValue = infante.Rows[0]["SEXO_INFANTE"].ToString()[0];
                cb_lugarNac.SelectedValue = (int)infante.Rows[0]["LUGAR_NAC"];
                cb_grupo.SelectedValue = (int)infante.Rows[0]["NO_SALON"];
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show("Error al cargar los datos de infante " + ex.Message, "Error de consulta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void tb_busqueda_KeyDown(object sender, KeyEventArgs e)
        {
            if (!ValidacionCampos.ValidarEntradasTexto(tb_busqueda)) return;

            if (e.KeyCode != Keys.Enter) return;

            try
            {
                infanteID = Infante.GetInfanteID(tb_busqueda.Text);

                if (infanteID == 0)
                {
                    MessageBox.Show("El Infante no ha sido encotrado o no existe", "Error de consulta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DataTable? infante = Infante.GetInfante(infanteID);

                if (infante == null)
                {
                    MessageBox.Show("El Infante no ha sido encotrado o no existe", "Error de consulta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                tb_busqueda.Enabled = false;
                btn_buscar.Enabled = false;

                gb_asistencia.Enabled = true;
                gb_acciones.Enabled = true;
                gb_datos.Enabled = true;
                gb_foto.Enabled = true;

                pb_imgInfante.Image = Imagenes.ByteArrayToImagen((byte[])infante.Rows[0]["IMG_INFANTE"]);

                tb_nombre.Text = (string)infante.Rows[0]["NOMBRES"];
                tb_curp.Text = (string)infante.Rows[0]["CURP"];
                tb_ap.Text = (string)infante.Rows[0]["AP_PAT"];
                tb_am.Text = (string)infante.Rows[0]["AP_MAT"];

                dtp_fechaNac.Value = (DateTime)infante.Rows[0]["FECHA_NAC"];

                cb_sexo.SelectedValue = infante.Rows[0]["SEXO_INFANTE"].ToString()[0];
                cb_lugarNac.SelectedValue = (int)infante.Rows[0]["LUGAR_NAC"];
                cb_grupo.SelectedValue = (int)infante.Rows[0]["NO_SALON"];
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show("Error al cargar los datos de infante " + ex.Message, "Error de consulta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (!ValidacionCampos.ValidarEntradasTexto(tb_curp, tb_nombre, tb_ap, tb_am, cb_grupo, cb_lugarNac, cb_sexo) || !fechaValida)
            {
                MessageBox.Show("Entrada no valida en el campo(s) señalado(s)", "Error en los campos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

#pragma warning disable CS8604 // Posible argumento de referencia nulo
            int noSalon = int.Parse(cb_grupo.SelectedValue.ToString());
#pragma warning restore CS8604 // Posible argumento de referencia nulo
            char sexo = cb_sexo.SelectedValue.ToString()[0];

            LugarNac lugarNac = new(dtp_fechaNac.Value, (int)cb_lugarNac.SelectedValue);
            Edad edad = new Edad((int)NUD_año.Value, (int)NUD_mes.Value);
            Nombre nombre = new(tb_nombre.Text, tb_ap.Text, tb_am.Text);
            
            try
            {
                Infante.UpdateInfanteData(infanteID, noSalon, pb_imgInfante.Image, nombre, tb_curp.Text, lugarNac, edad, sexo);
                MessageBox.Show("Datos actualizados con exito", "Informacion actualizada", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ValidacionCampos.LimpiarCampos(tb_busqueda, tb_curp, tb_nombre, tb_ap, tb_am, cb_lugarNac, cb_sexo, cb_grupo);

                gb_asistencia.Enabled = false;
                gb_acciones.Enabled = false;
                gb_datos.Enabled = false;
                gb_foto.Enabled = false;
                
                tb_busqueda.Enabled = true;
                btn_buscar.Enabled = true;

                reiniciandoFormulario = true;
                pb_imgInfante.Image = null;
                fechaValida = false;
                infanteID = 0;

                dtp_fechaNac.Value = DateTime.Today;
                dataGridView1.Rows.Clear();
                NUD_año.Value = 0;
                NUD_mes.Value = 0;
            }
            catch (NpgsqlException ex)
            {

                MessageBox.Show("Error de actualizacion, intente mas tarde o revise la conexion a internet " + ex.Message, "Error de registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("¿Esta seguro que quiere eliminar al infante?", "Eliminando infante...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (res == DialogResult.No) return;

            try
            {
                Infante.DeleteInfante(infanteID);
                MessageBox.Show("Infante eliminado con exito", "Baja realizada", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ValidacionCampos.LimpiarCampos(tb_busqueda, tb_curp, tb_nombre, tb_ap, tb_am, cb_lugarNac, cb_sexo, cb_grupo);

                gb_foto.Enabled = false;
                gb_datos.Enabled = false;
                gb_acciones.Enabled = false;
                gb_asistencia.Enabled = false;

                tb_busqueda.Enabled = true;
                btn_buscar.Enabled = true;

                reiniciandoFormulario = true;
                pb_imgInfante.Image = null;
                fechaValida = false;
                infanteID = 0;

                dtp_fechaNac.Value = DateTime.Today;
                dataGridView1.Rows.Clear();
                NUD_año.Value = 0;
                NUD_mes.Value = 0;


            }
            catch (NpgsqlException ex)
            {

                MessageBox.Show("Error de baja, intente mas tarde o revise la conexion a internet " + ex.Message, "Error de baja", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btn_buscarAsistencia_Click(object sender, EventArgs e)
        {
            if (!ValidacionCampos.ValidarEntradasTexto(cb_año, cb_mes))
            {
                MessageBox.Show("Entrada no valida en el campo(s) señalado(s)", "Error en los campos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int año = (int)cb_año.SelectedValue;
            int mes = (int)cb_mes.SelectedValue;

            CargarTablaAsistencia(año, mes);
        }
        private void btn_exportarAsistencia_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0) return;

            string[] displayMes = { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" };

            DataTable reporte = ToDataTable(dataGridView1, "reporte");
            Nombre nom = new(tb_nombre.Text, tb_ap.Text, tb_am.Text);

            string? año = cb_año.SelectedValue.ToString();
            int mes = (int)cb_mes.SelectedValue;

            string path;

            //pedimos en que ruta es donde vamos a guardar las credenciales generadas
            SaveFileDialog saveFileDialog1 = new SaveFileDialog
            {
                Filter = "Libro de Excel (*.xlsx)|*.xlsx",
                Title = "Guardando archivo de registro",
                FileName = string.Format("Reporte de asistencia {0} ({1} {2})", nom.ToString(), displayMes[mes - 1], año),
                RestoreDirectory = true
            };

            if (saveFileDialog1.ShowDialog() != DialogResult.OK) return;
            if (string.IsNullOrEmpty(saveFileDialog1.FileName)) return;

            path = saveFileDialog1.FileName;

            //pasar las tablas al excel
            SLDocument doc = new();

            SLStyle style = doc.CreateStyle();
            style.SetHorizontalAlignment(HorizontalAlignmentValues.Center);


            doc.AddWorksheet("Reporte");
            doc.SetColumnWidth("A", 11);
            doc.SetColumnWidth("B", 14);
            doc.SetColumnWidth("C", 14);
            doc.SetColumnWidth("D", 20);
            doc.SetColumnWidth("E", 20);
            doc.SetColumnWidth("F", 20);
            doc.SetColumnWidth("G", 20);

            doc.MergeWorksheetCells("A1", "G1");
            doc.SetCellValue("A1", string.Format("Reporte de asistencia {0} {1}", displayMes[mes - 1], año));
            doc.SetCellStyle("A1", style);

            doc.MergeWorksheetCells("A2", "D2");
            doc.SetCellValue("A2", string.Format("Infante: {0}", nom.ToString()));

            doc.SetCellStyle("A4", "G4", style);

            //ordenamos tabla en base al nombre del infante
            doc.ImportDataTable("A4", reporte, true);

            doc.DeleteWorksheet("Sheet1");
            doc.SaveAs(path);

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

        private void dtp_fechaNac_ValueChanged(object sender, EventArgs e)
        {
            if (dtp_fechaNac.Value >= DateTime.Today)
            {
                if (!reiniciandoFormulario)
                {
                    MessageBox.Show("La fecha seleccionada no es valida", "Fecha invalida", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    fechaValida = false;
                }
                else
                    reiniciandoFormulario = false;

                return;
            }

            DateTime nacimiento = dtp_fechaNac.Value;
            DateTime hoy = DateTime.Today;

            // Años
            int edadAnos = hoy.Year - nacimiento.Year;
            if (hoy.Month < nacimiento.Month || (hoy.Month == nacimiento.Month &&
            hoy.Day < nacimiento.Day))
                edadAnos--;

            // Meses
            int edadMeses = hoy.Month - nacimiento.Month;
            if (hoy.Day < nacimiento.Day)
                edadMeses--;
            if (edadMeses < 0)
                edadMeses += 12;

            NUD_año.Value = edadAnos;
            NUD_mes.Value = edadMeses;
            fechaValida = true;
        }
        private void tb_busqueda_TextChanged(object sender, EventArgs e)
        {
            ValidacionCampos.CambiarMayuscula(ref tb_busqueda);
        }
        private void tb_nombre_TextChanged(object sender, EventArgs e)
        {
            ValidacionCampos.CapitalizarTexto(ref tb_nombre);
        }
        private void tb_ap_TextChanged(object sender, EventArgs e)
        {
            ValidacionCampos.CapitalizarTexto(ref tb_ap);
        }
        private void tb_am_TextChanged(object sender, EventArgs e)
        {
            ValidacionCampos.CapitalizarTexto(ref tb_ap);
        }
        

        public static DataTable ToDataTable(DataGridView dataGridView, string tableName)
        {
            DataTable res = new(tableName);

            //creando las filas
            foreach (DataGridViewColumn column in dataGridView.Columns)
                res.Columns.Add(column.HeaderText);


            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                DataRow dataRow = res.NewRow();
                for (int j = 0; j < dataGridView.Rows[i].Cells.Count; j++)
                    dataRow[j] = dataGridView.Rows[i].Cells[j].Value;

                res.Rows.Add(dataRow);
            }

            return res;
        }
        private void CargarTablaAsistencia(int AÑO, int MES)
        {
            try
            {
                DataTable? regAsistencia = Asistencia.GetReporteAsistencia(infanteID, AÑO, MES);
                dataGridView1.Rows.Clear();

                if (regAsistencia == null) return;

                foreach (DataRow row in regAsistencia.Rows)
                {
                    DateTime fecha = (DateTime)row["FECHA"];
                    TimeSpan horaEntrada = (TimeSpan)row["HORA_ENTRADA"];
                    TimeSpan horaSalida = (TimeSpan)row["HORA_SALIDA"];
                    Nombre nomTutorEntrega = new((string)row["NOM_TUTOR_ENTREGA"], (string)row["AP_TUTOR_ENTREGA"], (string)row["AM_TUTOR_ENTREGA"]);
                    Nombre nomTutorSalida = new((string)row["NOM_TUTOR_RECOGE"], (string)row["AP_TUTOR_RECOGE"], (string)row["AM_TUTOR_RECOGE"]);

                    dataGridView1.Rows.Add(fecha.ToString("dd/MM/yyyy"), horaEntrada.ToString(@"hh\:mm"), horaSalida.ToString(@"hh\:mm"), nomTutorEntrega.ToString("NOM_AP"), row["PARENTESCO_ENTREGA"].ToString(), nomTutorEntrega.ToString("NOM_AP"), row["PARENTESCO_RECOGE"].ToString());
                }
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show("Error al cargar el reporte de asistencia, intente mas tarde o revise la conexion a internet " + ex.Message, "Error de consulta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void GenerarCBEntidades()
        {
            try
            {
                DataTable? entidad = Direccion.GetEstado(true);

                cb_lugarNac.DataSource = entidad;
                cb_lugarNac.ValueMember = "clave";
                cb_lugarNac.DisplayMember = "texto";

                if (entidad == null)
                    btn_guardar.Enabled = false;
                else
                    cb_lugarNac.SelectedValue = 9;

            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show("Error al cargar los salones registrados " + ex.Message, "Error de consulta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btn_guardar.Enabled = false;
            }
        }
        private void GenerarCBGrupos()
        {
            try
            {
                DataTable? grupos = Salon.GetAllSalon(true);

                cb_grupo.DataSource = grupos;
                cb_grupo.ValueMember = "clave";
                cb_grupo.DisplayMember = "texto";

                if (grupos == null)
                {
                    MessageBox.Show("No hay grupos registrados, debe registrar al menos un grupo para hacer inscripciones o reinscripciones", "Error de consulta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btn_guardar.Enabled = false;
                }

            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show("Error al cargar los salones registrados " + ex.Message, "Error de consulta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btn_guardar.Enabled = false;
            }
        }
        private void GenerarCBSexo()
        {
            string[] sexoDisplay = { "Masculino", "Femenino" };
            char[] sexoValue = { 'M', 'F' };

            DataTable grupos = new();

            grupos.Columns.Add("clave", typeof(char));
            grupos.Columns.Add("texto", typeof(string));
            grupos.Rows.Add(null, "NO SELECCIONADO");

            for (int i = 0; i < sexoDisplay.Length; i++)
            {
                grupos.Rows.Add(sexoValue[i], sexoDisplay[i]);
            }

            cb_sexo.DataSource = grupos;
            cb_sexo.ValueMember = "clave";
            cb_sexo.DisplayMember = "texto";
        }
        private void GenerarCBAños()
        {

            DateTime fecha = DateTime.Today;

            DataTable años = new();

            años.Columns.Add("clave", typeof(int));
            años.Columns.Add("texto", typeof(string));
            años.Rows.Add(null, "NO SELECCIONADO");

            for (int i = 0; i < 5; i++)
            {
                DateTime aux = fecha.AddYears(i - 2);
                años.Rows.Add(aux.Year, string.Format("Año {0}", aux.Year));
            }

            cb_año.DataSource = años;
            cb_año.ValueMember = "clave";
            cb_año.DisplayMember = "texto";

            cb_año.SelectedValue = fecha.Year;
        }
        private void GenerarCBMes()
        {
            string[] displayMes = { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" };

            DataTable meses = new();

            meses.Columns.Add("clave", typeof(int));
            meses.Columns.Add("texto", typeof(string));
            meses.Rows.Add(null, "NO SELECCIONADO");

            for (int i = 0; i < 12; i++)
                meses.Rows.Add(i + 1, displayMes[i]);

            cb_mes.DataSource = meses;
            cb_mes.ValueMember = "clave";
            cb_mes.DisplayMember = "texto";

            cb_mes.SelectedValue = DateTime.Today.Month;
        }

    }
}
