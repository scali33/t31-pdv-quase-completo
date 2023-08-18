using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Resources.ResXFileRef;

namespace t31_projetoBase
{
    public partial class frmAlg6 : Form
    {
        public frmAlg6()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {



            var valor = txtNumeros.Text;
            int num;
            bool isanumber = int.TryParse(valor, out num);

            if (isanumber)
            {
                lboNumeros.Items.Add(num);


            }
            else
            {
                MessageBox.Show("apenas numeros");
            }
           
        }

        private void btnOrdernar_Click(object sender, EventArgs e)
        {
            int[] numbers = lboNumeros.Items.OfType<int>().ToArray();
            Array.Sort(numbers);

            lboNumeros.Items.Clear();
            ///lboNumeros.Items: lboNumeros é o objeto ListBox ao qual estamos adicionando os itens.
            ///AddRange(): É o método do ListBox usado para adicionar uma coleção de itens.
            ///numbers.Select(n => (object)n): Aqui estamos usando a expressão numbers.Select(n => (object)n) para converter cada número da coleção 
            ///numbers em um objeto(object). Isso é necessário porque o ListBox aceita apenas itens do tipo object.A função Select() é usada para aplicar uma transformação a cada item da coleção, e(object)n é a transformação aplicada para converter cada número em um objeto.
            ///ToArray(): Converte a coleção de objetos em um array. O resultado é um array de objetos que contém os números convertidos.
            ///AddRange(...);: Adiciona a coleção de objetos(números convertidos) ao ListBox. Essa linha adiciona todos os números ordenados ao ListBox de uma só vez.
            ///No geral, essa linha de código permite adicionar os números ordenados como itens ao ListBox de forma eficiente, sem a necessidade de adicionar cada número individualmente usando o método Add().
            lboNumeros.Items.AddRange(numbers.Select(n => (object)n).ToArray());
        }
    }
    }

