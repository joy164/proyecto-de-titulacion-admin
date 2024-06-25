
using AForge.Video;
using AForge.Video.DirectShow;

namespace CENDI_admin.Forms_dialogos
{
    public partial class Dialogo6_foto : Form
    {
        public Image? FotoCapturada { get; set; } = null;

        private FilterInfoCollection? MisDispositivos;
        private VideoCaptureDevice? MiWebCam;

        public Dialogo6_foto()
        {
            InitializeComponent();
        }


        public Bitmap CortarImagen(Bitmap source, RectangleF section)
        {
            Bitmap bmp = new((int)section.Width, (int)section.Height);
            Graphics g = Graphics.FromImage(bmp);

            g.DrawImage(source, 0, 0, section, GraphicsUnit.Pixel);

            return bmp;
        }

        public void CargaDipositivos()
        {
            MisDispositivos = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            if (MisDispositivos.Count > 0)
            {
                for (int i = 0; i < MisDispositivos.Count; i++)
                    comboBox1.Items.Add(MisDispositivos[i].Name.ToString());
                comboBox1.Text = MisDispositivos[0].Name.ToString();

            }
        }

        private void Capturando(Object sender, NewFrameEventArgs e)
        {
            Bitmap Imagen = (Bitmap)e.Frame.Clone();
            pictureBox1.Image = Imagen;
        }

        private void CerrarWebCam()
        {
            if (MiWebCam != null && MiWebCam.IsRunning)
            {
                MiWebCam.SignalToStop();
                MiWebCam.WaitForStop();
            }
        }

        private void Dialogo6_foto_Load(object sender, EventArgs e)
        {
            CargaDipositivos();
        }

        private void Dialogo6_foto_FormClosed(object sender, FormClosedEventArgs e)
        {
            CerrarWebCam();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CerrarWebCam();
            int i = comboBox1.SelectedIndex;
            string NombreVideo = MisDispositivos[i].MonikerString;

            MiWebCam = new VideoCaptureDevice(NombreVideo);
            MiWebCam.NewFrame += new NewFrameEventHandler(Capturando);
            MiWebCam.Start();
            MessageBox.Show("Recuerde: la cara de la persona debe estar en el centro del cuadro de la camara, sin lentes y con la frente descubierta", "Recomendacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MiWebCam == null || !MiWebCam.IsRunning) return;

            Bitmap fuente = (Bitmap)pictureBox1.Image;
            int fuenteH, fuenteW;
            int finalH, finalW;

            fuenteH = fuente.Height;
            fuenteW = fuente.Width;

            finalH = (int)(fuenteH * 0.8);
            finalW = (int)(fuenteW * 0.4);

            RectangleF corteFinal = new((fuenteW / 2) - (finalW / 2), (fuenteH / 2) - (finalH / 2), finalW, finalH);

            Bitmap salida = CortarImagen(fuente, corteFinal);
            pictureBox2.Image = salida;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("¿Esta seguro que quiere conservar la foto actual?", "Saliendo...", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                FotoCapturada = pictureBox2.Image;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
