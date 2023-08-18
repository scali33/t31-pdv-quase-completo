using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace t31_projetoBase
{
    public partial class ext5 : Form
    {
        private jogoforca jogo; // Instância da classe jogoforca
        private string palavraOculta; // Armazena a palavra oculta
        private int vidas; // Armazena o número de vidas

        public ext5()
        {

            InitializeComponent();
            jogo = new jogoforca(); // Instanciação da classe jogoforca
            vidas = 6;// Inicialização do número de vidas
            InicializarJogo();// Inicialização do jogo  
        }

        private void InicializarJogo()
        {
            palavraOculta = jogo.Obterpalavra(); // Obtém uma palavra oculta aleatória
            string palavraExibida = ObterPalavraExibida(palavraOculta); // Obtém a palavra a ser exibida
            lblPalavra.Text = palavraExibida; //Exibe a palavra no label lblPalavra


        }

        private string ObterPalavraExibida(string palavra)
        {
            StringBuilder palavraExibida = new StringBuilder();

            foreach (char c in palavra)
            {
                if (Char.IsLetter(c))
                {
                    palavraExibida.Append("_");// Substitui letras por "_"
                }
                else
                {
                    palavraExibida.Append(c);// Mantém outros caracteres
                }
            }

            return palavraExibida.ToString(); // Retorna a palavra exibida
        }

        private void btnRodar_Click(object sender, EventArgs e)
        {
            InicializarJogo();// Reinicia o jogo ao clicar no botão
        }

        private void btnComfirmar_Click(object sender, EventArgs e)
        {

            char letra = txtLetra.Text.ToLower().FirstOrDefault();

            if (letra != default(char))
            {
                bool acertou = false;
                StringBuilder palavraExibida = new StringBuilder(lblPalavra.Text);

                for (int i = 0; i < palavraOculta.Length; i++)
                {
                    if (char.ToLower(palavraOculta[i]) == letra)
                    {
                        palavraExibida[i] = palavraOculta[i];// Revela a letra acertada na palavra exibida
                        acertou |= true;

                    }
                }
                if (!acertou)
                {
                    vidas--;// Decrementa o número de vidas se a letra não foi encontrada

                }
            

                lblPalavra.Text = palavraExibida.ToString();// Atualiza a palavra exibida no label
            }
            lblVidas.Text = vidas.ToString();// Atualiza o label das vidas
            txtLetra.Clear();// Limpa o campo de entrada de letras
            VerificarFimDoJogo();// Verifica se o jogo acabou
        }

        private void VerificarFimDoJogo()
        {
            if (!lblPalavra.Text.Contains('_'))
            {
                MessageBox.Show("Parabéns, você adivinhou a palavra!");
                InicializarJogo(); // Reinicia o jogo se todas as letras foram reveladas
            }
            else if (vidas == 0)
            {
                MessageBox.Show($"Perdeu filho gg a palavra éra {palavraOculta}");
                vidas = 6; // Reinicia o número de vidas para 3
                lblVidas.Text = vidas.ToString(); // Atualiza o label das vidas
                InicializarJogo(); // Reinicia o jogo

            }
        }
    }

    public class jogoforca
    {
        private List<string> PalavrasOcultas = new List<string>() { "caminhão", "Avião", "Usina Nuclear", "Milho", "pão de queijo" };
        private Random random = new Random();

        public string Obterpalavra()
        {
            int indiceAleatorio = random.Next(PalavrasOcultas.Count); //ele vai gerar um indice aleatorio correspondente a palavra da array PalavrasOcultas
            return PalavrasOcultas[indiceAleatorio]; // Retorna uma palavra aleatória da lista
        }
    }
}

