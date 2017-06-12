namespace Artigos
{
    partial class Dashboard
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnNovaArea = new System.Windows.Forms.Button();
            this.btnRevisarArtigo = new System.Windows.Forms.Button();
            this.btnCadastrarArtigo = new System.Windows.Forms.Button();
            this.btnCadastrarUsuario = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "login.png");
            // 
            // btnNovaArea
            // 
            this.btnNovaArea.BackColor = System.Drawing.Color.Transparent;
            this.btnNovaArea.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNovaArea.Enabled = false;
            this.btnNovaArea.Image = global::Artigos.Properties.Resources.add_area2;
            this.btnNovaArea.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNovaArea.Location = new System.Drawing.Point(395, 41);
            this.btnNovaArea.Name = "btnNovaArea";
            this.btnNovaArea.Size = new System.Drawing.Size(93, 89);
            this.btnNovaArea.TabIndex = 3;
            this.btnNovaArea.Text = "\r\n\r\n\r\n\r\nNova Área de Interesse";
            this.btnNovaArea.UseVisualStyleBackColor = true;
            this.btnNovaArea.Click += new System.EventHandler(this.btnNovaArea_Click);
            // 
            // btnRevisarArtigo
            // 
            this.btnRevisarArtigo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRevisarArtigo.Enabled = false;
            this.btnRevisarArtigo.Image = global::Artigos.Properties.Resources.edit_artigo;
            this.btnRevisarArtigo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRevisarArtigo.Location = new System.Drawing.Point(275, 41);
            this.btnRevisarArtigo.Name = "btnRevisarArtigo";
            this.btnRevisarArtigo.Size = new System.Drawing.Size(93, 89);
            this.btnRevisarArtigo.TabIndex = 2;
            this.btnRevisarArtigo.Text = "Revisar\r\nArtigo\r\n";
            this.btnRevisarArtigo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRevisarArtigo.UseVisualStyleBackColor = true;
            this.btnRevisarArtigo.Click += new System.EventHandler(this.btnRevisarArtigo_Click);
            // 
            // btnCadastrarArtigo
            // 
            this.btnCadastrarArtigo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCadastrarArtigo.Enabled = false;
            this.btnCadastrarArtigo.Image = global::Artigos.Properties.Resources.add_artigo;
            this.btnCadastrarArtigo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCadastrarArtigo.Location = new System.Drawing.Point(159, 41);
            this.btnCadastrarArtigo.Name = "btnCadastrarArtigo";
            this.btnCadastrarArtigo.Size = new System.Drawing.Size(91, 89);
            this.btnCadastrarArtigo.TabIndex = 1;
            this.btnCadastrarArtigo.Text = "Cadastrar \r\nArtigo";
            this.btnCadastrarArtigo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCadastrarArtigo.UseVisualStyleBackColor = true;
            this.btnCadastrarArtigo.Click += new System.EventHandler(this.btnCadastrarArtigo_Click);
            // 
            // btnCadastrarUsuario
            // 
            this.btnCadastrarUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCadastrarUsuario.Enabled = false;
            this.btnCadastrarUsuario.Image = global::Artigos.Properties.Resources.add_user_mod;
            this.btnCadastrarUsuario.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCadastrarUsuario.Location = new System.Drawing.Point(36, 41);
            this.btnCadastrarUsuario.Name = "btnCadastrarUsuario";
            this.btnCadastrarUsuario.Size = new System.Drawing.Size(91, 89);
            this.btnCadastrarUsuario.TabIndex = 0;
            this.btnCadastrarUsuario.Text = "Cadastrar \r\nUsuário";
            this.btnCadastrarUsuario.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCadastrarUsuario.UseVisualStyleBackColor = true;
            this.btnCadastrarUsuario.Click += new System.EventHandler(this.btnCadastrarUsuario_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(831, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sairToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(50, 20);
            this.toolStripMenuItem1.Text = "Menu";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 513);
            this.Controls.Add(this.btnNovaArea);
            this.Controls.Add(this.btnRevisarArtigo);
            this.Controls.Add(this.btnCadastrarArtigo);
            this.Controls.Add(this.btnCadastrarUsuario);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DashBoard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCadastrarUsuario;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnCadastrarArtigo;
        private System.Windows.Forms.Button btnRevisarArtigo;
        private System.Windows.Forms.Button btnNovaArea;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
    }
}

