using CENDI_admin.Clases.Entidades;
using CENDI_admin.Forms_dialogos;
using CENDI_admin.Clases.Utils;
using System.Data;
using Npgsql;

namespace CENDI_admin.Forms_hijos
{


    public partial class Form5_tutores : Form
    {
        private bool cargaCB_estado = false, cargaCB_municipio = false;
        private int tutorID, direccionID;

        public Form5_tutores()
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
                pb_imgTutor.Image = form.FotoCapturada;
        }
        private void btn_cargarFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "jpg (*.jpg)|*.jpg|png (*.png)|*.png|gif (*.gif)|*.gif",
                RestoreDirectory = true
            };

            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
                pb_imgTutor.ImageLocation = openFileDialog.FileName;

        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            if (!ValidacionCampos.ValidarEntradasTexto(tb_busqueda)) return;

            try
            {
                tutorID = Tutor.GetTutorID(tb_busqueda.Text);

                if (tutorID == 0)
                {
                    MessageBox.Show("El tutor no ha sido encotrado o no existe", "Error de consulta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DataTable? tutor = Tutor.GetTutor(tutorID);

                if (tutor == null)
                {
                    MessageBox.Show("El tutor no ha sido encotrado o no existe", "Error de consulta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                tb_busqueda.Enabled = false;
                btn_buscar.Enabled = false;

                direccionID = (int)tutor.Rows[0]["ID_DIRECCION"];

                pb_imgTutor.Image = Imagenes.ByteArrayToImagen((byte[])tutor.Rows[0]["IMG_TUTOR"]);

                tb_telFijo.Text = tutor.Rows[0]["TEL_FIJO"].ToString() == null ? string.Empty : tutor.Rows[0]["TEL_FIJO"].ToString();
                tb_noTel.Text = (string)tutor.Rows[0]["TEL_CELULAR"];
                tb_nom.Text = (string)tutor.Rows[0]["NOMBRES"];
                tb_ap.Text = (string)tutor.Rows[0]["AP_PAT"];
                tb_am.Text = (string)tutor.Rows[0]["AP_MAT"];

                cb_parentesco.SelectedValue = (int)tutor.Rows[0]["ID_PARENTESCO"];

                tb_calle.Text = (string)tutor.Rows[0]["CALLE"];
                tb_noExt.Text = (string)tutor.Rows[0]["NO_EXT"];
                tb_noInt.Text = (string)tutor.Rows[0]["NO_INT"];

                cb_estado.SelectedValue = (int)tutor.Rows[0]["ID_ESTADO"];
                cb_municipio.SelectedValue = (int)tutor.Rows[0]["ID_MUNICIPIO"];
                cb_colonia.SelectedValue = (int)tutor.Rows[0]["ID_COLONIA"];

                gb_direccion.Enabled = true;
                gb_accionesTutor.Enabled = true;
                gb_datos.Enabled = true;
                gb_foto.Enabled = true;

            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show("Error al cargar los datos del tutor " + ex.Message, "Error de consulta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void tb_busqueda_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;

            if (!ValidacionCampos.ValidarEntradasTexto(tb_busqueda)) return;

            try
            {
                tutorID = Tutor.GetTutorID(tb_busqueda.Text);

                if (tutorID == 0)
                {
                    MessageBox.Show("El tutor no ha sido encotrado o no existe", "Error de consulta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DataTable? tutor = Tutor.GetTutor(tutorID);

                if (tutor == null)
                {
                    MessageBox.Show("El tutor no ha sido encotrado o no existe", "Error de consulta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                tb_busqueda.Enabled = false;
                btn_buscar.Enabled = false;

                direccionID = (int)tutor.Rows[0]["ID_DIRECCION"];

                pb_imgTutor.Image = Imagenes.ByteArrayToImagen((byte[])tutor.Rows[0]["IMG_TUTOR"]);

                tb_telFijo.Text = tutor.Rows[0]["TEL_FIJO"].ToString() == null ? string.Empty : tutor.Rows[0]["TEL_FIJO"].ToString();
                tb_noTel.Text = (string)tutor.Rows[0]["TEL_CELULAR"];
                tb_nom.Text = (string)tutor.Rows[0]["NOMBRES"];
                tb_ap.Text = (string)tutor.Rows[0]["AP_PAT"];
                tb_am.Text = (string)tutor.Rows[0]["AP_MAT"];

                cb_parentesco.SelectedValue = (int)tutor.Rows[0]["ID_PARENTESCO"];

                tb_calle.Text = (string)tutor.Rows[0]["CALLE"];
                tb_noExt.Text = (string)tutor.Rows[0]["NO_EXT"];
                tb_noInt.Text = (string)tutor.Rows[0]["NO_INT"];

                cb_estado.SelectedValue = (int)tutor.Rows[0]["ID_ESTADO"];
                cb_municipio.SelectedValue = (int)tutor.Rows[0]["ID_MUNICIPIO"];
                cb_colonia.SelectedValue = (int)tutor.Rows[0]["ID_COLONIA"];

                gb_direccion.Enabled = true;
                gb_accionesTutor.Enabled = true;
                gb_datos.Enabled = true;
                gb_foto.Enabled = true;

            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show("Error al cargar los datos del tutor " + ex.Message, "Error de consulta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void btn_verCredencial_Click(object sender, EventArgs e)
        {
            Dialogo9_credencialActualizada form = new(tutorID);

            form.ShowDialog();

            ValidacionCampos.LimpiarCampos(tb_busqueda, tb_noTel, tb_nom, tb_ap, tb_am, cb_parentesco, tb_telFijo, cb_direcciones, tb_calle, tb_noExt, tb_noInt, cb_estado);

            pb_imgTutor.Image = null;

            btn_actualizarDir.Enabled = true;
            tb_busqueda.Enabled = true;
            btn_buscar.Enabled = true;

            gb_accionesTutor.Enabled = false;
            gb_direccion.Enabled = false;
            gb_datos.Enabled = false;
            gb_foto.Enabled = false;
        }
        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (!ValidacionCampos.ValidarEntradasTexto(tb_noTel, tb_nom, tb_ap, tb_am, cb_parentesco))
            {
                MessageBox.Show("Entrada no valida en el campo(s) señalado(s)", "Error en los campos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //datos de tutor
            Nombre nombre = new(tb_nom.Text, tb_ap.Text, tb_am.Text);

            string? telFijo = string.IsNullOrEmpty(tb_telFijo.Text.Trim()) ? null : tb_telFijo.Text.Trim();
            string noInt = string.IsNullOrEmpty(tb_noInt.Text.Trim()) ? "s/n" : tb_noInt.Text.Trim();
            int IDParenteso = (int)cb_parentesco.SelectedValue;
            string noTel = tb_noTel.Text;

            try
            {
                Tutor.UpdateTutorData(tutorID, IDParenteso, pb_imgTutor.Image, nombre, noTel, telFijo, direccionID);

                Dialogo9_credencialActualizada form = new(tutorID);

                form.ShowDialog();

                ValidacionCampos.LimpiarCampos(tb_busqueda, tb_noTel, tb_nom, tb_ap, tb_am, cb_parentesco, tb_telFijo, cb_direcciones, tb_calle, tb_noExt, tb_noInt, cb_estado);

                pb_imgTutor.Image = null;

                btn_actualizarDir.Enabled = true;
                tb_busqueda.Enabled = true;
                btn_buscar.Enabled = true;

                gb_accionesTutor.Enabled = false;
                gb_direccion.Enabled = false;
                gb_datos.Enabled = false;
                gb_foto.Enabled = false;

            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show("Error al registrar Tutor, intente mas tarde o revise la conexion a internet " + ex.Message, "Error de registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("¿Esta seguro que quiere eliminar a este tutor?, todos los registros de asistencia tambien se eliminaran", "Eliminando tutor...", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (res == DialogResult.No) return;

            try
            {
                Tutor.DeleteTutor(tutorID);
                MessageBox.Show("Tutor eliminado con exito", "Baja exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ValidacionCampos.LimpiarCampos(tb_busqueda, tb_noTel, tb_nom, tb_ap, tb_am, cb_parentesco, tb_telFijo, cb_direcciones, tb_calle, tb_noExt, tb_noInt, cb_estado);

                pb_imgTutor.Image = null;

                btn_actualizarDir.Enabled = true;
                tb_busqueda.Enabled = true;
                btn_buscar.Enabled = true;

                gb_accionesTutor.Enabled = false;
                gb_direccion.Enabled = false;
                gb_datos.Enabled = false;
                gb_foto.Enabled = false;
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show("Error al eliminar tutor, intente mas tarde o revise la conexion a internet " + ex.Message, "Error de registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btn_cambiarDir_Click(object sender, EventArgs e)
        {
            if (cb_direcciones.SelectedIndex == 0) return;

            DialogResult res = MessageBox.Show("¿Esta seguro que quire cambiar la direccion al tutor?", "Cambiando direceccion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (res == DialogResult.No) return;

            direccionID = (int)cb_direcciones.SelectedValue;

            try
            {
                Tutor.UpdateTutorDirID(tutorID, direccionID);

                Dialogo9_credencialActualizada form = new(tutorID);

                form.ShowDialog();

                ValidacionCampos.LimpiarCampos(tb_busqueda, tb_noTel, tb_nom, tb_ap, tb_am, cb_parentesco, tb_telFijo, cb_direcciones, tb_calle, tb_noExt, tb_noInt, cb_estado);

                pb_imgTutor.Image = null;

                btn_actualizarDir.Enabled = true;
                tb_busqueda.Enabled = true;
                btn_buscar.Enabled = true;

                gb_accionesTutor.Enabled = false;
                gb_direccion.Enabled = false;
                gb_datos.Enabled = false;
                gb_foto.Enabled = false;
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show("Error al actualizar direccion, intente mas tarde o revise la conexion a internet " + ex.Message, "Error de registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void btn_actualizarDir_Click(object sender, EventArgs e)
        {
            if (!ValidacionCampos.ValidarEntradasTexto(tb_calle, tb_noExt, cb_estado, cb_municipio, cb_colonia))
            {
                MessageBox.Show("Entrada no valida en el campo(s) señalado(s)", "Error en los campos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult res = MessageBox.Show("Advertencia: Si actualiza la direccion, se actualizara la direccion a otros tutores con esta direccion, ¿Quiere continuar?", "Actualizando direccion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (res == DialogResult.No) return;

            //datos de direccion
            string Calle = tb_calle.Text;
            string No_ext = tb_noExt.Text;
            string No_int = string.IsNullOrEmpty(tb_noInt.Text.Trim()) ? "s/n" : tb_noInt.Text.Trim();
            int ID_Estado = (int)cb_estado.SelectedValue;
            int ID_Municipio = (int)cb_municipio.SelectedValue;
            int ID_Colonia = (int)cb_colonia.SelectedValue;

            try
            {
                Direccion.UpdateDireccionData(direccionID, ID_Colonia, ID_Municipio, ID_Estado, Calle, No_ext, No_int);

                Dialogo9_credencialActualizada form = new(tutorID);

                form.ShowDialog();

                ValidacionCampos.LimpiarCampos(tb_busqueda, tb_noTel, tb_nom, tb_ap, tb_am, cb_parentesco, tb_telFijo, cb_direcciones, tb_calle, tb_noExt, tb_noInt, cb_estado);

                pb_imgTutor.Image = null;

                btn_actualizarDir.Enabled = true;
                tb_busqueda.Enabled = true;
                btn_buscar.Enabled = true;

                gb_accionesTutor.Enabled = false;
                gb_direccion.Enabled = false;
                gb_datos.Enabled = false;
                gb_foto.Enabled = false;

            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show("Error al actualizar direccion, intente mas tarde o revise la conexion a internet " + ex.Message, "Error de registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btn_nuevaDir_Click(object sender, EventArgs e)
        {
            Dialogo8_direccion form = new();

            if (form.ShowDialog() == DialogResult.OK)
                LlenarCBDirecciones();
        }
        private void btn_parentescos_Click(object sender, EventArgs e)
        {
            Dialogo11_parentescos form = new();

            if (form.ShowDialog() == DialogResult.OK)
                LlenarCBParentesco();
        }
        private void btn_nuevoTutor_Click(object sender, EventArgs e)
        {
            Dialogo7_tutor form = new();
            form.ShowDialog();
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
        private void tb_busqueda_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Delete)
                ValidacionCampos.FormatoTelefono(ref tb_busqueda);

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

                cb_direcciones.Enabled = direcciones != null ? true : false;
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
