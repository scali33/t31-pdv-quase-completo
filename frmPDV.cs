using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace t31_projetoBase
{
    public partial class frmPDV : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings[2].ConnectionString;
        bool novo;
        int codpro;
        double totalL;
        public frmPDV()
        {
            InitializeComponent();
        }

        private void frmPDV_Load(object sender, EventArgs e)
        {
            restaTela();
            carregarComboCli();
            carregar_grid();

        }
        private void restaTela()
        {

            btnAdicionar.Enabled = false;
            btnRemove.Enabled = false;
            btnClear.Enabled = false;
            btnClear.Enabled = false;
            btnConfirm.Enabled = true;
            txtPreco.Enabled = false;
            cboClientes.Text = string.Empty;
            btnFinaliza.Enabled = false;
            lblTotal.Text = string.Empty;
            lblIdvenda.Text = "0";




            // Itera sobre todos os controles do tipo TextBox no formulário



        }

        //combobox functions
        private void carregarComboCli()
        {
            SqlConnection con = new SqlConnection(connectionString);

            con.Open();
            SqlCommand sql = new SqlCommand();
            sql.Connection = con;
            sql.CommandText = "SELECT nome,codcli,cpf  FROM Clientes ORDER BY nome";
            SqlDataReader dr = sql.ExecuteReader();
            DataTable tb = new DataTable();
            tb.Load(dr);

            cboClientes.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboClientes.AutoCompleteSource = AutoCompleteSource.ListItems;
            cboClientes.ValueMember = "codcli";
            cboClientes.DisplayMember = "nome";
            cboClientes.DataSource = tb;




        }


        private void cboClientes_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cboClientes.SelectedValue != null)
            {
                DataRowView selectedRow = (DataRowView)cboClientes.SelectedItem;
                string cpfSelecionado = selectedRow["cpf"].ToString();
                lblCpf.Text = cpfSelecionado;

                // Aqui você pode usar o CPF selecionado para associar a compra ao cliente
                // Execute a lógica para associar a compra ao cliente usando o CPF
            }


        }


        //fim das combos box

        //carregar grid dos produtos
        private void carregar_grid()
        {
            // sql que filtra com a cláusula LIKE 
            string sql = "select *  from produtos where (descricao + categoria  LIKE '%'+@PESQUISA+'%');";

            // cria objeto da classe de Coneção com O BD
            SqlConnection con = new SqlConnection(connectionString);
            // cria objeto da classe de comandos ( executa comandos SQL no BD)
            SqlCommand cmd = new SqlCommand(sql, con);
            // adiciona paramero requerido na SQL criada, e o parametro vem do que foi digitado na Pesquisa
            cmd.Parameters.AddWithValue("@PESQUISA", txtProdpesquisa.Text);
            // configura o tipo de comando para texto
            cmd.CommandType = CommandType.Text;
            // abre conexão com o BD
            con.Open();
            try
            {
                // cria objeto clone de tabela do BD
                DataTable table = new DataTable();
                // carrega o objeto com o Select que a Sql Pediu para o BD
                table.Load(cmd.ExecuteReader());
                // associa a tabela gerada gerada ao datagrid
                dataGridView2.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO" + ex.ToString());
            }
            finally
            {
                con.Close();
                novo = false;
            }
        }
        //fim carregar grid produtos

        //carrega grid do itensvendas
        private void carregar_gridVendas()
        {
            // sql que filtra com a cláusula LIKE 
            string sql = "SELECT * from itensvendas where codven = @codven;";

            // cria objeto da classe de Coneção com O BD
            SqlConnection con = new SqlConnection(connectionString);
            // cria objeto da classe de comandos ( executa comandos SQL no BD)
            SqlCommand cmd = new SqlCommand(sql, con);
            // adiciona paramero requerido na SQL criada, e o parametro vem do que foi digitado na Pesquisa
            cmd.Parameters.AddWithValue("@codven", int.Parse(lblIdvenda.Text));
            // configura o tipo de comando para texto
            cmd.CommandType = CommandType.Text;
            // abre conexão com o BD
            con.Open();
            try
            {
                // cria objeto clone de tabela do BD
                DataTable table = new DataTable();
                // carrega o objeto com o Select que a Sql Pediu para o BD
                table.Load(cmd.ExecuteReader());
                // associa a tabela gerada gerada ao datagrid
                dataGridView1.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO" + ex.ToString());
            }
            finally
            {
                con.Close();

            }
        }
        //fim carrega grid itensvendas

        //btn adicionar

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            //string sqlSelect = "SELECT V.coditem as Codigo, V.qtd as Quantidade,V.subtotal as Subtotal,V.codven as Codigo_Venda, P.descricao as Produto  FROM itensvendas as V inner join Produtos as P ON V.codpro = P.codpro Where venda id = @";
            string sqlInsert = "Insert into itensvendas (qtd,subtotal,codven,codpro) values (@qtd,@subtotal,@codven,@codpro)";
            // Código do insert
            MessageBox.Show("insert na tabela itensvendas");
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(sqlInsert, con))
                    {
                        int codven = Convert.ToInt32(lblIdvenda.Text);
                        int qtd = int.Parse(txtQuanti.Text);
                        double preco = Convert.ToDouble(txtPreco.Text);
                        double total = preco * qtd;
                        totalL = +totalL + total;
                        lblTotal.Text = totalL.ToString() + " R$";

                        cmd.Parameters.AddWithValue("@qtd", qtd);
                        cmd.Parameters.AddWithValue("@subtotal", total);
                        cmd.Parameters.AddWithValue("@codven", codven);
                        cmd.Parameters.AddWithValue("@codpro", codpro);



                        cmd.ExecuteNonQuery(); // Executa o comando SQL de insert

                        MessageBox.Show("Dados inseridos com sucesso!");
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao inserir os dados: " + ex.Message);
            }
            carregar_gridVendas();
            btnFinaliza.Enabled = true;



        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            DateTime currentDate = DateTime.Now;
            // Código do insert
            MessageBox.Show("insert na venda");
            string sql = "INSERT INTO Vendas (dataven, hora, valortotal, codcli) VALUES (@dataven, @hora, @valortotal, @codcli)";




            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {

                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        TimeSpan hora = DateTime.Now.TimeOfDay;


                        // Verifica se é possível converter o ValueMember para int
                        if (int.TryParse(cboClientes.SelectedValue.ToString(), out int codecli))
                        {
                            cmd.Parameters.AddWithValue("@dataven", currentDate);
                            cmd.Parameters.AddWithValue("@hora", hora);
                            cmd.Parameters.AddWithValue("@codcli", codecli);
                            cmd.Parameters.AddWithValue("@valortotal", 0);

                            cmd.ExecuteNonQuery(); // Executa o comando SQL de insert
                            using (SqlCommand cmdIdentity = new SqlCommand("SELECT @@IDENTITY", con))
                            {
                                int idVenda = Convert.ToInt32(cmdIdentity.ExecuteScalar());
                                lblIdvenda.Text = idVenda.ToString();
                            }


                            MessageBox.Show("Dados inseridos com sucesso!");
                        }
                        else
                        {
                            MessageBox.Show($"O valor do código do cliente não é um número válido. ele é isso aqui ó {cboClientes.ValueMember}");
                            con.Close();
                        }
                    }
                    cboClientes.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao inserir os dados: " + ex.Message);

            }
            btnAdicionar.Enabled = true;
            btnConfirm.Enabled = false;

        }


        private void txtQuanti_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            restaTela();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
        }

        private void txtProdpesquisa_TextChanged(object sender, EventArgs e)
        {
            carregar_grid();
        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            codpro = Convert.ToInt32(dataGridView2.Rows[e.RowIndex].Cells["CodPro"].Value);
            txtPreco.Text = dataGridView2.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void btnFinaliza_Click(object sender, EventArgs e)
        {
            string sql = "UPDATE vendas SET valortotal = @total, hora= @horaven WHERE codven = @codven";

            SqlConnection con = new SqlConnection(connectionString);
            try
            {
                con.Open();

                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    TimeSpan hora = DateTime.Now.TimeOfDay;
                   

                    cmd.Parameters.AddWithValue("@horaven", hora);
                    cmd.Parameters.AddWithValue("@total", totalL);
                    cmd.Parameters.AddWithValue("@codven", int.Parse(lblIdvenda.Text));



                    cmd.ExecuteNonQuery(); // Executa o comando SQL de insert

                    MessageBox.Show("Dados alterados  com sucesso!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao inserir os dados: " + ex.Message);
            }
            finally
            {
                con.Close();

            }
            totalL = 0;
            cboClientes.Enabled = true;
            restaTela();
            carregar_gridVendas();
        }
    }
}
