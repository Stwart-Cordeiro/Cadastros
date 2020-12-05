namespace Apresentacao
{
    partial class FrmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            this.Barra = new System.Windows.Forms.StatusStrip();
            this.labelvarcao = new System.Windows.Forms.ToolStripStatusLabel();
            this.MenuInicial = new System.Windows.Forms.MenuStrip();
            this.Menucadastro = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSair = new System.Windows.Forms.ToolStripMenuItem();
            this.Barra.SuspendLayout();
            this.MenuInicial.SuspendLayout();
            this.SuspendLayout();
            // 
            // Barra
            // 
            this.Barra.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labelvarcao});
            this.Barra.Location = new System.Drawing.Point(0, 339);
            this.Barra.Name = "Barra";
            this.Barra.Size = new System.Drawing.Size(784, 22);
            this.Barra.TabIndex = 1;
            this.Barra.Text = "statusStrip1";
            // 
            // labelvarcao
            // 
            this.labelvarcao.Name = "labelvarcao";
            this.labelvarcao.Size = new System.Drawing.Size(61, 17);
            this.labelvarcao.Text = "Verção 1.0";
            // 
            // MenuInicial
            // 
            this.MenuInicial.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menucadastro,
            this.MenuSair});
            this.MenuInicial.Location = new System.Drawing.Point(0, 0);
            this.MenuInicial.Name = "MenuInicial";
            this.MenuInicial.Size = new System.Drawing.Size(784, 24);
            this.MenuInicial.TabIndex = 3;
            this.MenuInicial.Text = "menuStrip1";
            // 
            // Menucadastro
            // 
            this.Menucadastro.Name = "Menucadastro";
            this.Menucadastro.Size = new System.Drawing.Size(66, 20);
            this.Menucadastro.Text = "&Cadastro";
            this.Menucadastro.Click += new System.EventHandler(this.Menucadastro_Click);
            // 
            // MenuSair
            // 
            this.MenuSair.Name = "MenuSair";
            this.MenuSair.Size = new System.Drawing.Size(38, 20);
            this.MenuSair.Text = "&Sair";
            this.MenuSair.Click += new System.EventHandler(this.MenuSair_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 361);
            this.Controls.Add(this.Barra);
            this.Controls.Add(this.MenuInicial);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.MenuInicial;
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Barra.ResumeLayout(false);
            this.Barra.PerformLayout();
            this.MenuInicial.ResumeLayout(false);
            this.MenuInicial.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip Barra;
        private System.Windows.Forms.ToolStripStatusLabel labelvarcao;
        private System.Windows.Forms.MenuStrip MenuInicial;
        private System.Windows.Forms.ToolStripMenuItem Menucadastro;
        private System.Windows.Forms.ToolStripMenuItem MenuSair;
    }
}