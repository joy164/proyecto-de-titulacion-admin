namespace CENDI_admin.Forms_hijos
{
    partial class Form2_usuarios
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
            btn_nuevoUsuario = new Button();
            btn_editarUsuario = new Button();
            btn_eliminarUsuario = new Button();
            dataGridView1 = new DataGridView();
            idEmpleado = new DataGridViewTextBoxColumn();
            no_empleado = new DataGridViewTextBoxColumn();
            rol = new DataGridViewTextBoxColumn();
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
            tableLayoutPanel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(15, 5);
            label1.Margin = new Padding(15, 0, 3, 0);
            label1.Name = "label1";
            label1.Size = new Size(85, 25);
            label1.TabIndex = 0;
            label1.Text = "Usuarios";
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
            flowLayoutPanel1.Controls.Add(btn_nuevoUsuario);
            flowLayoutPanel1.Controls.Add(btn_editarUsuario);
            flowLayoutPanel1.Controls.Add(btn_eliminarUsuario);
            flowLayoutPanel1.Location = new Point(3, 3);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(770, 50);
            flowLayoutPanel1.TabIndex = 7;
            // 
            // btn_nuevoUsuario
            // 
            btn_nuevoUsuario.Anchor = AnchorStyles.Right;
            btn_nuevoUsuario.BackColor = Color.DarkGreen;
            btn_nuevoUsuario.FlatAppearance.BorderSize = 0;
            btn_nuevoUsuario.FlatStyle = FlatStyle.Flat;
            btn_nuevoUsuario.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_nuevoUsuario.ForeColor = Color.White;
            btn_nuevoUsuario.Image = Properties.Resources.agregar_usuario;
            btn_nuevoUsuario.Location = new Point(3, 3);
            btn_nuevoUsuario.Name = "btn_nuevoUsuario";
            btn_nuevoUsuario.Size = new Size(115, 48);
            btn_nuevoUsuario.TabIndex = 1;
            btn_nuevoUsuario.Text = "Nuevo usuario";
            btn_nuevoUsuario.TextImageRelation = TextImageRelation.TextBeforeImage;
            btn_nuevoUsuario.UseVisualStyleBackColor = false;
            btn_nuevoUsuario.Click += btn_nuevoUsuario_Click;
            // 
            // btn_editarUsuario
            // 
            btn_editarUsuario.Anchor = AnchorStyles.Right;
            btn_editarUsuario.BackColor = Color.DarkOrange;
            btn_editarUsuario.FlatAppearance.BorderSize = 0;
            btn_editarUsuario.FlatStyle = FlatStyle.Flat;
            btn_editarUsuario.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_editarUsuario.ForeColor = Color.White;
            btn_editarUsuario.Image = Properties.Resources.editar_usuario;
            btn_editarUsuario.Location = new Point(124, 3);
            btn_editarUsuario.Name = "btn_editarUsuario";
            btn_editarUsuario.Size = new Size(115, 48);
            btn_editarUsuario.TabIndex = 2;
            btn_editarUsuario.Text = "Editar usuario";
            btn_editarUsuario.TextImageRelation = TextImageRelation.TextBeforeImage;
            btn_editarUsuario.UseVisualStyleBackColor = false;
            btn_editarUsuario.Click += btn_editarUsuario_Click;
            // 
            // btn_eliminarUsuario
            // 
            btn_eliminarUsuario.Anchor = AnchorStyles.Right;
            btn_eliminarUsuario.BackColor = Color.DarkRed;
            btn_eliminarUsuario.FlatAppearance.BorderSize = 0;
            btn_eliminarUsuario.FlatStyle = FlatStyle.Flat;
            btn_eliminarUsuario.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_eliminarUsuario.ForeColor = Color.White;
            btn_eliminarUsuario.Image = Properties.Resources.borrar_usuario;
            btn_eliminarUsuario.Location = new Point(245, 3);
            btn_eliminarUsuario.Name = "btn_eliminarUsuario";
            btn_eliminarUsuario.Size = new Size(115, 48);
            btn_eliminarUsuario.TabIndex = 0;
            btn_eliminarUsuario.Text = "Eliminar usuario";
            btn_eliminarUsuario.TextImageRelation = TextImageRelation.TextBeforeImage;
            btn_eliminarUsuario.UseVisualStyleBackColor = false;
            btn_eliminarUsuario.Click += btn_eliminarUsuario_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idEmpleado, no_empleado, rol });
            dataGridView1.Location = new Point(3, 59);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(770, 501);
            dataGridView1.TabIndex = 8;
            // 
            // idEmpleado
            // 
            idEmpleado.HeaderText = "ID";
            idEmpleado.Name = "idEmpleado";
            idEmpleado.ReadOnly = true;
            idEmpleado.Visible = false;
            // 
            // no_empleado
            // 
            no_empleado.HeaderText = "No. empleado";
            no_empleado.Name = "no_empleado";
            no_empleado.ReadOnly = true;
            // 
            // rol
            // 
            rol.HeaderText = "Rol";
            rol.Name = "rol";
            rol.ReadOnly = true;
            // 
            // Form2_usuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(782, 605);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form2_usuarios";
            Text = "Form2_usuarios";
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
        private Button btn_eliminarUsuario;
        private Button btn_nuevoUsuario;
        private Button btn_editarUsuario;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn idEmpleado;
        private DataGridViewTextBoxColumn no_empleado;
        private DataGridViewTextBoxColumn rol;
    }
}