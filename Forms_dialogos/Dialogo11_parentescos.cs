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

namespace CENDI_admin.Forms_dialogos
{
    public partial class Dialogo11_parentescos : Form
    {
        private bool modoEdicion = false;
        private int noParentesco = 0;
        public Dialogo11_parentescos()
        {
            InitializeComponent();
            Cargar_tabla();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (!ValidacionCampos.ValidarEntradasTexto(tb_nomParentesco))
            {
                MessageBox.Show("Error en los campos señalados, revise que los datos ingresados esten correctos", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!modoEdicion)
            {
                try
                {
                    Parentesco.NewParentesco(tb_nomParentesco.Text, 10);
                    MessageBox.Show("parentesco registrado con exito", "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    modoEdicion = false;
                    Cargar_tabla();
                }
                catch (NpgsqlException ex)
                {
                    MessageBox.Show("Error al registrar parentesco, intente mas tarde o revise la conexion a internet " + ex.Message, "Error de registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                try
                {
                    if (noParentesco != 0)
                    {
                        Parentesco.UpdateParentescoData(noParentesco, tb_nomParentesco.Text, 10);
                        MessageBox.Show("parentescor actualizado con exito", "Actualizacion exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        label1.Text = "Nuevo parentesco";

                        dataGridView1.Enabled = true;
                        btn_eliminar.Visible = false;
                        modoEdicion = false;
                        Cargar_tabla();
                    }
                    else
                        MessageBox.Show("El id del parentesco es invalido", "Error de indice", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                catch (NpgsqlException ex)
                {
                    MessageBox.Show("Error al actualizar ciclo escolar, intente mas tarde o revise la conexion a internet " + ex.Message, "Error de actualizacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar una fila para editar", "Fila no seleccionada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!int.TryParse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString(), out noParentesco))
            {
                MessageBox.Show("El id tiene un formato invalido", "Argumento invalido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            label1.Text = "Edicion de parentesco";
            dataGridView1.Enabled = false;
            btn_eliminar.Visible = true;
            modoEdicion = true;

            try
            {
                DataTable? resultado = Parentesco.GetAllParentesco();

                if (resultado != null)
                {
                    tb_nomParentesco.Text = (string)resultado.Rows[0]["NOM_PARENTESCO"];
                    
                }
                else
                    MessageBox.Show("Error al cargar parentescos, intente mas tarde o revise la conexion a internet ", "Error de consulta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show("Error al cargar parentescos, intente mas tarde o revise la conexion a internet " + ex.Message, "Error de consulta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void Cargar_tabla()
        {
            try
            {
                DataTable? regParentescos = Parentesco.GetAllParentesco();
                dataGridView1.Rows.Clear();

                if (regParentescos != null)
                    foreach (DataRow row in regParentescos.Rows)
                        dataGridView1.Rows.Add(row["ID_PARENTESCO"], row["NOM_PARENTESCO"]);


            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show("Error al cargar parentescos, intente mas tarde o revise la conexion a internet " + ex.Message, "Error de consulta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
    }
}
