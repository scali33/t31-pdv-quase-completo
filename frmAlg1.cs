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
    public partial class frmAlg1 : Form
    {
        public frmAlg1()
        {
            InitializeComponent();
        }

        private void frmAlg1_Load(object sender, EventArgs e)
        {


        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            double N1, N2, N3, N4, Media;

            //entrada
            N1 = double.Parse(txtN1.Text);
            N2 = double.Parse(txtN2.Text);
            N3 = double.Parse(txtN3.Text);
            N4 = double.Parse(txtN4.Text);

            //processamento
            Media = (N1 + N2 + N3 + N4) / 4;

            if (Media > 7)
            {
                lblstatus.ForeColor = Color.Blue;
                lblstatus.Text = "parabens aprovado";
            }
            else
            {
                lblstatus.ForeColor = Color.Red;
                lblstatus.Text = "REPROVADO !!!!";
            }
            //saida do codigo 
            lblResul.Text = "A media das notas do aluno é :" + Media.ToString("N2");
            Console.WriteLine("testando");
        }
    }
}
