namespace CENDI_admin.Forms_dialogos
{
    partial class Dialogo4_cicloEscolar
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
            dataGridView1 = new DataGridView();
            idCiclo = new DataGridViewTextBoxColumn();
            fechaInicio = new DataGridViewTextBoxColumn();
            fechaCierre = new DataGridViewTextBoxColumn();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            button8 = new Button();
            button1 = new Button();
            label12 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idCiclo, fechaInicio, fechaCierre });
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(289, 229);
            dataGridView1.TabIndex = 37;
            dataGridView1.CellMouseDoubleClick += dataGridView1_CellMouseDoubleClick;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(318, 12);
            label1.Name = "label1";
            label1.Size = new Size(142, 20);
            label1.TabIndex = 38;
            label1.Text = "Nuevo ciclo escolar";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(318, 41);
            label2.Name = "label2";
            label2.Size = new Size(94, 15);
            label2.TabIndex = 39;
            label2.Text = "Fecha de inicio *";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(318, 94);
            label3.Name = "label3";
            label3.Size = new Size(94, 15);
            label3.TabIndex = 40;
            label3.Text = "Fecha de cierre *";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(318, 59);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(142, 23);
            dateTimePicker1.TabIndex = 41;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Location = new Point(318, 112);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(142, 23);
            dateTimePicker2.TabIndex = 42;
            // 
            // button8
            // 
            button8.Anchor = AnchorStyles.None;
            button8.BackColor = Color.DarkGreen;
            button8.FlatAppearance.BorderSize = 0;
            button8.FlatStyle = FlatStyle.Flat;
            button8.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button8.ForeColor = Color.White;
            button8.Image = Properties.Resources.guardar;
            button8.Location = new Point(360, 206);
            button8.Name = "button8";
            button8.Size = new Size(100, 35);
            button8.TabIndex = 43;
            button8.Text = "Guardar";
            button8.TextImageRelation = TextImageRelation.TextBeforeImage;
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.DarkRed;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Image = Properties.Resources.eliminar;
            button1.Location = new Point(360, 165);
            button1.Name = "button1";
            button1.Size = new Size(100, 35);
            button1.TabIndex = 44;
            button1.Text = "Eliminar";
            button1.TextImageRelation = TextImageRelation.TextBeforeImage;
            button1.UseVisualStyleBackColor = false;
            button1.Visible = false;
            button1.Click += button1_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.ForeColor = Color.DarkRed;
            label12.Location = new Point(318, 142);
            label12.Name = "label12";
            label12.Size = new Size(123, 15);
            label12.TabIndex = 45;
            label12.Text = "* campos obligatorios";
            // 
            // Dialogo4_cicloEscolar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(482, 253);
            Controls.Add(label12);
            Controls.Add(button1);
            Controls.Add(button8);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Dialogo4_cicloEscolar";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Ciclo escolar";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private Label label3;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private Button button8;
        private DataGridViewTextBoxColumn idCiclo;
        private DataGridViewTextBoxColumn fechaInicio;
        private DataGridViewTextBoxColumn fechaCierre;
        private Button button1;
        private Label label12;
    }
}