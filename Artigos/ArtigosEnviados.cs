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
    public partial class ArtigosEnviados : Form
    {
        public string ArtigoSelecionado = "";
        public ArtigosEnviados()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ArtigosEnviados_Load(object sender, EventArgs e)
        {
            var conn = Login.ConnectOpen;
            string sql = "Select * from artigos";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                dataGridView1.DataSource = dt;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            //Recuperar a linha selecionadas.
            ArtigoSelecionado = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();

            //Fechar a tela
            Hide();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string txtPesquisar = txtBuscar.Text;

            if (txtPesquisar == "")
            {
                var conn1 = Login.ConnectOpen;
                string sql1 = "Select * from artigos";
                DataTable dt1 = new DataTable();
                SqlDataAdapter da1 = new SqlDataAdapter(sql1, conn1);
                da1.Fill(dt1);

                if (dt1.Rows.Count > 0)
                {
                    dataGridView1.DataSource = dt1;
                }
            }
            else
            {
                var conn = Login.ConnectOpen;
                string sql = "Select * from artigos where nomeartigo = '" + txtPesquisar + "'";
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    dataGridView1.DataSource = dt;
                }
            }
        }
    }
}
