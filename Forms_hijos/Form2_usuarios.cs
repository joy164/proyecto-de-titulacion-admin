using CENDI_admin.Clases.Entidades;
using CENDI_admin.Forms_dialogos;
using System.Data;
using Npgsql;

namespace CENDI_admin.Forms_hijos
{
    public partial class Form2_usuarios : Form
    {
        public Form2_usuarios()
        {
            InitializeComponent();
            Cargar_tabla();
        }

        private void btn_nuevoUsuario_Click(object sender, EventArgs e)
        {
            Dialogo1_usuario form = new Dialogo1_usuario();

            if (form.ShowDialog() == DialogResult.OK)
                Cargar_tabla();
        }
        private void btn_editarUsuario_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar una fila para editar", "Fila no seleccionada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int id_usuario = (int)dataGridView1.SelectedRows[0].Cells[0].Value;

            Dialogo1_usuario form = new(id_usuario);

            if (form.ShowDialog() == DialogResult.OK)
                Cargar_tabla();
        }
        private void btn_eliminarUsuario_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0) return;

            int id_usuario = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
            int noEmp = (int)dataGridView1.SelectedRows[0].Cells[1].Value;

            DialogResult res = MessageBox.Show(string.Format("¿Esta seguro que quiere eliminar al usuario con # de empleado: {0, 5:D5} ?", noEmp), "Eliminando usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (res == DialogResult.No) return;

            try
            {
                if (Usuario.IsAdmin(id_usuario))
                {
                    if (Usuario.NumAdmins() == 1)
                    {
                        MessageBox.Show("No se puede eliminar a este usuario, debe existir minimo un usuario administrador", "Sin administradores suficientes", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                
                Usuario.DeleteUser(id_usuario);
                MessageBox.Show("El usuario se ha eliminado con exito", "Usuario eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Cargar_tabla();

            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show("Error al eliminar usuario, intente mas tarde o revise la conexion a internet " + ex.Message, "Error de consulta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Cargar_tabla()
        {
            try
            {
                DataTable? regUsuarios = Usuario.GetAllUsers();
                dataGridView1.Rows.Clear();

                if (regUsuarios != null)
                    foreach (DataRow row in regUsuarios.Rows)
                        dataGridView1.Rows.Add(row["ID_USUARIO"], row["NO_EMPLEADO"], row["ROL"]);
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show("Error al cargar usuarios, intente mas tarde o revise la conexion a internet " + ex.Message, "Error de consulta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
