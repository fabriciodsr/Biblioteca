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
    public partial class frmConsultaGeneros : Form
    {
        public frmConsultaGeneros()
        {
            InitializeComponent();
        }

        private void frmConsultaGeneros_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((frmPrincipal)this.MdiParent).gÊNEROSToolStripMenuItem.Enabled = true;
        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            CGenero.CGeneroClient oProxy = new CGenero.CGeneroClient();
            oProxy.Open();
            dtgGeneros.DataSource = oProxy.ListaTodosGeneros();

            oProxy.Close();
        }
    }
}
