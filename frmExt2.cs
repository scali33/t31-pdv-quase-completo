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
    public partial class frmExt2 : Form
    {
        public frmExt2()
        {
            InitializeComponent();
        }

        private void btnMostarci_Click(object sender, EventArgs e)
        {
            string cidade = cboCidades.SelectedItem as string;

            if (cidade != null)
            {
                MessageBox.Show($"a CIDADE SELECIONADA È {cidade}", "Atenção!!!!!");
            }
            else
            {
                MessageBox.Show("nada selecionado");
            }

        }
    }
}
