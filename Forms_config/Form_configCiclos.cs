using CENDI_admin.Clases.Entidades;
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
    public partial class Form_configCiclos : Form
    {
        public Form_configCiclos()
        {
            InitializeComponent();
            Cargar_tabla();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
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

            try
            {
                CicloEscolar.NewCiclo(fechaInicio, fechaCierre);
                MessageBox.Show("Ciclo escolar registrado con exito", "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Cargar_tabla();
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show("Error al registrar ciclo escolar, intente mas tarde o revise la conexion a internet " + ex.Message, "Error de registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
