namespace Artigos
{
    partial class CadastrarArtigo
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
            this.lblNomeArtigo = new System.Windows.Forms.Label();
            this.lblConteudo = new System.Windows.Forms.Label();
            this.txtNomeArtigo = new System.Windows.Forms.TextBox();
            this.txtConteudo = new System.Windows.Forms.TextBox();
            this.btnSubmeterAnalise = new System.Windows.Forms.Button();
            this.btnArtigosEnviados = new System.Windows.Forms.Button();
            this.btnVersaoFinal = new System.Windows.Forms.Button();
            this.lblAreaDeInteresse = new System.Windows.Forms.Label();
            this.cmbArea = new System.Windows.Forms.ComboBox();
            this.lblAutor = new System.Windows.Forms.Label();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblNomeArtigo
            // 
            this.lblNomeArtigo.AutoSize = true;
            this.lblNomeArtigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeArtigo.Location = new System.Drawing.Point(114, 113);
            this.lblNomeArtigo.Name = "lblNomeArtigo";
            this.lblNomeArtigo.Size = new System.Drawing.Size(145, 24);
            this.lblNomeArtigo.TabIndex = 0;
            this.lblNomeArtigo.Text = "Nome do artigo:";
            // 
            // lblConteudo
            // 
            this.lblConteudo.AutoSize = true;
            this.lblConteudo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConteudo.Location = new System.Drawing.Point(114, 176);
            this.lblConteudo.Name = "lblConteudo";
            this.lblConteudo.Size = new System.Drawing.Size(98, 24);
            this.lblConteudo.TabIndex = 1;
            this.lblConteudo.Text = "Conteúdo:";
            // 
            // txtNomeArtigo
            // 
            this.txtNomeArtigo.Location = new System.Drawing.Point(118, 141);
            this.txtNomeArtigo.Multiline = true;
            this.txtNomeArtigo.Name = "txtNomeArtigo";
            this.txtNomeArtigo.Size = new System.Drawing.Size(629, 32);
            this.txtNomeArtigo.TabIndex = 2;
            // 
            // txtConteudo
            // 
            this.txtConteudo.Location = new System.Drawing.Point(118, 203);
            this.txtConteudo.Multiline = true;
            this.txtConteudo.Name = "txtConteudo";
            this.txtConteudo.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtConteudo.Size = new System.Drawing.Size(629, 267);
            this.txtConteudo.TabIndex = 3;
            // 
            // btnSubmeterAnalise
            // 
            this.btnSubmeterAnalise.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmeterAnalise.Location = new System.Drawing.Point(118, 641);
            this.btnSubmeterAnalise.Name = "btnSubmeterAnalise";
            this.btnSubmeterAnalise.Size = new System.Drawing.Size(141, 56);
            this.btnSubmeterAnalise.TabIndex = 4;
            this.btnSubmeterAnalise.Text = "Submeter para Análise";
            this.btnSubmeterAnalise.UseVisualStyleBackColor = true;
            this.btnSubmeterAnalise.Click += new System.EventHandler(this.btnSubmeterAnalise_Click);
            // 
            // btnArtigosEnviados
            // 
            this.btnArtigosEnviados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArtigosEnviados.Location = new System.Drawing.Point(469, 641);
            this.btnArtigosEnviados.Name = "btnArtigosEnviados";
            this.btnArtigosEnviados.Size = new System.Drawing.Size(121, 56);
            this.btnArtigosEnviados.TabIndex = 5;
            this.btnArtigosEnviados.Text = "Artigos Enviados";
            this.btnArtigosEnviados.UseVisualStyleBackColor = true;
            this.btnArtigosEnviados.Click += new System.EventHandler(this.btnArtigosEnviados_Click);
            // 
            // btnVersaoFinal
            // 
            this.btnVersaoFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVersaoFinal.Location = new System.Drawing.Point(295, 641);
            this.btnVersaoFinal.Name = "btnVersaoFinal";
            this.btnVersaoFinal.Size = new System.Drawing.Size(129, 56);
            this.btnVersaoFinal.TabIndex = 6;
            this.btnVersaoFinal.Text = "Enviar Versão Final";
            this.btnVersaoFinal.UseVisualStyleBackColor = true;
            this.btnVersaoFinal.Click += new System.EventHandler(this.btnVersaoFinal_Click);
            // 
            // lblAreaDeInteresse
            // 
            this.lblAreaDeInteresse.AutoSize = true;
            this.lblAreaDeInteresse.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAreaDeInteresse.Location = new System.Drawing.Point(114, 490);
            this.lblAreaDeInteresse.Name = "lblAreaDeInteresse";
            this.lblAreaDeInteresse.Size = new System.Drawing.Size(163, 24);
            this.lblAreaDeInteresse.TabIndex = 7;
            this.lblAreaDeInteresse.Text = "Área de interesse:";
            // 
            // cmbArea
            // 
            this.cmbArea.FormattingEnabled = true;
            this.cmbArea.Items.AddRange(new object[] {
            "Tecnologia",
            "Português",
            "Ciências",
            "Matemática"});
            this.cmbArea.Location = new System.Drawing.Point(118, 518);
            this.cmbArea.Name = "cmbArea";
            this.cmbArea.Size = new System.Drawing.Size(353, 21);
            this.cmbArea.TabIndex = 8;
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutor.Location = new System.Drawing.Point(114, 557);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(60, 24);
            this.lblAutor.TabIndex = 9;
            this.lblAutor.Text = "Autor:";
            // 
            // txtAutor
            // 
            this.txtAutor.Location = new System.Drawing.Point(118, 585);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(353, 20);
            this.txtAutor.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(209, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(394, 47);
            this.label2.TabIndex = 11;
            this.label2.Text = "Cadastrar Novo Artigo";
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(618, 641);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(129, 56);
            this.btnVoltar.TabIndex = 12;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(517, 491);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 24);
            this.label1.TabIndex = 13;
            this.label1.Text = "Status:";
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(521, 518);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(226, 20);
            this.txtStatus.TabIndex = 14;
            // 
            // CadastrarArtigo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 725);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAutor);
            this.Controls.Add(this.lblAutor);
            this.Controls.Add(this.cmbArea);
            this.Controls.Add(this.lblAreaDeInteresse);
            this.Controls.Add(this.btnVersaoFinal);
            this.Controls.Add(this.btnArtigosEnviados);
            this.Controls.Add(this.btnSubmeterAnalise);
            this.Controls.Add(this.txtConteudo);
            this.Controls.Add(this.txtNomeArtigo);
            this.Controls.Add(this.lblConteudo);
            this.Controls.Add(this.lblNomeArtigo);
            this.Name = "CadastrarArtigo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Novo Artigo";
            this.Load += new System.EventHandler(this.CadastrarArtigo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomeArtigo;
        private System.Windows.Forms.Label lblConteudo;
        private System.Windows.Forms.TextBox txtNomeArtigo;
        private System.Windows.Forms.TextBox txtConteudo;
        private System.Windows.Forms.Button btnSubmeterAnalise;
        private System.Windows.Forms.Button btnArtigosEnviados;
        private System.Windows.Forms.Button btnVersaoFinal;
        private System.Windows.Forms.Label lblAreaDeInteresse;
        private System.Windows.Forms.ComboBox cmbArea;
        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtStatus;
    }
}