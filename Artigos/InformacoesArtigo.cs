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
    public partial class InformacoesArtigo : Form
    {
        private Conexao conn;
        private SqlConnection ConnectOpen;


        public InformacoesArtigo()
        {
            InitializeComponent();
            conn = new Conexao();
            ConnectOpen = conn.ConnectToDatabase();
        }

        private void btnPendentes_Click(object sender, EventArgs e)
        {
            var abreArtigosPendentes = new ArtigosPendentes();
            abreArtigosPendentes.ShowDialog();

            //Verificar se foi selecionado algum item
            if (abreArtigosPendentes.ArtigoSelecionado == "")
                return;

            var conn = Login.ConnectOpen;
            //Buscar Artigo selecionado
            string sql = "Select * from artigos where nomeartigo = '" + abreArtigosPendentes.ArtigoSelecionado + "'";


            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            da.Fill(dt);

            //Linha 0, coluna 0
            txtNomeArtigo.Text = dt.Rows[0][0].ToString();

            //Linha 0, coluna 1
            txtConteudo.Text = dt.Rows[0][1].ToString();

            //Linha 0, coluna 3
            txtAutor.Text = dt.Rows[0][3].ToString();

            //Linha 0, coluna 5
            txtJustificativa.Text = dt.Rows[0][5].ToString();

            //Linha 0, coluna 4
            txtStatus.Text = dt.Rows[0][4].ToString();

            string AreaDeInteresse;

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

        private void btnReprovado_Click(object sender, EventArgs e)
        {

            StringBuilder sql = new StringBuilder();
            sql.Append("UPDATE Artigos ");
            sql.Append("SET status = (@status), justificativa = (@justificativa) where nomeartigo = (@nomeartigo)");
            SqlCommand command = null;

            try
            {
                command = new SqlCommand(sql.ToString(), ConnectOpen);
                command.Parameters.Add(new SqlParameter("@status", "Reprovado"));
                command.Parameters.Add(new SqlParameter("@justificativa", txtJustificativa.Text));
                command.Parameters.Add(new SqlParameter("@nomeartigo", txtNomeArtigo.Text));
                command.ExecuteNonQuery();

                MessageBox.Show("Status atualizado.");
                LimparTela();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar" + ex);
                throw;
            }
        }

        private void btnAprovar_Click(object sender, EventArgs e)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("UPDATE Artigos ");
            sql.Append("SET status = (@status) where nomeartigo = (@nomeartigo)");
            SqlCommand command = null;

            try
            {
                command = new SqlCommand(sql.ToString(), ConnectOpen);
                command.Parameters.Add(new SqlParameter("@status", "Aprovado"));
                command.Parameters.Add(new SqlParameter("@nomeartigo", txtNomeArtigo.Text));
                command.ExecuteNonQuery();

                MessageBox.Show("Status atualizado.");
                LimparTela();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar" + ex);
                throw;
            }
        }

        private void btnAprovados_Click(object sender, EventArgs e)
        {
            var abreArtigosAprovados = new ArtigosAprovados();
            abreArtigosAprovados.ShowDialog();

            //Verificar se foi selecionado algum item
            if (abreArtigosAprovados.ArtigoSelecionado == "")
                return;

            var conn = Login.ConnectOpen;
            //Buscar Artigo selecionado
            string sql = "Select * from artigos where nomeartigo = '" + abreArtigosAprovados.ArtigoSelecionado + "'";


            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            da.Fill(dt);

            //Linha 0, coluna 0
            txtNomeArtigo.Text = dt.Rows[0][0].ToString();

            //Linha 0, coluna 1
            txtConteudo.Text = dt.Rows[0][1].ToString();

            //Linha 0, coluna 3
            txtAutor.Text = dt.Rows[0][3].ToString();

            //Linha 0, coluna 5
            txtJustificativa.Text = dt.Rows[0][5].ToString();

            //Linha 0, coluna 4
            txtStatus.Text = dt.Rows[0][4].ToString();

            string AreaDeInteresse;

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

        private void btnReprovados_Click(object sender, EventArgs e)
        {
            var abreArtigosReprovados = new ArtigosReprovados();
            abreArtigosReprovados.ShowDialog();

            //Verificar se foi selecionado algum item
            if (abreArtigosReprovados.ArtigoSelecionado == "")
                return;

            var conn = Login.ConnectOpen;
            //Buscar Artigo selecionado
            string sql = "Select * from artigos where nomeartigo = '" + abreArtigosReprovados.ArtigoSelecionado + "'";


            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            da.Fill(dt);

            //Linha 0, coluna 0
            txtNomeArtigo.Text = dt.Rows[0][0].ToString();

            //Linha 0, coluna 1
            txtConteudo.Text = dt.Rows[0][1].ToString();

            //Linha 0, coluna 3
            txtAutor.Text = dt.Rows[0][3].ToString();

            //Linha 0, coluna 5
            txtJustificativa.Text = dt.Rows[0][5].ToString();

            //Linha 0, coluna 4
            txtStatus.Text = dt.Rows[0][4].ToString();

            string AreaDeInteresse;

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

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            var TelaVoltar = new Dashboard();
            TelaVoltar.ShowDialog();
        }

        private void InformacoesArtigo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet.AreaInteresse' table. You can move, or remove it, as needed.
            this.areaInteresseTableAdapter.Fill(this.databaseDataSet.AreaInteresse);
        }

        public void LimparTela()
        {
            txtNomeArtigo.Text = "";
            txtConteudo.Text = "";
            txtJustificativa.Text = "";
            cmbArea.Text = "";
            txtAutor.Text = "";
            txtStatus.Text = "";
        }

        public void preencheArea()
        {
            var conn = Login.ConnectOpen;

            try
            {
                SqlCommand cmd = new SqlCommand("select AREA from AreaInteresse ORDER BY ASC");
                SqlDataReader reader = cmd.ExecuteReader(); //Retorna os dados resultantes da consulta;
                DataTable table = new DataTable();
                table.Load(reader); //Carrega dados na tabela de acordo com a instrução SQL passada;
                DataRow row = table.NewRow();
                row["Area"] = "";
                table.Rows.InsertAt(row, 0);

                this.cmbArea.DataSource = table;
                this.cmbArea.ValueMember = "Area";
                this.cmbArea.DisplayMember = "Area";

                reader.Close();
                reader.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível preencher o comboBox" + ex);
            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Fazendo o download do Artigo, por favor aguarde.");
            timerDownload.Start();
        }

        private void timerDownload_Tick(object sender, EventArgs e)
        {
            timerDownload.Stop();
            MessageBox.Show("Download Concluído.");
        }
    }
}