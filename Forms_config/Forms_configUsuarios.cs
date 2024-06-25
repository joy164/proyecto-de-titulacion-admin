using CENDI_admin.Clases.Entidades;
using CENDI_admin.Properties;
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CENDI_admin.Forms_config
{
    public partial class Forms_configUsuarios : Form
    {
        public Forms_configUsuarios()
        {
            InitializeComponent();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            int noEmp, idRol = 1;
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

            try
            {
                Usuario.NewUser(idRol, noEmp, pass);
                MessageBox.Show("Usuario registrado con exito", "Usuario registrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show("Error al registrar usuario, intente mas tarde o revise la conexion a internet " + ex.Message, "Error de registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBox1.Checked)
                textBox2.PasswordChar = '•';
            else
                textBox2.PasswordChar = '\0';
        }
    }
}
