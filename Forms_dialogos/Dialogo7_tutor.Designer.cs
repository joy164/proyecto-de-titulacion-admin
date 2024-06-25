namespace CENDI_admin.Forms_dialogos
{
    partial class Dialogo7_tutor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox3 = new GroupBox();
            btn_cargarImagen = new Button();
            btn_tomarFoto = new Button();
            pictureBox1 = new PictureBox();
            groupBox1 = new GroupBox();
            tb_telFijo = new TextBox();
            label12 = new Label();
            cb_parentesco = new ComboBox();
            label11 = new Label();
            label10 = new Label();
            tb_am = new TextBox();
            label6 = new Label();
            tb_nom = new TextBox();
            label5 = new Label();
            tb_ap = new TextBox();
            label4 = new Label();
            tb_noTel = new TextBox();
            label3 = new Label();
            groupBox4 = new GroupBox();
            cb_estado = new ComboBox();
            label15 = new Label();
            label17 = new Label();
            cb_municipio = new ComboBox();
            label14 = new Label();
            cb_colonia = new ComboBox();
            label13 = new Label();
            tb_noInt = new TextBox();
            label9 = new Label();
            tb_noExt = new TextBox();
            label8 = new Label();
            tb_calle = new TextBox();
            label7 = new Label();
            btn_guardar = new Button();
            cb_direcciones = new ComboBox();
            label18 = new Label();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btn_cargarImagen);
            groupBox3.Controls.Add(btn_tomarFoto);
            groupBox3.Controls.Add(pictureBox1);
            groupBox3.Location = new Point(12, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(142, 254);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "Fotografia";
            // 
            // btn_cargarImagen
            // 
            btn_cargarImagen.BackColor = Color.DarkGreen;
            btn_cargarImagen.FlatAppearance.BorderSize = 0;
            btn_cargarImagen.FlatStyle = FlatStyle.Flat;
            btn_cargarImagen.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_cargarImagen.ForeColor = Color.White;
            btn_cargarImagen.Image = Properties.Resources.cargar_archivo;
            btn_cargarImagen.Location = new Point(85, 185);
            btn_cargarImagen.Name = "btn_cargarImagen";
            btn_cargarImagen.Size = new Size(40, 40);
            btn_cargarImagen.TabIndex = 5;
            btn_cargarImagen.TextImageRelation = TextImageRelation.TextBeforeImage;
            btn_cargarImagen.UseVisualStyleBackColor = false;
            btn_cargarImagen.Click += btn_cargarImagen_Click;
            // 
            // btn_tomarFoto
            // 
            btn_tomarFoto.BackColor = Color.DarkOrange;
            btn_tomarFoto.FlatAppearance.BorderSize = 0;
            btn_tomarFoto.FlatStyle = FlatStyle.Flat;
            btn_tomarFoto.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_tomarFoto.ForeColor = Color.White;
            btn_tomarFoto.Image = Properties.Resources.camara;
            btn_tomarFoto.Location = new Point(11, 185);
            btn_tomarFoto.Name = "btn_tomarFoto";
            btn_tomarFoto.Size = new Size(40, 40);
            btn_tomarFoto.TabIndex = 4;
            btn_tomarFoto.TextImageRelation = TextImageRelation.TextBeforeImage;
            btn_tomarFoto.UseVisualStyleBackColor = false;
            btn_tomarFoto.Click += btn_tomarFoto_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Gainsboro;
            pictureBox1.Location = new Point(11, 40);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(114, 139);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tb_telFijo);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(cb_parentesco);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(tb_am);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(tb_nom);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(tb_ap);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(tb_noTel);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(170, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(425, 254);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos personales";
            // 
            // tb_telFijo
            // 
            tb_telFijo.Location = new Point(221, 95);
            tb_telFijo.MaxLength = 12;
            tb_telFijo.Name = "tb_telFijo";
            tb_telFijo.Size = new Size(182, 23);
            tb_telFijo.TabIndex = 18;
            tb_telFijo.KeyUp += tb_telFijo_KeyUp;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.ForeColor = Color.DarkRed;
            label12.Location = new Point(21, 225);
            label12.Name = "label12";
            label12.Size = new Size(123, 15);
            label12.TabIndex = 17;
            label12.Text = "* campos obligatorios";
            // 
            // cb_parentesco
            // 
            cb_parentesco.FormattingEnabled = true;
            cb_parentesco.Location = new Point(221, 44);
            cb_parentesco.Name = "cb_parentesco";
            cb_parentesco.Size = new Size(182, 23);
            cb_parentesco.TabIndex = 7;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(221, 77);
            label11.Name = "label11";
            label11.Size = new Size(72, 15);
            label11.TabIndex = 16;
            label11.Text = "Telefono fijo";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(221, 26);
            label10.Name = "label10";
            label10.Size = new Size(73, 15);
            label10.TabIndex = 14;
            label10.Text = "Parentesco *";
            // 
            // tb_am
            // 
            tb_am.Location = new Point(21, 196);
            tb_am.Name = "tb_am";
            tb_am.Size = new Size(173, 23);
            tb_am.TabIndex = 3;
            tb_am.TextChanged += tb_am_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(21, 178);
            label6.Name = "label6";
            label6.Size = new Size(107, 15);
            label6.TabIndex = 6;
            label6.Text = "Apellido materno *";
            // 
            // tb_nom
            // 
            tb_nom.Location = new Point(21, 95);
            tb_nom.Name = "tb_nom";
            tb_nom.Size = new Size(173, 23);
            tb_nom.TabIndex = 1;
            tb_nom.TextChanged += tb_nom_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(21, 77);
            label5.Name = "label5";
            label5.Size = new Size(59, 15);
            label5.TabIndex = 4;
            label5.Text = "Nombre *";
            // 
            // tb_ap
            // 
            tb_ap.Location = new Point(21, 143);
            tb_ap.Name = "tb_ap";
            tb_ap.Size = new Size(173, 23);
            tb_ap.TabIndex = 2;
            tb_ap.TextChanged += tb_ap_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 125);
            label4.Name = "label4";
            label4.Size = new Size(103, 15);
            label4.TabIndex = 2;
            label4.Text = "Apellido paterno *";
            // 
            // tb_noTel
            // 
            tb_noTel.Location = new Point(21, 44);
            tb_noTel.MaxLength = 12;
            tb_noTel.Name = "tb_noTel";
            tb_noTel.Size = new Size(173, 23);
            tb_noTel.TabIndex = 0;
            tb_noTel.KeyUp += tb_noTel_KeyUp;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 26);
            label3.Name = "label3";
            label3.Size = new Size(122, 15);
            label3.TabIndex = 0;
            label3.Text = "Numero de telefono *";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(cb_estado);
            groupBox4.Controls.Add(label15);
            groupBox4.Controls.Add(label17);
            groupBox4.Controls.Add(cb_municipio);
            groupBox4.Controls.Add(label14);
            groupBox4.Controls.Add(cb_colonia);
            groupBox4.Controls.Add(label13);
            groupBox4.Controls.Add(tb_noInt);
            groupBox4.Controls.Add(label9);
            groupBox4.Controls.Add(tb_noExt);
            groupBox4.Controls.Add(label8);
            groupBox4.Controls.Add(tb_calle);
            groupBox4.Controls.Add(label7);
            groupBox4.Location = new Point(12, 336);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(449, 200);
            groupBox4.TabIndex = 5;
            groupBox4.TabStop = false;
            groupBox4.Text = "Dirección";
            // 
            // cb_estado
            // 
            cb_estado.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            cb_estado.FormattingEnabled = true;
            cb_estado.Location = new Point(15, 90);
            cb_estado.Name = "cb_estado";
            cb_estado.Size = new Size(127, 23);
            cb_estado.TabIndex = 51;
            cb_estado.SelectedValueChanged += cb_estado_SelectedValueChanged;
            // 
            // label15
            // 
            label15.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label15.AutoSize = true;
            label15.Location = new Point(15, 72);
            label15.Name = "label15";
            label15.Size = new Size(53, 15);
            label15.TabIndex = 50;
            label15.Text = "Estado  *";
            // 
            // label17
            // 
            label17.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label17.AutoSize = true;
            label17.BackColor = Color.Transparent;
            label17.ForeColor = Color.DarkRed;
            label17.Location = new Point(13, 176);
            label17.Name = "label17";
            label17.Size = new Size(123, 15);
            label17.TabIndex = 49;
            label17.Text = "* campos obligatorios";
            // 
            // cb_municipio
            // 
            cb_municipio.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            cb_municipio.Enabled = false;
            cb_municipio.FormattingEnabled = true;
            cb_municipio.Location = new Point(163, 90);
            cb_municipio.Name = "cb_municipio";
            cb_municipio.Size = new Size(190, 23);
            cb_municipio.TabIndex = 44;
            cb_municipio.SelectedValueChanged += cb_municipio_SelectedValueChanged;
            // 
            // label14
            // 
            label14.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label14.AutoSize = true;
            label14.Location = new Point(163, 72);
            label14.Name = "label14";
            label14.Size = new Size(72, 15);
            label14.TabIndex = 43;
            label14.Text = "Municipio  *";
            // 
            // cb_colonia
            // 
            cb_colonia.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            cb_colonia.Enabled = false;
            cb_colonia.FormattingEnabled = true;
            cb_colonia.Location = new Point(15, 141);
            cb_colonia.Name = "cb_colonia";
            cb_colonia.Size = new Size(250, 23);
            cb_colonia.TabIndex = 42;
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label13.AutoSize = true;
            label13.Location = new Point(15, 123);
            label13.Name = "label13";
            label13.Size = new Size(59, 15);
            label13.TabIndex = 41;
            label13.Text = "Colonia  *";
            // 
            // tb_noInt
            // 
            tb_noInt.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            tb_noInt.Location = new Point(359, 38);
            tb_noInt.Name = "tb_noInt";
            tb_noInt.Size = new Size(80, 23);
            tb_noInt.TabIndex = 39;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.Location = new Point(359, 20);
            label9.Name = "label9";
            label9.Size = new Size(43, 15);
            label9.TabIndex = 40;
            label9.Text = "No. int";
            // 
            // tb_noExt
            // 
            tb_noExt.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            tb_noExt.Location = new Point(264, 38);
            tb_noExt.Name = "tb_noExt";
            tb_noExt.Size = new Size(80, 23);
            tb_noExt.TabIndex = 37;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Location = new Point(264, 20);
            label8.Name = "label8";
            label8.Size = new Size(53, 15);
            label8.TabIndex = 38;
            label8.Text = "No. ext *";
            // 
            // tb_calle
            // 
            tb_calle.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            tb_calle.Location = new Point(15, 38);
            tb_calle.Name = "tb_calle";
            tb_calle.Size = new Size(232, 23);
            tb_calle.TabIndex = 35;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Location = new Point(15, 20);
            label7.Name = "label7";
            label7.Size = new Size(41, 15);
            label7.TabIndex = 36;
            label7.Text = "Calle *";
            // 
            // btn_guardar
            // 
            btn_guardar.Anchor = AnchorStyles.None;
            btn_guardar.BackColor = Color.DarkGreen;
            btn_guardar.FlatAppearance.BorderSize = 0;
            btn_guardar.FlatStyle = FlatStyle.Flat;
            btn_guardar.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_guardar.ForeColor = Color.White;
            btn_guardar.Image = Properties.Resources.guardar;
            btn_guardar.Location = new Point(487, 488);
            btn_guardar.Name = "btn_guardar";
            btn_guardar.Size = new Size(108, 48);
            btn_guardar.TabIndex = 35;
            btn_guardar.Text = "Guardar";
            btn_guardar.TextImageRelation = TextImageRelation.TextBeforeImage;
            btn_guardar.UseVisualStyleBackColor = false;
            btn_guardar.Click += btn_guardar_Click;
            // 
            // cb_direcciones
            // 
            cb_direcciones.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            cb_direcciones.FormattingEnabled = true;
            cb_direcciones.Location = new Point(23, 301);
            cb_direcciones.Name = "cb_direcciones";
            cb_direcciones.Size = new Size(424, 23);
            cb_direcciones.TabIndex = 37;
            cb_direcciones.SelectedValueChanged += cb_direcciones_SelectedValueChanged;
            // 
            // label18
            // 
            label18.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label18.AutoSize = true;
            label18.Location = new Point(20, 283);
            label18.Name = "label18";
            label18.Size = new Size(197, 15);
            label18.TabIndex = 36;
            label18.Text = "Seleccionar una direccion registrada";
            // 
            // Dialogo7_tutor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(611, 550);
            Controls.Add(cb_direcciones);
            Controls.Add(label18);
            Controls.Add(btn_guardar);
            Controls.Add(groupBox4);
            Controls.Add(groupBox1);
            Controls.Add(groupBox3);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Dialogo7_tutor";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Tutor";
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox3;
        private Button btn_cargarImagen;
        private Button btn_tomarFoto;
        private PictureBox pictureBox1;
        private GroupBox groupBox1;
        private TextBox tb_telFijo;
        private Label label12;
        private ComboBox cb_parentesco;
        private Label label11;
        private Label label10;
        private TextBox tb_am;
        private Label label6;
        private TextBox tb_nom;
        private Label label5;
        private TextBox tb_ap;
        private Label label4;
        private TextBox tb_noTel;
        private Label label3;
        private GroupBox groupBox4;
        private Label label17;
        private ComboBox cb_municipio;
        private Label label14;
        private ComboBox cb_colonia;
        private Label label13;
        private TextBox tb_noInt;
        private Label label9;
        private TextBox tb_noExt;
        private Label label8;
        private TextBox tb_calle;
        private Label label7;
        private Button btn_guardar;
        private ComboBox cb_estado;
        private Label label15;
        private ComboBox cb_direcciones;
        private Label label18;
    }
}