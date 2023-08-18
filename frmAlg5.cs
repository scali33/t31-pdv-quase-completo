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
    public partial class frmAlg5 : Form
    {
        public frmAlg5()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
          var   num = double.Parse(txtNum.Text);
            lboResultado.Items.Clear();
           for (int i = 0; i <= 10; i += 1)
            {
                lboResultado.Items.Add($" {i} X {num} == {i*num} ");
            }
        }
    }
}
