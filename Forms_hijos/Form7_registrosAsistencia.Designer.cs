namespace CENDI_admin.Forms_hijos
{
    partial class Form7_registrosAsistencia
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
            label1 = new Label();
            dataGridView1 = new DataGridView();
            noReg = new DataGridViewTextBoxColumn();
            hora = new DataGridViewTextBoxColumn();
            infante = new DataGridViewTextBoxColumn();
            tutor = new DataGridViewTextBoxColumn();
            observaciones = new DataGridViewTextBoxColumn();
            btn_eliminar = new Button();
            dtp_fecha = new DateTimePicker();
            cb_grupo = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            btn_editar = new Button();
            btn_exportar = new Button();
            checkBoxGrupoActual = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(96, 20);
            label1.TabIndex = 0;
            label1.Text = "Registros de";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { noReg, hora, infante, tutor, observaciones });
            dataGridView1.Location = new Point(12, 93);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(752, 424);
            dataGridView1.TabIndex = 1;
            // 
            // noReg
            // 
            noReg.Frozen = true;
            noReg.HeaderText = "noReg";
            noReg.Name = "noReg";
            noReg.ReadOnly = true;
            noReg.Visible = false;
            // 
            // hora
            // 
            hora.HeaderText = "Hora";
            hora.Name = "hora";
            hora.ReadOnly = true;
            // 
            // infante
            // 
            infante.HeaderText = "Infante";
            infante.Name = "infante";
            infante.ReadOnly = true;
            // 
            // tutor
            // 
            tutor.HeaderText = "Tutor";
            tutor.Name = "tutor";
            tutor.ReadOnly = true;
            // 
            // observaciones
            // 
            observaciones.HeaderText = "Observaciones";
            observaciones.Name = "observaciones";
            observaciones.ReadOnly = true;
            // 
            // btn_eliminar
            // 
            btn_eliminar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_eliminar.BackColor = Color.DarkRed;
            btn_eliminar.FlatAppearance.BorderSize = 0;
            btn_eliminar.FlatStyle = FlatStyle.Flat;
            btn_eliminar.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_eliminar.ForeColor = Color.White;
            btn_eliminar.Image = Properties.Resources.eliminar;
            btn_eliminar.Location = new Point(528, 44);
            btn_eliminar.Name = "btn_eliminar";
            btn_eliminar.Size = new Size(115, 43);
            btn_eliminar.TabIndex = 3;
            btn_eliminar.Text = "Eliminar registro";
            btn_eliminar.TextImageRelation = TextImageRelation.TextBeforeImage;
            btn_eliminar.UseVisualStyleBackColor = false;
            btn_eliminar.Click += btn_eliminar_Click;
            // 
            // dtp_fecha
            // 
            dtp_fecha.Format = DateTimePickerFormat.Short;
            dtp_fecha.Location = new Point(12, 64);
            dtp_fecha.Name = "dtp_fecha";
            dtp_fecha.Size = new Size(101, 23);
            dtp_fecha.TabIndex = 4;
            dtp_fecha.ValueChanged += dtp_fecha_ValueChanged;
            // 
            // cb_grupo
            // 
            cb_grupo.FormattingEnabled = true;
            cb_grupo.Location = new Point(130, 64);
            cb_grupo.Name = "cb_grupo";
            cb_grupo.Size = new Size(181, 23);
            cb_grupo.TabIndex = 5;
            cb_grupo.SelectedValueChanged += cb_grupo_SelectedValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 46);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 6;
            label2.Text = "Fecha";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(130, 46);
            label3.Name = "label3";
            label3.Size = new Size(83, 15);
            label3.TabIndex = 7;
            label3.Text = "Grado y grupo";
            // 
            // btn_editar
            // 
            btn_editar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_editar.BackColor = Color.DarkOrange;
            btn_editar.FlatAppearance.BorderSize = 0;
            btn_editar.FlatStyle = FlatStyle.Flat;
            btn_editar.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_editar.ForeColor = Color.White;
            btn_editar.Image = Properties.Resources.editar_generico;
            btn_editar.Location = new Point(649, 44);
            btn_editar.Name = "btn_editar";
            btn_editar.Size = new Size(115, 43);
            btn_editar.TabIndex = 8;
            btn_editar.Text = "Editar observacion";
            btn_editar.TextImageRelation = TextImageRelation.TextBeforeImage;
            btn_editar.UseVisualStyleBackColor = false;
            btn_editar.Click += btn_editar_Click;
            // 
            // btn_exportar
            // 
            btn_exportar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_exportar.BackColor = Color.DarkGreen;
            btn_exportar.FlatAppearance.BorderSize = 0;
            btn_exportar.FlatStyle = FlatStyle.Flat;
            btn_exportar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_exportar.ForeColor = Color.White;
            btn_exportar.Image = Properties.Resources.excel_chico;
            btn_exportar.ImageAlign = ContentAlignment.MiddleLeft;
            btn_exportar.Location = new Point(679, 520);
            btn_exportar.Margin = new Padding(0);
            btn_exportar.Name = "btn_exportar";
            btn_exportar.Size = new Size(85, 34);
            btn_exportar.TabIndex = 9;
            btn_exportar.Text = "Exportar";
            btn_exportar.TextImageRelation = TextImageRelation.TextBeforeImage;
            btn_exportar.UseVisualStyleBackColor = false;
            btn_exportar.Click += btn_exportar_Click;
            // 
            // checkBoxGrupoActual
            // 
            checkBoxGrupoActual.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            checkBoxGrupoActual.AutoSize = true;
            checkBoxGrupoActual.Location = new Point(558, 529);
            checkBoxGrupoActual.Name = "checkBoxGrupoActual";
            checkBoxGrupoActual.Size = new Size(118, 19);
            checkBoxGrupoActual.TabIndex = 11;
            checkBoxGrupoActual.Text = "solo grupo actual";
            checkBoxGrupoActual.UseVisualStyleBackColor = true;
            // 
            // Form7_registrosAsistencia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(776, 563);
            Controls.Add(checkBoxGrupoActual);
            Controls.Add(btn_exportar);
            Controls.Add(btn_editar);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(cb_grupo);
            Controls.Add(dtp_fecha);
            Controls.Add(btn_eliminar);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form7_registrosAsistencia";
            Text = "Form7_registrosAsistencia";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private Button btn_eliminar;
        private DateTimePicker dtp_fecha;
        private ComboBox cb_grupo;
        private Label label2;
        private Label label3;
        private Button btn_editar;
        private DataGridViewTextBoxColumn noReg;
        private DataGridViewTextBoxColumn hora;
        private DataGridViewTextBoxColumn infante;
        private DataGridViewTextBoxColumn tutor;
        private DataGridViewTextBoxColumn observaciones;
        private Button btn_exportar;
        private CheckBox checkBoxGrupoActual;
    }
}