namespace Calculadora
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
            somar = new Button();
            segundoNumero = new TextBox();
            primeiroNumero = new TextBox();
            label1 = new Label();
            label2 = new Label();
            Resultado = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // somar
            // 
            somar.Location = new Point(1143, 203);
            somar.Name = "somar";
            somar.Size = new Size(112, 34);
            somar.TabIndex = 0;
            somar.Text = "somar";
            somar.UseVisualStyleBackColor = true;
            somar.Click += button1_Click;
            // 
            // segundoNumero
            // 
            segundoNumero.Location = new Point(1124, 141);
            segundoNumero.Name = "segundoNumero";
            segundoNumero.Size = new Size(150, 31);
            segundoNumero.TabIndex = 1;
            // 
            // primeiroNumero
            // 
            primeiroNumero.Location = new Point(1124, 80);
            primeiroNumero.Name = "primeiroNumero";
            primeiroNumero.Size = new Size(150, 31);
            primeiroNumero.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(954, 80);
            label1.Name = "label1";
            label1.Size = new Size(148, 25);
            label1.TabIndex = 3;
            label1.Text = "Primeiro Numero";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(948, 141);
            label2.Name = "label2";
            label2.Size = new Size(154, 25);
            label2.TabIndex = 4;
            label2.Text = "Segundo Numero";
            // 
            // Resultado
            // 
            Resultado.AutoSize = true;
            Resultado.Location = new Point(1187, 175);
            Resultado.Name = "Resultado";
            Resultado.Size = new Size(22, 25);
            Resultado.TabIndex = 5;
            Resultado.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1187, 114);
            label3.Name = "label3";
            label3.Size = new Size(24, 25);
            label3.TabIndex = 6;
            label3.Text = "+";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1472, 738);
            Controls.Add(label3);
            Controls.Add(Resultado);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(primeiroNumero);
            Controls.Add(segundoNumero);
            Controls.Add(somar);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button somar;
        private TextBox segundoNumero;
        private TextBox primeiroNumero;
        private Label label1;
        private Label label2;
        private Label Resultado;
        private Label label3;
    }
}