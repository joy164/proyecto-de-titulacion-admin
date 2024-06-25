namespace CENDI_admin.Forms_hijos
{
    partial class Form3_grupo
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
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btn_listaInfante = new Button();
            btn_nuevoGrupo = new Button();
            btn_editarGrupo = new Button();
            btn_eliminarGrupo = new Button();
            btn_ciclosEscolares = new Button();
            dataGridView1 = new DataGridView();
            noSalon = new DataGridViewTextBoxColumn();
            nivel = new DataGridViewTextBoxColumn();
            grado = new DataGridViewTextBoxColumn();
            grupo = new DataGridViewTextBoxColumn();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 6F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 94F));
            tableLayoutPanel1.Size = new Size(782, 605);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(15, 5);
            label1.Margin = new Padding(15, 0, 3, 0);
            label1.Name = "label1";
            label1.Size = new Size(73, 25);
            label1.TabIndex = 0;
            label1.Text = "Grupos";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(flowLayoutPanel1, 0, 0);
            tableLayoutPanel2.Controls.Add(dataGridView1, 0, 1);
            tableLayoutPanel2.Location = new Point(3, 39);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 90F));
            tableLayoutPanel2.Size = new Size(776, 563);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel1.Controls.Add(btn_listaInfante);
            flowLayoutPanel1.Controls.Add(btn_nuevoGrupo);
            flowLayoutPanel1.Controls.Add(btn_editarGrupo);
            flowLayoutPanel1.Controls.Add(btn_eliminarGrupo);
            flowLayoutPanel1.Controls.Add(btn_ciclosEscolares);
            flowLayoutPanel1.Location = new Point(3, 3);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(770, 50);
            flowLayoutPanel1.TabIndex = 7;
            // 
            // btn_listaInfante
            // 
            btn_listaInfante.Anchor = AnchorStyles.Right;
            btn_listaInfante.BackColor = Color.DarkMagenta;
            btn_listaInfante.FlatAppearance.BorderSize = 0;
            btn_listaInfante.FlatStyle = FlatStyle.Flat;
            btn_listaInfante.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_listaInfante.ForeColor = Color.White;
            btn_listaInfante.Image = Properties.Resources.infante;
            btn_listaInfante.Location = new Point(3, 3);
            btn_listaInfante.Name = "btn_listaInfante";
            btn_listaInfante.Size = new Size(115, 48);
            btn_listaInfante.TabIndex = 4;
            btn_listaInfante.Text = "Lista de infantes";
            btn_listaInfante.TextImageRelation = TextImageRelation.TextBeforeImage;
            btn_listaInfante.UseVisualStyleBackColor = false;
            btn_listaInfante.Click += btn_listaInfante_Click;
            // 
            // btn_nuevoGrupo
            // 
            btn_nuevoGrupo.Anchor = AnchorStyles.Right;
            btn_nuevoGrupo.BackColor = Color.DarkGreen;
            btn_nuevoGrupo.FlatAppearance.BorderSize = 0;
            btn_nuevoGrupo.FlatStyle = FlatStyle.Flat;
            btn_nuevoGrupo.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_nuevoGrupo.ForeColor = Color.White;
            btn_nuevoGrupo.Image = Properties.Resources.agregar_generico;
            btn_nuevoGrupo.Location = new Point(124, 3);
            btn_nuevoGrupo.Name = "btn_nuevoGrupo";
            btn_nuevoGrupo.Size = new Size(115, 48);
            btn_nuevoGrupo.TabIndex = 1;
            btn_nuevoGrupo.Text = "Nuevo grupo";
            btn_nuevoGrupo.TextImageRelation = TextImageRelation.TextBeforeImage;
            btn_nuevoGrupo.UseVisualStyleBackColor = false;
            btn_nuevoGrupo.Click += btn_nuevoGrupo_Click;
            // 
            // btn_editarGrupo
            // 
            btn_editarGrupo.Anchor = AnchorStyles.Right;
            btn_editarGrupo.BackColor = Color.DarkOrange;
            btn_editarGrupo.FlatAppearance.BorderSize = 0;
            btn_editarGrupo.FlatStyle = FlatStyle.Flat;
            btn_editarGrupo.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_editarGrupo.ForeColor = Color.White;
            btn_editarGrupo.Image = Properties.Resources.editar_generico;
            btn_editarGrupo.Location = new Point(245, 3);
            btn_editarGrupo.Name = "btn_editarGrupo";
            btn_editarGrupo.Size = new Size(115, 48);
            btn_editarGrupo.TabIndex = 2;
            btn_editarGrupo.Text = "Editar grupo";
            btn_editarGrupo.TextImageRelation = TextImageRelation.TextBeforeImage;
            btn_editarGrupo.UseVisualStyleBackColor = false;
            btn_editarGrupo.Click += btn_editarGrupo_Click;
            // 
            // btn_eliminarGrupo
            // 
            btn_eliminarGrupo.Anchor = AnchorStyles.Right;
            btn_eliminarGrupo.BackColor = Color.DarkRed;
            btn_eliminarGrupo.FlatAppearance.BorderSize = 0;
            btn_eliminarGrupo.FlatStyle = FlatStyle.Flat;
            btn_eliminarGrupo.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_eliminarGrupo.ForeColor = Color.White;
            btn_eliminarGrupo.Image = Properties.Resources.eliminar;
            btn_eliminarGrupo.Location = new Point(366, 3);
            btn_eliminarGrupo.Name = "btn_eliminarGrupo";
            btn_eliminarGrupo.Size = new Size(115, 48);
            btn_eliminarGrupo.TabIndex = 0;
            btn_eliminarGrupo.Text = "Eliminar grupo";
            btn_eliminarGrupo.TextImageRelation = TextImageRelation.TextBeforeImage;
            btn_eliminarGrupo.UseVisualStyleBackColor = false;
            btn_eliminarGrupo.Click += btn_eliminarGrupo_Click;
            // 
            // btn_ciclosEscolares
            // 
            btn_ciclosEscolares.Anchor = AnchorStyles.Right;
            btn_ciclosEscolares.BackColor = Color.DarkSlateGray;
            btn_ciclosEscolares.FlatAppearance.BorderSize = 0;
            btn_ciclosEscolares.FlatStyle = FlatStyle.Flat;
            btn_ciclosEscolares.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_ciclosEscolares.ForeColor = Color.White;
            btn_ciclosEscolares.Image = Properties.Resources.calendario;
            btn_ciclosEscolares.Location = new Point(487, 3);
            btn_ciclosEscolares.Name = "btn_ciclosEscolares";
            btn_ciclosEscolares.Size = new Size(115, 48);
            btn_ciclosEscolares.TabIndex = 3;
            btn_ciclosEscolares.Text = "Ciclos escolares";
            btn_ciclosEscolares.TextImageRelation = TextImageRelation.TextBeforeImage;
            btn_ciclosEscolares.UseVisualStyleBackColor = false;
            btn_ciclosEscolares.Click += btn_ciclosEscolares_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { noSalon, nivel, grado, grupo });
            dataGridView1.Location = new Point(3, 59);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(770, 501);
            dataGridView1.TabIndex = 8;
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
            // Form3_grupo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(782, 605);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form3_grupo";
            Text = "Form3_grupo";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel2;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btn_nuevoGrupo;
        private Button btn_editarGrupo;
        private Button btn_eliminarGrupo;
        private DataGridView dataGridView1;
        private Button btn_ciclosEscolares;
        private Button btn_listaInfante;
        private DataGridViewTextBoxColumn noSalon;
        private DataGridViewTextBoxColumn nivel;
        private DataGridViewTextBoxColumn grado;
        private DataGridViewTextBoxColumn grupo;
    }
}