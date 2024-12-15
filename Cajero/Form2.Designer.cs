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
            rbOpcion2 = new RadioButton();
            rbOpcion3 = new RadioButton();
            btnContinuar = new Button();
            rbOpcion4 = new RadioButton();
            rbOpcion1 = new RadioButton();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(95, 77);
            label1.Name = "label1";
            label1.Size = new Size(193, 20);
            label1.TabIndex = 0;
            label1.Text = "¿Qué acción desea realizar?";
            label1.Click += label1_Click;
            // 
            // rbOpcion2
            // 
            rbOpcion2.AutoSize = true;
            rbOpcion2.Location = new Point(119, 171);
            rbOpcion2.Margin = new Padding(3, 4, 3, 4);
            rbOpcion2.Name = "rbOpcion2";
            rbOpcion2.Size = new Size(121, 24);
            rbOpcion2.TabIndex = 1;
            rbOpcion2.TabStop = true;
            rbOpcion2.Text = "Retirar dinero";
            rbOpcion2.UseVisualStyleBackColor = true;
            // 
            // rbOpcion3
            // 
            rbOpcion3.AutoSize = true;
            rbOpcion3.Location = new Point(119, 217);
            rbOpcion3.Margin = new Padding(3, 4, 3, 4);
            rbOpcion3.Name = "rbOpcion3";
            rbOpcion3.Size = new Size(130, 24);
            rbOpcion3.TabIndex = 2;
            rbOpcion3.TabStop = true;
            rbOpcion3.Text = "Ingresar dinero";
            rbOpcion3.UseVisualStyleBackColor = true;
            // 
            // btnContinuar
            // 
            btnContinuar.Location = new Point(135, 316);
            btnContinuar.Margin = new Padding(3, 4, 3, 4);
            btnContinuar.Name = "btnContinuar";
            btnContinuar.Size = new Size(86, 31);
            btnContinuar.TabIndex = 3;
            btnContinuar.Text = "Continuar";
            btnContinuar.UseVisualStyleBackColor = true;
            btnContinuar.Click += btnContinuar_Click;
            // 
            // rbOpcion4
            // 
            rbOpcion4.AutoSize = true;
            rbOpcion4.Location = new Point(119, 263);
            rbOpcion4.Margin = new Padding(3, 4, 3, 4);
            rbOpcion4.Name = "rbOpcion4";
            rbOpcion4.Size = new Size(117, 24);
            rbOpcion4.TabIndex = 4;
            rbOpcion4.TabStop = true;
            rbOpcion4.Text = "Transferencia";
            rbOpcion4.UseVisualStyleBackColor = true;
            // 
            // rbOpcion1
            // 
            rbOpcion1.AutoSize = true;
            rbOpcion1.Location = new Point(119, 131);
            rbOpcion1.Name = "rbOpcion1";
            rbOpcion1.Size = new Size(132, 24);
            rbOpcion1.TabIndex = 5;
            rbOpcion1.TabStop = true;
            rbOpcion1.Text = "Consultar saldo";
            rbOpcion1.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(370, 512);
            Controls.Add(rbOpcion1);
            Controls.Add(rbOpcion4);
            Controls.Add(btnContinuar);
            Controls.Add(rbOpcion3);
            Controls.Add(rbOpcion2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private RadioButton rbOpcion2;
        private RadioButton rbOpcion3;
        private Button btnContinuar;
        private RadioButton rbOpcion4;
        private RadioButton rbOpcion1;
    }
}