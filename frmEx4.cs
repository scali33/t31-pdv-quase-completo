using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace t31_projetoBase
{
    public partial class frmEx4 : Form
    {
        private jogoAdivinhacao jogo;
        




        public frmEx4()
        {
            InitializeComponent();
            jogo = new jogoAdivinhacao();
        }

        private void btnAdivi_Click(object sender, EventArgs e)
        {
            int palpite;
            if (int.TryParse(txtNum.Text, out palpite))
            {
                string resultado = jogo.VerificarPalpite(palpite);
                MessageBox.Show(resultado);

                if (resultado == "Correto!")
                {
                    DialogResult opcao = MessageBox.Show("você acertou parabéns! a gora deseja jogar denovo?", "Jogo de adivinhação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (opcao == DialogResult.Yes)
                    {
                        jogo.Gerarnumerosecreto();
                        txtNum.Clear();
                    }
                    else
                    {
                        Close();
                    }
                }
                txtNum.Clear();
                txtNum.Focus();

            }
            else
            {
                MessageBox.Show("Digite um número válido","Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }        
        } 

    }


    public class jogoAdivinhacao
    {
        private int numerosecreto;
        private Random random;

        public jogoAdivinhacao()
        {
            random = new Random();
            Gerarnumerosecreto();
        }
        public void Gerarnumerosecreto()
        {
            numerosecreto = random.Next(1, 101);
        }

        public string VerificarPalpite(int palpite)
        {
            if (palpite < numerosecreto)
            {
                return "Muito baixo Tenta denovo";
            }
            else if (palpite > numerosecreto)
            {
                return "Muito alto Tente denovo";
            }
            else
            {
                return "Correto!";
            }
        }
    }

}
