namespace CENDI_admin.Forms_config
{
    partial class Forms_configServer
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
            btn_guardar = new Button();
            btn_testConn = new Button();
            label1 = new Label();
            label7 = new Label();
            groupBox1 = new GroupBox();
            tb_contraseña = new TextBox();
            tb_usuario = new TextBox();
            tb_nomDB = new TextBox();
            tb_puerto = new TextBox();
            tb_host = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
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
            btn_guardar.TabIndex = 25;
            btn_guardar.Text = "Guardar";
            btn_guardar.TextImageRelation = TextImageRelation.TextBeforeImage;
            btn_guardar.UseVisualStyleBackColor = false;
            btn_guardar.Click += btn_guardar_Click;
            // 
            // btn_testConn
            // 
            btn_testConn.BackColor = Color.DarkSlateGray;
            btn_testConn.FlatAppearance.BorderSize = 0;
            btn_testConn.FlatStyle = FlatStyle.Flat;
            btn_testConn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_testConn.ForeColor = Color.White;
            btn_testConn.Image = Properties.Resources.conexion_de_enchufe;
            btn_testConn.Location = new Point(219, 309);
            btn_testConn.Name = "btn_testConn";
            btn_testConn.Size = new Size(101, 40);
            btn_testConn.TabIndex = 24;
            btn_testConn.Text = "Probar conexion";
            btn_testConn.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_testConn.UseVisualStyleBackColor = false;
            btn_testConn.Click += btn_testConn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(9, 9);
            label1.Name = "label1";
            label1.Size = new Size(169, 17);
            label1.TabIndex = 13;
            label1.Text = "Configuracion de servidor";
            // 
            // label7
            // 
            label7.Location = new Point(9, 32);
            label7.Name = "label7";
            label7.Size = new Size(429, 38);
            label7.TabIndex = 26;
            label7.Text = "Configuracion que permite la conexion entre esta computadora y la computadora que registra la asistencia, deben estar conectados en la misma red\r\n";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tb_contraseña);
            groupBox1.Controls.Add(tb_usuario);
            groupBox1.Controls.Add(tb_nomDB);
            groupBox1.Controls.Add(tb_puerto);
            groupBox1.Controls.Add(tb_host);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(12, 73);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(426, 219);
            groupBox1.TabIndex = 27;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos de servidor";
            // 
            // tb_contraseña
            // 
            tb_contraseña.Location = new Point(6, 155);
            tb_contraseña.Name = "tb_contraseña";
            tb_contraseña.PasswordChar = '•';
            tb_contraseña.Size = new Size(157, 23);
            tb_contraseña.TabIndex = 33;
            // 
            // tb_usuario
            // 
            tb_usuario.Location = new Point(185, 103);
            tb_usuario.Name = "tb_usuario";
            tb_usuario.Size = new Size(157, 23);
            tb_usuario.TabIndex = 32;
            // 
            // tb_nomDB
            // 
            tb_nomDB.Location = new Point(6, 103);
            tb_nomDB.Name = "tb_nomDB";
            tb_nomDB.Size = new Size(157, 23);
            tb_nomDB.TabIndex = 31;
            // 
            // tb_puerto
            // 
            tb_puerto.Location = new Point(185, 53);
            tb_puerto.Name = "tb_puerto";
            tb_puerto.Size = new Size(49, 23);
            tb_puerto.TabIndex = 30;
            // 
            // tb_host
            // 
            tb_host.Location = new Point(6, 53);
            tb_host.Name = "tb_host";
            tb_host.Size = new Size(157, 23);
            tb_host.TabIndex = 29;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 137);
            label6.Name = "label6";
            label6.Size = new Size(70, 15);
            label6.TabIndex = 28;
            label6.Text = "Contraseña:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(185, 85);
            label5.Name = "label5";
            label5.Size = new Size(50, 15);
            label5.TabIndex = 27;
            label5.Text = "Usuario:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(185, 35);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 26;
            label4.Text = "Puerto:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 85);
            label3.Name = "label3";
            label3.Size = new Size(157, 15);
            label3.TabIndex = 25;
            label3.Text = "Nombre de la base de datos:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 35);
            label2.Name = "label2";
            label2.Size = new Size(73, 15);
            label2.TabIndex = 24;
            label2.Text = "Direccion IP:";
            // 
            // Forms_configServer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(450, 361);
            Controls.Add(groupBox1);
            Controls.Add(label7);
            Controls.Add(btn_guardar);
            Controls.Add(btn_testConn);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Forms_configServer";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Configuracion de servidor";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_guardar;
        private Button btn_testConn;
        private Label label1;
        private Label label7;
        private GroupBox groupBox1;
        private TextBox tb_contraseña;
        private TextBox tb_usuario;
        private TextBox tb_nomDB;
        private TextBox tb_puerto;
        private TextBox tb_host;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
    }
}