namespace Cajero
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblIdentificacion = new Label();
            txtID = new TextBox();
            btnEnviar = new Button();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btn0 = new Button();
            btnBorrar = new Button();
            SuspendLayout();
            // 
            // lblIdentificacion
            // 
            lblIdentificacion.AutoSize = true;
            lblIdentificacion.Font = new Font("Segoe UI", 12F);
            lblIdentificacion.Location = new Point(73, 28);
            lblIdentificacion.Name = "lblIdentificacion";
            lblIdentificacion.Size = new Size(122, 21);
            lblIdentificacion.TabIndex = 0;
            lblIdentificacion.Text = "Introduzca su ID";
            lblIdentificacion.Click += label1_Click;
            // 
            // txtID
            // 
            txtID.Location = new Point(83, 57);
            txtID.Name = "txtID";
            txtID.Size = new Size(100, 23);
            txtID.TabIndex = 1;
            txtID.TextAlign = HorizontalAlignment.Center;
            // 
            // btnEnviar
            // 
            btnEnviar.Location = new Point(237, 169);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(75, 23);
            btnEnviar.TabIndex = 2;
            btnEnviar.Text = "Enviar";
            btnEnviar.UseVisualStyleBackColor = true;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // btn1
            // 
            btn1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn1.Location = new Point(57, 90);
            btn1.Name = "btn1";
            btn1.Size = new Size(40, 40);
            btn1.TabIndex = 3;
            btn1.Text = " 1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // btn2
            // 
            btn2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn2.Location = new Point(113, 90);
            btn2.Name = "btn2";
            btn2.Size = new Size(40, 40);
            btn2.TabIndex = 4;
            btn2.Text = " 2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn2_Click;
            // 
            // btn3
            // 
            btn3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn3.Location = new Point(170, 90);
            btn3.Name = "btn3";
            btn3.Size = new Size(40, 40);
            btn3.TabIndex = 5;
            btn3.Text = " 3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn3_Click;
            // 
            // btn4
            // 
            btn4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn4.Location = new Point(57, 136);
            btn4.Name = "btn4";
            btn4.Size = new Size(40, 40);
            btn4.TabIndex = 6;
            btn4.Text = " 4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btn4_Click;
            // 
            // btn5
            // 
            btn5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn5.Location = new Point(113, 136);
            btn5.Name = "btn5";
            btn5.Size = new Size(40, 40);
            btn5.TabIndex = 7;
            btn5.Text = " 5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btn5_Click;
            // 
            // btn6
            // 
            btn6.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn6.Location = new Point(170, 136);
            btn6.Name = "btn6";
            btn6.Size = new Size(40, 40);
            btn6.TabIndex = 8;
            btn6.Text = " 6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btn6_Click;
            // 
            // btn7
            // 
            btn7.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn7.Location = new Point(57, 182);
            btn7.Name = "btn7";
            btn7.Size = new Size(40, 40);
            btn7.TabIndex = 9;
            btn7.Text = " 7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += btn7_Click;
            // 
            // btn8
            // 
            btn8.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn8.Location = new Point(113, 182);
            btn8.Name = "btn8";
            btn8.Size = new Size(40, 40);
            btn8.TabIndex = 10;
            btn8.Text = " 8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btn8_Click;
            // 
            // btn9
            // 
            btn9.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn9.Location = new Point(170, 182);
            btn9.Name = "btn9";
            btn9.Size = new Size(40, 40);
            btn9.TabIndex = 11;
            btn9.Text = " 9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += btn9_Click;
            // 
            // btn0
            // 
            btn0.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn0.Location = new Point(113, 228);
            btn0.Name = "btn0";
            btn0.Size = new Size(40, 40);
            btn0.TabIndex = 12;
            btn0.Text = " 0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += btn0_Click;
            // 
            // btnBorrar
            // 
            btnBorrar.Location = new Point(237, 124);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(75, 23);
            btnBorrar.TabIndex = 13;
            btnBorrar.Text = "Borrar";
            btnBorrar.UseVisualStyleBackColor = true;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(342, 316);
            Controls.Add(btnBorrar);
            Controls.Add(btn0);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(btnEnviar);
            Controls.Add(txtID);
            Controls.Add(lblIdentificacion);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblIdentificacion;
        private TextBox txtID;
        private Button btnEnviar;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btn0;
        private Button btnBorrar;
    }
}
