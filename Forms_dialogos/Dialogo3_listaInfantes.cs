using CENDI_admin.Clases.Entidades;
using CENDI_admin.Clases.Utils;
using Npgsql;
using SpreadsheetLight;
using DocumentFormat.OpenXml.Spreadsheet;
using System.Globalization;
using System.Diagnostics;
using System.Data;

namespace CENDI_admin.Forms_dialogos
{
    public partial class Dialogo3_listaInfantes : Form
    {
        private string nomSalon = string.Empty;
        private readonly int noSalon;
        private int diasAsistibles;

        private DataTable? listaInfantes;

        public Dialogo3_listaInfantes(int noSalon)
        {
            InitializeComponent();
            GenerarCBAños();
            GenerarCBMes();
            this.noSalon = noSalon;
        }

        private void btn_exportar_Click(object sender, EventArgs e)
        {
            int mes = (int)cb_mes.SelectedValue;
            int año = (int)cb_año.SelectedValue;

            DateTime fecha = new DateTime(año, mes, 1);
            if (checkBox1.Checked)
            {
                DataTable? asistenciaGrupo = Asistencia.GetReporteAsistenciaSalon(noSalon, fecha.Year, fecha.Month);
                DataTable dataTable = inicializarTabla(fecha.Month, fecha.Year);

                string path;

                if (asistenciaGrupo == null)
                {
                    MessageBox.Show("No hay infantes registrados en este grupo ", "Registro vacio", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int idInfanteAnterior = (int)asistenciaGrupo.Rows[0]["ID_INFANTE"];
                int index = 0;

                dataTable.Rows.Add();

                for (int i = 0; i < asistenciaGrupo.Rows.Count; i++)
                {
                    if (idInfanteAnterior != (int)asistenciaGrupo.Rows[0]["ID_INFANTE"])
                    {
                        dataTable.Rows.Add();
                        index++;

                        Nombre nom = new((string)asistenciaGrupo.Rows[i]["NOM_INFANTE"], (string)asistenciaGrupo.Rows[i]["AP_INFANTE"], (string)asistenciaGrupo.Rows[i]["AM_INFANTE"]);
                        TimeSpan horaAsistencia = (TimeSpan)asistenciaGrupo.Rows[i]["HORA_ENTRADA"];
                        DateTime fechaAsistencia = (DateTime)asistenciaGrupo.Rows[i]["FECHA"];

                        busquedaBinaria(index, ref dataTable, nom.ToString(), fechaAsistencia.Day, horaAsistencia.ToString(@"hh\:mm"));
                    }
                    else
                    {
                        Nombre nom = new((string)asistenciaGrupo.Rows[i]["NOM_INFANTE"], (string)asistenciaGrupo.Rows[i]["AP_INFANTE"], (string)asistenciaGrupo.Rows[i]["AM_INFANTE"]);
                        TimeSpan horaAsistencia = (TimeSpan)asistenciaGrupo.Rows[i]["HORA_ENTRADA"];
                        DateTime fechaAsistencia = (DateTime)asistenciaGrupo.Rows[i]["FECHA"];

                        busquedaBinaria(index, ref dataTable, nom.ToString(), fechaAsistencia.Day, horaAsistencia.ToString(@"hh\:mm"));
                    }
                }

                SaveFileDialog saveFileDialog1 = new SaveFileDialog
                {
                    Filter = "Libro de Excel (*.xlsx)|*.xlsx",
                    Title = "Guardando archivo de registro",
                    FileName = string.Format("Reporte de asistencia {0}", nomSalon),
                    RestoreDirectory = true
                };

                if (saveFileDialog1.ShowDialog() != DialogResult.OK) return;
                if (string.IsNullOrEmpty(saveFileDialog1.FileName)) return;

                path = saveFileDialog1.FileName;

                //pasar las tablas al excel
                SLDocument doc = new();

                FormatearHojaExcel(ref doc, nomSalon, fecha, dataTable);
                doc.DeleteWorksheet("Sheet1");
                doc.SaveAs(path);

                AbrirArchivo(path);
            }
            else
            {
                DataTable dataTable = inicializarTabla(fecha.Month, fecha.Year);

                string path;

                if (listaInfantes == null)
                {
                    MessageBox.Show("No hay infantes registrados en este grupo ", "Registro vacio", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                for (int i = 0; i < listaInfantes.Rows.Count; i++)
                {
                    dataTable.Rows.Add();
                    Nombre nom = new((string)listaInfantes.Rows[i]["NOMBRES"], (string)listaInfantes.Rows[i]["AP_PAT"], (string)listaInfantes.Rows[i]["AP_MAT"]);
                    dataTable.Rows[i][0] = nom.ToString();
                }

                SaveFileDialog saveFileDialog1 = new SaveFileDialog
                {
                    Filter = "Libro de Excel (*.xlsx)|*.xlsx",
                    Title = "Guardando archivo de registro",
                    FileName = string.Format("Reporte de asistencia {0}", nomSalon),
                    RestoreDirectory = true
                };

                if (saveFileDialog1.ShowDialog() != DialogResult.OK) return;
                if (string.IsNullOrEmpty(saveFileDialog1.FileName)) return;

                path = saveFileDialog1.FileName;

                //pasar las tablas al excel
                SLDocument doc = new();

                FormatearHojaExcel(ref doc, nomSalon, fecha, dataTable);
                doc.DeleteWorksheet("Sheet1");
                doc.SaveAs(path);

                AbrirArchivo(path);
            }
        }

        private void Dialogo3_listaInfantes_Load(object sender, EventArgs e)
        {
            LlenarListaInfante();
        }

        private void busquedaBinaria(int noFila, ref DataTable arreglo, string nomAlumno, int diaBusqueda, string horaIngreso)
        {
            arreglo.Rows[noFila][0] = nomAlumno;

            //busqueda binaria
            int izq = 1, der = arreglo.Columns.Count - 1;

            while (izq <= der)
            {
                //obtenemos el indice del valor medio
                int media = Convert.ToInt32(Math.Floor(Convert.ToDouble(izq + der) / 2));

                //la media es el valor buscado
                if (int.Parse(arreglo.Columns[media].ColumnName) == diaBusqueda)
                {
                    arreglo.Rows[noFila][media] = horaIngreso;

                    if (string.IsNullOrEmpty(arreglo.Rows[noFila][arreglo.Columns.Count - 1].ToString()))
                    {
                        arreglo.Rows[noFila][arreglo.Columns.Count - 1] = string.Format("1 de {0}", diasAsistibles);
                    }
                    else
                    {
                        arreglo.Rows[noFila][arreglo.Columns.Count - 1] = string.Format("{0} de {1}", (int)arreglo.Rows[noFila][arreglo.Columns.Count] + 1, diasAsistibles);

                    }
                }
                
                if (diaBusqueda < int.Parse(arreglo.Columns[media].ColumnName))
                    der = media - 1;
                else
                    izq = media + 1;
            }
        }
        private void FormatearHojaExcel(ref SLDocument doc, string nomHoja, DateTime fecha, DataTable dt)
        {

            char[] alfafeto = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
            string celdaFinal = alfafeto[dt.Columns.Count - 1] + "1";
            string celdaFinal2 = alfafeto[dt.Columns.Count - 1] + "2";

            SLStyle style = doc.CreateStyle();
            style.SetHorizontalAlignment(HorizontalAlignmentValues.Center);

            doc.AddWorksheet(nomHoja);
            doc.SetColumnWidth(1, 40);

            for (int i = 2; i < dt.Columns.Count; i++)
                doc.SetColumnWidth(i, 6);
            
            doc.SetColumnWidth(dt.Columns.Count, 18);

            doc.MergeWorksheetCells("A1", celdaFinal);
            doc.SetCellValue("A1", string.Format("Reporte de asistencia {0} {1}", fecha.ToString("MMMM", new CultureInfo("es-ES")), fecha.Year));
            doc.SetCellStyle("A1", style);

            doc.MergeWorksheetCells("B2", celdaFinal2);
            doc.SetCellValue("B2", string.Format("Dias de la semana"));
            doc.SetCellStyle("B2", style);

            doc.SetCellValue("A2", string.Format("Salon: {0}", nomSalon));

            doc.ImportDataTable("A3", dt, true);
        }
        private DataTable inicializarTabla(int mes, int año)
        {
            int noDias = DateTime.DaysInMonth(año, mes);

            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Nombre");

            for (int dia = 1; dia <= noDias; dia++)
            {
                DateTime fecha = new(año, mes, dia);
                if ((int)fecha.DayOfWeek >= 1 && (int)fecha.DayOfWeek <= 5)
                {
                    dataTable.Columns.Add(dia.ToString("D2"));
                    diasAsistibles++;
                }
            }
            dataTable.Columns.Add("Total de asistencia");
            return dataTable;
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
        private void LlenarListaInfante()
        {
            try
            {
                listaInfantes = Salon.GetInfanteSalon(noSalon);

                if (listaInfantes == null)
                {
                    MessageBox.Show("No hay infantes registrados en este grupo ", "Registro vacio", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Close();
                    return;
                }

                nomSalon = string.Format("{0} {1}° - {2}", (string)listaInfantes.Rows[0]["NIVEL"], (string)listaInfantes.Rows[0]["GRADO"], (string)listaInfantes.Rows[0]["GRUPO"]);

                foreach (DataRow row in listaInfantes.Rows)
                {
                    Nombre nomInfante = new((string)row["NOMBRES"], (string)row["AP_PAT"], (string)row["AP_MAT"]);
                    dataGridView1.Rows.Add(nomInfante.ToString());
                }
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show("Error al cargar la lista de infantes registrados en el salon, intente mas tarde " + ex.Message, "Error de consulta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
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
