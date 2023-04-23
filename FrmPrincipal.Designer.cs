namespace PDV
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.MenuPrincipal = new System.Windows.Forms.MenuStrip();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MenuCadastros = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuProduto = new System.Windows.Forms.ToolStripMenuItem();
            this.movimentaçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatóriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.img01 = new System.Windows.Forms.PictureBox();
            this.img02 = new System.Windows.Forms.PictureBox();
            this.img03 = new System.Windows.Forms.PictureBox();
            this.img04 = new System.Windows.Forms.PictureBox();
            this.MenuPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img01)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img02)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img03)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img04)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuPrincipal
            // 
            this.MenuPrincipal.BackColor = System.Drawing.SystemColors.Info;
            this.MenuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuCadastros,
            this.MenuProduto,
            this.movimentaçõesToolStripMenuItem,
            this.relatóriosToolStripMenuItem,
            this.sairToolStripMenuItem});
            resources.ApplyResources(this.MenuPrincipal, "MenuPrincipal");
            this.MenuPrincipal.Name = "MenuPrincipal";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            resources.ApplyResources(this.contextMenuStrip1, "contextMenuStrip1");
            // 
            // MenuCadastros
            // 
            this.MenuCadastros.Name = "MenuCadastros";
            resources.ApplyResources(this.MenuCadastros, "MenuCadastros");
            // 
            // MenuProduto
            // 
            this.MenuProduto.Name = "MenuProduto";
            resources.ApplyResources(this.MenuProduto, "MenuProduto");
            this.MenuProduto.Click += new System.EventHandler(this.produtosToolStripMenuItem_Click);
            // 
            // movimentaçõesToolStripMenuItem
            // 
            this.movimentaçõesToolStripMenuItem.Name = "movimentaçõesToolStripMenuItem";
            resources.ApplyResources(this.movimentaçõesToolStripMenuItem, "movimentaçõesToolStripMenuItem");
            // 
            // relatóriosToolStripMenuItem
            // 
            this.relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            resources.ApplyResources(this.relatóriosToolStripMenuItem, "relatóriosToolStripMenuItem");
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            resources.ApplyResources(this.sairToolStripMenuItem, "sairToolStripMenuItem");
            // 
            // img01
            // 
            resources.ApplyResources(this.img01, "img01");
            this.img01.Name = "img01";
            this.img01.TabStop = false;
            // 
            // img02
            // 
            resources.ApplyResources(this.img02, "img02");
            this.img02.Name = "img02";
            this.img02.TabStop = false;
            // 
            // img03
            // 
            resources.ApplyResources(this.img03, "img03");
            this.img03.Name = "img03";
            this.img03.TabStop = false;
            // 
            // img04
            // 
            resources.ApplyResources(this.img04, "img04");
            this.img04.Name = "img04";
            this.img04.TabStop = false;
            // 
            // frmPrincipal
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.Controls.Add(this.img04);
            this.Controls.Add(this.img03);
            this.Controls.Add(this.img02);
            this.Controls.Add(this.img01);
            this.Controls.Add(this.MenuPrincipal);
            this.MainMenuStrip = this.MenuPrincipal;
            this.Name = "frmPrincipal";
            this.UseWaitCursor = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.MenuPrincipal.ResumeLayout(false);
            this.MenuPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img01)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img02)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img03)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img04)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem MenuCadastros;
        private System.Windows.Forms.ToolStripMenuItem MenuProduto;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem movimentaçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatóriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.PictureBox img01;
        private System.Windows.Forms.PictureBox img02;
        private System.Windows.Forms.PictureBox img03;
        private System.Windows.Forms.PictureBox img04;
    }
}

