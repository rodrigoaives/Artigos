namespace Artigos
{
    partial class InformacoesArtigo
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.lblAutor = new System.Windows.Forms.Label();
            this.cmbArea = new System.Windows.Forms.ComboBox();
            this.areaInteresseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSet = new Artigos.databaseDataSet();
            this.lblAreaDeInteresse = new System.Windows.Forms.Label();
            this.btnReprovado = new System.Windows.Forms.Button();
            this.btnAprovar = new System.Windows.Forms.Button();
            this.txtConteudo = new System.Windows.Forms.TextBox();
            this.txtNomeArtigo = new System.Windows.Forms.TextBox();
            this.lblConteudo = new System.Windows.Forms.Label();
            this.lblNomeArtigo = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnReprovados = new System.Windows.Forms.Button();
            this.btnPendentes = new System.Windows.Forms.Button();
            this.btnAprovados = new System.Windows.Forms.Button();
            this.txtJustificativa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.areaInteresseTableAdapter = new Artigos.databaseDataSetTableAdapters.AreaInteresseTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.areaInteresseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(257, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(393, 47);
            this.label2.TabIndex = 24;
            this.label2.Text = "Informações do Artigo";
            // 
            // txtAutor
            // 
            this.txtAutor.Location = new System.Drawing.Point(161, 666);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(353, 20);
            this.txtAutor.TabIndex = 23;
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutor.Location = new System.Drawing.Point(157, 639);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(60, 24);
            this.lblAutor.TabIndex = 22;
            this.lblAutor.Text = "Autor:";
            // 
            // cmbArea
            // 
            this.cmbArea.DataSource = this.areaInteresseBindingSource;
            this.cmbArea.DisplayMember = "Area";
            this.cmbArea.FormattingEnabled = true;
            this.cmbArea.Location = new System.Drawing.Point(161, 600);
            this.cmbArea.Name = "cmbArea";
            this.cmbArea.Size = new System.Drawing.Size(353, 21);
            this.cmbArea.TabIndex = 21;
            this.cmbArea.ValueMember = "Area";
            // 
            // areaInteresseBindingSource
            // 
            this.areaInteresseBindingSource.DataMember = "AreaInteresse";
            this.areaInteresseBindingSource.DataSource = this.databaseDataSet;
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "databaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblAreaDeInteresse
            // 
            this.lblAreaDeInteresse.AutoSize = true;
            this.lblAreaDeInteresse.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAreaDeInteresse.Location = new System.Drawing.Point(157, 572);
            this.lblAreaDeInteresse.Name = "lblAreaDeInteresse";
            this.lblAreaDeInteresse.Size = new System.Drawing.Size(163, 24);
            this.lblAreaDeInteresse.TabIndex = 20;
            this.lblAreaDeInteresse.Text = "Área de interesse:";
            // 
            // btnReprovado
            // 
            this.btnReprovado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReprovado.Location = new System.Drawing.Point(348, 703);
            this.btnReprovado.Name = "btnReprovado";
            this.btnReprovado.Size = new System.Drawing.Size(166, 56);
            this.btnReprovado.TabIndex = 19;
            this.btnReprovado.Text = "Enviar Justificativa (Reprovado)";
            this.btnReprovado.UseVisualStyleBackColor = true;
            this.btnReprovado.Click += new System.EventHandler(this.btnReprovado_Click);
            // 
            // btnAprovar
            // 
            this.btnAprovar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAprovar.Location = new System.Drawing.Point(161, 703);
            this.btnAprovar.Name = "btnAprovar";
            this.btnAprovar.Size = new System.Drawing.Size(141, 56);
            this.btnAprovar.TabIndex = 17;
            this.btnAprovar.Text = "Aprovar Artigo";
            this.btnAprovar.UseVisualStyleBackColor = true;
            this.btnAprovar.Click += new System.EventHandler(this.btnAprovar_Click);
            // 
            // txtConteudo
            // 
            this.txtConteudo.Location = new System.Drawing.Point(164, 213);
            this.txtConteudo.Multiline = true;
            this.txtConteudo.Name = "txtConteudo";
            this.txtConteudo.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtConteudo.Size = new System.Drawing.Size(629, 267);
            this.txtConteudo.TabIndex = 16;
            // 
            // txtNomeArtigo
            // 
            this.txtNomeArtigo.Location = new System.Drawing.Point(164, 151);
            this.txtNomeArtigo.Multiline = true;
            this.txtNomeArtigo.Name = "txtNomeArtigo";
            this.txtNomeArtigo.Size = new System.Drawing.Size(629, 32);
            this.txtNomeArtigo.TabIndex = 15;
            // 
            // lblConteudo
            // 
            this.lblConteudo.AutoSize = true;
            this.lblConteudo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConteudo.Location = new System.Drawing.Point(160, 186);
            this.lblConteudo.Name = "lblConteudo";
            this.lblConteudo.Size = new System.Drawing.Size(98, 24);
            this.lblConteudo.TabIndex = 14;
            this.lblConteudo.Text = "Conteúdo:";
            // 
            // lblNomeArtigo
            // 
            this.lblNomeArtigo.AutoSize = true;
            this.lblNomeArtigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeArtigo.Location = new System.Drawing.Point(160, 123);
            this.lblNomeArtigo.Name = "lblNomeArtigo";
            this.lblNomeArtigo.Size = new System.Drawing.Size(145, 24);
            this.lblNomeArtigo.TabIndex = 13;
            this.lblNomeArtigo.Text = "Nome do artigo:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(569, 587);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 34);
            this.button1.TabIndex = 26;
            this.button1.Text = "Baixar artigo";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnReprovados
            // 
            this.btnReprovados.BackColor = System.Drawing.Color.DarkRed;
            this.btnReprovados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReprovados.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReprovados.ForeColor = System.Drawing.Color.White;
            this.btnReprovados.Location = new System.Drawing.Point(569, 792);
            this.btnReprovados.Name = "btnReprovados";
            this.btnReprovados.Size = new System.Drawing.Size(176, 34);
            this.btnReprovados.TabIndex = 29;
            this.btnReprovados.Text = "REPROVADOS";
            this.btnReprovados.UseVisualStyleBackColor = false;
            this.btnReprovados.Click += new System.EventHandler(this.btnReprovados_Click);
            // 
            // btnPendentes
            // 
            this.btnPendentes.BackColor = System.Drawing.Color.Goldenrod;
            this.btnPendentes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPendentes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPendentes.ForeColor = System.Drawing.Color.White;
            this.btnPendentes.Location = new System.Drawing.Point(161, 792);
            this.btnPendentes.Name = "btnPendentes";
            this.btnPendentes.Size = new System.Drawing.Size(176, 35);
            this.btnPendentes.TabIndex = 28;
            this.btnPendentes.Text = "PENDENTES";
            this.btnPendentes.UseVisualStyleBackColor = false;
            this.btnPendentes.Click += new System.EventHandler(this.btnPendentes_Click);
            // 
            // btnAprovados
            // 
            this.btnAprovados.BackColor = System.Drawing.Color.DarkGreen;
            this.btnAprovados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAprovados.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAprovados.ForeColor = System.Drawing.Color.White;
            this.btnAprovados.Location = new System.Drawing.Point(367, 792);
            this.btnAprovados.Name = "btnAprovados";
            this.btnAprovados.Size = new System.Drawing.Size(176, 35);
            this.btnAprovados.TabIndex = 27;
            this.btnAprovados.Text = "APROVADOS";
            this.btnAprovados.UseVisualStyleBackColor = false;
            this.btnAprovados.Click += new System.EventHandler(this.btnAprovados_Click);
            // 
            // txtJustificativa
            // 
            this.txtJustificativa.Location = new System.Drawing.Point(264, 486);
            this.txtJustificativa.Multiline = true;
            this.txtJustificativa.Name = "txtJustificativa";
            this.txtJustificativa.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtJustificativa.Size = new System.Drawing.Size(529, 72);
            this.txtJustificativa.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(157, 496);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 24);
            this.label1.TabIndex = 30;
            this.label1.Text = "Justificativa:";
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(569, 666);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(224, 20);
            this.txtStatus.TabIndex = 33;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(565, 639);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(65, 24);
            this.lblStatus.TabIndex = 32;
            this.lblStatus.Text = "Status:";
            // 
            // areaInteresseTableAdapter
            // 
            this.areaInteresseTableAdapter.ClearBeforeFill = true;
            // 
            // InformacoesArtigo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 865);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.txtJustificativa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnReprovados);
            this.Controls.Add(this.btnPendentes);
            this.Controls.Add(this.btnAprovados);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAutor);
            this.Controls.Add(this.lblAutor);
            this.Controls.Add(this.cmbArea);
            this.Controls.Add(this.lblAreaDeInteresse);
            this.Controls.Add(this.btnReprovado);
            this.Controls.Add(this.btnAprovar);
            this.Controls.Add(this.txtConteudo);
            this.Controls.Add(this.txtNomeArtigo);
            this.Controls.Add(this.lblConteudo);
            this.Controls.Add(this.lblNomeArtigo);
            this.Name = "InformacoesArtigo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Informações do Artigo";
            this.Load += new System.EventHandler(this.InformacoesArtigo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.areaInteresseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.ComboBox cmbArea;
        private System.Windows.Forms.Label lblAreaDeInteresse;
        private System.Windows.Forms.Button btnReprovado;
        private System.Windows.Forms.Button btnAprovar;
        private System.Windows.Forms.TextBox txtConteudo;
        private System.Windows.Forms.TextBox txtNomeArtigo;
        private System.Windows.Forms.Label lblConteudo;
        private System.Windows.Forms.Label lblNomeArtigo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnReprovados;
        private System.Windows.Forms.Button btnPendentes;
        private System.Windows.Forms.Button btnAprovados;
        private System.Windows.Forms.TextBox txtJustificativa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Label lblStatus;
        private databaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource areaInteresseBindingSource;
        private databaseDataSetTableAdapters.AreaInteresseTableAdapter areaInteresseTableAdapter;
    }
}