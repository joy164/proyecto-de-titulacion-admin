namespace CENDI_admin.Forms_config
{
    partial class Forms_configSalones
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
            groupBox1 = new GroupBox();
            label12 = new Label();
            btn_agregar = new Button();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            label7 = new Label();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            noSalon = new DataGridViewTextBoxColumn();
            nivel = new DataGridViewTextBoxColumn();
            grado = new DataGridViewTextBoxColumn();
            grupo = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(btn_agregar);
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(14, 248);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(426, 95);
            groupBox1.TabIndex = 36;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos de salon";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.ForeColor = Color.DarkRed;
            label12.Location = new Point(8, 67);
            label12.Name = "label12";
            label12.Size = new Size(123, 15);
            label12.TabIndex = 52;
            label12.Text = "* campos obligatorios";
            // 
            // btn_agregar
            // 
            btn_agregar.Anchor = AnchorStyles.None;
            btn_agregar.BackColor = Color.DarkGreen;
            btn_agregar.FlatAppearance.BorderSize = 0;
            btn_agregar.FlatStyle = FlatStyle.Flat;
            btn_agregar.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_agregar.ForeColor = Color.White;
            btn_agregar.Image = Properties.Resources.agregar_generico;
            btn_agregar.Location = new Point(377, 29);
            btn_agregar.Name = "btn_agregar";
            btn_agregar.Size = new Size(34, 34);
            btn_agregar.TabIndex = 51;
            btn_agregar.TextImageRelation = TextImageRelation.TextBeforeImage;
            btn_agregar.UseVisualStyleBackColor = false;
            btn_agregar.Click += btn_agregar_Click;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(184, 37);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(172, 23);
            comboBox2.TabIndex = 50;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(8, 37);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(170, 23);
            comboBox1.TabIndex = 49;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(184, 19);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 48;
            label2.Text = "Grupo *";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(8, 19);
            label3.Name = "label3";
            label3.Size = new Size(85, 15);
            label3.TabIndex = 47;
            label3.Text = "Nivel y grado *";
            // 
            // label7
            // 
            label7.Location = new Point(11, 34);
            label7.Name = "label7";
            label7.Size = new Size(429, 48);
            label7.TabIndex = 35;
            label7.Text = "Son los salones disponibles que tiene la escuela que perteneceran los infnates, si desea hacer alguna modificacion o eliminar un salon lo podra hacer mas adelante en el apartado de Grupos";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(11, 11);
            label1.Name = "label1";
            label1.Size = new Size(125, 17);
            label1.TabIndex = 34;
            label1.Text = "Registro de grupos";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { noSalon, nivel, grado, grupo });
            dataGridView1.Location = new Point(11, 85);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(429, 157);
            dataGridView1.TabIndex = 38;
            // 
            // noSalon
            // 
            noSalon.HeaderText = "No salon";
            noSalon.Name = "noSalon";
            noSalon.ReadOnly = true;
            noSalon.Visible = false;
            // 
            // nivel
            // 
            nivel.HeaderText = "Nivel";
            nivel.Name = "nivel";
            nivel.ReadOnly = true;
            // 
            // grado
            // 
            grado.HeaderText = "Grado";
            grado.Name = "grado";
            grado.ReadOnly = true;
            // 
            // grupo
            // 
            grupo.HeaderText = "Grupo";
            grupo.Name = "grupo";
            grupo.ReadOnly = true;
            // 
            // Forms_configSalones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(450, 361);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Controls.Add(label7);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Forms_configSalones";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Grupos";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private GroupBox groupBox1;
        private Label label7;
        private Label label1;
        private Label label12;
        private Button btn_agregar;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private Label label2;
        private Label label3;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn noSalon;
        private DataGridViewTextBoxColumn nivel;
        private DataGridViewTextBoxColumn grado;
        private DataGridViewTextBoxColumn grupo;
    }
}