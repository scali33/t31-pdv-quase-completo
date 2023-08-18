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
    public partial class frmAlg3 : Form
    {
        double val, val2,resultado;
        public frmAlg3()
        {
            InitializeComponent();
        }

        private void btnsoma_Click(object sender, EventArgs e)
        {
             val = double.Parse(txtval1.Text);
             val2 = double.Parse(txtval2.Text);

             resultado = val + val2;

            lblResul.Text = resultado.ToString();
            lblResul.ForeColor = Color.Red;

        }

        private void btnsub_Click(object sender, EventArgs e)
        {
             val = double.Parse(txtval1.Text);
             val2 = double.Parse(txtval2.Text);

             resultado = val - val2;

            lblResul.Text = resultado.ToString();
            lblResul.ForeColor = Color.Red;
        }

        private void btnmulti_Click(object sender, EventArgs e)
        {
             val = double.Parse(txtval1.Text);
             val2 = double.Parse(txtval2.Text);

             resultado = val * val2;

            lblResul.Text = resultado.ToString();
            lblResul.ForeColor = Color.Red;
        }

        private void btndiv_Click(object sender, EventArgs e)
        {
             val = double.Parse(txtval1.Text);
             val2 = double.Parse (txtval2.Text);
             resultado = val / val2;

            lblResul.Text = resultado.ToString();
            lblResul.ForeColor = Color.Red;
        }
    }
}
