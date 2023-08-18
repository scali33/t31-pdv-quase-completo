using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace t31_projetoBase
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            MessageBox.Show("welcome", "Testando jaj", MessageBoxButtons.OK, MessageBoxIcon.Warning);


        }

        private void fecharToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void algoritimo01ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAlg1 frm = new frmAlg1();
            frm.ShowDialog();
        }

        private void algoritimo02ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAlg2 frm = new frmAlg2();
            frm.ShowDialog();
        }

        private void algoritimo03ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAlg3 frm = new frmAlg3();
            frm.ShowDialog();
        }

        private void algoritimo04ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAlg4 frm = new frmAlg4();
            frm.ShowDialog();
        }

        private void ext01ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new frmEx1();
            frm.ShowDialog();
        }

        private void ext02ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new frmExt2();
            frm.ShowDialog();
        }

        private void ext03ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new frmExt3();
            frm.ShowDialog();
        }

        private void bancoDeDadosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void algoritimo05ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new frmAlg5();
            frm.ShowDialog();
        }

        private void algoritimo06ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new frmAlg6();
            frm.ShowDialog();

        }

        private void algoritimo07ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new frmAlg7();
            frm.ShowDialog();
        }

        private void ext04ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new frmEx4();
            frm.ShowDialog();

        }

        private void ext05ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new ext5();
            frm.ShowDialog();
        }

        private void ext06ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new frmEx6();
            frm.ShowDialog();
        }

        private void ntdExemplo1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new frmBco1();
            frm.ShowDialog();
        }

        private void ntdExemplo2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new ntwExemp02();
            frm.ShowDialog();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new frmBco3();
            frm.ShowDialog();
        }

        private void fornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new frmBco4();
            frm.ShowDialog();
        }

        private void pDVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new frmPDV();
            frm.ShowDialog();
        }
    }
}
