namespace ej1
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
            tbPatente = new TextBox();
            label1 = new Label();
            btnProcesar = new Button();
            lsbVer = new ListBox();
            label2 = new Label();
            rbString = new RadioButton();
            rbRegex = new RadioButton();
            SuspendLayout();
            // 
            // tbPatente
            // 
            tbPatente.Location = new Point(40, 46);
            tbPatente.Name = "tbPatente";
            tbPatente.Size = new Size(237, 23);
            tbPatente.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 28);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 1;
            label1.Text = "Patente";
            // 
            // btnProcesar
            // 
            btnProcesar.Location = new Point(456, 103);
            btnProcesar.Name = "btnProcesar";
            btnProcesar.Size = new Size(153, 60);
            btnProcesar.TabIndex = 2;
            btnProcesar.Text = "Procesar";
            btnProcesar.UseVisualStyleBackColor = true;
            btnProcesar.Click += btnProcesar_Click;
            // 
            // lsbVer
            // 
            lsbVer.FormattingEnabled = true;
            lsbVer.ItemHeight = 15;
            lsbVer.Location = new Point(40, 103);
            lsbVer.Name = "lsbVer";
            lsbVer.ScrollAlwaysVisible = true;
            lsbVer.Size = new Size(410, 169);
            lsbVer.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 85);
            label2.Name = "label2";
            label2.Size = new Size(23, 15);
            label2.TabIndex = 4;
            label2.Text = "Ver";
            // 
            // rbString
            // 
            rbString.AutoSize = true;
            rbString.Location = new Point(456, 184);
            rbString.Name = "rbString";
            rbString.Size = new Size(56, 19);
            rbString.TabIndex = 5;
            rbString.TabStop = true;
            rbString.Text = "String";
            rbString.UseVisualStyleBackColor = true;
            // 
            // rbRegex
            // 
            rbRegex.AutoSize = true;
            rbRegex.Location = new Point(456, 242);
            rbRegex.Name = "rbRegex";
            rbRegex.Size = new Size(56, 19);
            rbRegex.TabIndex = 6;
            rbRegex.TabStop = true;
            rbRegex.Text = "Regex";
            rbRegex.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(666, 426);
            Controls.Add(rbRegex);
            Controls.Add(rbString);
            Controls.Add(label2);
            Controls.Add(lsbVer);
            Controls.Add(btnProcesar);
            Controls.Add(label1);
            Controls.Add(tbPatente);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbPatente;
        private Label label1;
        private Button btnProcesar;
        private ListBox lsbVer;
        private Label label2;
        private RadioButton rbString;
        private RadioButton rbRegex;
    }
}
