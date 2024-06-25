using CENDI_admin.Clases.Entidades;
using CENDI_admin.Clases.Utils;
using Gma.QrCodeNet.Encoding.Windows.Render;
using Gma.QrCodeNet.Encoding;
using iTextSharp.text.pdf;
using iTextSharp.text;
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CENDI_admin.Forms_dialogos
{
    public partial class Dialogo9_credencialActualizada : Form
    {
        private bool cargaCompleta = false;
        private int noTutor, noCiclo;
        private string path = string.Empty;
        private DataTable? datosPermiso = new();

        public Dialogo9_credencialActualizada(int noTutor)
        {
            InitializeComponent();
            this.noTutor = noTutor;
            this.noCiclo = CicloEscolar.GetIDCicloActual();

            GenerarCBInfantes();
            datosPermiso = InfanteTutor.GetAllTutorInfante(this.noTutor, this.noCiclo);
            MostarCredencial(0);
        }

        private void btn_generar_Click(object sender, EventArgs e)
        {
            if (datosPermiso == null) return;

            Nombre nomTutor = new((string)datosPermiso.Rows[0]["NOM_TUTOR"], (string)datosPermiso.Rows[0]["AP_TUTOR"], (string)datosPermiso.Rows[0]["AM_TUTOR"]);
            Bitmap[] credenciales = new Bitmap[datosPermiso.Rows.Count];

            for (int i = 0; i < datosPermiso.Rows.Count; i++)
            {
                credenciales[i] = new(panel1.Width, panel1.Height);
                MostarCredencial(i);
                panel1.DrawToBitmap(credenciales[i], new System.Drawing.Rectangle(0, 0, panel1.Width, panel1.Height));
            }

            //pedimos en que ruta es donde vamos a guardar las credenciales generadas
            SaveFileDialog saveFileDialog1 = new SaveFileDialog
            {
                Filter = "PDF document|*.pdf",
                Title = "Guardando credenciales generadas",
                FileName = "Credenciales de " + nomTutor.ToString("NOM_AP") + " (reposicion)",
                RestoreDirectory = true
            };

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (!string.IsNullOrEmpty(saveFileDialog1.FileName))
                {
                    path = saveFileDialog1.FileName;
                    GenerarPDF(credenciales);

                    DialogResult = DialogResult.OK;
                    Close();
                }
            }

        }
        private void btn_credActual_Click(object sender, EventArgs e)
        {
            if (datosPermiso == null) return;

            int index = cb_credencial.SelectedIndex;

            Nombre nomTutor = new((string)datosPermiso.Rows[0]["NOM_TUTOR"], (string)datosPermiso.Rows[0]["AP_TUTOR"], (string)datosPermiso.Rows[0]["AM_TUTOR"]);
            Bitmap credencial;


            credencial = new(panel1.Width, panel1.Height);
            MostarCredencial(index);
            panel1.DrawToBitmap(credencial, new System.Drawing.Rectangle(0, 0, panel1.Width, panel1.Height));


            //pedimos en que ruta es donde vamos a guardar las credenciales generadas
            SaveFileDialog saveFileDialog1 = new SaveFileDialog
            {
                Filter = "PDF document|*.pdf",
                Title = "Guardando credenciales generadas",
                FileName = string.Format("Credencial #{0} de {1} (reposicion)", (index + 1), nomTutor.ToString("NOM_AP")),
                RestoreDirectory = true
            };

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (!string.IsNullOrEmpty(saveFileDialog1.FileName))
                {
                    path = saveFileDialog1.FileName;
                    GenerarPDF(credencial);

                    DialogResult = DialogResult.OK;
                    Close();
                }
            }
        }

        private void cb_credencial_SelectedValueChanged(object sender, EventArgs e)
        {
            if (!cargaCompleta) return;

            int index = cb_credencial.SelectedIndex;
            MostarCredencial(index);
        }

        private System.Drawing.Image GenerarQR(string noCredencial, Size tam)
        {
            QrEncoder qrEncoder = new QrEncoder(ErrorCorrectionLevel.H);
            GraphicsRenderer renderer = new GraphicsRenderer(new FixedCodeSize(400, QuietZoneModules.Zero), Brushes.Black, Brushes.White);
            MemoryStream ms = new MemoryStream();

            qrEncoder.TryEncode(noCredencial, out QrCode qrCode);
            renderer.WriteToStream(qrCode.Matrix, ImageFormat.Png, ms);
            Bitmap imagenTemporal = new Bitmap(ms);
            Bitmap imagen = new Bitmap(imagenTemporal, tam);
            return imagen;
        }
        public void GenerarPDF(Bitmap[] credTutores)
        {
            iTextSharp.text.Image[] imgTutores = new iTextSharp.text.Image[credTutores.Length];

            Document doc = new Document(PageSize.LETTER);
            PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(path, FileMode.OpenOrCreate));

            doc.AddTitle("Credenciales PDF");
            doc.AddCreator("SIDAE v2");
            doc.Open();

            if (imgTutores.Length != 1)
            {
                for (int i = 0; i < imgTutores.Length; i++)
                {
                    imgTutores[i] = Imagenes.ImgToPDF(credTutores[i]);
                    imgTutores[i].Alignment = Element.ALIGN_CENTER;
                    imgTutores[i].ScalePercent(80);
                    doc.Add(new Paragraph(""));

                    doc.Add(imgTutores[i]);
                }
            }
            else
            {
                imgTutores[0] = Imagenes.ImgToPDF(credTutores[0]);
                imgTutores[0].Alignment = Element.ALIGN_CENTER;
                imgTutores[0].ScalePercent(80);
                doc.Add(new Paragraph(""));

                doc.Add(imgTutores[0]);
            }


            doc.Close();
            writer.Close();
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
                    MessageBox.Show("Error al generar PDF, intente mas tarde", "Archivo no generado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (FileNotFoundException e)
            {
                MessageBox.Show("Error al generar PDF, intente mas tarde" + e.Message, "Archivo no generado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void GenerarPDF(Bitmap credTutor)
        {
            iTextSharp.text.Image imgTutor;

            Document doc = new Document(PageSize.LETTER);
            PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(path, FileMode.OpenOrCreate));

            doc.AddTitle("Credenciales PDF");
            doc.AddCreator("SIDAE v2");
            doc.Open();


            imgTutor = Imagenes.ImgToPDF(credTutor);
            imgTutor.Alignment = Element.ALIGN_CENTER;
            imgTutor.ScalePercent(80);
            doc.Add(new Paragraph(""));

            doc.Add(imgTutor);

            doc.Close();
            writer.Close();

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
                    MessageBox.Show("Error al generar PDF, intente mas tarde", "Archivo no generado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (FileNotFoundException e)
            {
                MessageBox.Show("Error al generar PDF, intente mas tarde" + e.Message, "Archivo no generado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void MostarCredencial(int index)
        {
            if (datosPermiso == null) return;

            string noCredencial = string.Format("{0:D4}{1:D4}{2:D2}", (int)datosPermiso.Rows[index]["ID_INFANTE"], (int)datosPermiso.Rows[index]["ID_TUTOR"], (int)datosPermiso.Rows[index]["ID_CICLO"]);
            string l_noCredencial = string.Format("{0:D4}-{1:D4}-{2:D2}", (int)datosPermiso.Rows[index]["ID_INFANTE"], (int)datosPermiso.Rows[index]["ID_TUTOR"], (int)datosPermiso.Rows[index]["ID_CICLO"]);

            Nombre nomInfante = new((string)datosPermiso.Rows[index]["NOM_INFANTE"], (string)datosPermiso.Rows[index]["AP_INFANTE"], (string)datosPermiso.Rows[index]["AM_INFANTE"]);
            Nombre nomTutor = new((string)datosPermiso.Rows[index]["NOM_TUTOR"], (string)datosPermiso.Rows[index]["AP_TUTOR"], (string)datosPermiso.Rows[index]["AM_TUTOR"]);

            DateTime inicioCiclo = (DateTime)datosPermiso.Rows[index]["FECHA_INICIO"];
            DateTime FinaloCiclo = (DateTime)datosPermiso.Rows[index]["FECHA_CIERRE"];

            string dir = string.Format("{0}\nExt: {1}/Int: {2}, {3} {4}, {5}, {6}, {7:D5}",
                (string)datosPermiso.Rows[index]["CALLE"], (string)datosPermiso.Rows[index]["NO_EXT"], (string)datosPermiso.Rows[index]["NO_INT"], (string)datosPermiso.Rows[index]["ASENTAMIENTO"],
                (string)datosPermiso.Rows[index]["COLONIA"], (string)datosPermiso.Rows[index]["MUNICIPIO"], (string)datosPermiso.Rows[index]["ABREVIATURA"], (int)datosPermiso.Rows[index]["CODIGO_POSTAL"]);

            pb_QR.Image = GenerarQR(noCredencial, pb_QR.Size);
            lb_noCredencial.Text = l_noCredencial;

            pb_fotoInfante.Image = Imagenes.ByteArrayToImagen((byte[])datosPermiso.Rows[index]["IMG_INFANTE"]);
            lb_nombreInfante.Text = nomInfante.ToString();
            lb_gradoGrupo.Text = string.Format("{0} {1} - {2}", (string)datosPermiso.Rows[index]["NIVEL"], (string)datosPermiso.Rows[index]["GRADO"], (string)datosPermiso.Rows[index]["GRUPO"]);
            lb_cicloEscolar.Text = string.Format("Ciclo Escolar {0} - {1}", inicioCiclo.Year, FinaloCiclo.Year);

            pb_fotoTutor.Image = Imagenes.ByteArrayToImagen((byte[])datosPermiso.Rows[index]["IMG_TUTOR"]);
            lb_nomTutor.Text = nomTutor.ToString("NOM_AP");
            lb_tel.Text = (string)datosPermiso.Rows[index]["TEL_CELULAR"];
            lb_dir.Text = dir;
            lb_parentesco.Text = (string)datosPermiso.Rows[index]["NOM_PARENTESCO"];
        }
        private void GenerarCBInfantes()
        {
            try
            {
                DataTable? infantesCB = InfanteTutor.GetAllTutorInfante(noTutor, noCiclo, true);

                if (infantesCB == null) return;

                btn_generar.Enabled = true;
                btn_credActual.Enabled = true;

                cb_credencial.DataSource = infantesCB;
                cb_credencial.ValueMember = "clave";
                cb_credencial.DisplayMember = "texto";

                cb_credencial.SelectedIndex = 0;
                cargaCompleta = true;

            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show("Error al cargar los permisos registrados " + ex.Message, "Error de consulta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btn_generar.Enabled = false;
            }
        }


    }
}
