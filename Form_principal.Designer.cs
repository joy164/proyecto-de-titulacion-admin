namespace CENDI_admin
{
    partial class Form_principal
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
            panel1 = new Panel();
            label1 = new Label();
            btn_cerrar = new Button();
            label4 = new Label();
            btn_asistencia = new Button();
            label3 = new Label();
            label2 = new Label();
            btn_inscripcion = new Button();
            btn_tutores = new Button();
            btn_infantes = new Button();
            btn_grupos = new Button();
            btn_usuarios = new Button();
            p_workbeanch = new Panel();
            pictureBox1 = new PictureBox();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            p_workbeanch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(p_workbeanch, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(984, 611);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btn_cerrar);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(btn_asistencia);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btn_inscripcion);
            panel1.Controls.Add(btn_tutores);
            panel1.Controls.Add(btn_infantes);
            panel1.Controls.Add(btn_grupos);
            panel1.Controls.Add(btn_usuarios);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(190, 605);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(3, 532);
            label1.Name = "label1";
            label1.Size = new Size(143, 17);
            label1.TabIndex = 11;
            label1.Text = "Sesion de: # empleado";
            // 
            // btn_cerrar
            // 
            btn_cerrar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btn_cerrar.BackColor = Color.DarkRed;
            btn_cerrar.FlatAppearance.BorderSize = 0;
            btn_cerrar.FlatStyle = FlatStyle.Flat;
            btn_cerrar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_cerrar.ForeColor = Color.White;
            btn_cerrar.Image = Properties.Resources.apagar;
            btn_cerrar.Location = new Point(2, 552);
            btn_cerrar.Name = "btn_cerrar";
            btn_cerrar.Size = new Size(188, 50);
            btn_cerrar.TabIndex = 7;
            btn_cerrar.Text = "Cerrar sesión";
            btn_cerrar.TextAlign = ContentAlignment.MiddleRight;
            btn_cerrar.TextImageRelation = TextImageRelation.TextBeforeImage;
            btn_cerrar.UseVisualStyleBackColor = false;
            btn_cerrar.Click += btn_cerrar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(6, 2);
            label4.Name = "label4";
            label4.Size = new Size(65, 17);
            label4.TabIndex = 10;
            label4.Text = "Asistencia";
            // 
            // btn_asistencia
            // 
            btn_asistencia.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btn_asistencia.BackColor = Color.DarkSlateGray;
            btn_asistencia.FlatAppearance.BorderSize = 0;
            btn_asistencia.FlatStyle = FlatStyle.Flat;
            btn_asistencia.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_asistencia.ForeColor = Color.White;
            btn_asistencia.Image = Properties.Resources.asistencia;
            btn_asistencia.Location = new Point(0, 22);
            btn_asistencia.Name = "btn_asistencia";
            btn_asistencia.Size = new Size(188, 50);
            btn_asistencia.TabIndex = 0;
            btn_asistencia.Text = "Asistencia";
            btn_asistencia.TextAlign = ContentAlignment.MiddleRight;
            btn_asistencia.TextImageRelation = TextImageRelation.TextBeforeImage;
            btn_asistencia.UseVisualStyleBackColor = false;
            btn_asistencia.Click += Btn_asistencia_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(6, 298);
            label3.Name = "label3";
            label3.Size = new Size(83, 17);
            label3.TabIndex = 7;
            label3.Text = "Inscripciones";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(6, 75);
            label2.Name = "label2";
            label2.Size = new Size(94, 17);
            label2.TabIndex = 6;
            label2.Text = "Administración";
            // 
            // btn_inscripcion
            // 
            btn_inscripcion.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btn_inscripcion.BackColor = Color.DarkSlateGray;
            btn_inscripcion.FlatAppearance.BorderSize = 0;
            btn_inscripcion.FlatStyle = FlatStyle.Flat;
            btn_inscripcion.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_inscripcion.ForeColor = Color.White;
            btn_inscripcion.Image = Properties.Resources.inscripcion;
            btn_inscripcion.Location = new Point(0, 318);
            btn_inscripcion.Name = "btn_inscripcion";
            btn_inscripcion.Size = new Size(188, 50);
            btn_inscripcion.TabIndex = 5;
            btn_inscripcion.Text = "Inscripcion y \r\nreinscripcion";
            btn_inscripcion.TextAlign = ContentAlignment.MiddleRight;
            btn_inscripcion.TextImageRelation = TextImageRelation.TextBeforeImage;
            btn_inscripcion.UseVisualStyleBackColor = false;
            btn_inscripcion.Click += Btn_inscripcion_Click;
            // 
            // btn_tutores
            // 
            btn_tutores.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btn_tutores.BackColor = Color.DarkSlateGray;
            btn_tutores.FlatAppearance.BorderSize = 0;
            btn_tutores.FlatStyle = FlatStyle.Flat;
            btn_tutores.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_tutores.ForeColor = Color.White;
            btn_tutores.Image = Properties.Resources.tutor;
            btn_tutores.Location = new Point(0, 245);
            btn_tutores.Name = "btn_tutores";
            btn_tutores.Size = new Size(188, 50);
            btn_tutores.TabIndex = 4;
            btn_tutores.Text = "Tutores";
            btn_tutores.TextAlign = ContentAlignment.MiddleRight;
            btn_tutores.TextImageRelation = TextImageRelation.TextBeforeImage;
            btn_tutores.UseVisualStyleBackColor = false;
            btn_tutores.Click += Btn_tutores_Click;
            // 
            // btn_infantes
            // 
            btn_infantes.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btn_infantes.BackColor = Color.DarkSlateGray;
            btn_infantes.FlatAppearance.BorderSize = 0;
            btn_infantes.FlatStyle = FlatStyle.Flat;
            btn_infantes.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_infantes.ForeColor = Color.White;
            btn_infantes.Image = Properties.Resources.infante;
            btn_infantes.Location = new Point(0, 195);
            btn_infantes.Name = "btn_infantes";
            btn_infantes.Size = new Size(188, 50);
            btn_infantes.TabIndex = 3;
            btn_infantes.Text = "Infantes";
            btn_infantes.TextAlign = ContentAlignment.MiddleRight;
            btn_infantes.TextImageRelation = TextImageRelation.TextBeforeImage;
            btn_infantes.UseVisualStyleBackColor = false;
            btn_infantes.Click += Btn_infantes_Click;
            // 
            // btn_grupos
            // 
            btn_grupos.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btn_grupos.BackColor = Color.DarkSlateGray;
            btn_grupos.FlatAppearance.BorderSize = 0;
            btn_grupos.FlatStyle = FlatStyle.Flat;
            btn_grupos.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_grupos.ForeColor = Color.White;
            btn_grupos.Image = Properties.Resources.salon;
            btn_grupos.Location = new Point(0, 145);
            btn_grupos.Name = "btn_grupos";
            btn_grupos.Size = new Size(188, 50);
            btn_grupos.TabIndex = 2;
            btn_grupos.Text = "Grupos";
            btn_grupos.TextAlign = ContentAlignment.MiddleRight;
            btn_grupos.TextImageRelation = TextImageRelation.TextBeforeImage;
            btn_grupos.UseVisualStyleBackColor = false;
            btn_grupos.Click += Btn_grupos_Click;
            // 
            // btn_usuarios
            // 
            btn_usuarios.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btn_usuarios.BackColor = Color.DarkSlateGray;
            btn_usuarios.FlatAppearance.BorderSize = 0;
            btn_usuarios.FlatStyle = FlatStyle.Flat;
            btn_usuarios.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_usuarios.ForeColor = Color.White;
            btn_usuarios.Image = Properties.Resources.usuario;
            btn_usuarios.Location = new Point(0, 95);
            btn_usuarios.Name = "btn_usuarios";
            btn_usuarios.Size = new Size(188, 50);
            btn_usuarios.TabIndex = 1;
            btn_usuarios.Text = "Usuarios";
            btn_usuarios.TextAlign = ContentAlignment.MiddleRight;
            btn_usuarios.TextImageRelation = TextImageRelation.TextBeforeImage;
            btn_usuarios.UseVisualStyleBackColor = false;
            btn_usuarios.Click += Btn_usuarios_Click;
            // 
            // p_workbeanch
            // 
            p_workbeanch.BackColor = Color.White;
            p_workbeanch.Controls.Add(pictureBox1);
            p_workbeanch.Dock = DockStyle.Fill;
            p_workbeanch.Location = new Point(199, 3);
            p_workbeanch.Name = "p_workbeanch";
            p_workbeanch.Size = new Size(782, 605);
            p_workbeanch.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo2;
            pictureBox1.Location = new Point(20, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(523, 80);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Form_principal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 611);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MinimumSize = new Size(800, 525);
            Name = "Form_principal";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SIDAE | Menu principal";
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            p_workbeanch.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Button btn_usuarios;
        private Button btn_infantes;
        private Button btn_grupos;
        private Button btn_inscripcion;
        private Button btn_tutores;
        private Label label3;
        private Label label2;
        private Label label4;
        private Button btn_asistencia;
        private Button btn_cerrar;
        private Panel p_workbeanch;
        private PictureBox pictureBox1;
        private Label label1;
    }
}