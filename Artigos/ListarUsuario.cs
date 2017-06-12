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
    public partial class ListarUsuario : Form
    {
        public string UsuarioSelecionado = "";

        public ListarUsuario()
        {
            InitializeComponent();
        }

        private void ListarUsuario_Load(object sender, EventArgs e)
        {
            var conn = Login.ConnectOpen;
            //Buscar todos usuários cadastrados
            string sql = "Select * from usuarios ";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                dataGridView1.DataSource = dt;
            }
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            //Recuperar a linha selecionadas.
            UsuarioSelecionado = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();

            //Fechar a tela
            Hide();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }        

        private void btnPesquisar_Click_1(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "")
            {
                var conn = Login.ConnectOpen;
                string sql = "Select * from Usuarios";
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
                switch (cmbBusca.Text)
                {
                    case "Usuário":
                        var conn = Login.ConnectOpen;
                        string sql = "Select * from Usuarios where Usuario = '" + txtBuscar.Text + "'";
                        DataTable dt = new DataTable();
                        SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                        da.Fill(dt);

                        if (dt.Rows.Count > 0)
                        {
                            dataGridView1.DataSource = dt;
                        }
                        break;
                    case "ID":
                        var conn2 = Login.ConnectOpen;
                        string sql2 = "Select * from Usuarios where ID = '" + txtBuscar.Text + "'";
                        DataTable dt2 = new DataTable();
                        SqlDataAdapter da2 = new SqlDataAdapter(sql2, conn2);
                        da2.Fill(dt2);

                        if (dt2.Rows.Count > 0)
                        {
                            dataGridView1.DataSource = dt2;
                        }
                        break;
                }
            }
        }
    }
}
