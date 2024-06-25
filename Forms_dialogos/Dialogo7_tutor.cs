using CENDI_admin.Clases.Entidades;
using CENDI_admin.Clases.Utils;
using Npgsql;
using System.Data;

namespace CENDI_admin.Forms_dialogos
{
    public partial class Dialogo7_tutor : Form
    {
        private bool cargaCB_estado = false, cargaCB_municipio = false, cargaCB_direcciones = false;
        private bool fotoCargada = false, direccionNueva = true;

        public Dialogo7_tutor()
        {
            InitializeComponent();

            LlenarCBDirecciones();
            GenerarCBEntidades();
            LlenarCBParentesco();
        }

        private void btn_tomarFoto_Click(object sender, EventArgs e)
        {
            Dialogo6_foto form = new();

            if (form.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = form.FotoCapturada;
                fotoCargada = true;
            }
        }
        private void btn_cargarImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "jpg (*.jpg)|*.jpg|png (*.png)|*.png|gif (*.gif)|*.gif",
                RestoreDirectory = true
            };

            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                pictureBox1.ImageLocation = openFileDialog.FileName;
                fotoCargada = true;
            }
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (!ValidacionCampos.ValidarEntradasTexto(tb_noTel, tb_nom, tb_ap, tb_am, cb_parentesco, tb_calle, tb_noExt, cb_estado, cb_municipio, cb_colonia))
            {
                MessageBox.Show("Entrada no valida en el campo(s) señalado(s)", "Error en los campos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!fotoCargada)
            {
                MessageBox.Show("Debe cargar una foto o tomar una foto", "Error en los campos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //datos de tutor
            string? telFijo = string.IsNullOrEmpty(tb_telFijo.Text.Trim()) ? null : tb_telFijo.Text.Trim();
            string noInt = string.IsNullOrEmpty(tb_noInt.Text.Trim()) ? "s/n" : tb_noInt.Text.Trim();
            int IDParenteso = (int)cb_parentesco.SelectedValue;
            string noTel = tb_noTel.Text;
            Nombre nombre = new()
            {
                Nombres = tb_nom.Text,
                ApellidoPaterno = tb_ap.Text,
                ApellidoMaterno = tb_am.Text
            };

            try
            {
                if (direccionNueva)
                {
                    Direccion dir = new()
                    {
                        Calle = tb_calle.Text,
                        No_ext = tb_noExt.Text,
                        No_int = noInt,
                        ID_Estado = (int)cb_estado.SelectedValue,
                        ID_Municipio = (int)cb_municipio.SelectedValue,
                        ID_Colonia = (int)cb_colonia.SelectedValue
                    };
                    try
                    {
                        Tutor.NewTutor(IDParenteso, pictureBox1.Image, nombre, noTel, telFijo, dir);

                        MessageBox.Show("Tutor registrado con exito", "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DialogResult = DialogResult.OK;
                        Close();
                    }
                    catch (NpgsqlException ex)
                    {
                        MessageBox.Show("Error al registrar Tutor, intente mas tarde o revise la conexion a internet " + ex.Message, "Error de registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    int idDir = (int)cb_direcciones.SelectedValue;
                    try
                    {
                        Tutor.NewTutor(IDParenteso, pictureBox1.Image, nombre, noTel, telFijo, idDir);

                        MessageBox.Show("Datos actualizados con exito", "Informacion actualizada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DialogResult = DialogResult.OK;
                        Close();
                    }
                    catch (NpgsqlException ex)
                    {
                        MessageBox.Show("Error al actualizar Tutor, intente mas tarde o revise la conexion a internet " + ex.Message, "Error de registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show("Error al registrar Tutor, intente mas tarde o revise la conexion a internet " + ex.Message, "Error de registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        private void cb_direcciones_SelectedValueChanged(object sender, EventArgs e)
        {
            if (!cargaCB_direcciones) return;

            if (string.IsNullOrEmpty(cb_direcciones.SelectedValue.ToString()))
            {
                cb_municipio.Enabled = false;
                cb_colonia.Enabled = false;
                cb_estado.Enabled = true;

                tb_calle.Enabled = true;
                tb_noExt.Enabled = true;
                tb_noInt.Enabled = true;

                cargaCB_municipio = false;

                tb_calle.Text = string.Empty;
                tb_noExt.Text = string.Empty;
                tb_noInt.Text = string.Empty;

                cb_municipio.DataSource = null;
                cb_municipio.Items.Clear();

                cb_colonia.DataSource = null;
                cb_colonia.Items.Clear();

                direccionNueva = true;
                return;
            }

            int ID_direccion = (int)cb_direcciones.SelectedValue;
            DataTable? dir = Direccion.GetDireccion(ID_direccion);

            if (dir != null)
            {
                int noEstado, noMunicipio, noColonia;

                noEstado = (int)dir.Rows[0]["ID_ESTADO"];
                noMunicipio = (int)dir.Rows[0]["ID_MUNICIPIO"];
                noColonia = (int)dir.Rows[0]["ID_COLONIA"];

                tb_calle.Text = (string)dir.Rows[0]["CALLE"];
                tb_noExt.Text = (string)dir.Rows[0]["NO_EXT"];
                tb_noInt.Text = (string)dir.Rows[0]["NO_INT"];

                tb_calle.Enabled = false;
                tb_noExt.Enabled = false;
                tb_noInt.Enabled = false;

                GenerarCBMunicipios(noEstado);

                cb_estado.SelectedValue = noEstado;
                cb_municipio.SelectedValue = noMunicipio;
                cb_colonia.SelectedValue = noColonia;

                cb_municipio.Enabled = false;
                cb_colonia.Enabled = false;
                cb_estado.Enabled = false;

                direccionNueva = false;
            }

        }
        private void tb_nom_TextChanged(object sender, EventArgs e)
        {
            ValidacionCampos.CapitalizarTexto(ref tb_nom);
        }
        private void tb_ap_TextChanged(object sender, EventArgs e)
        {
            ValidacionCampos.CapitalizarTexto(ref tb_ap);
        }
        private void tb_am_TextChanged(object sender, EventArgs e)
        {
            ValidacionCampos.CapitalizarTexto(ref tb_am);
        }
        private void tb_telFijo_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Delete)
                ValidacionCampos.FormatoTelefono(ref tb_telFijo);
        }
        private void tb_noTel_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Delete)
                ValidacionCampos.FormatoTelefono(ref tb_noTel);
        }

        private void LlenarCBParentesco()
        {
            try
            {
                DataTable? parentesco = Parentesco.GetAllParentesco(true);

                cb_parentesco.DataSource = parentesco;
                cb_parentesco.ValueMember = "clave";
                cb_parentesco.DisplayMember = "texto";

                btn_guardar.Enabled = parentesco == null ? false : true;
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show("Error al cargar los parentescos registradas " + ex.Message, "Error de consulta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btn_guardar.Enabled = false;
            }
        }
        private void LlenarCBDirecciones()
        {
            try
            {
                DataTable? direcciones = Direccion.GetAllDirecciones(true);

                cb_direcciones.DataSource = direcciones;
                cb_direcciones.ValueMember = "clave";
                cb_direcciones.DisplayMember = "texto";

                if (direcciones != null)
                {
                    cb_direcciones.Enabled = true;
                    cargaCB_direcciones = true;
                }
                else
                    cb_direcciones.Enabled = false;

            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show("Error al cargar las direcciones registradas " + ex.Message, "Error de consulta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btn_guardar.Enabled = false;
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

    }
}
