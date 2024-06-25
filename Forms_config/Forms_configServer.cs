using CENDI_admin.Clases.BD_conector;
using CENDI_admin.Clases.Utils;
using CENDI_admin.Properties;
using Npgsql;

namespace CENDI_admin.Forms_config
{
    public partial class Forms_configServer : Form
    {
        private Form_configPrincipal? formPadre;
        public Forms_configServer(Form_configPrincipal? formPadre)
        {
            InitializeComponent();
            CargarElementos();
            this.formPadre = formPadre;
        }
        private void btn_testConn_Click(object sender, EventArgs e)
        {
            ProbarConexion();
        }
        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (!ValidacionCampos.ValidarEntradasTexto(tb_contraseña, tb_nomDB, tb_usuario, tb_host) || !ValidacionCampos.ValidarEntradasNumero(true, tb_puerto))
            {
                MessageBox.Show("Error en los campos señalados, revise que los datos esten correctos o no tengan caracteres invalidos", "Error de entredas de texto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Settings.Default.password = tb_contraseña.Text;
            Settings.Default.name_db = tb_nomDB.Text;
            Settings.Default.user = tb_usuario.Text;
            Settings.Default.port = tb_puerto.Text;
            Settings.Default.host = tb_host.Text;

            Settings.Default.Save();

            if (ProbarConexion())
            {
                formPadre.btn_admin.Enabled = true;
                formPadre.btn_ciclos.Enabled = true;
                formPadre.btn_grupos.Enabled = true;
                formPadre.btn_terminar.Enabled = true;
            }
        }

        private void CargarElementos()
        {
            tb_contraseña.Text = Settings.Default.password;
            tb_nomDB.Text = Settings.Default.name_db;
            tb_usuario.Text = Settings.Default.user;
            tb_puerto.Text = Settings.Default.port;
            tb_host.Text = Settings.Default.host;
        }
        private bool ProbarConexion()
        {
            string Cad_conexion = "Server=" + tb_host.Text + ";Username= " + tb_usuario.Text + ";Database= " + tb_nomDB.Text + " ;Port= " + tb_puerto.Text + ";Password= " + tb_contraseña.Text + ";Pooling=false;";

            try
            {
                NpgsqlConnection conn = ConectorPostgreSQL.TestConexion(Cad_conexion);

                if (conn == null)
                {
                    MessageBox.Show("Fallo la conexion con el servidor, revise que la configuracion este realizada correctamente", "Conexion fallida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else
                {
                    MessageBox.Show("Conexion exitosa con el servidor", "Conexion exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ConectorPostgreSQL.TermConexion(conn);
                    return true;
                }
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show("Fallo la conexion con el servidor, revise que la configuracion este realizada correctamente " + ex.Message, "Conexion fallida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        
    }
}
