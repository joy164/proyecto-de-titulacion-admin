using CENDI_admin.Clases.Entidades;
using CENDI_admin.Clases.Utils;
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;

namespace CENDI_admin.Forms_dialogos
{
    public partial class Dialogo10_edicionAsistencia : Form
    {
        private int modo, noReg;
        private bool textoValido = false;

        public Dialogo10_edicionAsistencia(int modo, int noReg)
        {
            InitializeComponent();
            this.noReg = noReg;
            this.modo = modo;
            cargarTexto();
        }
        private void cargarTexto()
        {

            DataTable? res = Asistencia.GetAsistencia(modo, noReg);

            if (res == null) Close();

            tb_observaciones.Text = (string)res.Rows[0]["OBSERVACIONES"] == null ? string.Empty : (string)res.Rows[0]["OBSERVACIONES"];
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (!textoValido) return;

            string texto = tb_observaciones.Text;

            try
            {
                Asistencia.UpdateAsistenciaObservaciones(modo, noReg, texto);
                MessageBox.Show("Datos actualizados con exito", "Informacion actualizada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            catch (NpgsqlException ex)
            {

                MessageBox.Show("Error de actualizacion, intente mas tarde o revise la conexion a internet " + ex.Message, "Error de registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tb_observaciones_TextChanged(object sender, EventArgs e)
        {
            string diccionario = "@=<>^[]{};:?\\|~+%!*$`'";

            if (!string.IsNullOrEmpty(tb_observaciones.Text.Trim()))
            {
                foreach (char token in diccionario)
                    if (tb_observaciones.Text.Contains(token))
                    {
                        tb_observaciones.BackColor = Color.Moccasin;
                        textoValido = false;
                    }
                    else
                    {
                        tb_observaciones.BackColor = SystemColors.Window;
                        textoValido = true;
                    }
            }
            else
            {
                tb_observaciones.Text = string.Empty;
                textoValido = true;
            }
        }
    }
}
