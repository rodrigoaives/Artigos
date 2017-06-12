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
    public partial class CadastrarUsuario : Form
    {
        private Conexao conn;
        private SqlConnection ConnectOpen;
        public CadastrarUsuario()
        {
            InitializeComponent();
            conn = new Conexao();
            ConnectOpen = conn.ConnectToDatabase();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Hide();
            Login abreTelaLogin = new Login();
            abreTelaLogin.ShowDialog();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text != "" &&
                txtTelefone.Text != "" &&
                txtEmail.Text != "" &&
                txtUsuario.Text != "" &&
                txtSenha.Text != ""
                )
            {
                StringBuilder sql = new StringBuilder();
                sql.Append("Insert into usuarios(nome, telefone, email, usuario, senha, perfil) ");
                sql.Append("Values (@nome, @telefone, @email, @usuario, @senha, @perfil)");
                SqlCommand command = null;

                try
                {
                    command = new SqlCommand(sql.ToString(), ConnectOpen);
                    command.Parameters.Add(new SqlParameter("@nome", txtNome.Text));
                    command.Parameters.Add(new SqlParameter("@telefone", txtTelefone.Text));
                    command.Parameters.Add(new SqlParameter("@email", txtEmail.Text));
                    command.Parameters.Add(new SqlParameter("@usuario", txtUsuario.Text));
                    command.Parameters.Add(new SqlParameter("@senha", txtSenha.Text));
                    command.Parameters.Add(new SqlParameter("@perfil", 1));
                    command.ExecuteNonQuery();

                    MessageBox.Show("Cadastrado com sucesso!");
                    LimparTela();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao cadastrar" + ex);
                    throw;
                }
            }
            else if (txtNome.Text == "") { 
                MessageBox.Show("O campo Nome é obrigatório.");
            } else if (txtTelefone.Text == "")
            {
                MessageBox.Show("O campo Telefone é obrigatório.");
            } else if (txtEmail.Text == "")
            {
                MessageBox.Show("O campo Email é obrigatório.");
            }else if (txtUsuario.Text == "")
            {
                MessageBox.Show("O campo Usuário é obrigatório.");
            } else if (txtSenha.Text == "")
            {
                MessageBox.Show("O campo Senha é obrigatório.");
            } 
}


       private void LimparTela()
        {
            txtNome.Text = "";
            txtTelefone.Text = "";
            txtEmail.Text = "";
            txtUsuario.Text = "";
            txtSenha.Text = "";            
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            LimparTela();
        }
    }
}
