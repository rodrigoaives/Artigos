using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Artigos
{
    public partial class Dashboard : Form
    {
            //1 - Autores
            //2 - Revisores
            //3 - Gerente
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            var frmLogin = new Login();
            frmLogin.ShowDialog();

            if (frmLogin.logado == false) {
                Close();

            }

            if (Login.perfilUsuario == 3)
            {
                btnCadastrarUsuario.Enabled = true;
                btnNovaArea.Enabled = true;
                btnRevisarArtigo.Enabled = true;
            }
            else if (Login.perfilUsuario == 2)
            {
                btnRevisarArtigo.Enabled = true;
            }
            else
                btnCadastrarArtigo.Enabled = true;
        }

        private void btnCadastrarUsuario_Click(object sender, EventArgs e)
        {
            var TelaCadastrar = new Cadastrar();
            TelaCadastrar.ShowDialog();
        }

        private void btnCadastrarArtigo_Click(object sender, EventArgs e)
        {
            var CadastrarArtigo = new CadastrarArtigo();
            CadastrarArtigo.ShowDialog();
        }

        private void btnRevisarArtigo_Click(object sender, EventArgs e)
        {
            var TelaInformacoesArtigo = new InformacoesArtigo();
            TelaInformacoesArtigo.ShowDialog();
        }

        private void btnNovaArea_Click(object sender, EventArgs e)
        {
            var TelaNovaArea = new AreaDeInteresse();
            TelaNovaArea.ShowDialog();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
