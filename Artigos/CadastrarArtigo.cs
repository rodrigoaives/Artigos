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
    public partial class CadastrarArtigo : Form
    {
        private Conexao conn;
        private SqlConnection ConnectOpen;

        public CadastrarArtigo()
        {
            InitializeComponent();
            conn = new Conexao();
            ConnectOpen = conn.ConnectToDatabase();
        }

        private void btnArtigosEnviados_Click(object sender, EventArgs e)
        {
            var ArtigosEnviados = new ArtigosEnviados();
            ArtigosEnviados.ShowDialog();


            //Verificar se foi selecionado algum item
            if (ArtigosEnviados.ArtigoSelecionado == "")
                return;

            var conn = Login.ConnectOpen;
            //Buscar Artigo selecionado
            string sql = "Select * from artigos where nomeartigo = '" + ArtigosEnviados.ArtigoSelecionado + "'";


            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            da.Fill(dt);

            //Linha 0, coluna 0
            txtNomeArtigo.Text = dt.Rows[0][0].ToString();

            //Linha 0, coluna 1
            txtConteudo.Text = dt.Rows[0][1].ToString();

            //Linha 0, coluna 3
            txtAutor.Text = dt.Rows[0][3].ToString();

            //Linha 0, coluna 4
            txtStatus.Text = dt.Rows[0][4].ToString();

            string AreaDeInteresse = "";

            switch (dt.Rows[0][6].ToString())
            {
                case "Tecnologia":
                    AreaDeInteresse = "Tecnologia";
                    break;
                case "Português":
                    AreaDeInteresse = "Português";
                    break;
                case "Ciências":
                    AreaDeInteresse = "Ciências";
                    break;
                case "Matemática":
                    AreaDeInteresse = "Matemática";
                    break;
                default:
                    AreaDeInteresse = "";
                    break;
            }
            cmbArea.Text = AreaDeInteresse;
        }


        private void btnSubmeterAnalise_Click(object sender, EventArgs e)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("Insert into Artigos(nomeartigo, conteudo, area, autor, status) ");
            sql.Append("Values (@nomeartigo, @conteudo, @area, @autor, @status)");
            SqlCommand command = null;

            string AreaInteresse = "";

            switch (cmbArea.Text)
            {
                case "Tecnologia":
                    AreaInteresse = "Tecnologia";
                    break;
                case "Português":
                    AreaInteresse = "Português";
                    break;
                case "Ciências":
                    AreaInteresse = "Ciências";
                    break;
                case "Matemática":
                    AreaInteresse = "Matemática";
                    break;
                default:
                    AreaInteresse = "";
                    break;
                    }
                    try
                    {
                        command = new SqlCommand(sql.ToString(), ConnectOpen);
                        command.Parameters.Add(new SqlParameter("@nomeartigo", txtNomeArtigo.Text));
                        command.Parameters.Add(new SqlParameter("@conteudo", txtConteudo.Text));
                        command.Parameters.Add(new SqlParameter("@area", AreaInteresse));
                        command.Parameters.Add(new SqlParameter("@autor", txtAutor.Text));
                        command.Parameters.Add(new SqlParameter("@status", "Em Análise"));
                        command.ExecuteNonQuery();

                        MessageBox.Show("Artigo enviado com sucesso.");
                        LimparTela();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao cadastrar" + ex);
                        LimparTela();
                        throw;
                    }
            }


        private void btnVoltar_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void btnVersaoFinal_Click(object sender, EventArgs e)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("UPDATE Artigos ");
            sql.Append("SET status = (@status) where nomeartigo = (@nomeartigo)");
            SqlCommand command = null;

            try
            {
                command = new SqlCommand(sql.ToString(), ConnectOpen);
                command.Parameters.Add(new SqlParameter("@status", "Publicado"));
                command.Parameters.Add(new SqlParameter("@nomeartigo", txtNomeArtigo.Text));
                command.ExecuteNonQuery();

                MessageBox.Show("Status atualizado.");
                LimparTela();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar" + ex);
                LimparTela();
                throw;
            }
        }

        public void LimparTela()
        {
            txtNomeArtigo.Text = "";
            txtConteudo.Text = "";
            cmbArea.Text = "";
            txtAutor.Text = "";
            txtStatus.Text = "";
        }

        private void CadastrarArtigo_Load(object sender, EventArgs e)
        {

        }
    }
}

