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
    public partial class frmAlg2 : Form
    {
        public frmAlg2()
        {
            InitializeComponent();
        }

        private void btnMedia_Click(object sender, EventArgs e)
        {
            double km, tempo, media;

            //entrada
            km = double.Parse(txtKm.Text);
            tempo = double.Parse(txtTemp.Text);
            if (km <=0 || tempo <=0)
            {
                MessageBox.Show("pessoa poderia colocar o valores não posso calcular o vazio com o vazio","pela mor", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

            // processamento
            media = (km / tempo);
            // apresentação dos resultados

            MessageBox.Show("A Média da velocidade foi " + media.ToString("n3") + " km'hora", "atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


    }
}
