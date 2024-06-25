namespace CENDI_admin.Forms_dialogos
{
    partial class Dialogo11_parentescos
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
            IDParentesco = new DataGridViewTextBoxColumn();
            nombreParentesco = new DataGridViewTextBoxColumn();
            label1 = new Label();
            label2 = new Label();
            tb_nomParentesco = new TextBox();
            label12 = new Label();
            btn_eliminar = new Button();
            btn_guardar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { IDParentesco, nombreParentesco });
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(289, 229);
            dataGridView1.TabIndex = 0;
            dataGridView1.DoubleClick += dataGridView1_DoubleClick;
            // 
            // IDParentesco
            // 
            IDParentesco.HeaderText = "IDParentesco";
            IDParentesco.Name = "IDParentesco";
            IDParentesco.ReadOnly = true;
            IDParentesco.Visible = false;
            // 
            // nombreParentesco
            // 
            nombreParentesco.HeaderText = "Nombre de parentesco";
            nombreParentesco.Name = "nombreParentesco";
            nombreParentesco.ReadOnly = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(307, 12);
            label1.Name = "label1";
            label1.Size = new Size(134, 20);
            label1.TabIndex = 39;
            label1.Text = "Nuevo parentesco";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(307, 41);
            label2.Name = "label2";
            label2.Size = new Size(136, 15);
            label2.TabIndex = 40;
            label2.Text = "Nombre de parentesco *";
            // 
            // tb_nomParentesco
            // 
            tb_nomParentesco.Location = new Point(307, 59);
            tb_nomParentesco.Name = "tb_nomParentesco";
            tb_nomParentesco.Size = new Size(151, 23);
            tb_nomParentesco.TabIndex = 41;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.ForeColor = Color.DarkRed;
            label12.Location = new Point(307, 97);
            label12.Name = "label12";
            label12.Size = new Size(123, 15);
            label12.TabIndex = 48;
            label12.Text = "* campos obligatorios";
            // 
            // btn_eliminar
            // 
            btn_eliminar.Anchor = AnchorStyles.None;
            btn_eliminar.BackColor = Color.DarkRed;
            btn_eliminar.FlatAppearance.BorderSize = 0;
            btn_eliminar.FlatStyle = FlatStyle.Flat;
            btn_eliminar.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_eliminar.ForeColor = Color.White;
            btn_eliminar.Image = Properties.Resources.eliminar;
            btn_eliminar.Location = new Point(358, 165);
            btn_eliminar.Name = "btn_eliminar";
            btn_eliminar.Size = new Size(100, 35);
            btn_eliminar.TabIndex = 47;
            btn_eliminar.Text = "Eliminar";
            btn_eliminar.TextImageRelation = TextImageRelation.TextBeforeImage;
            btn_eliminar.UseVisualStyleBackColor = false;
            btn_eliminar.Visible = false;
            // 
            // btn_guardar
            // 
            btn_guardar.Anchor = AnchorStyles.None;
            btn_guardar.BackColor = Color.DarkGreen;
            btn_guardar.FlatAppearance.BorderSize = 0;
            btn_guardar.FlatStyle = FlatStyle.Flat;
            btn_guardar.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_guardar.ForeColor = Color.White;
            btn_guardar.Image = Properties.Resources.guardar;
            btn_guardar.Location = new Point(358, 206);
            btn_guardar.Name = "btn_guardar";
            btn_guardar.Size = new Size(100, 35);
            btn_guardar.TabIndex = 46;
            btn_guardar.Text = "Guardar";
            btn_guardar.TextImageRelation = TextImageRelation.TextBeforeImage;
            btn_guardar.UseVisualStyleBackColor = false;
            btn_guardar.Click += btn_guardar_Click;
            // 
            // Dialogo11_parentescos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 253);
            Controls.Add(label12);
            Controls.Add(btn_eliminar);
            Controls.Add(btn_guardar);
            Controls.Add(tb_nomParentesco);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Dialogo11_parentescos";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Parentesco";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private TextBox tb_nomParentesco;
        private Label label12;
        private Button btn_eliminar;
        private Button btn_guardar;
        private DataGridViewTextBoxColumn IDParentesco;
        private DataGridViewTextBoxColumn nombreParentesco;
    }
}