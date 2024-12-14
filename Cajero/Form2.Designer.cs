namespace Cajero
{
    partial class Form2
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
            rbOpcion1 = new RadioButton();
            rbOpcion2 = new RadioButton();
            btnContinuar = new Button();
            rbOpcion3 = new RadioButton();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(83, 58);
            label1.Name = "label1";
            label1.Size = new Size(150, 15);
            label1.TabIndex = 0;
            label1.Text = "¿Qué acción desea realizar?";
            label1.Click += label1_Click;
            // 
            // rbOpcion1
            // 
            rbOpcion1.AutoSize = true;
            rbOpcion1.Location = new Point(108, 115);
            rbOpcion1.Name = "rbOpcion1";
            rbOpcion1.Size = new Size(96, 19);
            rbOpcion1.TabIndex = 1;
            rbOpcion1.TabStop = true;
            rbOpcion1.Text = "Retirar dinero";
            rbOpcion1.UseVisualStyleBackColor = true;
            // 
            // rbOpcion2
            // 
            rbOpcion2.AutoSize = true;
            rbOpcion2.Location = new Point(108, 149);
            rbOpcion2.Name = "rbOpcion2";
            rbOpcion2.Size = new Size(104, 19);
            rbOpcion2.TabIndex = 2;
            rbOpcion2.TabStop = true;
            rbOpcion2.Text = "Ingresar dinero";
            rbOpcion2.UseVisualStyleBackColor = true;
            // 
            // btnContinuar
            // 
            btnContinuar.Location = new Point(118, 237);
            btnContinuar.Name = "btnContinuar";
            btnContinuar.Size = new Size(75, 23);
            btnContinuar.TabIndex = 3;
            btnContinuar.Text = "Continuar";
            btnContinuar.UseVisualStyleBackColor = true;
            btnContinuar.Click += btnContinuar_Click;
            // 
            // rbOpcion3
            // 
            rbOpcion3.AutoSize = true;
            rbOpcion3.Location = new Point(108, 184);
            rbOpcion3.Name = "rbOpcion3";
            rbOpcion3.Size = new Size(94, 19);
            rbOpcion3.TabIndex = 4;
            rbOpcion3.TabStop = true;
            rbOpcion3.Text = "Transferencia";
            rbOpcion3.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(324, 384);
            Controls.Add(rbOpcion3);
            Controls.Add(btnContinuar);
            Controls.Add(rbOpcion2);
            Controls.Add(rbOpcion1);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private RadioButton rbOpcion1;
        private RadioButton rbOpcion2;
        private Button btnContinuar;
        private RadioButton rbOpcion3;
    }
}