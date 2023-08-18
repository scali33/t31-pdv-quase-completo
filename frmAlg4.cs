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
    public partial class frmAlg4 : Form
    {
        public frmAlg4()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            var peso = double.Parse(txtPeso.Text);
            var altura = double.Parse(txtAltura.Text);

            var imc = peso/ (altura * altura) ;

            txtImc.Text = imc.ToString("N2");

            string julgamento = imc < 18.5 ? "abaixo do peso"
                : imc > 18.5 && imc < 25 ? "dentro do peso"
                : imc > 25 && imc < 30 ? "acima do peso"
                : "OBESIDADe MORBIDA PARE DE COMER ";

            lblResult.Text = julgamento;
           
        }
    }
}
