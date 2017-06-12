namespace Artigos
{
    partial class Login
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
            this.btnEntrar = new System.Windows.Forms.Button();
            this.lblSuperior = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.chkManter_Logado = new System.Windows.Forms.CheckBox();
            this.lblEsqueceu_Senha = new System.Windows.Forms.LinkLabel();
            this.lblCadastrar = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEntrar
            // 
            this.btnEntrar.Location = new System.Drawing.Point(55, 399);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(198, 31);
            this.btnEntrar.TabIndex = 0;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = true;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // lblSuperior
            // 
            this.lblSuperior.AutoSize = true;
            this.lblSuperior.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuperior.Location = new System.Drawing.Point(131, 31);
            this.lblSuperior.Name = "lblSuperior";
            this.lblSuperior.Size = new System.Drawing.Size(41, 25);
            this.lblSuperior.TabIndex = 1;
            this.lblSuperior.Text = "Olá";
            // 
            // txtUsuario
            // 
            this.txtUsuario.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtUsuario.Location = new System.Drawing.Point(52, 211);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(201, 20);
            this.txtUsuario.TabIndex = 2;
            this.txtUsuario.Text = "Usuário: ";
            this.txtUsuario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUsuario_KeyDown);
            // 
            // txtSenha
            // 
            this.txtSenha.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtSenha.Location = new System.Drawing.Point(52, 251);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(201, 20);
            this.txtSenha.TabIndex = 3;
            this.txtSenha.Text = "Senha:";
            this.txtSenha.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSenha_KeyDown);
            // 
            // chkManter_Logado
            // 
            this.chkManter_Logado.AutoSize = true;
            this.chkManter_Logado.Location = new System.Drawing.Point(52, 296);
            this.chkManter_Logado.Name = "chkManter_Logado";
            this.chkManter_Logado.Size = new System.Drawing.Size(109, 17);
            this.chkManter_Logado.TabIndex = 4;
            this.chkManter_Logado.Text = "Mantenha logado";
            this.chkManter_Logado.UseVisualStyleBackColor = true;
            // 
            // lblEsqueceu_Senha
            // 
            this.lblEsqueceu_Senha.AutoSize = true;
            this.lblEsqueceu_Senha.Location = new System.Drawing.Point(52, 316);
            this.lblEsqueceu_Senha.Name = "lblEsqueceu_Senha";
            this.lblEsqueceu_Senha.Size = new System.Drawing.Size(108, 13);
            this.lblEsqueceu_Senha.TabIndex = 5;
            this.lblEsqueceu_Senha.TabStop = true;
            this.lblEsqueceu_Senha.Text = "Esqueci minha senha";
            this.lblEsqueceu_Senha.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblEsqueceu_Senha_LinkClicked);
            // 
            // lblCadastrar
            // 
            this.lblCadastrar.AutoSize = true;
            this.lblCadastrar.Location = new System.Drawing.Point(52, 366);
            this.lblCadastrar.Name = "lblCadastrar";
            this.lblCadastrar.Size = new System.Drawing.Size(93, 13);
            this.lblCadastrar.TabIndex = 7;
            this.lblCadastrar.TabStop = true;
            this.lblCadastrar.Text = "Cadastre-se agora";
            this.lblCadastrar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblCadastrar_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Artigos.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(100, 73);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(105, 106);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 353);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Não possui um usuário?";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(315, 471);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCadastrar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblEsqueceu_Senha);
            this.Controls.Add(this.chkManter_Logado);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lblSuperior);
            this.Controls.Add(this.btnEntrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.Label lblSuperior;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.CheckBox chkManter_Logado;
        private System.Windows.Forms.LinkLabel lblEsqueceu_Senha;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel lblCadastrar;
        private System.Windows.Forms.Label label1;
    }
}