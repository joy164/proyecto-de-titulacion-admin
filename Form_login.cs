using CENDI_admin.Clases.Cache;
using CENDI_admin.Clases.Entidades;
using CENDI_admin.Clases.Utils;
using CENDI_admin.Forms_config;
using System.Configuration;
using System.Data;


namespace CENDI_admin
{
    public partial class Form_login : Form
    {
        public Form_login()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBox1.Checked)
                tb_password.PasswordChar = '•';
            else
                tb_password.PasswordChar = '\0';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!ValidacionCampos.ValidarEntradasNumero(true, tb_noEmpleado) || !ValidacionCampos.ValidarEntradasTexto(tb_password))
            {
                MessageBox.Show("Debe de completar o llenar correctamente los campos señalados", "Entrada invalida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int usuario = int.Parse(tb_noEmpleado.Text);
            string contraseña = tb_password.Text;

            DataTable? res = Usuario.GetUser(usuario, contraseña);

            if (res == null)
            {
                MessageBox.Show("Usuario o contraseña invalidos", "Usuario no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DatosUsuario.NoEmpleado = usuario;
                DatosUsuario.Contraseña = contraseña;
                DatosUsuario.TipoUsuario = (int)res.Rows[0]["ID_TIPO_USUARIO"];

                Form_principal? form = new();
#pragma warning disable CS8622 // La nulabilidad de los tipos de referencia del tipo de parámetro no coincide con el delegado de destino (posiblemente debido a los atributos de nulabilidad).
                form.FormClosed += Logout;
#pragma warning restore CS8622 // La nulabilidad de los tipos de referencia del tipo de parámetro no coincide con el delegado de destino (posiblemente debido a los atributos de nulabilidad).
                form.Show();
                Hide();
            }
        }

        private void Logout(object sender, FormClosedEventArgs e)
        {
            DatosUsuario.NoEmpleado = 0;
            DatosUsuario.Contraseña = string.Empty;
            DatosUsuario.TipoUsuario = (int)DatosUsuario.Tipo.None;

            tb_noEmpleado.Text = string.Empty;
            tb_password.Text = string.Empty;

            tb_noEmpleado.BackColor = SystemColors.Window;
            tb_password.BackColor = SystemColors.Window;

            ActiveControl = tb_noEmpleado;
            Show();
        }

        private void Form_login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == (Keys.Control | Keys.Alt | Keys.C))
            {
                Form_configPrincipal form = new Form_configPrincipal();
                form.ShowDialog();
            }
        }
    }
}