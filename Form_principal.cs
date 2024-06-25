using CENDI_admin.Clases.Cache;
using CENDI_admin.Clases.Entidades;
using CENDI_admin.Forms_hijos;

namespace CENDI_admin
{
    public partial class Form_principal : Form
    {
        private Button btn_activo;
        private Form? currentChildForm;

        public Form_principal()
        {
            InitializeComponent();
            btn_activo = btn_asistencia;
            label1.Text = string.Format("Sesion de: # {0:D5}", DatosUsuario.NoEmpleado);

            if(DatosUsuario.TipoUsuario == (int)DatosUsuario.Tipo.Usuario)
            {
                btn_usuarios.Visible = false;
                btn_grupos.Visible = false;
                btn_tutores.Visible = false;
                btn_infantes.Visible = false;
                btn_inscripcion.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
            }
        }
        private void Btn_asistencia_Click(object sender, EventArgs e)
        {
            AbrirForm(new Form1_asistencia());

            Text = "SIDAE | Asistencia";

            btn_activo.BackColor = Color.DarkSlateGray;
            btn_asistencia.BackColor = Color.Teal;
            btn_activo = btn_asistencia;
        }
        private void Btn_usuarios_Click(object sender, EventArgs e)
        {
            AbrirForm(new Form2_usuarios());

            Text = "SIDAE | Administracion de usuarios";

            btn_activo.BackColor = Color.DarkSlateGray;
            btn_usuarios.BackColor = Color.Teal;
            btn_activo = btn_usuarios;
        }
        private void Btn_grupos_Click(object sender, EventArgs e)
        {
            AbrirForm(new Form3_grupo());

            Text = "SIDAE | Administracion de grupos";

            btn_activo.BackColor = Color.DarkSlateGray;
            btn_grupos.BackColor = Color.Teal;
            btn_activo = btn_grupos;
        }
        private void Btn_infantes_Click(object sender, EventArgs e)
        {
            AbrirForm(new Form4_infantes());

            Text = "SIDAE | Administracion de infantes";

            btn_activo.BackColor = Color.DarkSlateGray;
            btn_infantes.BackColor = Color.Teal;
            btn_activo = btn_infantes;
        }
        private void Btn_tutores_Click(object sender, EventArgs e)
        {
            AbrirForm(new Form5_tutores());

            Text = "SIDAE | Administracion de tutores";

            btn_activo.BackColor = Color.DarkSlateGray;
            btn_tutores.BackColor = Color.Teal;
            btn_activo = btn_tutores;
        }
        private void Btn_inscripcion_Click(object sender, EventArgs e)
        {
            AbrirForm(new Form6_inscripciones());

            Text = "SIDAE | Inscripciones y reinscripciones";

            btn_activo.BackColor = Color.DarkSlateGray;
            btn_inscripcion.BackColor = Color.Teal;
            btn_activo = btn_inscripcion;
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

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("¿Esta seguro que quiere salir", "Saliendo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (res == DialogResult.No) return;

            Close();
        }

        
    }
}
