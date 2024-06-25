namespace CENDI_admin.Forms_dialogos
{
    partial class Dialogo5_credencial
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
            panel1 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel2 = new Panel();
            lb_nombreInfante = new Label();
            lb_noCredencial = new Label();
            label3 = new Label();
            label2 = new Label();
            panel4 = new Panel();
            lb_cicloEscolar = new Label();
            lb_gradoGrupo = new Label();
            pb_QR = new PictureBox();
            pb_fotoInfante = new PictureBox();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            lb_dir = new Label();
            lb_tel = new Label();
            lb_nomTutor = new Label();
            panel5 = new Panel();
            lb_parentesco = new Label();
            pb_fotoTutor = new PictureBox();
            label1 = new Label();
            cb_credencial = new ComboBox();
            btn_generar = new Button();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pb_QR).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_fotoInfante).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pb_fotoTutor).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Location = new Point(12, 47);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(5);
            panel1.Size = new Size(650, 208);
            panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(panel2, 0, 0);
            tableLayoutPanel1.Controls.Add(panel3, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(5, 5);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(638, 196);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(lb_nombreInfante);
            panel2.Controls.Add(lb_noCredencial);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(pb_QR);
            panel2.Controls.Add(pb_fotoInfante);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(313, 190);
            panel2.TabIndex = 0;
            // 
            // lb_nombreInfante
            // 
            lb_nombreInfante.AutoSize = true;
            lb_nombreInfante.Location = new Point(7, 144);
            lb_nombreInfante.Name = "lb_nombreInfante";
            lb_nombreInfante.Size = new Size(51, 15);
            lb_nombreInfante.TabIndex = 7;
            lb_nombreInfante.Text = "Nombre";
            // 
            // lb_noCredencial
            // 
            lb_noCredencial.Location = new Point(207, 141);
            lb_noCredencial.Name = "lb_noCredencial";
            lb_noCredencial.Size = new Size(88, 13);
            lb_noCredencial.TabIndex = 6;
            lb_noCredencial.Text = "######";
            lb_noCredencial.TextAlign = ContentAlignment.TopCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(94, 67);
            label3.Name = "label3";
            label3.Size = new Size(49, 21);
            label3.TabIndex = 5;
            label3.Text = "No. 2";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(89, 41);
            label2.Name = "label2";
            label2.Size = new Size(215, 21);
            label2.TabIndex = 4;
            label2.Text = "Centro de desarrollo infantil";
            // 
            // panel4
            // 
            panel4.BackColor = Color.DarkSlateGray;
            panel4.Controls.Add(lb_cicloEscolar);
            panel4.Controls.Add(lb_gradoGrupo);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(0, 160);
            panel4.Name = "panel4";
            panel4.Size = new Size(311, 28);
            panel4.TabIndex = 3;
            // 
            // lb_cicloEscolar
            // 
            lb_cicloEscolar.AutoSize = true;
            lb_cicloEscolar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lb_cicloEscolar.ForeColor = Color.White;
            lb_cicloEscolar.Location = new Point(207, 9);
            lb_cicloEscolar.Name = "lb_cicloEscolar";
            lb_cicloEscolar.Size = new Size(75, 15);
            lb_cicloEscolar.TabIndex = 1;
            lb_cicloEscolar.Text = "Ciclo escolar";
            // 
            // lb_gradoGrupo
            // 
            lb_gradoGrupo.AutoSize = true;
            lb_gradoGrupo.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lb_gradoGrupo.ForeColor = Color.White;
            lb_gradoGrupo.Location = new Point(7, 9);
            lb_gradoGrupo.Name = "lb_gradoGrupo";
            lb_gradoGrupo.Size = new Size(85, 15);
            lb_gradoGrupo.TabIndex = 0;
            lb_gradoGrupo.Text = "Nivel escolar";
            // 
            // pb_QR
            // 
            pb_QR.BackColor = Color.WhiteSmoke;
            pb_QR.Location = new Point(216, 67);
            pb_QR.Name = "pb_QR";
            pb_QR.Size = new Size(70, 70);
            pb_QR.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_QR.TabIndex = 2;
            pb_QR.TabStop = false;
            // 
            // pb_fotoInfante
            // 
            pb_fotoInfante.BackColor = Color.WhiteSmoke;
            pb_fotoInfante.Location = new Point(3, 41);
            pb_fotoInfante.Name = "pb_fotoInfante";
            pb_fotoInfante.Size = new Size(85, 100);
            pb_fotoInfante.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_fotoInfante.TabIndex = 1;
            pb_fotoInfante.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.ErrorImage = Properties.Resources.logo2;
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(311, 35);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(lb_dir);
            panel3.Controls.Add(lb_tel);
            panel3.Controls.Add(lb_nomTutor);
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(pb_fotoTutor);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(322, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(313, 190);
            panel3.TabIndex = 1;
            // 
            // lb_dir
            // 
            lb_dir.Location = new Point(98, 27);
            lb_dir.Name = "lb_dir";
            lb_dir.Size = new Size(206, 81);
            lb_dir.TabIndex = 7;
            lb_dir.Text = "Direccion";
            lb_dir.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lb_tel
            // 
            lb_tel.Location = new Point(98, 8);
            lb_tel.Name = "lb_tel";
            lb_tel.Size = new Size(206, 13);
            lb_tel.TabIndex = 6;
            lb_tel.Text = "Telefono";
            // 
            // lb_nomTutor
            // 
            lb_nomTutor.Location = new Point(7, 111);
            lb_nomTutor.Name = "lb_nomTutor";
            lb_nomTutor.Size = new Size(297, 13);
            lb_nomTutor.TabIndex = 5;
            lb_nomTutor.Text = "Nombre";
            // 
            // panel5
            // 
            panel5.BackColor = Color.DarkSlateGray;
            panel5.Controls.Add(lb_parentesco);
            panel5.Dock = DockStyle.Bottom;
            panel5.Location = new Point(0, 160);
            panel5.Name = "panel5";
            panel5.Size = new Size(311, 28);
            panel5.TabIndex = 4;
            // 
            // lb_parentesco
            // 
            lb_parentesco.AutoSize = true;
            lb_parentesco.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lb_parentesco.ForeColor = Color.White;
            lb_parentesco.Location = new Point(7, 9);
            lb_parentesco.Name = "lb_parentesco";
            lb_parentesco.Size = new Size(69, 15);
            lb_parentesco.TabIndex = 0;
            lb_parentesco.Text = "Parentesco";
            // 
            // pb_fotoTutor
            // 
            pb_fotoTutor.BackColor = Color.WhiteSmoke;
            pb_fotoTutor.Location = new Point(7, 8);
            pb_fotoTutor.Name = "pb_fotoTutor";
            pb_fotoTutor.Size = new Size(85, 100);
            pb_fotoTutor.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_fotoTutor.TabIndex = 0;
            pb_fotoTutor.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 1;
            label1.Text = "Credencial:";
            // 
            // cb_credencial
            // 
            cb_credencial.FormattingEnabled = true;
            cb_credencial.Location = new Point(84, 15);
            cb_credencial.Name = "cb_credencial";
            cb_credencial.Size = new Size(188, 23);
            cb_credencial.TabIndex = 2;
            cb_credencial.SelectedValueChanged += cb_credencial_SelectedValueChanged;
            // 
            // btn_generar
            // 
            btn_generar.Anchor = AnchorStyles.None;
            btn_generar.BackColor = Color.DarkGreen;
            btn_generar.Enabled = false;
            btn_generar.FlatAppearance.BorderSize = 0;
            btn_generar.FlatStyle = FlatStyle.Flat;
            btn_generar.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_generar.ForeColor = Color.White;
            btn_generar.Image = Properties.Resources.pdf;
            btn_generar.Location = new Point(547, 269);
            btn_generar.Name = "btn_generar";
            btn_generar.Size = new Size(115, 48);
            btn_generar.TabIndex = 36;
            btn_generar.Text = "Guardar";
            btn_generar.TextImageRelation = TextImageRelation.TextBeforeImage;
            btn_generar.UseVisualStyleBackColor = false;
            btn_generar.Click += btn_generar_Click;
            // 
            // Dialogo5_credencial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(681, 328);
            Controls.Add(btn_generar);
            Controls.Add(cb_credencial);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Dialogo5_credencial";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Credenciales";
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pb_QR).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_fotoInfante).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pb_fotoTutor).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private ComboBox cb_credencial;
        private Button btn_generar;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel2;
        private Panel panel4;
        private PictureBox pb_QR;
        private PictureBox pb_fotoInfante;
        private PictureBox pictureBox1;
        private Panel panel3;
        private Panel panel5;
        private PictureBox pb_fotoTutor;
        private Label lb_noCredencial;
        private Label label3;
        private Label label2;
        private Label lb_cicloEscolar;
        private Label lb_gradoGrupo;
        private Label lb_dir;
        private Label lb_tel;
        private Label lb_nomTutor;
        private Label lb_parentesco;
        private Label lb_nombreInfante;
    }
}