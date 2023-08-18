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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {


        }

        private void btlogin_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "admin") {
                if (txtSenha.Text == "1234")
                {
                    //MessageBox.Show("Calma meu patrão");
                    frmPrincipal frm = new frmPrincipal();
                    this.Hide();
                    frm.Show();
                }
                else {
                    MessageBox.Show("senha incorreta", "atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            else if (txtUsuario.Text != "admin" && txtSenha.Text != "1234")
            {
                MessageBox.Show("usuario e senha invalidos", "atention", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Usuario invalido", "atention", MessageBoxButtons.OK, MessageBoxIcon.Error); }
          
        }
    }
}
