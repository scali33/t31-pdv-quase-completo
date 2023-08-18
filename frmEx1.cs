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
    public partial class frmEx1 : Form
    {
        public frmEx1()
        {
            InitializeComponent();
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            var entrada = (txtNum.Text);
            int numero;
            bool isnumber = int.TryParse(entrada, out numero);

            if (isnumber) 
            {
                MessageBox.Show($"O número {(numero % 2 == 0 ? "par" : "impar")} parbaens");


            }
            else
            {
                 MessageBox.Show("porfavor coloque apenas numeros", "Foi par ou impar?", MessageBoxButtons.OK);
            }

        }
    }
}
