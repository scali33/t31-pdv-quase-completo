﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
//using Microsoft.Data.SqlClient;

namespace t31_projetoBase
{
    public partial class frmBco1 : Form
    {
        private string conexao = ConfigurationManager.ConnectionStrings[1].ConnectionString;
        public frmBco1()
        {
            InitializeComponent();
        }
        private void carregagrid()
        {

            string sql = "SELECT * FROM categories";

            SqlConnection con = new SqlConnection(conexao);
            SqlCommand cmd = new SqlCommand(sql, con);

            cmd.CommandType = CommandType.Text;
            con.Open();
            try
            {
                DataTable table = new DataTable();
                table.Load(cmd.ExecuteReader());
                dgvCategories.DataSource = table;
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
        private void carregarCombo()
        {
            SqlConnection con = new SqlConnection(conexao);

            con.Open();
            SqlCommand sql = new SqlCommand();
            sql.Connection = con;
            sql.CommandText = "SELECT companyName As Fornecedor FROM Suppliers ORDER BY Fornecedor";
            SqlDataReader dr = sql.ExecuteReader();
            DataTable tb = new DataTable();
            tb.Load(dr);

            cboSuppliers.ValueMember = "Fornecedor";
            cboSuppliers.DataSource = tb;

            btnSelectFromBco.Enabled = true;
        }

        private void btnCarregar_Click(object sender, EventArgs e)
        {
            carregagrid();
        }

        private void btnCarregarcombo_Click(object sender, EventArgs e)
        {
            carregarCombo();
        }

        private void btnSelectFromBco_Click(object sender, EventArgs e)
        {
            MessageBox.Show("foi selecionado:" + cboSuppliers.ValueMember.ToString());
        }
    }
}
