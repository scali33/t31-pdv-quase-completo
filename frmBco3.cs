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
using System.ComponentModel.Design.Serialization;
using System.Diagnostics.Eventing.Reader;

namespace t31_projetoBase
{
    public partial class frmBco3 : Form
    {
        // criando a variável string qeu tem a conexão com o banco de dados
        //1 é o Northwind e 2 é o banco chicó
        private string connectionString = ConfigurationManager.ConnectionStrings[2].ConnectionString;
        //variavel de controle para definir INSERT ou UPDATE
        bool novo = true;

        public frmBco3()
        {
            InitializeComponent();
        }
        private void restaTela()
        {

            btnAdicionar.Enabled = true;
            btnSalvar.Enabled = false;
            btnCancel.Enabled = false;
            btnExcluir.Enabled = false;
            lblCode.Text = string.Empty;

            // Itera sobre todos os controles do tipo TextBox no formulário
            foreach (TextBox textBox in Controls.OfType<TextBox>())
            {
                // Limpa o conteúdo do TextBox
                textBox.Text = String.Empty;
                textBox.Enabled = false;
            }
            txtPesquisa.Enabled = true;
        }
        private void restaTela(int num)
        {
            btnAdicionar.Enabled = false;
            btnSalvar.Enabled = true;
            btnCancel.Enabled = true;
            btnExcluir.Enabled = true;
            lblCode.Text = string.Empty;

            // Itera sobre todos os controles do tipo TextBox no formulário
            foreach (TextBox textBox in Controls.OfType<TextBox>())
            {
                // Limpa o conteúdo do TextBox
                textBox.Text = String.Empty;
                textBox.Enabled = true;
            }

        }
        private void restaTela(string two)
        {
            btnAdicionar.Enabled = false;
            btnSalvar.Enabled = true;
            btnCancel.Enabled = true;
            btnExcluir.Enabled = true;
            lblCode.Text = string.Empty;

            // Itera sobre todos os controles do tipo TextBox no formulário
            foreach (TextBox textBox in Controls.OfType<TextBox>())
            {
                // Limpa o conteúdo do TextBox
                textBox.Enabled = true;
            }

        }

        private void carrega_grid()
        {
            // sql que filtra com a cláusula LIKE 
            string sql = "SELECT codcli, nome, cpf, rg, rua, telefone, cidade, cep, bairro, estado " +
                "FROM Clientes WHERE (nome + cpf + rg + rua + telefone + cidade + cep + bairro + estado " +
                "LIKE '%' + @PESQUISA + '%')";

            // cria objeto da classe de Coneção com O BD
            SqlConnection con = new SqlConnection(connectionString);
            // cria objeto da classe de comandos ( executa comandos SQL no BD)
            SqlCommand cmd = new SqlCommand(sql, con);
            // adiciona paramero requerido na SQL criada, e o parametro vem do que foi digitado na Pesquisa
            cmd.Parameters.AddWithValue("@PESQUISA", txtPesquisa.Text);
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
                novo = false;
            }
        }

        private void frmBco3_Load(object sender, EventArgs e)
        {
            restaTela();
            carrega_grid();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            restaTela(1);
            novo = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            restaTela();
            novo = false;
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            carrega_grid();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string chumbas = "ahahaha";
            restaTela(chumbas);
            //posiciona o cursor na caixa de texto indicada
            txtNome.Focus();
            //captura cada coluna da grid e passa o valor convertido em texto para
            // a caixa de texto da esquerda
            lblCode.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtNome.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtCpf.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtRg.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtRua.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtTelefone.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtCidade.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            txtCep.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            txtBairro.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
            txtEstado.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();




        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            string sql = "DELETE FROM Clientes WHERE codcli=@codigo";
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@codigo", lblCode.Text);
            cmd.CommandType = CommandType.Text;
            con.Open();

            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Registro excluido com sucesso!",
                        "informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.ToString());

            }
            finally
            {
                con.Close();
            }
            carrega_grid();
            restaTela();

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
         
            if (novo)
            {
                // Código do insert
                string sql = "INSERT INTO Clientes (nome, cpf, rg, rua, telefone, cidade, cep, bairro, estado) VALUES (@nome, @cpf, @rg, @rua, @telefone, @cidade, @cep, @bairro, @estado)";

                try
                {
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        con.Open();

                        using (SqlCommand cmd = new SqlCommand(sql, con))
                        {
                            cmd.Parameters.AddWithValue("@nome", txtNome.Text);
                            cmd.Parameters.AddWithValue("@cpf", txtCpf.Text);
                            cmd.Parameters.AddWithValue("@rg", txtRg.Text);
                            cmd.Parameters.AddWithValue("@rua", txtRua.Text);
                            cmd.Parameters.AddWithValue("@telefone", txtTelefone.Text);
                            cmd.Parameters.AddWithValue("@cidade", txtCidade.Text);
                            cmd.Parameters.AddWithValue("@cep", txtCep.Text);
                            cmd.Parameters.AddWithValue("@bairro", txtBairro.Text);
                            cmd.Parameters.AddWithValue("@estado", txtEstado.Text);

                            cmd.ExecuteNonQuery(); // Executa o comando SQL de insert

                            MessageBox.Show("Dados inseridos com sucesso!");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro ao inserir os dados: " + ex.Message);
                }
                carrega_grid();
            }
            else
            {
                // Código do update

                string sql = "UPDATE Clientes SET nome = @nome, cpf = @cpf, rg = @rg, rua = @rua, telefone = @telefone, " +
                              "cidade = @cidade, cep = @cep, bairro = @bairro, estado = @estado WHERE codcli = @codecli";
                SqlConnection con = new SqlConnection(connectionString);
                    try
                    {
                        con.Open();

                        using (SqlCommand cmd = new SqlCommand(sql, con))
                        {
                            cmd.Parameters.AddWithValue("@nome", txtNome.Text);
                            cmd.Parameters.AddWithValue("@cpf", txtCpf.Text);
                            cmd.Parameters.AddWithValue("@rg", txtRg.Text);
                            cmd.Parameters.AddWithValue("@rua", txtRua.Text);
                            cmd.Parameters.AddWithValue("@telefone", txtTelefone.Text);
                            cmd.Parameters.AddWithValue("@cidade", txtCidade.Text);
                            cmd.Parameters.AddWithValue("@cep", txtCep.Text);
                            cmd.Parameters.AddWithValue("@bairro", txtBairro.Text);
                            cmd.Parameters.AddWithValue("@estado", txtEstado.Text);
                            cmd.Parameters.AddWithValue("@codecli",lblCode.Text);

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
                    carrega_grid();
                }
            }


        }

        }
            
 }

