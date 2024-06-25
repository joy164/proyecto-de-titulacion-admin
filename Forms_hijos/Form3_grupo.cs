using CENDI_admin.Clases.Entidades;
using CENDI_admin.Forms_dialogos;
using Npgsql;
using System.Data;

namespace CENDI_admin.Forms_hijos
{
    public partial class Form3_grupo : Form
    {
        public Form3_grupo()
        {
            InitializeComponent();
            Cargar_tabla();
        }

        private void btn_listaInfante_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar una fila para ver la lista de infantes registrados en la fila seleccionada", "Fila no seleccionada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int noSalon = (int)dataGridView1.SelectedRows[0].Cells[0].Value;

            Dialogo3_listaInfantes form = new(noSalon);
            form.ShowDialog();
        }
        private void btn_nuevoGrupo_Click(object sender, EventArgs e)
        {
            Dialogo2_grupo form = new();

            if (form.ShowDialog() == DialogResult.OK) Cargar_tabla();
        }
        private void btn_editarGrupo_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar una fila para editar", "Fila no seleccionada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int noSalon = (int)dataGridView1.SelectedRows[0].Cells[0].Value;

            Dialogo2_grupo form = new(noSalon);

            if (form.ShowDialog() == DialogResult.OK) Cargar_tabla();
        }
        private void btn_eliminarGrupo_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar una fila para eliminar", "Fila no seleccionada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int noSalon = (int)dataGridView1.SelectedRows[0].Cells[0].Value;

            string? nivel = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            string? grado = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            string? grupo = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();

            DialogResult res = MessageBox.Show(string.Format("¿Esta seguro que quiere eliminar el salon {0} {1}-{2}?", nivel, grado, grupo), "Eliminando salon", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (res == DialogResult.No) return;

            try
            {
                Salon.DeleteSalon(noSalon);
                MessageBox.Show("El salon se ha eliminado con exito", "Salon eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Cargar_tabla();
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show("Error al eliminar salon, intente mas tarde o revise la conexion a internet " + ex.Message, "Error de consulta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void btn_ciclosEscolares_Click(object sender, EventArgs e)
        {
            Dialogo4_cicloEscolar form = new();
            form.ShowDialog();
        }

        private void Cargar_tabla()
        {
            try
            {
                DataTable? regGrupos = Salon.GetAllSalon();
                dataGridView1.Rows.Clear();

                if (regGrupos != null)
                    foreach (DataRow row in regGrupos.Rows)
                        dataGridView1.Rows.Add(row["NO_SALON"], row["NIVEL"], row["GRADO"], row["GRUPO"]);
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show("Error al cargar grupos, intente mas tarde o revise la conexion a internet " + ex.Message, "Error de consulta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
