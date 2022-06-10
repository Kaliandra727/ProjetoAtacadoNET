namespace AtacadoWinApp
{
    partial class PrincipalFrm
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
            this.PrincipalMenu = new System.Windows.Forms.MenuStrip();
            this.ArquivoMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FuncionariosMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AdicionarFuncionarioMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EmpresaMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AdicionarEmpresaMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PrincipalMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // OiMundoBtn
            // 
            this.OiMundoBtn.Location = new System.Drawing.Point(12, 423);
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
            // PrincipalMenu
            // 
            this.PrincipalMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ArquivoMenuItem});
            this.PrincipalMenu.Location = new System.Drawing.Point(0, 0);
            this.PrincipalMenu.Name = "PrincipalMenu";
            this.PrincipalMenu.Size = new System.Drawing.Size(796, 24);
            this.PrincipalMenu.TabIndex = 2;
            this.PrincipalMenu.Text = "menuStrip1";
            // 
            // ArquivoMenuItem
            // 
            this.ArquivoMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FuncionariosMenuItem,
            this.EmpresaMenuItem});
            this.ArquivoMenuItem.Name = "ArquivoMenuItem";
            this.ArquivoMenuItem.Size = new System.Drawing.Size(61, 20);
            this.ArquivoMenuItem.Text = "Arquivo";
            this.ArquivoMenuItem.Click += new System.EventHandler(this.ArquivoMenuItem1_Click);
            // 
            // FuncionariosMenuItem
            // 
            this.FuncionariosMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AdicionarFuncionarioMenuItem});
            this.FuncionariosMenuItem.Name = "FuncionariosMenuItem";
            this.FuncionariosMenuItem.Size = new System.Drawing.Size(180, 22);
            this.FuncionariosMenuItem.Text = "Funcionários";
            // 
            // AdicionarFuncionarioMenuItem
            // 
            this.AdicionarFuncionarioMenuItem.Name = "AdicionarFuncionarioMenuItem";
            this.AdicionarFuncionarioMenuItem.Size = new System.Drawing.Size(125, 22);
            this.AdicionarFuncionarioMenuItem.Text = "Adicionar";
            this.AdicionarFuncionarioMenuItem.Click += new System.EventHandler(this.AdicionarFuncionarioMenuItem_Click);
            // 
            // EmpresaMenuItem
            // 
            this.EmpresaMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AdicionarEmpresaMenuItem});
            this.EmpresaMenuItem.Name = "EmpresaMenuItem";
            this.EmpresaMenuItem.Size = new System.Drawing.Size(180, 22);
            this.EmpresaMenuItem.Text = "Empresa";
            // 
            // AdicionarEmpresaMenuItem
            // 
            this.AdicionarEmpresaMenuItem.Name = "AdicionarEmpresaMenuItem";
            this.AdicionarEmpresaMenuItem.Size = new System.Drawing.Size(180, 22);
            this.AdicionarEmpresaMenuItem.Text = "Adicionar";
            this.AdicionarEmpresaMenuItem.Click += new System.EventHandler(this.AdicionarEmpresaMenuItem_Click);
            // 
            // PrincipalFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 458);
            this.Controls.Add(this.FecharBtn);
            this.Controls.Add(this.OiMundoBtn);
            this.Controls.Add(this.PrincipalMenu);
            this.MainMenuStrip = this.PrincipalMenu;
            this.Name = "PrincipalFrm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.PrincipalMenu.ResumeLayout(false);
            this.PrincipalMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button OiMundoBtn;
        private Button FecharBtn;
        private MenuStrip PrincipalMenu;
        private ToolStripMenuItem ArquivoMenuItem;
        private ToolStripMenuItem FuncionariosMenuItem;
        private ToolStripMenuItem AdicionarFuncionarioMenuItem;
        private ToolStripMenuItem EmpresaMenuItem;
        private ToolStripMenuItem AdicionarEmpresaMenuItem;
    }
}