namespace Artigos
{
    partial class OpcaoRevisao
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
            this.lblArtigos = new System.Windows.Forms.Label();
            this.btnAprovados = new System.Windows.Forms.Button();
            this.btnPendentes = new System.Windows.Forms.Button();
            this.btnReprovados = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblArtigos
            // 
            this.lblArtigos.AutoSize = true;
            this.lblArtigos.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArtigos.Location = new System.Drawing.Point(127, 64);
            this.lblArtigos.Name = "lblArtigos";
            this.lblArtigos.Size = new System.Drawing.Size(132, 45);
            this.lblArtigos.TabIndex = 0;
            this.lblArtigos.Text = "Artigos";
            // 
            // btnAprovados
            // 
            this.btnAprovados.BackColor = System.Drawing.Color.DarkGreen;
            this.btnAprovados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAprovados.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAprovados.ForeColor = System.Drawing.Color.White;
            this.btnAprovados.Location = new System.Drawing.Point(102, 196);
            this.btnAprovados.Name = "btnAprovados";
            this.btnAprovados.Size = new System.Drawing.Size(176, 35);
            this.btnAprovados.TabIndex = 1;
            this.btnAprovados.Text = "APROVADOS";
            this.btnAprovados.UseVisualStyleBackColor = false;
            this.btnAprovados.Click += new System.EventHandler(this.btnAprovados_Click);
            // 
            // btnPendentes
            // 
            this.btnPendentes.BackColor = System.Drawing.Color.Goldenrod;
            this.btnPendentes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPendentes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPendentes.ForeColor = System.Drawing.Color.White;
            this.btnPendentes.Location = new System.Drawing.Point(102, 145);
            this.btnPendentes.Name = "btnPendentes";
            this.btnPendentes.Size = new System.Drawing.Size(176, 33);
            this.btnPendentes.TabIndex = 2;
            this.btnPendentes.Text = "PENDENTES";
            this.btnPendentes.UseVisualStyleBackColor = false;
            this.btnPendentes.Click += new System.EventHandler(this.btnPendentes_Click);
            // 
            // btnReprovados
            // 
            this.btnReprovados.BackColor = System.Drawing.Color.DarkRed;
            this.btnReprovados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReprovados.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReprovados.ForeColor = System.Drawing.Color.White;
            this.btnReprovados.Location = new System.Drawing.Point(102, 251);
            this.btnReprovados.Name = "btnReprovados";
            this.btnReprovados.Size = new System.Drawing.Size(176, 31);
            this.btnReprovados.TabIndex = 3;
            this.btnReprovados.Text = "REPROVADOS";
            this.btnReprovados.UseVisualStyleBackColor = false;
            this.btnReprovados.Click += new System.EventHandler(this.btnReprovados_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(102, 299);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(176, 31);
            this.btnVoltar.TabIndex = 4;
            this.btnVoltar.Text = "VOLTAR";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // OpcaoRevisao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 398);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnReprovados);
            this.Controls.Add(this.btnPendentes);
            this.Controls.Add(this.btnAprovados);
            this.Controls.Add(this.lblArtigos);
            this.Name = "OpcaoRevisao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Revisão de Artigos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblArtigos;
        private System.Windows.Forms.Button btnAprovados;
        private System.Windows.Forms.Button btnPendentes;
        private System.Windows.Forms.Button btnReprovados;
        private System.Windows.Forms.Button btnVoltar;
    }
}