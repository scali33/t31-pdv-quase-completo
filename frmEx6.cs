using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace t31_projetoBase
{
    public partial class frmEx6 : Form
    {
        private Odemetro odometro;

        public frmEx6()
        {
            InitializeComponent();
            odometro = new Odemetro();
            string Numero = txtNaosei.Text;
            int num = 0;
            bool isanumber = int.TryParse(Numero, out num);
        }

        private void btnRodar_Click(object sender, EventArgs e)
        {
            List<string> velocimetro = odometro.calcular1();
            txtCentena.Text = velocimetro[0];
            txtDezena.Text = velocimetro[1];
            txtUnidade.Text = velocimetro[2];


        }

        private void btnRodar_para_Click(object sender, EventArgs e)
        {

            var valor = txtNaosei.Text;
            int num;
            bool isanumber = int.TryParse(valor, out num);
            if (isanumber)
            {
                MessageBox.Show("o numero que você digitou é" + num);

                List<string> velocimetro = odometro.calcular1(num);
                txtCentena.Text = velocimetro[0];
                txtDezena.Text = velocimetro[1];
                txtUnidade.Text = velocimetro[2];
            }
        }   
    }
    public class Odemetro
    {

        public List<string> calcular1()
        {

            List<string> lista = new List<string>() { "0", "0", "0" };
            for (int c = 0; c < 10; c++)
            {
                lista[0] = c.ToString();
                for (int d = 0; d < 10; d++)
                {
                    lista[1] = d.ToString();
                    for (int u = 0; u < 10; u++)
                    {
                        lista[2] = u.ToString();
                    }


                }



            }
            return lista;
        }
        public List<string> calcular1(int stop)
        {
          
            List<string> lista = new List<string>() { "0", "0", "0" };
            for (int c = 0; c < 10; c++)
            {
                lista[0] = c.ToString();
                for (int d = 0; d < 10; d++)
                {
                    lista[1] = d.ToString();
                    for (int u = 0; u < 10; u++)
                    {
                        lista[2] = u.ToString();
                        string concatenado = string.Join("", lista);
                        int valorConcatenado;
                        if (int.TryParse(concatenado, out valorConcatenado) && valorConcatenado == stop)
                        {
                            return lista;
                        }
                    }


                }



            }
            return lista;
          
     
  
        }

    }
}