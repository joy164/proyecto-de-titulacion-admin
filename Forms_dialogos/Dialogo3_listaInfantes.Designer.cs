namespace CENDI_admin.Forms_dialogos
{
    partial class Dialogo3_listaInfantes
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
            nomInfante = new DataGridViewTextBoxColumn();
            btn_exportar = new Button();
            checkBox1 = new CheckBox();
            cb_mes = new ComboBox();
            cb_año = new ComboBox();
            lb_año = new Label();
            lb_mes = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { nomInfante });
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(411, 173);
            dataGridView1.TabIndex = 0;
            // 
            // nomInfante
            // 
            nomInfante.HeaderText = "Nombre de infante";
            nomInfante.Name = "nomInfante";
            nomInfante.ReadOnly = true;
            // 
            // btn_exportar
            // 
            btn_exportar.Anchor = AnchorStyles.None;
            btn_exportar.BackColor = Color.ForestGreen;
            btn_exportar.FlatAppearance.BorderSize = 0;
            btn_exportar.FlatStyle = FlatStyle.Flat;
            btn_exportar.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_exportar.ForeColor = Color.White;
            btn_exportar.Image = Properties.Resources.excel;
            btn_exportar.Location = new Point(311, 222);
            btn_exportar.Name = "btn_exportar";
            btn_exportar.Size = new Size(112, 45);
            btn_exportar.TabIndex = 35;
            btn_exportar.Text = "Exportar";
            btn_exportar.TextImageRelation = TextImageRelation.TextBeforeImage;
            btn_exportar.UseVisualStyleBackColor = false;
            btn_exportar.Click += btn_exportar_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Checked = true;
            checkBox1.CheckState = CheckState.Checked;
            checkBox1.Location = new Point(12, 191);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(207, 19);
            checkBox1.TabIndex = 36;
            checkBox1.Text = "Con reporte mensual de asistencia";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // cb_mes
            // 
            cb_mes.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cb_mes.FormattingEnabled = true;
            cb_mes.Location = new Point(47, 244);
            cb_mes.Name = "cb_mes";
            cb_mes.Size = new Size(124, 23);
            cb_mes.TabIndex = 40;
            // 
            // cb_año
            // 
            cb_año.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cb_año.FormattingEnabled = true;
            cb_año.Location = new Point(47, 215);
            cb_año.Name = "cb_año";
            cb_año.Size = new Size(124, 23);
            cb_año.TabIndex = 38;
            // 
            // lb_año
            // 
            lb_año.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lb_año.AutoSize = true;
            lb_año.Location = new Point(12, 218);
            lb_año.Name = "lb_año";
            lb_año.Size = new Size(29, 15);
            lb_año.TabIndex = 39;
            lb_año.Text = "Año";
            // 
            // lb_mes
            // 
            lb_mes.AutoSize = true;
            lb_mes.Location = new Point(12, 244);
            lb_mes.Name = "lb_mes";
            lb_mes.Size = new Size(29, 15);
            lb_mes.TabIndex = 37;
            lb_mes.Text = "Mes";
            // 
            // Dialogo3_listaInfantes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(435, 276);
            Controls.Add(cb_mes);
            Controls.Add(cb_año);
            Controls.Add(lb_año);
            Controls.Add(lb_mes);
            Controls.Add(checkBox1);
            Controls.Add(btn_exportar);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Dialogo3_listaInfantes";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Lista de infantes";
            Load += Dialogo3_listaInfantes_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btn_exportar;
        private CheckBox checkBox1;
        private ComboBox cb_mes;
        private ComboBox cb_año;
        private Label lb_año;
        private Label lb_mes;
        private DataGridViewTextBoxColumn nomInfante;
    }
}