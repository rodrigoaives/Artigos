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
    public partial class OpcaoRevisao : Form
    {
        public OpcaoRevisao()
        {
            InitializeComponent();
        }

        private void btnPendentes_Click(object sender, EventArgs e)
        {
            var TelaArtigosPendentes = new ArtigosPendentes();
            TelaArtigosPendentes.ShowDialog();
        }

        private void btnAprovados_Click(object sender, EventArgs e)
        {
            var TelaArtigosAprovados = new ArtigosAprovados();
            TelaArtigosAprovados.ShowDialog();
        }

        private void btnReprovados_Click(object sender, EventArgs e)
        {
            var TelaArtigosReprovados = new ArtigosReprovados();
            TelaArtigosReprovados.ShowDialog();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
