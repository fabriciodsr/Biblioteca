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
    public partial class frmRelatorioCadastroLivros : Form
    {
        public frmRelatorioCadastroLivros()
        {
            InitializeComponent();
        }

        private void btnPesquisarLivro_Click(object sender, EventArgs e)
        {
            CRelatorioLivro.CRelatorioLivroClient oProxy = new CRelatorioLivro.CRelatorioLivroClient();
            oProxy.Open();
            if (rdbId.Checked)
            {
                dtgRelatorio.DataSource = oProxy.GerarRelatorioID();
                dtgRelatorio.Refresh();
            }
            else if (rdbTitulo.Checked)
            {
                dtgRelatorio.DataSource = oProxy.GerarRelatorioTitulo();
                dtgRelatorio.Refresh();
            }
            oProxy.Close();
        }
    }
}
