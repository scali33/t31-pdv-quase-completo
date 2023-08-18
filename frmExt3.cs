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
    public partial class frmExt3 : Form
    {
        public frmExt3()
        {
            InitializeComponent();
        }

        private void btnexibir_Click(object sender, EventArgs e)

        {
            lbxInfos.Items.Clear(); // Limpa o conteúdo existente do ListBox
            string frase = txtFrase.Text;

            lbxInfos.Items.Add($"a frase completamente maiuscula fica: {frase.ToUpper()}");
            char[] caracteresInvertidos = frase.Reverse().ToArray();
            lbxInfos.Items.Add($" a frase de tras para frente fica: {string.Join("", caracteresInvertidos)}");
            lbxInfos.Items.Add($"O tamanho da frase é {frase.Length} caracteres");
        }
    }
}
