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
    public partial class frmRelatorioCadastroEditoras : Form
    {
        public frmRelatorioCadastroEditoras()
        {
            InitializeComponent();
        }

        private void btnPesquisarEditora_Click(object sender, EventArgs e)
        {
            CRelatorioEditora.CRelatorioEditoraClient oProxy = new CRelatorioEditora.CRelatorioEditoraClient();
            oProxy.Open();
            if (rdbId.Checked)
            {
                dtgRelatorio.DataSource = RelatoriosEditoraMetod.GerarRelatorioID();
                dtgRelatorio.Refresh();
            }
            else if (rdbNome.Checked)
            {
                dtgRelatorio.DataSource = RelatoriosEditoraMetod.GerarRelatorioNome();
                dtgRelatorio.Refresh();
            }
            oProxy.Close();
        }
    }
}
