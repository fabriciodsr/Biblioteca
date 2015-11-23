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
    public partial class frmRelatorioCadastroAutores : Form
    {
        public frmRelatorioCadastroAutores()
        {
            InitializeComponent();
        }

        private void btnPesquisarAutor_Click(object sender, EventArgs e)
        {
            CRelatorioAutor.CRelatorioAutorClient oProxy = new CRelatorioAutor.CRelatorioAutorClient();
            oProxy.Open();
            if (rdbId.Checked)
            {
                dtgRelatorio.DataSource = oProxy.GerarRelatorioID();
                dtgRelatorio.Refresh();
            }
            else if (rdbNome.Checked)
            {
                dtgRelatorio.DataSource = oProxy.GerarRelatorioNome();
                dtgRelatorio.Refresh();
            }
            oProxy.Close();
        }
    }
}
