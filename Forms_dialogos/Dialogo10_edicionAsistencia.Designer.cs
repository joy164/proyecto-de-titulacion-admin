namespace CENDI_admin.Forms_dialogos
{
    partial class Dialogo10_edicionAsistencia
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
            tb_observaciones = new TextBox();
            btn_guardar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(87, 15);
            label1.TabIndex = 0;
            label1.Text = "Observaciones:";
            // 
            // tb_observaciones
            // 
            tb_observaciones.Location = new Point(12, 27);
            tb_observaciones.Multiline = true;
            tb_observaciones.Name = "tb_observaciones";
            tb_observaciones.Size = new Size(222, 171);
            tb_observaciones.TabIndex = 1;
            tb_observaciones.TextChanged += tb_observaciones_TextChanged;
            // 
            // btn_guardar
            // 
            btn_guardar.Anchor = AnchorStyles.Right;
            btn_guardar.BackColor = Color.DarkGreen;
            btn_guardar.FlatAppearance.BorderSize = 0;
            btn_guardar.FlatStyle = FlatStyle.Flat;
            btn_guardar.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_guardar.ForeColor = Color.White;
            btn_guardar.Image = Properties.Resources.guardar;
            btn_guardar.Location = new Point(137, 208);
            btn_guardar.Name = "btn_guardar";
            btn_guardar.Size = new Size(97, 40);
            btn_guardar.TabIndex = 3;
            btn_guardar.Text = "Guardar";
            btn_guardar.TextImageRelation = TextImageRelation.TextBeforeImage;
            btn_guardar.UseVisualStyleBackColor = false;
            btn_guardar.Click += btn_guardar_Click;
            // 
            // Dialogo10_edicionAsistencia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(246, 257);
            Controls.Add(btn_guardar);
            Controls.Add(tb_observaciones);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Dialogo10_edicionAsistencia";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Edicion de observaciones";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tb_observaciones;
        private Button btn_guardar;
    }
}