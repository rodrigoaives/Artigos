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
    public partial class AreasCadastradas : Form
    {
        public string AreaSelecionada = "";

        public AreasCadastradas()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AreasCadastradas_Load(object sender, EventArgs e)
        {
            var conn = Login.ConnectOpen;
            string sql = "Select * from AreaInteresse";
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
            AreaSelecionada = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            //Fechar a tela
            Hide();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "")
            {
                var conn = Login.ConnectOpen;
                string sql = "Select * from AreaInteresse";
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    dataGridView1.DataSource = dt;
                }
            }
            else
            {
                var conn = Login.ConnectOpen;
                string sql = "Select * from AreaInteresse where area = '" + txtBuscar.Text + "'";
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
