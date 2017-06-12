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
    public partial class Login : Form
    {
        public bool logado = false;
        private Conexao conn;
        public static SqlConnection ConnectOpen;
        public static int perfilUsuario;

        public Login()
        {
            conn = new Conexao();
            ConnectOpen = conn.ConnectToDatabase();
            InitializeComponent();
        }



        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string strCommand = "Select * from usuarios where usuario = '" + txtUsuario.Text + "' and " + "Senha = '" + txtSenha.Text + "'";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(strCommand,ConnectOpen);
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                this.Hide();
                logado = true;
                perfilUsuario = Convert.ToInt16(dt.Rows[0][2]);
            }
            else
                MessageBox.Show("Usuário ou senha incorreto(s)!");

        }

        private void Focus(object sender, EventArgs e)
        {
            var btn = (TextBox)sender;
            btn.Text = string.Empty;
            btn.ForeColor = Color.Black;
        }
        private void Login_Load(object sender, EventArgs e)
        {
            txtUsuario.GotFocus += Focus;
            txtSenha.GotFocus += Focus;

        }

        private void lblCadastrar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            var frm = new CadastrarUsuario();
            frm.ShowDialog();             
        }

        private void txtUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtSenha.Focus();
            }
        }

        private void txtSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnEntrar.PerformClick();
            }            
        }

        private void lblEsqueceu_Senha_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Foi enviado uma redefinição de senha para o email cadastrado.");
        }
    }
}
