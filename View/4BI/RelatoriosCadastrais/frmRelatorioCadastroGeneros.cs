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

namespace View._4BI.RelatoriosCadastrais
{
    public partial class frmRelatorioCadastroGeneros : Form
    {
        public frmRelatorioCadastroGeneros()
        {
            InitializeComponent();
        }

        private void btnPesquisarGenero_Click(object sender, EventArgs e)
        {
            CRelatorioGenero.CRelatorioGeneroClient oProxy = new CRelatorioGenero.CRelatorioGeneroClient();
            oProxy.Open();
            if (rdbId.Checked)
            {
                dtgRelatorio.DataSource = oProxy.GerarRelatorioID();
                dtgRelatorio.Refresh();
            }
            else if (rdbDesc.Checked)
            {
                dtgRelatorio.DataSource = oProxy.GerarRelatorioDescricao();
                dtgRelatorio.Refresh();
            }
            oProxy.Close();
        }
    }
}
