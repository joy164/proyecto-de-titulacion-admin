namespace CENDI_admin.Forms_config
{
    partial class Form_configCiclos
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
            groupBox1 = new GroupBox();
            label12 = new Label();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            label3 = new Label();
            label2 = new Label();
            label7 = new Label();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            idCiclo = new DataGridViewTextBoxColumn();
            fechaInicio = new DataGridViewTextBoxColumn();
            fechaCierre = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            btn_guardar.Location = new Point(337, 310);
            btn_guardar.Name = "btn_guardar";
            btn_guardar.Size = new Size(101, 40);
            btn_guardar.TabIndex = 37;
            btn_guardar.Text = "Guardar";
            btn_guardar.TextImageRelation = TextImageRelation.TextBeforeImage;
            btn_guardar.UseVisualStyleBackColor = false;
            btn_guardar.Click += btn_guardar_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(dateTimePicker2);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(14, 198);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(426, 100);
            groupBox1.TabIndex = 36;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos de ciclo escolar";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.ForeColor = Color.DarkRed;
            label12.Location = new Point(6, 73);
            label12.Name = "label12";
            label12.Size = new Size(123, 15);
            label12.TabIndex = 49;
            label12.Text = "* campos obligatorios";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Location = new Point(166, 44);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(142, 23);
            dateTimePicker2.TabIndex = 48;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(6, 44);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(142, 23);
            dateTimePicker1.TabIndex = 47;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(166, 26);
            label3.Name = "label3";
            label3.Size = new Size(94, 15);
            label3.TabIndex = 46;
            label3.Text = "Fecha de cierre *";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 26);
            label2.Name = "label2";
            label2.Size = new Size(94, 15);
            label2.TabIndex = 45;
            label2.Text = "Fecha de inicio *";
            // 
            // label7
            // 
            label7.Location = new Point(11, 34);
            label7.Name = "label7";
            label7.Size = new Size(429, 48);
            label7.TabIndex = 35;
            label7.Text = "Configuracion que le permite controlar la vigencia de las credenciales para los tutores";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(11, 11);
            label1.Name = "label1";
            label1.Size = new Size(157, 17);
            label1.TabIndex = 34;
            label1.Text = "Registro de ciclo escolar";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idCiclo, fechaInicio, fechaCierre });
            dataGridView1.Location = new Point(14, 78);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(424, 107);
            dataGridView1.TabIndex = 38;
            // 
            // idCiclo
            // 
            idCiclo.HeaderText = "# de ciclo";
            idCiclo.Name = "idCiclo";
            idCiclo.ReadOnly = true;
            idCiclo.Visible = false;
            // 
            // fechaInicio
            // 
            fechaInicio.HeaderText = "Fecha de inicio";
            fechaInicio.Name = "fechaInicio";
            fechaInicio.ReadOnly = true;
            // 
            // fechaCierre
            // 
            fechaCierre.HeaderText = "Fecha de cierre";
            fechaCierre.Name = "fechaCierre";
            fechaCierre.ReadOnly = true;
            // 
            // Form_configCiclos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(450, 361);
            Controls.Add(dataGridView1);
            Controls.Add(btn_guardar);
            Controls.Add(groupBox1);
            Controls.Add(label7);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form_configCiclos";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ciclos escolares";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_guardar;
        private GroupBox groupBox1;
        private Label label7;
        private Label label1;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
        private Label label3;
        private Label label2;
        private Label label12;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn idCiclo;
        private DataGridViewTextBoxColumn fechaInicio;
        private DataGridViewTextBoxColumn fechaCierre;
    }
}