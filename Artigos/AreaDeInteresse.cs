using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Artigos
{
    public partial class AreaDeInteresse : Form
    {
        private Conexao conn;
        private SqlConnection ConnectOpen;
        public AreaDeInteresse()
        {
            InitializeComponent();
            conn = new Conexao();
            ConnectOpen = conn.ConnectToDatabase();
        }
        private void btnVoltar_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "")
            {
                MessageBox.Show("Nome da área é obrigatório.");
            }
            else if (txtRevisores.Text == "")
            {
                MessageBox.Show("Insira o nome de pelo menos 1 revisor.");
            }
            else { 
            string novaArea = "";
                novaArea = txtNome.Text;

                StringBuilder sql = new StringBuilder();
                sql.Append("Insert into AreaInteresse (Area, Revisores) ");
                sql.Append("Values (@nome, @revisores)");
                SqlCommand command = null;

                try
                {
                    command = new SqlCommand(sql.ToString(), ConnectOpen);
                    command.Parameters.Add(new SqlParameter("@nome", txtNome.Text));
                    command.Parameters.Add(new SqlParameter("@revisores", txtRevisores.Text));
                    command.ExecuteNonQuery();

                    MessageBox.Show("Área de Interesse cadastrada com sucesso!");
                    LimparTela();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao cadastrar" + ex);
                    throw;
                }
            }
        }
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "")
            {
                MessageBox.Show("Nome da área é obrigatório.");
            }
            else
            {
                StringBuilder sql = new StringBuilder();
                sql.Append("DELETE FROM AreaInteresse ");
                sql.Append("where area = (@nome)");
                SqlCommand command = null;

                try
                {
                    command = new SqlCommand(sql.ToString(), ConnectOpen);
                    command.Parameters.Add(new SqlParameter("@nome", txtNome.Text));
                    command.ExecuteNonQuery();

                    MessageBox.Show("Área de interesse excluída com sucesso!");
                    LimparTela();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao excluir" + ex);
                    throw;
                }
            }
        }

        private void LimparTela()
        {
            txtNome.Text = "";
            txtRevisores.Text = "";
        }

        private void btnListarTodos_Click(object sender, EventArgs e)
        {
            var AreasCadastradas= new AreasCadastradas();
            AreasCadastradas.ShowDialog();

            var conn = Login.ConnectOpen;
            //Verificar se foi selecionado algum item
            if (AreasCadastradas.AreaSelecionada == "")
            return;

            //var conn = Login.ConnectOpen;
            //Buscar Artigo selecionado
            string sql = "Select * from AreaInteresse where area = '" + AreasCadastradas.AreaSelecionada + "'";
            
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            da.Fill(dt);

            //Linha 0, coluna 0
            txtNome.Text = dt.Rows[0][0].ToString();

            //Linha 0, coluna 1
            txtRevisores.Text = dt.Rows[0][1].ToString();
        }
   }
}
