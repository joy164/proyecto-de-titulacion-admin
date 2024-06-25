using CENDI_admin.Clases.Entidades;
using Npgsql;
using System.Data;

namespace CENDI_admin.Forms_dialogos
{
    public partial class Dialogo1_usuario : Form
    {
        private int noUsuario;
        private bool modoEdicion = false;
        public Dialogo1_usuario()
        {
            InitializeComponent();
            modoEdicion = false;

            try
            {
                DataTable? roles = TipoUsuario.GetRoleUsers();

                if (roles != null)
                {
                    comboBox1.DataSource = roles;
                    comboBox1.ValueMember = "CLAVE";
                    comboBox1.DisplayMember = "TEXTO";
                }
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show("Error al cargar datos de usuario, intente mas tarde o revise la conexion a internet " + ex.Message, "Error de consulta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public Dialogo1_usuario(int noUsuario)
        {
            InitializeComponent();
            this.noUsuario = noUsuario;
            modoEdicion = true;
            textBox1.Enabled = false;

            try
            {
                DataTable? roles = TipoUsuario.GetRoleUsers();
                DataTable? res = Usuario.GetUser(this.noUsuario);

                if (res != null && roles != null)
                {
                    comboBox1.DataSource = roles;
                    comboBox1.ValueMember = "CLAVE";
                    comboBox1.DisplayMember = "TEXTO";

                    textBox1.Text = res.Rows[0]["NO_EMPLEADO"].ToString();
                    textBox2.Text = res.Rows[0]["PASSWORD"].ToString();
                    comboBox1.SelectedValue = (int)res.Rows[0]["ID_TIPO_USUARIO"];
                }
                else
                    MessageBox.Show("Error al cargar elementos del formulario, intente mas tarde o revise la conexion a internet ", "Error de consulta", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show("Error al cargar datos de usuario, intente mas tarde o revise la conexion a internet " + ex.Message, "Error de consulta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBox1.Checked)
                textBox2.PasswordChar = '•';
            else
                textBox2.PasswordChar = '\0';
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int noEmp, idRol;
            string pass;

            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Debe completar todos los campos marcados", "Error de argumentos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox1.BackColor = Color.Moccasin;
                return;
            }

            if (string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Debe completar todos los campos marcados", "Error de argumentos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox2.BackColor = Color.Moccasin;
                return;
            }
            pass = textBox2.Text;

            if (!int.TryParse(textBox1.Text, out noEmp))
            {
                MessageBox.Show("El campo solo acepta numeros", "Error de argumentos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox1.BackColor = Color.Moccasin;
                return;
            }

            _ = int.TryParse(comboBox1.SelectedValue.ToString(), out idRol);

            try
            {
                if (!modoEdicion)
                {
                    Usuario.NewUser(idRol, noEmp, pass);
                    MessageBox.Show("Usuario registrado con exito", "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    Usuario.UpdateUserData(noUsuario, idRol, pass);
                    MessageBox.Show("Datos actualizados con exito", "Informacion actualizada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    Close();
                }

            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show("Error al registrar usuario, intente mas tarde o revise la conexion a internet " + ex.Message, "Error de registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text))
                textBox1.BackColor = SystemColors.Window;
            else
                textBox1.BackColor = Color.Moccasin;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox2.Text))
                textBox2.BackColor = SystemColors.Window;
            else
                textBox2.BackColor = Color.Moccasin;
        }
    }
}
