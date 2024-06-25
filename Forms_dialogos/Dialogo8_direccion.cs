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
    public partial class Dialogo8_direccion : Form
    {
        private bool cargaCB_estado = false, cargaCB_municipio = false;
        public Dialogo8_direccion()
        {
            InitializeComponent();
            GenerarCBEntidades();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (!ValidacionCampos.ValidarEntradasTexto(tb_calle, tb_noExt, cb_estado, cb_municipio, cb_colonia))
            {
                MessageBox.Show("Entrada no valida en el campo(s) señalado(s)", "Error en los campos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //datos de direccion
            string Calle = tb_calle.Text;
            string No_ext = tb_noExt.Text;
            string No_int = string.IsNullOrEmpty(tb_noInt.Text.Trim()) ? "s/n" : tb_noInt.Text.Trim();
            int ID_Estado = (int)cb_estado.SelectedValue;
            int ID_Municipio = (int)cb_municipio.SelectedValue;
            int ID_Colonia = (int)cb_colonia.SelectedValue;

            try
            {
                Direccion.NewDireccion(ID_Colonia, ID_Municipio, ID_Estado, Calle, No_ext, No_int);
                MessageBox.Show("Direccion registrada con exito", "Registro exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show("Error al registrar direccion, intente mas tarde o revise la conexion a internet " + ex.Message, "Error de registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GenerarCBEntidades()
        {
            try
            {
                DataTable? entidad = Direccion.GetEstado(true);

                cb_estado.DataSource = entidad;
                cb_estado.ValueMember = "clave";
                cb_estado.DisplayMember = "texto";

                if (entidad == null)
                    btn_guardar.Enabled = false;
                else
                {
                    btn_guardar.Enabled = true;
                    cargaCB_estado = true;
                }

            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show("Error al cargar los salones registrados " + ex.Message, "Error de consulta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btn_guardar.Enabled = false;
            }
        }
        private void GenerarCBMunicipios(int noEstado)
        {
            try
            {
                DataTable? municipios = Direccion.GetMunicipios(noEstado, true);

                cb_municipio.DataSource = municipios;
                cb_municipio.ValueMember = "clave";
                cb_municipio.DisplayMember = "texto";

                if (municipios == null)
                    btn_guardar.Enabled = false;
                else
                {
                    cb_municipio.Enabled = true;
                    btn_guardar.Enabled = true;
                    cargaCB_municipio = true;
                }


            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show("Error al cargar los municipios registrados " + ex.Message, "Error de consulta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btn_guardar.Enabled = false;
            }
        }
        private void GenerarCBColonias(int noColonia)
        {
            try
            {
                DataTable? colonias = Direccion.GetColonias(noColonia, true);

                cb_colonia.DataSource = colonias;
                cb_colonia.ValueMember = "clave";
                cb_colonia.DisplayMember = "texto";

                if (colonias == null)
                    btn_guardar.Enabled = false;
                else
                {
                    cb_colonia.Enabled = true;
                    btn_guardar.Enabled = true;
                }


            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show("Error al cargar las colonias registrados " + ex.Message, "Error de consulta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btn_guardar.Enabled = false;
            }
        }

        private void cb_estado_SelectedValueChanged(object sender, EventArgs e)
        {
            if (!cargaCB_estado) return;

            if (string.IsNullOrEmpty(cb_estado.SelectedValue.ToString()))
            {
                cb_municipio.Enabled = false;
                cb_colonia.Enabled = false;

                cargaCB_municipio = false;

                cb_colonia.DataSource = null;
                cb_colonia.Items.Clear();

                cb_municipio.DataSource = null;
                cb_municipio.Items.Clear();
                return;
            }

            int noEstado = (int)cb_estado.SelectedValue;
            GenerarCBMunicipios(noEstado);
        }
        private void cb_municipio_SelectedValueChanged(object sender, EventArgs e)
        {
            if (!cargaCB_municipio) return;

            if (string.IsNullOrEmpty(cb_municipio.SelectedValue.ToString()))
            {
                cb_colonia.DataSource = null;
                cb_colonia.Enabled = false;
                cb_colonia.Items.Clear();
                return;
            }

            int noColonia = (int)cb_municipio.SelectedValue;
            GenerarCBColonias(noColonia);
        }
    }
}
