namespace CENDI_admin.Forms_dialogos
{
    partial class Dialogo2_grupo
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
            label2 = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            button8 = new Button();
            label12 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 9);
            label1.Name = "label1";
            label1.Size = new Size(85, 15);
            label1.TabIndex = 0;
            label1.Text = "Nivel y grado *";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 66);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 1;
            label2.Text = "Grupo *";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(14, 27);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(177, 23);
            comboBox1.TabIndex = 2;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(14, 84);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(177, 23);
            comboBox2.TabIndex = 3;
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
            button8.Location = new Point(76, 149);
            button8.Name = "button8";
            button8.Size = new Size(115, 48);
            button8.TabIndex = 36;
            button8.Text = "Guardar";
            button8.TextImageRelation = TextImageRelation.TextBeforeImage;
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.ForeColor = Color.DarkRed;
            label12.Location = new Point(12, 118);
            label12.Name = "label12";
            label12.Size = new Size(123, 15);
            label12.TabIndex = 46;
            label12.Text = "* campos obligatorios";
            // 
            // Dialogo2_grupo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(203, 209);
            Controls.Add(label12);
            Controls.Add(button8);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Dialogo2_grupo";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Grupo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Button button8;
        private Label label12;
    }
}