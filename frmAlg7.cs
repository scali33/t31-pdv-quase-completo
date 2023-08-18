using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace t31_projetoBase
{
    public partial class frmAlg7 : Form
    {
        public frmAlg7()
        {
            InitializeComponent();
        }

        private void btnSomarFor_Click(object sender, EventArgs e)
        {
            var valor = txtNum.Text;
            int num;
            int conta = 0;
            bool isanumber = int.TryParse(valor, out num);
            if (isanumber)
            {
                for (int i = 1; i <= num; i++)
                {
                    conta = i+conta;
                    lstSoma.Items.Add($"somando...{conta}");
                }
            }
            else

            {
                MessageBox.Show("digite numeros"+"no caso foi"+num);
            }
        }
    }
}
