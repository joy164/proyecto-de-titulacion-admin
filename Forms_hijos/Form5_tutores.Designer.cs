namespace CENDI_admin.Forms_hijos
{
    partial class Form5_tutores
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
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            gb_datos = new GroupBox();
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
            gb_foto = new GroupBox();
            btn_cargarFoto = new Button();
            btn_tomarFoto = new Button();
            pb_imgTutor = new PictureBox();
            gb_accionesTutor = new GroupBox();
            btn_verCredencial = new Button();
            btn_guardar = new Button();
            btn_eliminar = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label2 = new Label();
            tb_busqueda = new TextBox();
            btn_buscar = new Button();
            tableLayoutPanel3 = new TableLayoutPanel();
            gb_accionesDir = new GroupBox();
            btn_parentescos = new Button();
            btn_nuevaDir = new Button();
            gb_direccion = new GroupBox();
            cb_estado = new ComboBox();
            label15 = new Label();
            btn_cambiarDir = new Button();
            btn_actualizarDir = new Button();
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
            cb_direcciones = new ComboBox();
            label18 = new Label();
            btn_nuevoTutor = new Button();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            gb_datos.SuspendLayout();
            gb_foto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pb_imgTutor).BeginInit();
            gb_accionesTutor.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            gb_accionesDir.SuspendLayout();
            gb_direccion.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 2);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 0, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 3);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 6F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 8F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 43F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 43F));
            tableLayoutPanel1.Size = new Size(782, 605);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(15, 5);
            label1.Margin = new Padding(15, 0, 3, 0);
            label1.Name = "label1";
            label1.Size = new Size(57, 25);
            label1.TabIndex = 0;
            label1.Text = "Tutor";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.Controls.Add(gb_datos, 0, 0);
            tableLayoutPanel2.Controls.Add(gb_foto, 0, 0);
            tableLayoutPanel2.Controls.Add(gb_accionesTutor, 2, 0);
            tableLayoutPanel2.Location = new Point(3, 87);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(776, 254);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // gb_datos
            // 
            gb_datos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gb_datos.Controls.Add(tb_telFijo);
            gb_datos.Controls.Add(label12);
            gb_datos.Controls.Add(cb_parentesco);
            gb_datos.Controls.Add(label11);
            gb_datos.Controls.Add(label10);
            gb_datos.Controls.Add(tb_am);
            gb_datos.Controls.Add(label6);
            gb_datos.Controls.Add(tb_nom);
            gb_datos.Controls.Add(label5);
            gb_datos.Controls.Add(tb_ap);
            gb_datos.Controls.Add(label4);
            gb_datos.Controls.Add(tb_noTel);
            gb_datos.Controls.Add(label3);
            gb_datos.Enabled = false;
            gb_datos.Location = new Point(158, 3);
            gb_datos.Name = "gb_datos";
            gb_datos.Size = new Size(459, 248);
            gb_datos.TabIndex = 3;
            gb_datos.TabStop = false;
            gb_datos.Text = "Datos personales";
            // 
            // tb_telFijo
            // 
            tb_telFijo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tb_telFijo.Location = new Point(285, 95);
            tb_telFijo.Name = "tb_telFijo";
            tb_telFijo.Size = new Size(146, 23);
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
            cb_parentesco.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cb_parentesco.FormattingEnabled = true;
            cb_parentesco.Location = new Point(284, 44);
            cb_parentesco.Name = "cb_parentesco";
            cb_parentesco.Size = new Size(147, 23);
            cb_parentesco.TabIndex = 7;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label11.AutoSize = true;
            label11.Location = new Point(284, 77);
            label11.Name = "label11";
            label11.Size = new Size(72, 15);
            label11.TabIndex = 16;
            label11.Text = "Telefono fijo";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label10.AutoSize = true;
            label10.Location = new Point(285, 26);
            label10.Name = "label10";
            label10.Size = new Size(73, 15);
            label10.TabIndex = 14;
            label10.Text = "Parentesco *";
            // 
            // tb_am
            // 
            tb_am.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tb_am.Location = new Point(21, 196);
            tb_am.Name = "tb_am";
            tb_am.Size = new Size(224, 23);
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
            tb_nom.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tb_nom.Location = new Point(21, 95);
            tb_nom.Name = "tb_nom";
            tb_nom.Size = new Size(224, 23);
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
            tb_ap.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tb_ap.Location = new Point(21, 143);
            tb_ap.Name = "tb_ap";
            tb_ap.Size = new Size(224, 23);
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
            tb_noTel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tb_noTel.Enabled = false;
            tb_noTel.Location = new Point(21, 44);
            tb_noTel.Name = "tb_noTel";
            tb_noTel.Size = new Size(224, 23);
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
            // gb_foto
            // 
            gb_foto.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gb_foto.Controls.Add(btn_cargarFoto);
            gb_foto.Controls.Add(btn_tomarFoto);
            gb_foto.Controls.Add(pb_imgTutor);
            gb_foto.Enabled = false;
            gb_foto.Location = new Point(3, 3);
            gb_foto.Name = "gb_foto";
            gb_foto.Size = new Size(149, 248);
            gb_foto.TabIndex = 0;
            gb_foto.TabStop = false;
            gb_foto.Text = "Fotografia";
            // 
            // btn_cargarFoto
            // 
            btn_cargarFoto.Anchor = AnchorStyles.Top;
            btn_cargarFoto.BackColor = Color.DarkGreen;
            btn_cargarFoto.FlatAppearance.BorderSize = 0;
            btn_cargarFoto.FlatStyle = FlatStyle.Flat;
            btn_cargarFoto.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_cargarFoto.ForeColor = Color.White;
            btn_cargarFoto.Image = Properties.Resources.cargar_archivo;
            btn_cargarFoto.Location = new Point(89, 189);
            btn_cargarFoto.Name = "btn_cargarFoto";
            btn_cargarFoto.Size = new Size(40, 40);
            btn_cargarFoto.TabIndex = 5;
            btn_cargarFoto.TextImageRelation = TextImageRelation.TextBeforeImage;
            btn_cargarFoto.UseVisualStyleBackColor = false;
            btn_cargarFoto.Click += btn_cargarFoto_Click;
            // 
            // btn_tomarFoto
            // 
            btn_tomarFoto.Anchor = AnchorStyles.Top;
            btn_tomarFoto.BackColor = Color.DarkOrange;
            btn_tomarFoto.FlatAppearance.BorderSize = 0;
            btn_tomarFoto.FlatStyle = FlatStyle.Flat;
            btn_tomarFoto.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_tomarFoto.ForeColor = Color.White;
            btn_tomarFoto.Image = Properties.Resources.camara;
            btn_tomarFoto.Location = new Point(15, 189);
            btn_tomarFoto.Name = "btn_tomarFoto";
            btn_tomarFoto.Size = new Size(40, 40);
            btn_tomarFoto.TabIndex = 4;
            btn_tomarFoto.TextImageRelation = TextImageRelation.TextBeforeImage;
            btn_tomarFoto.UseVisualStyleBackColor = false;
            btn_tomarFoto.Click += btn_tomarFoto_Click;
            // 
            // pb_imgTutor
            // 
            pb_imgTutor.Anchor = AnchorStyles.Top;
            pb_imgTutor.BackColor = Color.Gainsboro;
            pb_imgTutor.Location = new Point(15, 44);
            pb_imgTutor.Name = "pb_imgTutor";
            pb_imgTutor.Size = new Size(114, 139);
            pb_imgTutor.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_imgTutor.TabIndex = 3;
            pb_imgTutor.TabStop = false;
            // 
            // gb_accionesTutor
            // 
            gb_accionesTutor.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gb_accionesTutor.Controls.Add(btn_verCredencial);
            gb_accionesTutor.Controls.Add(btn_guardar);
            gb_accionesTutor.Controls.Add(btn_eliminar);
            gb_accionesTutor.Enabled = false;
            gb_accionesTutor.Location = new Point(623, 3);
            gb_accionesTutor.Name = "gb_accionesTutor";
            gb_accionesTutor.Size = new Size(150, 248);
            gb_accionesTutor.TabIndex = 2;
            gb_accionesTutor.TabStop = false;
            gb_accionesTutor.Text = "Acciones";
            // 
            // btn_verCredencial
            // 
            btn_verCredencial.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_verCredencial.BackColor = Color.DarkSlateGray;
            btn_verCredencial.FlatAppearance.BorderSize = 0;
            btn_verCredencial.FlatStyle = FlatStyle.Flat;
            btn_verCredencial.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_verCredencial.ForeColor = Color.White;
            btn_verCredencial.Image = Properties.Resources.credencial;
            btn_verCredencial.Location = new Point(22, 134);
            btn_verCredencial.Name = "btn_verCredencial";
            btn_verCredencial.Size = new Size(115, 48);
            btn_verCredencial.TabIndex = 5;
            btn_verCredencial.Text = " Ver credenciales";
            btn_verCredencial.TextImageRelation = TextImageRelation.TextBeforeImage;
            btn_verCredencial.UseVisualStyleBackColor = false;
            btn_verCredencial.Click += btn_verCredencial_Click;
            // 
            // btn_guardar
            // 
            btn_guardar.BackColor = Color.DarkGreen;
            btn_guardar.FlatAppearance.BorderSize = 0;
            btn_guardar.FlatStyle = FlatStyle.Flat;
            btn_guardar.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_guardar.ForeColor = Color.White;
            btn_guardar.Image = Properties.Resources.guardar;
            btn_guardar.Location = new Point(22, 26);
            btn_guardar.Name = "btn_guardar";
            btn_guardar.Size = new Size(115, 48);
            btn_guardar.TabIndex = 1;
            btn_guardar.Text = "Guardar cambios";
            btn_guardar.TextImageRelation = TextImageRelation.TextBeforeImage;
            btn_guardar.UseVisualStyleBackColor = false;
            btn_guardar.Click += btn_guardar_Click;
            // 
            // btn_eliminar
            // 
            btn_eliminar.BackColor = Color.DarkRed;
            btn_eliminar.FlatAppearance.BorderSize = 0;
            btn_eliminar.FlatStyle = FlatStyle.Flat;
            btn_eliminar.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_eliminar.ForeColor = Color.White;
            btn_eliminar.Image = Properties.Resources.borrar_usuario;
            btn_eliminar.Location = new Point(22, 80);
            btn_eliminar.Name = "btn_eliminar";
            btn_eliminar.Size = new Size(115, 48);
            btn_eliminar.TabIndex = 2;
            btn_eliminar.Text = "Eliminar tutor";
            btn_eliminar.TextImageRelation = TextImageRelation.TextBeforeImage;
            btn_eliminar.UseVisualStyleBackColor = false;
            btn_eliminar.Click += btn_eliminar_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel1.Controls.Add(label2);
            flowLayoutPanel1.Controls.Add(tb_busqueda);
            flowLayoutPanel1.Controls.Add(btn_buscar);
            flowLayoutPanel1.Location = new Point(3, 39);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(776, 42);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Location = new Point(3, 14);
            label2.Name = "label2";
            label2.Size = new Size(96, 15);
            label2.TabIndex = 2;
            label2.Text = "Ingrese Telefono:";
            // 
            // tb_busqueda
            // 
            tb_busqueda.Anchor = AnchorStyles.Left;
            tb_busqueda.Location = new Point(105, 10);
            tb_busqueda.Name = "tb_busqueda";
            tb_busqueda.Size = new Size(139, 23);
            tb_busqueda.TabIndex = 3;
            tb_busqueda.KeyDown += tb_busqueda_KeyDown;
            tb_busqueda.KeyUp += tb_busqueda_KeyUp;
            // 
            // btn_buscar
            // 
            btn_buscar.Anchor = AnchorStyles.None;
            btn_buscar.BackColor = Color.DarkSlateGray;
            btn_buscar.FlatAppearance.BorderSize = 0;
            btn_buscar.FlatStyle = FlatStyle.Flat;
            btn_buscar.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_buscar.ForeColor = Color.White;
            btn_buscar.Image = Properties.Resources.buscar;
            btn_buscar.Location = new Point(250, 3);
            btn_buscar.Name = "btn_buscar";
            btn_buscar.Size = new Size(97, 37);
            btn_buscar.TabIndex = 4;
            btn_buscar.Text = "Buscar";
            btn_buscar.TextImageRelation = TextImageRelation.TextBeforeImage;
            btn_buscar.UseVisualStyleBackColor = false;
            btn_buscar.Click += btn_buscar_Click;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel3.Controls.Add(gb_accionesDir, 0, 0);
            tableLayoutPanel3.Controls.Add(gb_direccion, 0, 0);
            tableLayoutPanel3.Location = new Point(3, 347);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(776, 255);
            tableLayoutPanel3.TabIndex = 3;
            // 
            // gb_accionesDir
            // 
            gb_accionesDir.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gb_accionesDir.Controls.Add(btn_nuevoTutor);
            gb_accionesDir.Controls.Add(btn_parentescos);
            gb_accionesDir.Controls.Add(btn_nuevaDir);
            gb_accionesDir.Location = new Point(623, 3);
            gb_accionesDir.Name = "gb_accionesDir";
            gb_accionesDir.Size = new Size(150, 249);
            gb_accionesDir.TabIndex = 5;
            gb_accionesDir.TabStop = false;
            gb_accionesDir.Text = "Acciones";
            // 
            // btn_parentescos
            // 
            btn_parentescos.BackColor = Color.DarkGreen;
            btn_parentescos.FlatAppearance.BorderSize = 0;
            btn_parentescos.FlatStyle = FlatStyle.Flat;
            btn_parentescos.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_parentescos.ForeColor = Color.White;
            btn_parentescos.Image = Properties.Resources.tutor;
            btn_parentescos.Location = new Point(22, 76);
            btn_parentescos.Name = "btn_parentescos";
            btn_parentescos.Size = new Size(115, 48);
            btn_parentescos.TabIndex = 52;
            btn_parentescos.Text = "Parentesco";
            btn_parentescos.TextImageRelation = TextImageRelation.TextBeforeImage;
            btn_parentescos.UseVisualStyleBackColor = false;
            btn_parentescos.Click += btn_parentescos_Click;
            // 
            // btn_nuevaDir
            // 
            btn_nuevaDir.BackColor = Color.DarkGreen;
            btn_nuevaDir.FlatAppearance.BorderSize = 0;
            btn_nuevaDir.FlatStyle = FlatStyle.Flat;
            btn_nuevaDir.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_nuevaDir.ForeColor = Color.White;
            btn_nuevaDir.Image = Properties.Resources.direccion;
            btn_nuevaDir.Location = new Point(22, 22);
            btn_nuevaDir.Name = "btn_nuevaDir";
            btn_nuevaDir.Size = new Size(115, 48);
            btn_nuevaDir.TabIndex = 51;
            btn_nuevaDir.Text = "Nueva direccion";
            btn_nuevaDir.TextImageRelation = TextImageRelation.TextBeforeImage;
            btn_nuevaDir.UseVisualStyleBackColor = false;
            btn_nuevaDir.Click += btn_nuevaDir_Click;
            // 
            // gb_direccion
            // 
            gb_direccion.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            gb_direccion.Controls.Add(cb_estado);
            gb_direccion.Controls.Add(label15);
            gb_direccion.Controls.Add(btn_cambiarDir);
            gb_direccion.Controls.Add(btn_actualizarDir);
            gb_direccion.Controls.Add(label17);
            gb_direccion.Controls.Add(cb_municipio);
            gb_direccion.Controls.Add(label14);
            gb_direccion.Controls.Add(cb_colonia);
            gb_direccion.Controls.Add(label13);
            gb_direccion.Controls.Add(tb_noInt);
            gb_direccion.Controls.Add(label9);
            gb_direccion.Controls.Add(tb_noExt);
            gb_direccion.Controls.Add(label8);
            gb_direccion.Controls.Add(tb_calle);
            gb_direccion.Controls.Add(label7);
            gb_direccion.Controls.Add(cb_direcciones);
            gb_direccion.Controls.Add(label18);
            gb_direccion.Enabled = false;
            gb_direccion.Location = new Point(3, 3);
            gb_direccion.Name = "gb_direccion";
            gb_direccion.Size = new Size(614, 249);
            gb_direccion.TabIndex = 4;
            gb_direccion.TabStop = false;
            gb_direccion.Text = "Dirección";
            // 
            // cb_estado
            // 
            cb_estado.FormattingEnabled = true;
            cb_estado.Location = new Point(15, 142);
            cb_estado.Name = "cb_estado";
            cb_estado.Size = new Size(127, 23);
            cb_estado.TabIndex = 53;
            cb_estado.SelectedValueChanged += cb_estado_SelectedValueChanged;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(15, 124);
            label15.Name = "label15";
            label15.Size = new Size(53, 15);
            label15.TabIndex = 52;
            label15.Text = "Estado  *";
            // 
            // btn_cambiarDir
            // 
            btn_cambiarDir.BackColor = Color.DarkOrange;
            btn_cambiarDir.FlatAppearance.BorderSize = 0;
            btn_cambiarDir.FlatStyle = FlatStyle.Flat;
            btn_cambiarDir.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_cambiarDir.ForeColor = Color.White;
            btn_cambiarDir.Image = Properties.Resources.reemplazar;
            btn_cambiarDir.Location = new Point(554, 33);
            btn_cambiarDir.Name = "btn_cambiarDir";
            btn_cambiarDir.Size = new Size(32, 32);
            btn_cambiarDir.TabIndex = 51;
            btn_cambiarDir.TextImageRelation = TextImageRelation.TextBeforeImage;
            btn_cambiarDir.UseVisualStyleBackColor = false;
            btn_cambiarDir.Click += btn_cambiarDir_Click;
            // 
            // btn_actualizarDir
            // 
            btn_actualizarDir.BackColor = Color.DarkOrange;
            btn_actualizarDir.FlatAppearance.BorderSize = 0;
            btn_actualizarDir.FlatStyle = FlatStyle.Flat;
            btn_actualizarDir.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_actualizarDir.ForeColor = Color.White;
            btn_actualizarDir.Image = Properties.Resources.direccion;
            btn_actualizarDir.Location = new Point(471, 181);
            btn_actualizarDir.Name = "btn_actualizarDir";
            btn_actualizarDir.Size = new Size(115, 48);
            btn_actualizarDir.TabIndex = 50;
            btn_actualizarDir.Text = "Actualizar direccion";
            btn_actualizarDir.TextImageRelation = TextImageRelation.TextBeforeImage;
            btn_actualizarDir.UseVisualStyleBackColor = false;
            btn_actualizarDir.Click += btn_actualizarDir_Click;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.BackColor = Color.Transparent;
            label17.ForeColor = Color.DarkRed;
            label17.Location = new Point(13, 228);
            label17.Name = "label17";
            label17.Size = new Size(123, 15);
            label17.TabIndex = 49;
            label17.Text = "* campos obligatorios";
            // 
            // cb_municipio
            // 
            cb_municipio.FormattingEnabled = true;
            cb_municipio.Location = new Point(160, 142);
            cb_municipio.Name = "cb_municipio";
            cb_municipio.Size = new Size(167, 23);
            cb_municipio.TabIndex = 44;
            cb_municipio.SelectedValueChanged += cb_municipio_SelectedValueChanged;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(160, 124);
            label14.Name = "label14";
            label14.Size = new Size(72, 15);
            label14.TabIndex = 43;
            label14.Text = "Municipio  *";
            // 
            // cb_colonia
            // 
            cb_colonia.FormattingEnabled = true;
            cb_colonia.Location = new Point(15, 196);
            cb_colonia.Name = "cb_colonia";
            cb_colonia.Size = new Size(312, 23);
            cb_colonia.TabIndex = 42;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(15, 178);
            label13.Name = "label13";
            label13.Size = new Size(59, 15);
            label13.TabIndex = 41;
            label13.Text = "Colonia  *";
            // 
            // tb_noInt
            // 
            tb_noInt.Location = new Point(458, 90);
            tb_noInt.Name = "tb_noInt";
            tb_noInt.Size = new Size(75, 23);
            tb_noInt.TabIndex = 39;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(458, 72);
            label9.Name = "label9";
            label9.Size = new Size(51, 15);
            label9.TabIndex = 40;
            label9.Text = "No. int *";
            // 
            // tb_noExt
            // 
            tb_noExt.Location = new Point(354, 90);
            tb_noExt.Name = "tb_noExt";
            tb_noExt.Size = new Size(75, 23);
            tb_noExt.TabIndex = 37;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(354, 72);
            label8.Name = "label8";
            label8.Size = new Size(53, 15);
            label8.TabIndex = 38;
            label8.Text = "No. ext *";
            // 
            // tb_calle
            // 
            tb_calle.Location = new Point(15, 90);
            tb_calle.Name = "tb_calle";
            tb_calle.Size = new Size(312, 23);
            tb_calle.TabIndex = 35;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(15, 72);
            label7.Name = "label7";
            label7.Size = new Size(41, 15);
            label7.TabIndex = 36;
            label7.Text = "Calle *";
            // 
            // cb_direcciones
            // 
            cb_direcciones.FormattingEnabled = true;
            cb_direcciones.Location = new Point(15, 40);
            cb_direcciones.Name = "cb_direcciones";
            cb_direcciones.Size = new Size(518, 23);
            cb_direcciones.TabIndex = 4;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(12, 22);
            label18.Name = "label18";
            label18.Size = new Size(198, 15);
            label18.TabIndex = 3;
            label18.Text = "Camabiar a otra direccion registrada";
            // 
            // btn_nuevoTutor
            // 
            btn_nuevoTutor.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_nuevoTutor.BackColor = Color.DarkGreen;
            btn_nuevoTutor.FlatAppearance.BorderSize = 0;
            btn_nuevoTutor.FlatStyle = FlatStyle.Flat;
            btn_nuevoTutor.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_nuevoTutor.ForeColor = Color.White;
            btn_nuevoTutor.Image = Properties.Resources.agregar_usuario;
            btn_nuevoTutor.Location = new Point(22, 130);
            btn_nuevoTutor.Name = "btn_nuevoTutor";
            btn_nuevoTutor.Size = new Size(115, 48);
            btn_nuevoTutor.TabIndex = 53;
            btn_nuevoTutor.Text = "Registrar tutor";
            btn_nuevoTutor.TextImageRelation = TextImageRelation.TextBeforeImage;
            btn_nuevoTutor.UseVisualStyleBackColor = false;
            btn_nuevoTutor.Click += btn_nuevoTutor_Click;
            // 
            // Form5_tutores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(782, 605);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form5_tutores";
            Text = "Form4_tutores";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            gb_datos.ResumeLayout(false);
            gb_datos.PerformLayout();
            gb_foto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pb_imgTutor).EndInit();
            gb_accionesTutor.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            gb_accionesDir.ResumeLayout(false);
            gb_direccion.ResumeLayout(false);
            gb_direccion.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel2;
        private GroupBox gb_foto;
        private Button btn_cargarFoto;
        private Button btn_tomarFoto;
        private PictureBox pb_imgTutor;
        private GroupBox gb_accionesTutor;
        private Button btn_guardar;
        private Button btn_eliminar;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label2;
        private TextBox tb_busqueda;
        private Button btn_buscar;
        private GroupBox gb_datos;
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
        private TextBox tb_telFijo;
        private TableLayoutPanel tableLayoutPanel3;
        private GroupBox gb_accionesDir;
        private Button btn_nuevaDir;
        private GroupBox gb_direccion;
        private ComboBox cb_estado;
        private Label label15;
        private Button btn_cambiarDir;
        private Button btn_actualizarDir;
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
        private ComboBox cb_direcciones;
        private Label label18;
        private Button btn_verCredencial;
        private Button btn_parentescos;
        private Button btn_nuevoTutor;
    }
}