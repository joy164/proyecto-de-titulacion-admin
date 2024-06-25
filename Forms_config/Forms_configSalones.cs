using CENDI_admin.Clases.Entidades;
using CENDI_admin.Clases.Utils;
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
    public partial class Forms_configSalones : Form
    {
        public Forms_configSalones()
        {
            InitializeComponent();
            GenerarTablaGrupo();
            GenerarNiveles();
            Cargar_tabla();
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
        private void GenerarTablaGrupo()
        {
            string membreteGrupo = "ABCDEFGHIJ";

            DataTable grupos = new();

            grupos.Columns.Add("clave", typeof(char));
            grupos.Columns.Add("texto", typeof(string));
            grupos.Rows.Add(null, "SIN GRUPO SELECCIONADO");

            foreach (char token in membreteGrupo)
            {
                grupos.Rows.Add(token, string.Format("Grupo {0}", token));
            }

            comboBox2.DataSource = grupos;
            comboBox2.ValueMember = "clave";
            comboBox2.DisplayMember = "texto";
        }
        private void GenerarNiveles()
        {
            try
            {
                DataTable? niveles = Nivel.GetAllNiveles();

                if (niveles != null)
                {
                    comboBox1.DataSource = niveles;
                    comboBox1.ValueMember = "CLAVE";
                    comboBox1.DisplayMember = "TEXTO";
                }
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show("Error al cargar datos de nivel y grado, intente mas tarde o revise la conexion a internet " + ex.Message, "Error de consulta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void btn_agregar_Click(object sender, EventArgs e)
        {
            string? grupo;

            if (!ValidacionCampos.ValidarEntradasTexto(comboBox1, comboBox2))
            {
                MessageBox.Show("Error en los campos marcados, revise si la informacion seleccionada es la correcta", "Error de seleccion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

#pragma warning disable CS8604 // Posible argumento de referencia nulo
            int noNivel = int.Parse(comboBox1.SelectedValue.ToString());
#pragma warning restore CS8604 // Posible argumento de referencia nulo
            grupo = comboBox2.SelectedValue.ToString();

            try
            {
                Salon.NewSalon(noNivel, grupo[0]);
                MessageBox.Show("Grupo registrado con exito", "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Cargar_tabla();
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show("Error al registrar grupo, intente mas tarde o revise la conexion a internet " + ex.Message, "Error de registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
