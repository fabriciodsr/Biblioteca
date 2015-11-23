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
    public partial class frmRelatorioCadastroAluno : Form
    {
        public frmRelatorioCadastroAluno()
        {
            InitializeComponent();
        }

        private void frmRelatorioCadastroAluno_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }

        private void btnPesquisarAluno_Click(object sender, EventArgs e)
        {
            CRelatorioAluno.CRelatorioAlunoClient oProxy = new CRelatorioAluno.CRelatorioAlunoClient();
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
