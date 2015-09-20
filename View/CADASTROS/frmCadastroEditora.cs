using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using Controller;

namespace View
{
    public partial class frmCadastroEditora : Form
    {
        public frmCadastroEditora()
        {
            InitializeComponent();
        }

        private void frmCadastroEditora_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((frmPrincipal)this.MdiParent).eDITORAToolStripMenuItem.Enabled = true;
        }

        private void frmCadastroEditora_Load(object sender, EventArgs e)
        {
            cmbPais.DataSource = ListaPais.ListaPaises();
        }
    }
}
