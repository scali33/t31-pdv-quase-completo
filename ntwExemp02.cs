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
using System.Configuration;

namespace t31_projetoBase
{
    public partial class ntwExemp02 : Form
    {
        public string conexao = ConfigurationManager.ConnectionStrings[1].ConnectionString;

        private void carregarCombo()
        {

            SqlConnection con = new SqlConnection(conexao);

            con.Open();
            SqlCommand sql = new SqlCommand();
            sql.Connection = con;
            sql.CommandText = "SELECT CategoryName,CategoryID FROM Categories";
            SqlDataReader dr = sql.ExecuteReader();
            DataTable tb = new DataTable();
            tb.Load(dr);

            cboFiltro.ValueMember = "CategoryName";
            cboFiltro.DataSource = tb;


        }

        private void carregarGrid()
        {
            string param =  cboFiltro.SelectedValue.ToString();
            string sql = "SELECT categories.categoryID AS Código_da_categoria, products.ProductName as Produto, products.UnitPrice as Preço, products.UnitsInStock as Estoque, products.ProductId as Código" +
                " FROM Products " +
            "INNER JOIN Categories ON categories.categoryID = products.categoryID " +
            "WHERE CategoryName = @param"+
            " ORDER BY products.ProductID";

            SqlConnection con = new SqlConnection(conexao);
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@param", param);
            cmd.CommandType = CommandType.Text;
            con.Open();
            try
            {
                DataTable table = new DataTable();
                table.Load(cmd.ExecuteReader());
                dgvProdutos.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.ToString());
            }
            finally
            {
                con.Close();
            }
        }
        public ntwExemp02()
        {
            InitializeComponent();
            carregarCombo();
        }

        private void btnCarregar_Click(object sender, EventArgs e)
        {
            carregarGrid();
        }
    }




}


