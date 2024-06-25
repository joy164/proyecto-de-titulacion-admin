using CENDI_admin.Clases.Entidades;
using Npgsql;
using System.Data;

namespace CENDI_admin.Forms_dialogos
{
    public partial class Dialogo4_cicloEscolar : Form
    {
        private bool modoEdicion = false;
        private int noCiclo = 0;

        public Dialogo4_cicloEscolar()
        {
            InitializeComponent();
            Cargar_tabla();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            DateTime fechaInicio, fechaCierre;

            fechaInicio = dateTimePicker1.Value;
            fechaCierre = dateTimePicker2.Value;

            if (fechaInicio >= fechaCierre)
            {
                MessageBox.Show("La fecha de inicio no puede ser igual o mayor que la fecha de cierre", "Error de argumentos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (fechaCierre <= fechaInicio)
            {
                MessageBox.Show("La fecha de cierre no puede ser igual o menor que la fecha de inicio", "Error de argumentos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!modoEdicion)
            {
                try
                {
                    CicloEscolar.NewCiclo(fechaInicio, fechaCierre);
                    MessageBox.Show("Ciclo escolar registrado con exito", "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    modoEdicion = false;
                    Cargar_tabla();
                }
                catch (NpgsqlException ex)
                {
                    MessageBox.Show("Error al registrar ciclo escolar, intente mas tarde o revise la conexion a internet " + ex.Message, "Error de registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                try
                {
                    if (noCiclo != 0)
                    {
                        CicloEscolar.UpdateCicloData(noCiclo, fechaInicio, fechaCierre);
                        MessageBox.Show("Ciclo escolar actualizado con exito", "Actualizacion exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        label1.Text = "Nuevo ciclo escolar";

                        dataGridView1.Enabled = true;
                        button1.Visible = false;
                        modoEdicion = false;
                        Cargar_tabla();
                    }
                    else
                        MessageBox.Show("El id del ciclo escolar es invalido", "Error de indice", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                catch (NpgsqlException ex)
                {
                    MessageBox.Show("Error al actualizar ciclo escolar, intente mas tarde o revise la conexion a internet " + ex.Message, "Error de actualizacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar una fila para eliminar", "Fila no seleccionada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (noCiclo == 0)
            {
                MessageBox.Show("El id tiene un formato invalido", "Argumento invalido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

#pragma warning disable CS8604 // Posible argumento de referencia nulo
            DateTime inicio = DateTime.Parse(dataGridView1.SelectedRows[0].Cells[1].Value.ToString());
            DateTime final = DateTime.Parse(dataGridView1.SelectedRows[0].Cells[2].Value.ToString());
#pragma warning restore CS8604 // Posible argumento de referencia nulo

            DialogResult res = MessageBox.Show(string.Format("¿Esta seguro que quiere eliminar el ciclo {0}-{1}?, los permisos registrados con este ciclo se eliminaran", inicio.ToString("yyyy"), final.ToString("yyyy")), "Eliminando ciclo escolar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (res == DialogResult.Yes)
            {
                try
                {
                    CicloEscolar.DeleteCiclo(noCiclo);
                    MessageBox.Show("El ciclo escolar se ha eliminado con exito", "Ciclo escolar eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    label1.Text = "Nuevo ciclo escolar";

                    dataGridView1.Enabled = true;
                    button1.Visible = false;
                    modoEdicion = false;
                    Cargar_tabla();
                }
                catch (NpgsqlException ex)
                {
                    MessageBox.Show("Error al eliminar ciclo escolar, intente mas tarde o revise la conexion a internet " + ex.Message, "Error de consulta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar una fila para editar", "Fila no seleccionada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!int.TryParse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString(), out noCiclo))
            {
                MessageBox.Show("El id tiene un formato invalido", "Argumento invalido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            label1.Text = "Ciclo escolar";
            dataGridView1.Enabled = false;
            button1.Visible = true;
            modoEdicion = true;

            try
            {
                DataTable? resultado = CicloEscolar.GetCiclo(noCiclo);

                if (resultado != null)
                {
                    dateTimePicker1.Value = (DateTime)resultado.Rows[0]["FECHA_INICIO"];
                    dateTimePicker2.Value = (DateTime)resultado.Rows[0]["FECHA_CIERRE"];
                }
                else
                    MessageBox.Show("Error al cargar ciclo, intente mas tarde o revise la conexion a internet ", "Error de consulta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show("Error al cargar ciclo, intente mas tarde o revise la conexion a internet " + ex.Message, "Error de consulta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void Cargar_tabla()
        {
            try
            {
                DataTable? regCiclos = CicloEscolar.GetAllCiclos();
                dataGridView1.Rows.Clear();

                if (regCiclos != null)
                    foreach (DataRow row in regCiclos.Rows)
                    {
                        DateTime fechaInicio = (DateTime)row["FECHA_INICIO"];
                        DateTime fechaCierre = (DateTime)row["FECHA_CIERRE"];

                        dataGridView1.Rows.Add(row["ID_CICLO"], fechaInicio.ToString("dd-MM-yyyy"), fechaCierre.ToString("dd-MM-yyyy"));
                    }

            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show("Error al cargar ciclos escolares, intente mas tarde o revise la conexion a internet " + ex.Message, "Error de consulta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
