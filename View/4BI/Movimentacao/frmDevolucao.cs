using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View._4BI.Movimentacao
{
    public partial class frmDevolucao : Form
    {
        public frmDevolucao()
        {
            InitializeComponent();
        }

        private void frmDevolucao_Load(object sender, EventArgs e)
        {
            ((frmPrincipal)this.MdiParent).dEVOLUÇÃOToolStripMenuItem.Enabled = false;

        }

        private void frmDevolucao_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((frmPrincipal)this.MdiParent).dEVOLUÇÃOToolStripMenuItem.Enabled = true;
        }
    }
}
