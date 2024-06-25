namespace CENDI_admin.Forms_config
{
    partial class Forms_configUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Forms_configUsuarios));
            groupBox1 = new GroupBox();
            label12 = new Label();
            checkBox1 = new CheckBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label6 = new Label();
            label3 = new Label();
            label7 = new Label();
            label1 = new Label();
            btn_guardar = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(checkBox1);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(14, 97);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(426, 186);
            groupBox1.TabIndex = 32;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos de administrador";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.ForeColor = Color.DarkRed;
            label12.Location = new Point(6, 158);
            label12.Name = "label12";
            label12.Size = new Size(123, 15);
            label12.TabIndex = 54;
            label12.Text = "* campos obligatorios";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(6, 115);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(128, 19);
            checkBox1.TabIndex = 53;
            checkBox1.Text = "Mostrar contraseña";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(6, 86);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '•';
            textBox2.Size = new Size(157, 23);
            textBox2.TabIndex = 52;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(6, 37);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(157, 23);
            textBox1.TabIndex = 51;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 68);
            label6.Name = "label6";
            label6.Size = new Size(75, 15);
            label6.TabIndex = 50;
            label6.Text = "Contraseña *";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 19);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 49;
            label3.Text = "Usuario *";
            // 
            // label7
            // 
            label7.Location = new Point(11, 33);
            label7.Name = "label7";
            label7.Size = new Size(429, 48);
            label7.TabIndex = 31;
            label7.Text = resources.GetString("label7.Text");
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(11, 10);
            label1.Name = "label1";
            label1.Size = new Size(219, 17);
            label1.TabIndex = 28;
            label1.Text = "Registro de usuario administrador";
            // 
            // btn_guardar
            // 
            btn_guardar.BackColor = Color.DarkGreen;
            btn_guardar.FlatAppearance.BorderSize = 0;
            btn_guardar.FlatStyle = FlatStyle.Flat;
            btn_guardar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_guardar.ForeColor = Color.White;
            btn_guardar.Image = Properties.Resources.guardar;
            btn_guardar.ImageAlign = ContentAlignment.MiddleLeft;
            btn_guardar.Location = new Point(337, 309);
            btn_guardar.Name = "btn_guardar";
            btn_guardar.Size = new Size(101, 40);
            btn_guardar.TabIndex = 33;
            btn_guardar.Text = "Guardar";
            btn_guardar.TextImageRelation = TextImageRelation.TextBeforeImage;
            btn_guardar.UseVisualStyleBackColor = false;
            btn_guardar.Click += btn_guardar_Click;
            // 
            // Forms_configUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(450, 361);
            Controls.Add(btn_guardar);
            Controls.Add(groupBox1);
            Controls.Add(label7);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Forms_configUsuarios";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registro de usuarios";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label7;
        private Label label1;
        private Label label12;
        private CheckBox checkBox1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label6;
        private Label label3;
        private Button btn_guardar;
    }
}