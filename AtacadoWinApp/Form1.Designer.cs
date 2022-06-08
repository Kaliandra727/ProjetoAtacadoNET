namespace AtacadoWinApp
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
            this.OiMundoBtn = new System.Windows.Forms.Button();
            this.FecharBtn = new System.Windows.Forms.Button();
            this.cpfLbl = new System.Windows.Forms.Label();
            this.CpfTxt = new System.Windows.Forms.TextBox();
            this.ValidarBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OiMundoBtn
            // 
            this.OiMundoBtn.Location = new System.Drawing.Point(12, 27);
            this.OiMundoBtn.Name = "OiMundoBtn";
            this.OiMundoBtn.Size = new System.Drawing.Size(120, 23);
            this.OiMundoBtn.TabIndex = 0;
            this.OiMundoBtn.Text = "Clique aqui!!!";
            this.OiMundoBtn.UseVisualStyleBackColor = true;
            this.OiMundoBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // FecharBtn
            // 
            this.FecharBtn.Location = new System.Drawing.Point(709, 423);
            this.FecharBtn.Name = "FecharBtn";
            this.FecharBtn.Size = new System.Drawing.Size(75, 23);
            this.FecharBtn.TabIndex = 1;
            this.FecharBtn.Text = "Fechar";
            this.FecharBtn.UseVisualStyleBackColor = true;
            this.FecharBtn.Click += new System.EventHandler(this.FecharBtn_Click);
            // 
            // cpfLbl
            // 
            this.cpfLbl.AutoSize = true;
            this.cpfLbl.Location = new System.Drawing.Point(12, 108);
            this.cpfLbl.Name = "cpfLbl";
            this.cpfLbl.Size = new System.Drawing.Size(94, 15);
            this.cpfLbl.TabIndex = 2;
            this.cpfLbl.Text = "CPF Funcionário";
            // 
            // CpfTxt
            // 
            this.CpfTxt.Location = new System.Drawing.Point(112, 105);
            this.CpfTxt.Name = "CpfTxt";
            this.CpfTxt.Size = new System.Drawing.Size(100, 23);
            this.CpfTxt.TabIndex = 3;
            // 
            // ValidarBtn
            // 
            this.ValidarBtn.Location = new System.Drawing.Point(137, 134);
            this.ValidarBtn.Name = "ValidarBtn";
            this.ValidarBtn.Size = new System.Drawing.Size(75, 23);
            this.ValidarBtn.TabIndex = 4;
            this.ValidarBtn.Text = "Validar";
            this.ValidarBtn.UseVisualStyleBackColor = true;
            this.ValidarBtn.Click += new System.EventHandler(this.ValidarBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 458);
            this.Controls.Add(this.ValidarBtn);
            this.Controls.Add(this.CpfTxt);
            this.Controls.Add(this.cpfLbl);
            this.Controls.Add(this.FecharBtn);
            this.Controls.Add(this.OiMundoBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button OiMundoBtn;
        private Button FecharBtn;
        private Label cpfLbl;
        private TextBox CpfTxt;
        private Button ValidarBtn;
    }
}