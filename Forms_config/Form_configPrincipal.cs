using CENDI_admin.Forms_hijos;
using CENDI_admin.Properties;

namespace CENDI_admin.Forms_config
{
    public partial class Form_configPrincipal : Form
    {   
        private Button btn_activo;
        private Form? currentChildForm;
        
        public Form_configPrincipal()
        {
            InitializeComponent();

            btn_activo = btn_servidor;

            if (!Settings.Default.primerUso)
            {
                btn_admin.Visible = false;
                btn_ciclos.Visible = false;
                btn_grupos.Visible = false;
            }

            AbrirForm(new Forms_configServer(this));
        }

        private void btn_servidor_Click(object sender, EventArgs e)
        {
            AbrirForm(new Forms_configServer(this));

            btn_activo.BackColor = Color.White;
            btn_activo.ForeColor = SystemColors.ControlText;

            btn_servidor.BackColor = Color.DarkSlateGray;
            btn_servidor.ForeColor = Color.White;

            btn_activo = btn_servidor;
        }
        private void btn_admin_Click(object sender, EventArgs e)
        {
            AbrirForm(new Forms_configUsuarios());

            btn_activo.BackColor = Color.White;
            btn_activo.ForeColor = SystemColors.ControlText;

            btn_admin.BackColor = Color.DarkSlateGray;
            btn_admin.ForeColor = Color.White;

            btn_activo = btn_admin;
        }
        private void btn_grupos_Click(object sender, EventArgs e)
        {
            AbrirForm(new Forms_configSalones());

            btn_activo.BackColor = Color.White;
            btn_activo.ForeColor = SystemColors.ControlText;

            btn_grupos.BackColor = Color.DarkSlateGray;
            btn_grupos.ForeColor = Color.White;

            btn_activo = btn_grupos;
        }
        private void btn_ciclos_Click(object sender, EventArgs e)
        {
            AbrirForm(new Form_configCiclos());

            btn_activo.BackColor = Color.White;
            btn_activo.ForeColor = SystemColors.ControlText;

            btn_ciclos.BackColor = Color.DarkSlateGray;
            btn_ciclos.ForeColor = Color.White;

            btn_activo = btn_ciclos;
        }
        private void btn_terminar_Click(object sender, EventArgs e)
        {
            Settings.Default.primerUso = false;
            Settings.Default.Save();
            Application.Restart();
        }

        private void AbrirForm(Form childForm)
        {
            currentChildForm?.Close();
            currentChildForm = childForm;

            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            childForm.TopLevel = false;

            p_workbeanch.Controls.Add(childForm);
            p_workbeanch.Text = childForm.Text;
            p_workbeanch.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }


    }
}
