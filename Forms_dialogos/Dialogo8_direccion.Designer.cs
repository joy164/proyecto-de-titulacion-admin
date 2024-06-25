namespace CENDI_admin.Forms_dialogos
{
    partial class Dialogo8_direccion
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
            gb_direccion = new GroupBox();
            cb_estado = new ComboBox();
            label15 = new Label();
            btn_guardar = new Button();
            label17 = new Label();
            cb_municipio = new ComboBox();
            label14 = new Label();
            cb_colonia = new ComboBox();
            label13 = new Label();
            tb_noInt = new TextBox();
            label9 = new Label();
            tb_noExt = new TextBox();
            label8 = new Label();
            tb_calle = new TextBox();
            label7 = new Label();
            label18 = new Label();
            gb_direccion.SuspendLayout();
            SuspendLayout();
            // 
            // gb_direccion
            // 
            gb_direccion.Controls.Add(cb_estado);
            gb_direccion.Controls.Add(label15);
            gb_direccion.Controls.Add(btn_guardar);
            gb_direccion.Controls.Add(label17);
            gb_direccion.Controls.Add(cb_municipio);
            gb_direccion.Controls.Add(label14);
            gb_direccion.Controls.Add(cb_colonia);
            gb_direccion.Controls.Add(label13);
            gb_direccion.Controls.Add(tb_noInt);
            gb_direccion.Controls.Add(label9);
            gb_direccion.Controls.Add(tb_noExt);
            gb_direccion.Controls.Add(label8);
            gb_direccion.Controls.Add(tb_calle);
            gb_direccion.Controls.Add(label7);
            gb_direccion.Controls.Add(label18);
            gb_direccion.Location = new Point(9, 8);
            gb_direccion.Name = "gb_direccion";
            gb_direccion.Size = new Size(544, 237);
            gb_direccion.TabIndex = 5;
            gb_direccion.TabStop = false;
            gb_direccion.Text = "Nueva dirección";
            // 
            // cb_estado
            // 
            cb_estado.FormattingEnabled = true;
            cb_estado.Location = new Point(12, 118);
            cb_estado.Name = "cb_estado";
            cb_estado.Size = new Size(127, 23);
            cb_estado.TabIndex = 53;
            cb_estado.SelectedValueChanged += cb_estado_SelectedValueChanged;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(12, 100);
            label15.Name = "label15";
            label15.Size = new Size(53, 15);
            label15.TabIndex = 52;
            label15.Text = "Estado  *";
            // 
            // btn_guardar
            // 
            btn_guardar.BackColor = Color.DarkGreen;
            btn_guardar.FlatAppearance.BorderSize = 0;
            btn_guardar.FlatStyle = FlatStyle.Flat;
            btn_guardar.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_guardar.ForeColor = Color.White;
            btn_guardar.Image = Properties.Resources.direccion;
            btn_guardar.Location = new Point(437, 189);
            btn_guardar.Name = "btn_guardar";
            btn_guardar.Size = new Size(93, 37);
            btn_guardar.TabIndex = 50;
            btn_guardar.Text = "Guardar";
            btn_guardar.TextImageRelation = TextImageRelation.TextBeforeImage;
            btn_guardar.UseVisualStyleBackColor = false;
            btn_guardar.Click += btn_guardar_Click;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.BackColor = Color.Transparent;
            label17.ForeColor = Color.DarkRed;
            label17.Location = new Point(12, 204);
            label17.Name = "label17";
            label17.Size = new Size(123, 15);
            label17.TabIndex = 49;
            label17.Text = "* campos obligatorios";
            // 
            // cb_municipio
            // 
            cb_municipio.FormattingEnabled = true;
            cb_municipio.Location = new Point(157, 118);
            cb_municipio.Name = "cb_municipio";
            cb_municipio.Size = new Size(167, 23);
            cb_municipio.TabIndex = 44;
            cb_municipio.SelectedValueChanged += cb_municipio_SelectedValueChanged;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(157, 100);
            label14.Name = "label14";
            label14.Size = new Size(72, 15);
            label14.TabIndex = 43;
            label14.Text = "Municipio  *";
            // 
            // cb_colonia
            // 
            cb_colonia.FormattingEnabled = true;
            cb_colonia.Location = new Point(12, 172);
            cb_colonia.Name = "cb_colonia";
            cb_colonia.Size = new Size(312, 23);
            cb_colonia.TabIndex = 42;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(12, 154);
            label13.Name = "label13";
            label13.Size = new Size(59, 15);
            label13.TabIndex = 41;
            label13.Text = "Colonia  *";
            // 
            // tb_noInt
            // 
            tb_noInt.Location = new Point(455, 66);
            tb_noInt.Name = "tb_noInt";
            tb_noInt.Size = new Size(75, 23);
            tb_noInt.TabIndex = 39;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(455, 48);
            label9.Name = "label9";
            label9.Size = new Size(51, 15);
            label9.TabIndex = 40;
            label9.Text = "No. int *";
            // 
            // tb_noExt
            // 
            tb_noExt.Location = new Point(351, 66);
            tb_noExt.Name = "tb_noExt";
            tb_noExt.Size = new Size(75, 23);
            tb_noExt.TabIndex = 37;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(351, 48);
            label8.Name = "label8";
            label8.Size = new Size(53, 15);
            label8.TabIndex = 38;
            label8.Text = "No. ext *";
            // 
            // tb_calle
            // 
            tb_calle.Location = new Point(12, 66);
            tb_calle.Name = "tb_calle";
            tb_calle.Size = new Size(312, 23);
            tb_calle.TabIndex = 35;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 48);
            label7.Name = "label7";
            label7.Size = new Size(41, 15);
            label7.TabIndex = 36;
            label7.Text = "Calle *";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(12, 22);
            label18.Name = "label18";
            label18.Size = new Size(198, 15);
            label18.TabIndex = 3;
            label18.Text = "Camabiar a otra direccion registrada";
            // 
            // Dialogo8_direccion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(562, 257);
            Controls.Add(gb_direccion);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Dialogo8_direccion";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Nueva direccion";
            gb_direccion.ResumeLayout(false);
            gb_direccion.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gb_direccion;
        private ComboBox cb_estado;
        private Label label15;
        private Button btn_guardar;
        private Label label17;
        private ComboBox cb_municipio;
        private Label label14;
        private ComboBox cb_colonia;
        private Label label13;
        private TextBox tb_noInt;
        private Label label9;
        private TextBox tb_noExt;
        private Label label8;
        private TextBox tb_calle;
        private Label label7;
        private Label label18;
    }
}