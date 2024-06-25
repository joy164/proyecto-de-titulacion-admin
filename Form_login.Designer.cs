namespace CENDI_admin
{
    partial class Form_login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            panel3 = new Panel();
            checkBox1 = new CheckBox();
            label4 = new Label();
            label3 = new Label();
            tb_password = new TextBox();
            tb_noEmpleado = new TextBox();
            button1 = new Button();
            label2 = new Label();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 43.42857F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 56.57143F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(panel2, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(525, 298);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightGray;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Fill;
            panel1.ForeColor = Color.Black;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(222, 292);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(31, 18);
            label1.Name = "label1";
            label1.Size = new Size(155, 69);
            label1.TabIndex = 1;
            label1.Text = "Sistema Digital de Asistencia Escolar\r\n2";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.CendiIZt;
            pictureBox1.Location = new Point(31, 113);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(155, 155);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(231, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(291, 292);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.DarkSlateGray;
            panel3.Controls.Add(checkBox1);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(tb_password);
            panel3.Controls.Add(tb_noEmpleado);
            panel3.Location = new Point(11, 55);
            panel3.Name = "panel3";
            panel3.Size = new Size(266, 170);
            panel3.TabIndex = 8;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.ForeColor = Color.White;
            checkBox1.Location = new Point(19, 133);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(128, 19);
            checkBox1.TabIndex = 11;
            checkBox1.Text = "Mostrar contraseña";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(19, 78);
            label4.Name = "label4";
            label4.Size = new Size(106, 21);
            label4.TabIndex = 10;
            label4.Text = "Contrtaseña:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(19, 11);
            label3.Name = "label3";
            label3.Size = new Size(73, 21);
            label3.TabIndex = 9;
            label3.Text = "Usuario:";
            // 
            // tb_password
            // 
            tb_password.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            tb_password.Location = new Point(19, 102);
            tb_password.Name = "tb_password";
            tb_password.PasswordChar = '•';
            tb_password.PlaceholderText = "Ingrese contraseña";
            tb_password.Size = new Size(229, 25);
            tb_password.TabIndex = 8;
            // 
            // tb_noEmpleado
            // 
            tb_noEmpleado.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            tb_noEmpleado.Location = new Point(19, 35);
            tb_noEmpleado.Name = "tb_noEmpleado";
            tb_noEmpleado.PlaceholderText = "Ingrese numero de empleado";
            tb_noEmpleado.Size = new Size(229, 25);
            tb_noEmpleado.TabIndex = 7;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkSlateGray;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(192, 250);
            button1.Name = "button1";
            button1.Size = new Size(81, 33);
            button1.TabIndex = 7;
            button1.Text = "Entrar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(3, 11);
            label2.Name = "label2";
            label2.Size = new Size(285, 33);
            label2.TabIndex = 5;
            label2.Text = "Iniciar sesión";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form_login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(525, 298);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form_login";
            Opacity = 0.85D;
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SIDAE | Administrador";
            KeyDown += Form_login_KeyDown;
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Label label1;
        private Label label2;
        private Button button1;
        private Panel panel3;
        private CheckBox checkBox1;
        private Label label4;
        private Label label3;
        private TextBox tb_password;
        private TextBox tb_noEmpleado;
    }
}