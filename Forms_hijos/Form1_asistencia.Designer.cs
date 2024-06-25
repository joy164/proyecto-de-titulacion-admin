namespace CENDI_admin.Forms_hijos
{
    partial class Form1_asistencia
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
            panel1 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btn_regEntrada = new Button();
            btn_regSalida = new Button();
            p_workbeanch = new Panel();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(panel1, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 6F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 94F));
            tableLayoutPanel1.Size = new Size(782, 605);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(15, 5);
            label1.Margin = new Padding(15, 0, 3, 0);
            label1.Name = "label1";
            label1.Size = new Size(98, 25);
            label1.TabIndex = 0;
            label1.Text = "Asistencia";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(flowLayoutPanel1);
            panel1.Controls.Add(p_workbeanch);
            panel1.Location = new Point(3, 39);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 563);
            panel1.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(btn_regEntrada);
            flowLayoutPanel1.Controls.Add(btn_regSalida);
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(776, 33);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // btn_regEntrada
            // 
            btn_regEntrada.BackColor = Color.Indigo;
            btn_regEntrada.FlatAppearance.BorderColor = Color.Silver;
            btn_regEntrada.FlatAppearance.BorderSize = 0;
            btn_regEntrada.FlatStyle = FlatStyle.Flat;
            btn_regEntrada.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_regEntrada.ForeColor = Color.White;
            btn_regEntrada.Location = new Point(0, 0);
            btn_regEntrada.Margin = new Padding(0);
            btn_regEntrada.Name = "btn_regEntrada";
            btn_regEntrada.Size = new Size(135, 33);
            btn_regEntrada.TabIndex = 1;
            btn_regEntrada.Text = "Registro de entrada";
            btn_regEntrada.UseVisualStyleBackColor = false;
            btn_regEntrada.Click += btn_regEntrada_Click;
            // 
            // btn_regSalida
            // 
            btn_regSalida.BackColor = Color.White;
            btn_regSalida.FlatAppearance.BorderColor = Color.Silver;
            btn_regSalida.FlatStyle = FlatStyle.Flat;
            btn_regSalida.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_regSalida.ForeColor = Color.Black;
            btn_regSalida.Location = new Point(135, 0);
            btn_regSalida.Margin = new Padding(0);
            btn_regSalida.Name = "btn_regSalida";
            btn_regSalida.Size = new Size(135, 33);
            btn_regSalida.TabIndex = 2;
            btn_regSalida.Text = "Registro de salida";
            btn_regSalida.UseVisualStyleBackColor = false;
            btn_regSalida.Click += btn_regSalida_Click;
            // 
            // p_workbeanch
            // 
            p_workbeanch.BackColor = Color.White;
            p_workbeanch.Dock = DockStyle.Bottom;
            p_workbeanch.Location = new Point(0, 36);
            p_workbeanch.Name = "p_workbeanch";
            p_workbeanch.Size = new Size(776, 527);
            p_workbeanch.TabIndex = 1;
            // 
            // Form1_asistencia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(782, 605);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1_asistencia";
            Text = "Form1_asistencia";
            FormClosing += Form1_asistencia_FormClosing;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel1.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Panel panel1;
        private Button btn_regEntrada;
        private Button btn_regSalida;
        private Panel p_workbeanch;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}