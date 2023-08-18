using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace t31_projetoBase
{
    public partial class frmBco4 : Form
    {
        bool novo;
        private string connectionString = ConfigurationManager.ConnectionStrings[2].ConnectionString;
        public frmBco4()
        {
            InitializeComponent();
         
        }
        private void restaTela()
        {

            btnAdicionar.Enabled = true;
            btnSalvar.Enabled = false;
            btnCancelar.Enabled = false;
            btnExcluir.Enabled = false;
            lblcodigo.Text = string.Empty;

            // Itera sobre todos os controles do tipo TextBox no formulário
            foreach (TextBox textBox in Controls.OfType<TextBox>())
            {
                // Limpa o conteúdo do TextBox
                textBox.Text = String.Empty;
                textBox.Enabled = false;
            }
            txtPesquisa.Enabled = true;
        }


        private void carregar_grid()
        {
            // sql que filtra com a cláusula LIKE 
            string sql = "SELECT [codfor]\r\n      ,[razaosocial]\r\n      ,[nomefan]\r\n      ,[cnpj]\r\n      ,[rua]\r\n      ,[bairro]\r\n      ,[estado]\r\n      ,[telefone]\r\n      ,[email]\r\n      ,[cep]\r\n      ,[cidade]\r\n  FROM [dbo].[Fornecedores]\r\n  WHERE ([razaosocial] + [nomefan] + [cnpj] + [rua] + [bairro] + [estado] + [telefone] + [email] + [cep] + [cidade]  LIKE '%'+@PESQUISA+'%');";

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
        private void restaTela(int num)
        {
            btnAdicionar.Enabled = false;
            btnSalvar.Enabled = true;
            btnCancelar.Enabled = true;
            btnExcluir.Enabled = true;

            // Itera sobre todos os controles do tipo TextBox no formulário
            foreach (TextBox textBox in Controls.OfType<TextBox>())
            {
                // Limpa o conteúdo do TextBox
                textBox.Text = String.Empty;
                textBox.Enabled = true;
            }
            if (txtraz != null)
            {
                foreach (TextBox textBox in Controls.OfType<TextBox>())
                {
                    // Limpa o conteúdo do TextBox
                    textBox.Enabled = true;
                }
            }


        }

        private void frmBco4_Load(object sender, EventArgs e)
        {
            restaTela();
            carregar_grid();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            restaTela(1);
            novo = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            restaTela();
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            carregar_grid();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtraz.Focus();
            restaTela(1);
            lblcodigo.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtraz.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtnomefan.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtcnpj.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtrua.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtbairro.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtestado.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            txttelefone.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            txtemail.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
            txtcep.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
            txtcidade.Text = dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            string sql = "DELETE FROM Fornecedores WHERE codfor=@codigo";
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@codigo", lblcodigo.Text);
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
            carregar_grid();
            restaTela();
          
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (novo)
            {
                // Código do insert
                MessageBox.Show("insert");
                string sql = "insert into Fornecedores (razaosocial, nomefan, cnpj, rua, cidade, bairro, estado, telefone, email, cep) values (@razao,@nomefan,@cnpj,@rua,@cidade,@bairro,@estado,@telefone,@email,@cep)";

                try
                {
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        con.Open();
                        using (SqlCommand cmd = new SqlCommand(sql, con))
                        {
                            
                            cmd.Parameters.AddWithValue("@nomefan", txtnomefan.Text);
                            cmd.Parameters.AddWithValue("@razao", txtraz.Text);
                            cmd.Parameters.AddWithValue("@cnpj", txtcnpj.Text);
                            cmd.Parameters.AddWithValue("@rua", txtrua.Text);
                            cmd.Parameters.AddWithValue("@telefone", txttelefone.Text);
                            cmd.Parameters.AddWithValue("@cidade", txtcidade.Text);
                            cmd.Parameters.AddWithValue("@cep", txtcep.Text);
                            cmd.Parameters.AddWithValue("@bairro", txtbairro.Text);
                            cmd.Parameters.AddWithValue("@estado", txtestado.Text);
                            cmd.Parameters.AddWithValue("@email", txtemail.Text);

                            cmd.ExecuteNonQuery(); // Executa o comando SQL de insert

                            MessageBox.Show("Dados inseridos com sucesso!");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro ao inserir os dados: " + ex.Message);
                }
                carregar_grid();
            }
            else
            {
                // Código do update

                string sql = "UPDATE Fornecedores SET razaosocial = @razao, nomefan = @nomefan, cnpj = @cnpj, rua = @rua, cidade = @cidade,bairro = @bairro, estado = @estado, telefone = @telefone, email = @email, cep = @cep  WHERE codfor = @codefor";

                SqlConnection con = new SqlConnection(connectionString);
                try
                {
                    con.Open();

                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@codefor", lblcodigo.Text);
                        cmd.Parameters.AddWithValue("@nomefan", txtnomefan.Text);
                        cmd.Parameters.AddWithValue("@razao", txtraz.Text);
                        cmd.Parameters.AddWithValue("@cnpj", txtcnpj.Text);
                        cmd.Parameters.AddWithValue("@rua", txtrua.Text);
                        cmd.Parameters.AddWithValue("@telefone", txttelefone.Text);
                        cmd.Parameters.AddWithValue("@cidade", txtcidade.Text);
                        cmd.Parameters.AddWithValue("@cep", txtcep.Text);
                        cmd.Parameters.AddWithValue("@bairro", txtbairro.Text);
                        cmd.Parameters.AddWithValue("@estado", txtestado.Text);
                        cmd.Parameters.AddWithValue("@email", txtemail.Text);
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
                    carregar_grid();
                }
            }
        }
    }
}
