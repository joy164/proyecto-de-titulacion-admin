using static CENDI_admin.Clases.Entidades.Asistencia;

namespace CENDI_admin.Forms_hijos
{
    public partial class Form1_asistencia : Form
    {
        private Form? currentChildForm;
        private Button btn_activo;

        public Form1_asistencia()
        {
            InitializeComponent();

            AbrirForm(new Form7_registrosAsistencia((int)Tipo.entrada));

            btn_regEntrada.BackColor = Color.Indigo;
            btn_regEntrada.ForeColor = Color.White;

            btn_activo = btn_regEntrada;
        }

        private void btn_regEntrada_Click(object sender, EventArgs e)
        {
            AbrirForm(new Form7_registrosAsistencia((int)Tipo.entrada));

            btn_regEntrada.FlatAppearance.BorderSize = 0;
            btn_regEntrada.BackColor = Color.Indigo;
            btn_regEntrada.ForeColor = Color.White;

            btn_activo.FlatAppearance.BorderSize = 1;
            btn_activo.BackColor = Color.White;
            btn_activo.ForeColor = Color.Black;

            btn_activo = btn_regEntrada;
        }
        private void btn_regSalida_Click(object sender, EventArgs e)
        {
            AbrirForm(new Form7_registrosAsistencia((int)Tipo.salida));

            btn_regSalida.FlatAppearance.BorderSize = 0;
            btn_regSalida.BackColor = Color.Indigo;
            btn_regSalida.ForeColor = Color.White;

            btn_activo.FlatAppearance.BorderSize = 1;
            btn_activo.BackColor = Color.White;
            btn_activo.ForeColor = Color.Black;


            btn_activo = btn_regSalida;
        }

        private void Form1_asistencia_FormClosing(object sender, FormClosingEventArgs e)
        {
            currentChildForm?.Close();
        }

        private void AbrirForm(Form childForm)
        {
            currentChildForm?.Close();
            currentChildForm = childForm;

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            p_workbeanch.Controls.Add(childForm);
            p_workbeanch.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            p_workbeanch.Text = childForm.Text;
        }
    }
}
