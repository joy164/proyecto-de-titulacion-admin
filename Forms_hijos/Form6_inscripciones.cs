using CENDI_admin.Clases.Entidades;
using CENDI_admin.Clases.Utils;
using CENDI_admin.Forms_dialogos;
using Npgsql;
using System.Data;

namespace CENDI_admin.Forms_hijos
{
    public partial class Form6_inscripciones : Form
    {
        private bool esInscripcion = true, fechaValida = false, fotoCargada = false, cargaCompleta = false, reiniciandoFormulario = false;
        private int infanteID, cicloAcutalID;

        public Form6_inscripciones()
        {
            InitializeComponent();

            GenerarCBCicloEscolar();
            GenerarCBEntidades();
            GenerarCBTutores();
            GenerarCBGrupos();
            GenerarCBSexo();
        }

        private void btn_tomarFoto_Click(object sender, EventArgs e)
        {
            Dialogo6_foto form = new();

            if (form.ShowDialog() == DialogResult.OK)
            {
                pb_imgInfante.Image = form.FotoCapturada;
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
                pb_imgInfante.ImageLocation = openFileDialog.FileName;
                fotoCargada = true;
            }

        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (!ValidacionCampos.ValidarEntradasTexto(tb_curp, tb_nombre, tb_ap, tb_am, cb_grupo, cb_lugarNac, cb_sexo) || !fechaValida)
            {
                MessageBox.Show("Entrada no valida en el campo(s) señalado(s)", "Error en los campos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!fotoCargada)
            {
                MessageBox.Show("Debe cargar una foto o tomar una foto", "Error en los campos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

#pragma warning disable CS8604 // Posible argumento de referencia nulo
            int noSalon = int.Parse(cb_grupo.SelectedValue.ToString());
#pragma warning restore CS8604 // Posible argumento de referencia nulo
            char sexo = cb_sexo.SelectedValue.ToString()[0];
            
            LugarNac lugarNac = new(dtp_fechaNac.Value, (int)cb_lugarNac.SelectedValue);
            Edad edad = new Edad((int)NUD_año.Value, (int)NUD_mes.Value);
            Nombre nombre = new(tb_nombre.Text, tb_ap.Text, tb_am.Text);
            
            try
            {
                if (esInscripcion)
                {
                    Infante.NewInfante(noSalon, pb_imgInfante.Image, nombre, tb_curp.Text, lugarNac, edad, sexo);
                    infanteID = Infante.GetInfanteID(tb_curp.Text);
                    MessageBox.Show("Infante registrado con exito", "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    panel1.Enabled = false;
                    panel3.Enabled = true;
                }
                else
                {
                    Infante.UpdateInfanteData(infanteID, noSalon, pb_imgInfante.Image, nombre, tb_curp.Text, lugarNac, edad, sexo);
                    CargarTablaPermisos(infanteID, cicloAcutalID);
                    MessageBox.Show("Datos actualizados con exito", "Informacion actualizada", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    panel1.Enabled = false;
                    panel3.Enabled = true;

                }

            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show( string.Format("Error de {0}, intente mas tarde o revise la conexion a internet {1}", esInscripcion ? "inscripcion" : "reinscripcion", ex.Message) , "Error de registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btn_buscar_Click(object sender, EventArgs e)
        {
            if (!ValidacionCampos.ValidarEntradasTexto(tb_busqueda)) return;
            
            try
            {
                infanteID = Infante.GetInfanteID(tb_busqueda.Text);

                if (infanteID == 0)
                {
                    MessageBox.Show("El Infante no ha sido encotrado o no existe", "Error de consulta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DataTable? infante = Infante.GetInfante(infanteID);

                if (infante == null)
                {
                    MessageBox.Show("El Infante no ha sido encotrado o no existe", "Error de consulta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                tb_busqueda.Enabled = false;
                btn_buscar.Enabled = false;

                pb_imgInfante.Image = Imagenes.ByteArrayToImagen((byte[])infante.Rows[0]["IMG_INFANTE"]);

                tb_nombre.Enabled = false;
                tb_curp.Enabled = false;
                tb_ap.Enabled = false;
                tb_am.Enabled = false;

                dtp_fechaNac.Enabled = false;

                cb_lugarNac.Enabled = false;
                cb_sexo.Enabled = false;

                tb_nombre.Text = (string)infante.Rows[0]["NOMBRES"];
                tb_curp.Text = (string)infante.Rows[0]["CURP"];
                tb_ap.Text = (string)infante.Rows[0]["AP_PAT"];
                tb_am.Text = (string)infante.Rows[0]["AP_MAT"];

                dtp_fechaNac.Value = (DateTime)infante.Rows[0]["FECHA_NAC"];

                cb_sexo.SelectedValue = infante.Rows[0]["SEXO_INFANTE"].ToString()[0];
                cb_lugarNac.SelectedValue = (int)infante.Rows[0]["LUGAR_NAC"];
                cb_grupo.SelectedValue = (int)infante.Rows[0]["NO_SALON"];

                esInscripcion = false;
                fotoCargada = true;
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show("Error al cargar los datos de infante " + ex.Message, "Error de consulta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void tb_busqueda_KeyDown(object sender, KeyEventArgs e)
        {
            if (!ValidacionCampos.ValidarEntradasTexto(tb_busqueda)) return;
            
            if (e.KeyCode != Keys.Enter) return;

            try
            {
                infanteID = Infante.GetInfanteID(tb_busqueda.Text);

                if (infanteID == 0)
                {
                    MessageBox.Show("El Infante no ha sido encotrado o no existe", "Error de consulta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DataTable? infante = Infante.GetInfante(infanteID);

                if (infante == null)
                {
                    MessageBox.Show("El Infante no ha sido encotrado o no existe", "Error de consulta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                tb_busqueda.Enabled = false;
                btn_buscar.Enabled = false;

                pb_imgInfante.Image = Imagenes.ByteArrayToImagen((byte[])infante.Rows[0]["IMG_INFANTE"]);

                tb_curp.Enabled = false;
                tb_nombre.Enabled = false;
                tb_ap.Enabled = false;
                tb_am.Enabled = false;

                dtp_fechaNac.Enabled = false;

                cb_lugarNac.Enabled = false;
                cb_sexo.Enabled = false;

                tb_curp.Text = (string)infante.Rows[0]["CURP"];
                tb_nombre.Text = (string)infante.Rows[0]["NOMBRES"];
                tb_ap.Text = (string)infante.Rows[0]["AP_PAT"];
                tb_am.Text = (string)infante.Rows[0]["AP_MAT"];

                dtp_fechaNac.Value = (DateTime)infante.Rows[0]["FECHA_NAC"];

                cb_lugarNac.SelectedValue = (int)infante.Rows[0]["LUGAR_NAC"];
                cb_sexo.SelectedValue = infante.Rows[0]["SEXO_INFANTE"].ToString()[0];
                cb_grupo.SelectedValue = (int)infante.Rows[0]["NO_SALON"];

                esInscripcion = false;
                fotoCargada = true;
                
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show("Error al cargar los datos de infante " + ex.Message, "Error de consulta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btn_nuevoTutor_Click(object sender, EventArgs e)
        {
            Dialogo7_tutor form = new();

            if (form.ShowDialog() == DialogResult.OK)
            {
                btn_agregarPermiso.Enabled = true;
                GenerarCBTutores();
            }
        }
        private void btn_agregarPermiso_Click(object sender, EventArgs e)
        {
            if (!ValidacionCampos.ValidarEntradasTexto(cb_cicloEscolar, cb_tutor))
            {
                MessageBox.Show("Entrada no valida en el campo(s) señalado(s)", "Error en los campos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int noCiclo = (int)cb_cicloEscolar.SelectedValue;
            int noTutor = (int)cb_tutor.SelectedValue;

            if (cicloAcutalID != noCiclo)
            {
                DialogResult res = MessageBox.Show("Advertencia: el ciclo que tiene seleccionado no es el ciclo actual, ¿Desea continuar?", "Ciclo no actual seleccionado", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (res == DialogResult.No) return;
            }

            try
            {
                InfanteTutor.NewInfanteTutor(noTutor, infanteID, noCiclo);
                MessageBox.Show("Permiso registrado con exito", "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarTablaPermisos(infanteID, noCiclo);
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show("Error al registrar permiso, intente mas tarde o revise la conexion a internet " + ex.Message, "Error de registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btn_quitarPermiso_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar una fila para eliminar", "Fila no seleccionada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int noCiclo = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
            int noTutor = (int)dataGridView1.SelectedRows[0].Cells[1].Value;
            string nom = (string)dataGridView1.SelectedRows[0].Cells[2].Value;

            DialogResult res = MessageBox.Show(string.Format("¿Esta seguro que quiere eliminar al tutor {0}?", nom), "Eliminando salon", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (res == DialogResult.No) return;
            
            try
            {
                InfanteTutor.DeleteInfanteTutor(noTutor, infanteID, noCiclo);
                CargarTablaPermisos(infanteID, noCiclo);
                MessageBox.Show("El tutor se ha eliminado con exito", "Tutor eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show("Error al eliminar tutor, intente mas tarde o revise la conexion a internet " + ex.Message, "Error de consulta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void btn_terminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("Debe de registrar por lo menos un tutor para recoger al infante", "Sin tutores autorizados", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ValidacionCampos.LimpiarCampos(tb_busqueda, tb_curp, tb_nombre, tb_ap, tb_am, cb_lugarNac, cb_sexo, cb_grupo, cb_tutor);

            tb_busqueda.Enabled = true;
            btn_buscar.Enabled = true;

            tb_curp.Enabled = true;
            tb_nombre.Enabled = true;
            tb_ap.Enabled = true;
            tb_am.Enabled = true;

            dtp_fechaNac.Enabled = true;

            cb_lugarNac.Enabled = true;
            cb_sexo.Enabled = true;

            reiniciandoFormulario = true;
            pb_imgInfante.Image = null;
            panel1.Enabled = true;
            panel3.Enabled = false;
            esInscripcion = true;
            fechaValida = false;
            fotoCargada = false;
            infanteID = 0;

            cb_cicloEscolar.SelectedValue = cicloAcutalID;
            dtp_fechaNac.Value = DateTime.Today;
            dataGridView1.Rows.Clear();
            NUD_año.Value = 0;
            NUD_mes.Value = 0;
        }
        private void btn_verCredencial_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("Debe de registrar por lo menos un tutor para ver las credenciales", "Sin tutores autorizados", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int noCiclo = (int)cb_cicloEscolar.SelectedValue;
            CargarTablaPermisos(infanteID, noCiclo);

            Dialogo5_credencial form = new(infanteID, noCiclo);
            form.ShowDialog();
        }

        private void cb_cicloEscolar_SelectedValueChanged(object sender, EventArgs e)
        {
            if (!cargaCompleta) return;

            if (!ValidacionCampos.ValidarEntradasTexto(cb_cicloEscolar))
            {
                MessageBox.Show("Entrada no valida en el campo(s) señalado(s)", "Error en los campos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int noCiclo = (int)cb_cicloEscolar.SelectedValue;

            CargarTablaPermisos(infanteID, noCiclo);
        }
        private void dtp_fechaNac_ValueChanged(object sender, EventArgs e)
        {
            if (dtp_fechaNac.Value >= DateTime.Today)
            {
                if (!reiniciandoFormulario)
                {
                    MessageBox.Show("La fecha seleccionada no es valida", "Fecha invalida", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    fechaValida = false;
                }
                else
                    reiniciandoFormulario = false;

                return;
            }

            DateTime nacimiento = dtp_fechaNac.Value;
            DateTime hoy = DateTime.Today;

            // Años
            int edadAnos = hoy.Year - nacimiento.Year;
            if (hoy.Month < nacimiento.Month || (hoy.Month == nacimiento.Month &&
            hoy.Day < nacimiento.Day))
                edadAnos--;

            // Meses
            int edadMeses = hoy.Month - nacimiento.Month;
            if (hoy.Day < nacimiento.Day)
                edadMeses--;
            if (edadMeses < 0)
                edadMeses += 12;

            NUD_año.Value = edadAnos;
            NUD_mes.Value = edadMeses;
            fechaValida = true;
        }
        private void tb_busqueda_TextChanged(object sender, EventArgs e)
        {
            ValidacionCampos.CambiarMayuscula(ref tb_busqueda);
        }
        private void tb_curp_TextChanged(object sender, EventArgs e)
        {
            ValidacionCampos.CambiarMayuscula(ref tb_curp);
        }
        private void tb_nombre_TextChanged(object sender, EventArgs e)
        {
            ValidacionCampos.CapitalizarTexto(ref tb_nombre);
        }
        private void tb_ap_TextChanged(object sender, EventArgs e)
        {
            ValidacionCampos.CapitalizarTexto(ref tb_ap);
        }
        private void tb_am_TextChanged(object sender, EventArgs e)
        {
            ValidacionCampos.CapitalizarTexto(ref tb_am);
        }

        private void CargarTablaPermisos(int ID_INFANTE, int ID_CICLO)
        {
            try
            {
                DataTable? regUsuarios = InfanteTutor.GetAllInfanteTutor(ID_INFANTE, ID_CICLO);
                dataGridView1.Rows.Clear();

                if (regUsuarios == null) return;

                foreach (DataRow row in regUsuarios.Rows)
                {
                    Nombre nom = new((string)row["NOM_TUTOR"], (string)row["AP_TUTOR"], (string)row["AM_TUTOR"]);
                    dataGridView1.Rows.Add(row["ID_CICLO"], row["ID_TUTOR"], nom.ToString());
                }
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show("Error al cargar los permisos de infante, intente mas tarde o revise la conexion a internet " + ex.Message, "Error de consulta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void GenerarCBSexo()
        {
            string[] sexoDisplay = { "Masculino", "Femenino" };
            char[] sexoValue = { 'M', 'F' };

            DataTable grupos = new();

            grupos.Columns.Add("clave", typeof(char));
            grupos.Columns.Add("texto", typeof(string));
            grupos.Rows.Add(null, "NO SELECCIONADO");

            for (int i = 0; i < sexoDisplay.Length; i++)
            {
                grupos.Rows.Add(sexoValue[i], sexoDisplay[i]);
            }

            cb_sexo.DataSource = grupos;
            cb_sexo.ValueMember = "clave";
            cb_sexo.DisplayMember = "texto";
        }
        private void GenerarCBGrupos()
        {
            try
            {
                DataTable? grupos = Salon.GetAllSalon(true);

                cb_grupo.DataSource = grupos;
                cb_grupo.ValueMember = "clave";
                cb_grupo.DisplayMember = "texto";

                if (grupos == null)
                {
                    MessageBox.Show("No hay grupos registrados, debe registrar al menos un grupo para hacer inscripciones o reinscripciones", "Error de consulta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btn_guardar.Enabled = false;
                }

            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show("Error al cargar los salones registrados " + ex.Message, "Error de consulta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btn_guardar.Enabled = false;
            }
        }
        private void GenerarCBTutores()
        {
            try
            {
                DataTable? tutores = Tutor.GetAllTutores(true);

                cb_tutor.DataSource = tutores;
                cb_tutor.ValueMember = "clave";
                cb_tutor.DisplayMember = "texto";

                if (tutores == null)
                    btn_agregarPermiso.Enabled = false;
                else
                    btn_agregarPermiso.Enabled = true;

            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show("Error al cargar los tutores registrados " + ex.Message, "Error de consulta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btn_agregarPermiso.Enabled = false;
            }
        }
        private void GenerarCBEntidades()
        {
            try
            {
                DataTable? entidad = Direccion.GetEstado(true);

                cb_lugarNac.DataSource = entidad;
                cb_lugarNac.ValueMember = "clave";
                cb_lugarNac.DisplayMember = "texto";

                if (entidad == null)
                    btn_guardar.Enabled = false;
                else
                    cb_lugarNac.SelectedValue = 9;

            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show("Error al cargar los salones registrados " + ex.Message, "Error de consulta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btn_guardar.Enabled = false;
            }
        }
        private void GenerarCBCicloEscolar()
        {
            try
            {
                DataTable? ciclo = CicloEscolar.GetAllCiclos(true);

                cb_cicloEscolar.DataSource = ciclo;
                cb_cicloEscolar.ValueMember = "clave";
                cb_cicloEscolar.DisplayMember = "texto";

                if (ciclo == null)
                {
                    MessageBox.Show("No hay ciclos escolares registrados, debe registrar un ciclo escolar para dar de alta permisos a tutores", "Error de consulta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btn_guardar.Enabled = false;
                }
                else
                {
                    cicloAcutalID = CicloEscolar.GetIDCicloActual();
                    cb_cicloEscolar.SelectedValue = cicloAcutalID;
                    cargaCompleta = true;
                }

            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show("Error al cargar los ciclos escolares registrados " + ex.Message, "Error de consulta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btn_guardar.Enabled = false;
            }
        }


    }
}
