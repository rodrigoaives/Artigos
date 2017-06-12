namespace Artigos
{
    partial class DadosArtigosEnviados
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
            this.btnVoltar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.lblAutor = new System.Windows.Forms.Label();
            this.cmbArea = new System.Windows.Forms.ComboBox();
            this.lblAreaDeInteresse = new System.Windows.Forms.Label();
            this.btnArtigosEnviados = new System.Windows.Forms.Button();
            this.txtConteudo = new System.Windows.Forms.TextBox();
            this.txtNomeArtigo = new System.Windows.Forms.TextBox();
            this.lblConteudo = new System.Windows.Forms.Label();
            this.lblNomeArtigo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(734, 641);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(129, 56);
            this.btnVoltar.TabIndex = 25;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(297, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(393, 47);
            this.label2.TabIndex = 24;
            this.label2.Text = "Informações do Artigo";
            // 
            // txtAutor
            // 
            this.txtAutor.Location = new System.Drawing.Point(181, 594);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(353, 20);
            this.txtAutor.TabIndex = 23;
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutor.Location = new System.Drawing.Point(177, 567);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(60, 24);
            this.lblAutor.TabIndex = 22;
            this.lblAutor.Text = "Autor:";
            // 
            // cmbArea
            // 
            this.cmbArea.FormattingEnabled = true;
            this.cmbArea.Items.AddRange(new object[] {
            "Programação",
            "Modelagem",
            "Matemática Aplicada",
            "Banco de Dados"});
            this.cmbArea.Location = new System.Drawing.Point(181, 528);
            this.cmbArea.Name = "cmbArea";
            this.cmbArea.Size = new System.Drawing.Size(353, 21);
            this.cmbArea.TabIndex = 21;
            // 
            // lblAreaDeInteresse
            // 
            this.lblAreaDeInteresse.AutoSize = true;
            this.lblAreaDeInteresse.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAreaDeInteresse.Location = new System.Drawing.Point(177, 500);
            this.lblAreaDeInteresse.Name = "lblAreaDeInteresse";
            this.lblAreaDeInteresse.Size = new System.Drawing.Size(163, 24);
            this.lblAreaDeInteresse.TabIndex = 20;
            this.lblAreaDeInteresse.Text = "Área de interesse:";
            // 
            // btnArtigosEnviados
            // 
            this.btnArtigosEnviados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArtigosEnviados.Location = new System.Drawing.Point(181, 641);
            this.btnArtigosEnviados.Name = "btnArtigosEnviados";
            this.btnArtigosEnviados.Size = new System.Drawing.Size(121, 56);
            this.btnArtigosEnviados.TabIndex = 18;
            this.btnArtigosEnviados.Text = "Cancelar Artigo";
            this.btnArtigosEnviados.UseVisualStyleBackColor = true;
            // 
            // txtConteudo
            // 
            this.txtConteudo.Location = new System.Drawing.Point(181, 212);
            this.txtConteudo.Multiline = true;
            this.txtConteudo.Name = "txtConteudo";
            this.txtConteudo.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtConteudo.Size = new System.Drawing.Size(675, 267);
            this.txtConteudo.TabIndex = 16;
            // 
            // txtNomeArtigo
            // 
            this.txtNomeArtigo.Location = new System.Drawing.Point(181, 150);
            this.txtNomeArtigo.Multiline = true;
            this.txtNomeArtigo.Name = "txtNomeArtigo";
            this.txtNomeArtigo.Size = new System.Drawing.Size(675, 32);
            this.txtNomeArtigo.TabIndex = 15;
            // 
            // lblConteudo
            // 
            this.lblConteudo.AutoSize = true;
            this.lblConteudo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConteudo.Location = new System.Drawing.Point(177, 185);
            this.lblConteudo.Name = "lblConteudo";
            this.lblConteudo.Size = new System.Drawing.Size(98, 24);
            this.lblConteudo.TabIndex = 14;
            this.lblConteudo.Text = "Conteúdo:";
            // 
            // lblNomeArtigo
            // 
            this.lblNomeArtigo.AutoSize = true;
            this.lblNomeArtigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeArtigo.Location = new System.Drawing.Point(177, 122);
            this.lblNomeArtigo.Name = "lblNomeArtigo";
            this.lblNomeArtigo.Size = new System.Drawing.Size(145, 24);
            this.lblNomeArtigo.TabIndex = 13;
            this.lblNomeArtigo.Text = "Nome do artigo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(596, 525);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 24);
            this.label1.TabIndex = 26;
            this.label1.Text = "Data de Envio:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(734, 523);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(122, 26);
            this.dateTimePicker1.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(596, 589);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 24);
            this.label3.TabIndex = 29;
            this.label3.Text = "Status:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(681, 593);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(175, 20);
            this.textBox1.TabIndex = 30;
            // 
            // DadosArtigosEnviados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 735);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAutor);
            this.Controls.Add(this.lblAutor);
            this.Controls.Add(this.cmbArea);
            this.Controls.Add(this.lblAreaDeInteresse);
            this.Controls.Add(this.btnArtigosEnviados);
            this.Controls.Add(this.txtConteudo);
            this.Controls.Add(this.txtNomeArtigo);
            this.Controls.Add(this.lblConteudo);
            this.Controls.Add(this.lblNomeArtigo);
            this.Name = "DadosArtigosEnviados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dados dos Artigos Enviados";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.ComboBox cmbArea;
        private System.Windows.Forms.Label lblAreaDeInteresse;
        private System.Windows.Forms.Button btnArtigosEnviados;
        private System.Windows.Forms.TextBox txtConteudo;
        private System.Windows.Forms.TextBox txtNomeArtigo;
        private System.Windows.Forms.Label lblConteudo;
        private System.Windows.Forms.Label lblNomeArtigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
    }
}