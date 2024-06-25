namespace CENDI_admin.Forms_config
{
    partial class Form_configPrincipal
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
            p_workbeanch = new Panel();
            panel2 = new Panel();
            btn_terminar = new Button();
            btn_ciclos = new Button();
            btn_grupos = new Button();
            btn_admin = new Button();
            btn_servidor = new Button();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // p_workbeanch
            // 
            p_workbeanch.Location = new Point(155, 8);
            p_workbeanch.Name = "p_workbeanch";
            p_workbeanch.Size = new Size(450, 361);
            p_workbeanch.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(btn_terminar);
            panel2.Controls.Add(btn_ciclos);
            panel2.Controls.Add(btn_grupos);
            panel2.Controls.Add(btn_admin);
            panel2.Controls.Add(btn_servidor);
            panel2.Location = new Point(2, 8);
            panel2.Name = "panel2";
            panel2.Size = new Size(147, 361);
            panel2.TabIndex = 1;
            // 
            // btn_terminar
            // 
            btn_terminar.BackColor = Color.DarkGreen;
            btn_terminar.Enabled = false;
            btn_terminar.FlatAppearance.BorderSize = 0;
            btn_terminar.FlatStyle = FlatStyle.Flat;
            btn_terminar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_terminar.ForeColor = Color.White;
            btn_terminar.Image = Properties.Resources.guardar;
            btn_terminar.Location = new Point(3, 319);
            btn_terminar.Name = "btn_terminar";
            btn_terminar.Size = new Size(141, 38);
            btn_terminar.TabIndex = 4;
            btn_terminar.Text = "Terminar";
            btn_terminar.TextImageRelation = TextImageRelation.TextBeforeImage;
            btn_terminar.UseVisualStyleBackColor = false;
            btn_terminar.Click += btn_terminar_Click;
            // 
            // btn_ciclos
            // 
            btn_ciclos.BackColor = Color.White;
            btn_ciclos.Enabled = false;
            btn_ciclos.FlatAppearance.BorderSize = 0;
            btn_ciclos.FlatStyle = FlatStyle.Flat;
            btn_ciclos.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_ciclos.Location = new Point(3, 117);
            btn_ciclos.Name = "btn_ciclos";
            btn_ciclos.Size = new Size(141, 38);
            btn_ciclos.TabIndex = 3;
            btn_ciclos.Text = "Ciclo escolar";
            btn_ciclos.UseVisualStyleBackColor = false;
            btn_ciclos.Click += btn_ciclos_Click;
            // 
            // btn_grupos
            // 
            btn_grupos.BackColor = Color.White;
            btn_grupos.Enabled = false;
            btn_grupos.FlatAppearance.BorderSize = 0;
            btn_grupos.FlatStyle = FlatStyle.Flat;
            btn_grupos.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_grupos.Location = new Point(3, 79);
            btn_grupos.Name = "btn_grupos";
            btn_grupos.Size = new Size(141, 38);
            btn_grupos.TabIndex = 2;
            btn_grupos.Text = "Grupos";
            btn_grupos.UseVisualStyleBackColor = false;
            btn_grupos.Click += btn_grupos_Click;
            // 
            // btn_admin
            // 
            btn_admin.BackColor = Color.White;
            btn_admin.Enabled = false;
            btn_admin.FlatAppearance.BorderSize = 0;
            btn_admin.FlatStyle = FlatStyle.Flat;
            btn_admin.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_admin.Location = new Point(3, 41);
            btn_admin.Name = "btn_admin";
            btn_admin.Size = new Size(141, 38);
            btn_admin.TabIndex = 1;
            btn_admin.Text = "Administrador";
            btn_admin.UseVisualStyleBackColor = false;
            btn_admin.Click += btn_admin_Click;
            // 
            // btn_servidor
            // 
            btn_servidor.BackColor = Color.DarkSlateGray;
            btn_servidor.FlatAppearance.BorderSize = 0;
            btn_servidor.FlatStyle = FlatStyle.Flat;
            btn_servidor.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_servidor.ForeColor = Color.White;
            btn_servidor.Location = new Point(3, 3);
            btn_servidor.Name = "btn_servidor";
            btn_servidor.Size = new Size(141, 38);
            btn_servidor.TabIndex = 0;
            btn_servidor.Text = "Servidor";
            btn_servidor.UseVisualStyleBackColor = false;
            btn_servidor.Click += btn_servidor_Click;
            // 
            // Form_configPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(612, 377);
            Controls.Add(panel2);
            Controls.Add(p_workbeanch);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form_configPrincipal";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Configuracion";
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel p_workbeanch;
        private Panel panel2;
        private Button btn_servidor;
        public Button btn_grupos;
        public Button btn_admin;
        public Button btn_ciclos;
        public Button btn_terminar;
    }
}