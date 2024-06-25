using CENDI_admin.Clases.Entidades;
using CENDI_admin.Clases.Utils;
using Npgsql;
using System.Data;

namespace CENDI_admin.Forms_dialogos
{
    public partial class Dialogo2_grupo : Form
    {
        private int noSalon = 0;
        private bool modoEdicion = false;

        public Dialogo2_grupo()
        {
            InitializeComponent();
            GenerarTablaGrupo();

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

            modoEdicion = false;


        }
        public Dialogo2_grupo(int noSalon)
        {
            InitializeComponent();
            GenerarTablaGrupo();

            modoEdicion = true;
            this.noSalon = noSalon;

            try
            {
                DataTable? niveles = Nivel.GetAllNiveles();
                DataTable? res = Salon.GetSalon(this.noSalon);

                if (niveles != null && res != null)
                {
                    comboBox1.DataSource = niveles;
                    comboBox1.ValueMember = "CLAVE";
                    comboBox1.DisplayMember = "TEXTO";

                    comboBox1.SelectedValue = (int)res.Rows[0]["NO_NIVEL"];
                    comboBox2.SelectedValue = res.Rows[0]["GRUPO"].ToString()[0];
                }
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show("Error al cargar datos de nivel y grado, intente mas tarde o revise la conexion a internet " + ex.Message, "Error de consulta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int noNivel = 0;
            string? grupo;

            if (!ValidacionCampos.ValidarEntradasTexto(comboBox1, comboBox2))
            {
                MessageBox.Show("Error en los campos marcados, revise si la informacion seleccionada es la correcta", "Error de seleccion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

#pragma warning disable CS8604 // Posible argumento de referencia nulo
            noNivel = int.Parse(comboBox1.SelectedValue.ToString());
#pragma warning restore CS8604 // Posible argumento de referencia nulo
            grupo = comboBox2.SelectedValue.ToString();

            if (!modoEdicion)
            {

                try
                {
                    Salon.NewSalon(noNivel, grupo[0]);
                    MessageBox.Show("Grupo registrado con exito", "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    Close();
                }
                catch (NpgsqlException ex)
                {
                    MessageBox.Show("Error al registrar grupo, intente mas tarde o revise la conexion a internet " + ex.Message, "Error de registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                try
                {
                    Salon.UpdateSalonData(noSalon, noNivel, grupo[0]);
                    MessageBox.Show("Datos actualizados con exito", "Informacion actualizada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    Close();
                }
                catch (NpgsqlException ex)
                {
                    MessageBox.Show("Error al actualizar grupo, intente mas tarde o revise la conexion a internet " + ex.Message, "Error de registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
    }
}
