namespace CENDI_admin.Forms_hijos
{
    partial class Form4_infantes
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
            cb_lugarNac = new ComboBox();
            label16 = new Label();
            label12 = new Label();
            cb_grupo = new ComboBox();
            cb_sexo = new ComboBox();
            label11 = new Label();
            label10 = new Label();
            NUD_mes = new NumericUpDown();
            label9 = new Label();
            NUD_año = new NumericUpDown();
            label8 = new Label();
            dtp_fechaNac = new DateTimePicker();
            label7 = new Label();
            tb_am = new TextBox();
            label6 = new Label();
            tb_nombre = new TextBox();
            label5 = new Label();
            tb_ap = new TextBox();
            label4 = new Label();
            tb_curp = new TextBox();
            label3 = new Label();
            gb_foto = new GroupBox();
            btn_cargarFoto = new Button();
            btn_tomarFoto = new Button();
            pb_imgInfante = new PictureBox();
            gb_acciones = new GroupBox();
            btn_guardar = new Button();
            btn_eliminar = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label2 = new Label();
            tb_busqueda = new TextBox();
            btn_buscar = new Button();
            gb_asistencia = new GroupBox();
            cb_mes = new ComboBox();
            cb_año = new ComboBox();
            label17 = new Label();
            btn_exportarAsistencia = new Button();
            btn_buscarAsistencia = new Button();
            label14 = new Label();
            label13 = new Label();
            dataGridView1 = new DataGridView();
            fecha = new DataGridViewTextBoxColumn();
            horaEntrada = new DataGridViewTextBoxColumn();
            horaSalida = new DataGridViewTextBoxColumn();
            tutorEntrega = new DataGridViewTextBoxColumn();
            parentescoEntrega = new DataGridViewTextBoxColumn();
            tutorRecoge = new DataGridViewTextBoxColumn();
            parentescoRecoge = new DataGridViewTextBoxColumn();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            gb_datos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NUD_mes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NUD_año).BeginInit();
            gb_foto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pb_imgInfante).BeginInit();
            gb_acciones.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            gb_asistencia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 2);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 0, 1);
            tableLayoutPanel1.Controls.Add(gb_asistencia, 0, 3);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 6F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 8F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 43F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 43F));
            tableLayoutPanel1.Size = new Size(782, 605);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(15, 5);
            label1.Margin = new Padding(15, 0, 3, 0);
            label1.Name = "label1";
            label1.Size = new Size(82, 25);
            label1.TabIndex = 0;
            label1.Text = "Infantes";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 21.0051556F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 59.4072151F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19.4587631F));
            tableLayoutPanel2.Controls.Add(gb_datos, 1, 0);
            tableLayoutPanel2.Controls.Add(gb_foto, 0, 0);
            tableLayoutPanel2.Controls.Add(gb_acciones, 2, 0);
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
            gb_datos.Controls.Add(cb_lugarNac);
            gb_datos.Controls.Add(label16);
            gb_datos.Controls.Add(label12);
            gb_datos.Controls.Add(cb_grupo);
            gb_datos.Controls.Add(cb_sexo);
            gb_datos.Controls.Add(label11);
            gb_datos.Controls.Add(label10);
            gb_datos.Controls.Add(NUD_mes);
            gb_datos.Controls.Add(label9);
            gb_datos.Controls.Add(NUD_año);
            gb_datos.Controls.Add(label8);
            gb_datos.Controls.Add(dtp_fechaNac);
            gb_datos.Controls.Add(label7);
            gb_datos.Controls.Add(tb_am);
            gb_datos.Controls.Add(label6);
            gb_datos.Controls.Add(tb_nombre);
            gb_datos.Controls.Add(label5);
            gb_datos.Controls.Add(tb_ap);
            gb_datos.Controls.Add(label4);
            gb_datos.Controls.Add(tb_curp);
            gb_datos.Controls.Add(label3);
            gb_datos.Enabled = false;
            gb_datos.Location = new Point(166, 3);
            gb_datos.Name = "gb_datos";
            gb_datos.Size = new Size(455, 248);
            gb_datos.TabIndex = 1;
            gb_datos.TabStop = false;
            gb_datos.Text = "Datos personales y escolares";
            // 
            // cb_lugarNac
            // 
            cb_lugarNac.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cb_lugarNac.FormattingEnabled = true;
            cb_lugarNac.Location = new Point(218, 95);
            cb_lugarNac.Name = "cb_lugarNac";
            cb_lugarNac.Size = new Size(125, 23);
            cb_lugarNac.TabIndex = 20;
            // 
            // label16
            // 
            label16.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label16.AutoSize = true;
            label16.Location = new Point(219, 77);
            label16.Name = "label16";
            label16.Size = new Size(124, 15);
            label16.TabIndex = 21;
            label16.Text = "Lugar de nacimiento *";
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
            // cb_grupo
            // 
            cb_grupo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cb_grupo.FormattingEnabled = true;
            cb_grupo.Location = new Point(219, 196);
            cb_grupo.Name = "cb_grupo";
            cb_grupo.Size = new Size(218, 23);
            cb_grupo.TabIndex = 8;
            // 
            // cb_sexo
            // 
            cb_sexo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cb_sexo.FormattingEnabled = true;
            cb_sexo.Location = new Point(307, 143);
            cb_sexo.Name = "cb_sexo";
            cb_sexo.Size = new Size(130, 23);
            cb_sexo.TabIndex = 7;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label11.AutoSize = true;
            label11.Location = new Point(219, 178);
            label11.Name = "label11";
            label11.Size = new Size(48, 15);
            label11.TabIndex = 16;
            label11.Text = "Grupo *";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label10.AutoSize = true;
            label10.Location = new Point(307, 125);
            label10.Name = "label10";
            label10.Size = new Size(40, 15);
            label10.TabIndex = 14;
            label10.Text = "Sexo *";
            // 
            // NUD_mes
            // 
            NUD_mes.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            NUD_mes.Enabled = false;
            NUD_mes.Location = new Point(219, 143);
            NUD_mes.Name = "NUD_mes";
            NUD_mes.Size = new Size(82, 23);
            NUD_mes.TabIndex = 6;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.Location = new Point(219, 125);
            label9.Name = "label9";
            label9.Size = new Size(37, 15);
            label9.TabIndex = 12;
            label9.Text = "Año *";
            // 
            // NUD_año
            // 
            NUD_año.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            NUD_año.Enabled = false;
            NUD_año.Location = new Point(356, 95);
            NUD_año.Name = "NUD_año";
            NUD_año.Size = new Size(82, 23);
            NUD_año.TabIndex = 5;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Location = new Point(356, 77);
            label8.Name = "label8";
            label8.Size = new Size(41, 15);
            label8.TabIndex = 10;
            label8.Text = "Edad *";
            // 
            // dtp_fechaNac
            // 
            dtp_fechaNac.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dtp_fechaNac.Format = DateTimePickerFormat.Short;
            dtp_fechaNac.Location = new Point(218, 44);
            dtp_fechaNac.Name = "dtp_fechaNac";
            dtp_fechaNac.Size = new Size(125, 23);
            dtp_fechaNac.TabIndex = 4;
            dtp_fechaNac.ValueChanged += dtp_fechaNac_ValueChanged;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Location = new Point(218, 26);
            label7.Name = "label7";
            label7.Size = new Size(125, 15);
            label7.TabIndex = 8;
            label7.Text = "Fecha de nacimiento *";
            // 
            // tb_am
            // 
            tb_am.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tb_am.Location = new Point(21, 196);
            tb_am.Name = "tb_am";
            tb_am.Size = new Size(171, 23);
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
            // tb_nombre
            // 
            tb_nombre.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tb_nombre.Location = new Point(21, 95);
            tb_nombre.Name = "tb_nombre";
            tb_nombre.Size = new Size(171, 23);
            tb_nombre.TabIndex = 1;
            tb_nombre.TextChanged += tb_nombre_TextChanged;
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
            tb_ap.Size = new Size(171, 23);
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
            // tb_curp
            // 
            tb_curp.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tb_curp.Enabled = false;
            tb_curp.Location = new Point(21, 44);
            tb_curp.Name = "tb_curp";
            tb_curp.Size = new Size(171, 23);
            tb_curp.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 26);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 0;
            label3.Text = "CURP *";
            // 
            // gb_foto
            // 
            gb_foto.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gb_foto.Controls.Add(btn_cargarFoto);
            gb_foto.Controls.Add(btn_tomarFoto);
            gb_foto.Controls.Add(pb_imgInfante);
            gb_foto.Enabled = false;
            gb_foto.Location = new Point(3, 3);
            gb_foto.Name = "gb_foto";
            gb_foto.Size = new Size(157, 248);
            gb_foto.TabIndex = 0;
            gb_foto.TabStop = false;
            gb_foto.Text = "Fotografia";
            // 
            // btn_cargarFoto
            // 
            btn_cargarFoto.Anchor = AnchorStyles.None;
            btn_cargarFoto.BackColor = Color.DarkGreen;
            btn_cargarFoto.FlatAppearance.BorderSize = 0;
            btn_cargarFoto.FlatStyle = FlatStyle.Flat;
            btn_cargarFoto.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_cargarFoto.ForeColor = Color.White;
            btn_cargarFoto.Image = Properties.Resources.cargar_archivo;
            btn_cargarFoto.Location = new Point(93, 189);
            btn_cargarFoto.Name = "btn_cargarFoto";
            btn_cargarFoto.Size = new Size(40, 40);
            btn_cargarFoto.TabIndex = 5;
            btn_cargarFoto.TextImageRelation = TextImageRelation.TextBeforeImage;
            btn_cargarFoto.UseVisualStyleBackColor = false;
            btn_cargarFoto.Click += btn_cargarFoto_Click;
            // 
            // btn_tomarFoto
            // 
            btn_tomarFoto.Anchor = AnchorStyles.None;
            btn_tomarFoto.BackColor = Color.DarkOrange;
            btn_tomarFoto.FlatAppearance.BorderSize = 0;
            btn_tomarFoto.FlatStyle = FlatStyle.Flat;
            btn_tomarFoto.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_tomarFoto.ForeColor = Color.White;
            btn_tomarFoto.Image = Properties.Resources.camara;
            btn_tomarFoto.Location = new Point(19, 189);
            btn_tomarFoto.Name = "btn_tomarFoto";
            btn_tomarFoto.Size = new Size(40, 40);
            btn_tomarFoto.TabIndex = 4;
            btn_tomarFoto.TextImageRelation = TextImageRelation.TextBeforeImage;
            btn_tomarFoto.UseVisualStyleBackColor = false;
            btn_tomarFoto.Click += btn_tomarFoto_Click;
            // 
            // pb_imgInfante
            // 
            pb_imgInfante.Anchor = AnchorStyles.None;
            pb_imgInfante.BackColor = Color.Gainsboro;
            pb_imgInfante.Location = new Point(19, 44);
            pb_imgInfante.Name = "pb_imgInfante";
            pb_imgInfante.Size = new Size(114, 139);
            pb_imgInfante.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_imgInfante.TabIndex = 3;
            pb_imgInfante.TabStop = false;
            // 
            // gb_acciones
            // 
            gb_acciones.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gb_acciones.Controls.Add(btn_guardar);
            gb_acciones.Controls.Add(btn_eliminar);
            gb_acciones.Enabled = false;
            gb_acciones.Location = new Point(627, 3);
            gb_acciones.Name = "gb_acciones";
            gb_acciones.Size = new Size(146, 248);
            gb_acciones.TabIndex = 2;
            gb_acciones.TabStop = false;
            gb_acciones.Text = "Acciones";
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
            btn_guardar.Location = new Point(18, 26);
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
            btn_eliminar.Anchor = AnchorStyles.None;
            btn_eliminar.BackColor = Color.DarkRed;
            btn_eliminar.FlatAppearance.BorderSize = 0;
            btn_eliminar.FlatStyle = FlatStyle.Flat;
            btn_eliminar.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_eliminar.ForeColor = Color.White;
            btn_eliminar.Image = Properties.Resources.borrar_usuario;
            btn_eliminar.Location = new Point(18, 80);
            btn_eliminar.Name = "btn_eliminar";
            btn_eliminar.Size = new Size(115, 48);
            btn_eliminar.TabIndex = 2;
            btn_eliminar.Text = "Eliminar infante";
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
            label2.Size = new Size(81, 15);
            label2.TabIndex = 2;
            label2.Text = "Ingrese CURP:";
            // 
            // tb_busqueda
            // 
            tb_busqueda.Anchor = AnchorStyles.Left;
            tb_busqueda.Location = new Point(90, 10);
            tb_busqueda.Name = "tb_busqueda";
            tb_busqueda.Size = new Size(139, 23);
            tb_busqueda.TabIndex = 3;
            tb_busqueda.TextChanged += tb_busqueda_TextChanged;
            tb_busqueda.KeyDown += tb_busqueda_KeyDown;
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
            btn_buscar.Location = new Point(235, 3);
            btn_buscar.Name = "btn_buscar";
            btn_buscar.Size = new Size(97, 37);
            btn_buscar.TabIndex = 4;
            btn_buscar.Text = "Buscar";
            btn_buscar.TextImageRelation = TextImageRelation.TextBeforeImage;
            btn_buscar.UseVisualStyleBackColor = false;
            btn_buscar.Click += btn_buscar_Click;
            // 
            // gb_asistencia
            // 
            gb_asistencia.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gb_asistencia.Controls.Add(cb_mes);
            gb_asistencia.Controls.Add(cb_año);
            gb_asistencia.Controls.Add(label17);
            gb_asistencia.Controls.Add(btn_exportarAsistencia);
            gb_asistencia.Controls.Add(btn_buscarAsistencia);
            gb_asistencia.Controls.Add(label14);
            gb_asistencia.Controls.Add(label13);
            gb_asistencia.Controls.Add(dataGridView1);
            gb_asistencia.Enabled = false;
            gb_asistencia.Location = new Point(3, 347);
            gb_asistencia.Name = "gb_asistencia";
            gb_asistencia.Size = new Size(776, 255);
            gb_asistencia.TabIndex = 3;
            gb_asistencia.TabStop = false;
            gb_asistencia.Text = "Asistencia";
            // 
            // cb_mes
            // 
            cb_mes.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cb_mes.FormattingEnabled = true;
            cb_mes.Location = new Point(12, 81);
            cb_mes.Name = "cb_mes";
            cb_mes.Size = new Size(124, 23);
            cb_mes.TabIndex = 24;
            // 
            // cb_año
            // 
            cb_año.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cb_año.FormattingEnabled = true;
            cb_año.Location = new Point(12, 37);
            cb_año.Name = "cb_año";
            cb_año.Size = new Size(124, 23);
            cb_año.TabIndex = 22;
            // 
            // label17
            // 
            label17.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label17.AutoSize = true;
            label17.Location = new Point(12, 19);
            label17.Name = "label17";
            label17.Size = new Size(29, 15);
            label17.TabIndex = 23;
            label17.Text = "Año";
            // 
            // btn_exportarAsistencia
            // 
            btn_exportarAsistencia.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_exportarAsistencia.BackColor = Color.DarkGreen;
            btn_exportarAsistencia.FlatAppearance.BorderSize = 0;
            btn_exportarAsistencia.FlatStyle = FlatStyle.Flat;
            btn_exportarAsistencia.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_exportarAsistencia.ForeColor = Color.White;
            btn_exportarAsistencia.Image = Properties.Resources.excel;
            btn_exportarAsistencia.Location = new Point(669, 212);
            btn_exportarAsistencia.Name = "btn_exportarAsistencia";
            btn_exportarAsistencia.Size = new Size(98, 37);
            btn_exportarAsistencia.TabIndex = 7;
            btn_exportarAsistencia.Text = "Exportar";
            btn_exportarAsistencia.TextImageRelation = TextImageRelation.TextBeforeImage;
            btn_exportarAsistencia.UseVisualStyleBackColor = false;
            btn_exportarAsistencia.Click += btn_exportarAsistencia_Click;
            // 
            // btn_buscarAsistencia
            // 
            btn_buscarAsistencia.BackColor = Color.DarkSlateGray;
            btn_buscarAsistencia.FlatAppearance.BorderSize = 0;
            btn_buscarAsistencia.FlatStyle = FlatStyle.Flat;
            btn_buscarAsistencia.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_buscarAsistencia.ForeColor = Color.White;
            btn_buscarAsistencia.Image = Properties.Resources.buscar;
            btn_buscarAsistencia.Location = new Point(39, 165);
            btn_buscarAsistencia.Name = "btn_buscarAsistencia";
            btn_buscarAsistencia.Size = new Size(97, 37);
            btn_buscarAsistencia.TabIndex = 6;
            btn_buscarAsistencia.Text = "Buscar";
            btn_buscarAsistencia.TextImageRelation = TextImageRelation.TextBeforeImage;
            btn_buscarAsistencia.UseVisualStyleBackColor = false;
            btn_buscarAsistencia.Click += btn_buscarAsistencia_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(12, 63);
            label14.Name = "label14";
            label14.Size = new Size(29, 15);
            label14.TabIndex = 2;
            label14.Text = "Mes";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(156, 19);
            label13.Name = "label13";
            label13.Size = new Size(118, 15);
            label13.TabIndex = 1;
            label13.Text = "Reporte de asistencia";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { fecha, horaEntrada, horaSalida, tutorEntrega, parentescoEntrega, tutorRecoge, parentescoRecoge });
            dataGridView1.Location = new Point(156, 37);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(611, 165);
            dataGridView1.TabIndex = 0;
            // 
            // fecha
            // 
            fecha.HeaderText = "Fecha";
            fecha.Name = "fecha";
            fecha.ReadOnly = true;
            // 
            // horaEntrada
            // 
            horaEntrada.HeaderText = "Hora entrada";
            horaEntrada.Name = "horaEntrada";
            horaEntrada.ReadOnly = true;
            // 
            // horaSalida
            // 
            horaSalida.HeaderText = "Hora salida";
            horaSalida.Name = "horaSalida";
            horaSalida.ReadOnly = true;
            // 
            // tutorEntrega
            // 
            tutorEntrega.HeaderText = "Tutor entrada";
            tutorEntrega.Name = "tutorEntrega";
            tutorEntrega.ReadOnly = true;
            // 
            // parentescoEntrega
            // 
            parentescoEntrega.HeaderText = "Parentesco entrada";
            parentescoEntrega.Name = "parentescoEntrega";
            parentescoEntrega.ReadOnly = true;
            // 
            // tutorRecoge
            // 
            tutorRecoge.HeaderText = "Tutor salida";
            tutorRecoge.Name = "tutorRecoge";
            tutorRecoge.ReadOnly = true;
            // 
            // parentescoRecoge
            // 
            parentescoRecoge.HeaderText = "Parentesco salida";
            parentescoRecoge.Name = "parentescoRecoge";
            parentescoRecoge.ReadOnly = true;
            // 
            // Form4_infantes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(782, 605);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form4_infantes";
            Text = "Form4_infantes";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            gb_datos.ResumeLayout(false);
            gb_datos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NUD_mes).EndInit();
            ((System.ComponentModel.ISupportInitialize)NUD_año).EndInit();
            gb_foto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pb_imgInfante).EndInit();
            gb_acciones.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            gb_asistencia.ResumeLayout(false);
            gb_asistencia.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel2;
        private GroupBox gb_datos;
        private ComboBox cb_grupo;
        private ComboBox cb_sexo;
        private Label label11;
        private Label label10;
        private NumericUpDown NUD_mes;
        private Label label9;
        private NumericUpDown NUD_año;
        private Label label8;
        private DateTimePicker dtp_fechaNac;
        private Label label7;
        private TextBox tb_am;
        private Label label6;
        private TextBox tb_nombre;
        private Label label5;
        private TextBox tb_ap;
        private Label label4;
        private TextBox tb_curp;
        private Label label3;
        private GroupBox gb_foto;
        private Button btn_cargarFoto;
        private Button btn_tomarFoto;
        private PictureBox pb_imgInfante;
        private GroupBox gb_acciones;
        private Button btn_guardar;
        private Button btn_eliminar;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label2;
        private TextBox tb_busqueda;
        private Button btn_buscar;
        private Label label12;
        private GroupBox gb_asistencia;
        private Button btn_buscarAsistencia;
        private Label label14;
        private Label label13;
        private DataGridView dataGridView1;
        private Button btn_exportarAsistencia;
        private ComboBox cb_lugarNac;
        private Label label16;
        private ComboBox cb_año;
        private Label label17;
        private ComboBox cb_mes;
        private DataGridViewTextBoxColumn fecha;
        private DataGridViewTextBoxColumn horaEntrada;
        private DataGridViewTextBoxColumn horaSalida;
        private DataGridViewTextBoxColumn tutorEntrega;
        private DataGridViewTextBoxColumn parentescoEntrega;
        private DataGridViewTextBoxColumn tutorRecoge;
        private DataGridViewTextBoxColumn parentescoRecoge;
    }
}