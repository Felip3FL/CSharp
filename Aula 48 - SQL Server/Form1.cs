using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Aula_48___SQL_Server
{
    public partial class Form1 : Form
    {

        string strCon = ConfigurationManager.ConnectionStrings["EstoqueFelipeConnectionString"].ConnectionString;

        public DataSet exibeProdutos()
        {
            SqlConnection con = new SqlConnection(strCon);
            String SQL = "Select * from Produtos";
            SqlCommand cmd = new SqlCommand(SQL, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }


        
        /// /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


        public Form1()
        {
            InitializeComponent();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(strCon);
            String SQL = "insert into Produtos values(@id, @nome, @preco)";
            SqlCommand cmd = new SqlCommand(SQL, con);
            cmd.Parameters.AddWithValue("@id", txtID.Text);
            cmd.Parameters.AddWithValue("@nome", txtNome.Text);
            cmd.Parameters.AddWithValue("@preco", txtPreco.Text);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(strCon);
            String SQL = "update produtos set nome=@nome, produto=@preco where id=@id";
            SqlCommand cmd = new SqlCommand(SQL, con);
            cmd.Parameters.AddWithValue("@id", txtID.Text);
            cmd.Parameters.AddWithValue("@nome", txtNome.Text);
            cmd.Parameters.AddWithValue("@preco", txtPreco.Text);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(strCon);
            String SQL = "delete from produtos where id=@id";
            SqlCommand cmd = new SqlCommand(SQL, con);
            cmd.Parameters.AddWithValue("@id", txtID.Text);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void btnExibir_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds = exibeProdutos();
            gdvProdutos.DataSource = ds.Tables[0];
        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(strCon);
            String SQL = "Select * from Produtos where id=@id";
            SqlCommand cmd = new SqlCommand(SQL, con);
            cmd.Parameters.AddWithValue("@id", txtID.Text);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                txtID.Text = Convert.ToString(dr["id"]);
                txtNome.Text = (string)dr["Nome"];
                txtPreco.Text = Convert.ToString(dr["Produto"]);
            }
            dr.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
