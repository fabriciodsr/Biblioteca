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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void aLUNOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aLUNOSToolStripMenuItem.Enabled = false;
            frmConsultaAlunos frm = new frmConsultaAlunos();
            frm.MdiParent = this;
            frm.Show();
            
        }

        private void aUTORESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aUTORESToolStripMenuItem.Enabled = false;
            frmConsultaAutores frm = new frmConsultaAutores();
            frm.MdiParent = this;
            frm.Show();
        }

        private void eDITORASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            eDITORASToolStripMenuItem.Enabled = false;
            frmConsultaEditoras frm = new frmConsultaEditoras();
            frm.MdiParent = this;
            frm.Show();
        }

        private void gÊNEROSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gÊNEROSToolStripMenuItem.Enabled = false;
            frmConsultaGeneros frm = new frmConsultaGeneros();
            frm.MdiParent = this;
            frm.Show();
        }

        private void lIVROSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lIVROSToolStripMenuItem.Enabled = false;
            frmConsultaLivros frm = new frmConsultaLivros();
            frm.MdiParent = this;
            frm.Show();
        }

        private void aLUNOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aLUNOToolStripMenuItem.Enabled = false;
            frmCadastroAluno frm = new frmCadastroAluno();
            frm.MdiParent = this;
            frm.Show();

        }

        private void aUTORToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aUTORToolStripMenuItem.Enabled = false;
            frmCadastroAutor frm = new frmCadastroAutor();
            frm.MdiParent = this;
            frm.Show();
        }

        private void eDITORAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            eDITORAToolStripMenuItem.Enabled = false;
            frmCadastroEditora frm = new frmCadastroEditora();
            frm.MdiParent = this;
            frm.Show();
        }

        private void gENEROToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gENEROToolStripMenuItem.Enabled = false;
            frmCadastroGenero frm = new frmCadastroGenero();
            frm.MdiParent = this;
            frm.Show();
        }

        private void lIVROToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lIVROToolStripMenuItem.Enabled = false;
            frmCadastroLivro frm = new frmCadastroLivro();
            frm.MdiParent = this;
            frm.Show();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void eMPRESTIMOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            eMPRESTIMOToolStripMenuItem.Enabled = false;
            View._4BI.Movimentacao.frmEmprestimo frm = new _4BI.Movimentacao.frmEmprestimo();
            frm.MdiParent = this;
            frm.Show();
        }

        private void rESERVAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rESERVAToolStripMenuItem.Enabled = false;
            View._4BI.Movimentacao.frmReserva frm = new _4BI.Movimentacao.frmReserva();
            frm.MdiParent = this;
            frm.Show();
        }

        private void dEVOLUÇÃOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dEVOLUÇÃOToolStripMenuItem.Enabled = false;
            View._4BI.Movimentacao.frmDevolucao frm = new _4BI.Movimentacao.frmDevolucao();
            frm.MdiParent = this;
            frm.Show();
        }

        private void rELATÓRIOMOVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void relCadastroAlunosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            relCadastroAlunosToolStripMenuItem.Enabled = false;
            View._4BI.RelatoriosCadastrais.frmRelatorioCadastroAluno frm = new _4BI.RelatoriosCadastrais.frmRelatorioCadastroAluno();
            frm.MdiParent = this;
            frm.Show();
        }

        private void relAlunosPendenciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            relAlunosPendenciasToolStripMenuItem.Enabled = false;
            View._4BI.RelatoriosdeMovimentacao.frmRelAlunosPendencias frm = new _4BI.RelatoriosdeMovimentacao.frmRelAlunosPendencias();
            frm.MdiParent = this;
            frm.Show();
        }

        private void relLivrosDevAtrasadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
           relLivrosDevAtrasadoToolStripMenuItem.Enabled = false;
            View._4BI.RelatoriosdeMovimentacao.frmRelLivrosDevolucaoAtrasada frm = new _4BI.RelatoriosdeMovimentacao.frmRelLivrosDevolucaoAtrasada();
            frm.MdiParent = this;
            frm.Show();
        }

        private void sOBREToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mOVIMENTAÇÃOToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void relLivrosEmprestadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            relLivrosEmprestadosToolStripMenuItem.Enabled = false;
            View._4BI.RelatoriosdeMovimentacao.frmRelLivrosEmprestados frm = new _4BI.RelatoriosdeMovimentacao.frmRelLivrosEmprestados();
            frm.MdiParent = this;
            frm.Show();
        }

        private void relLivrosReservadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            relLivrosReservadosToolStripMenuItem.Enabled = false;
            View._4BI.RelatoriosdeMovimentacao.RelLivrosReservados frm = new _4BI.RelatoriosdeMovimentacao.RelLivrosReservados();
            frm.MdiParent = this;
            frm.Show();
        }

        private void relCadastroAutoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            relCadastroAutoresToolStripMenuItem.Enabled = false;
            View._4BI.RelatoriosCadastrais.frmRelatorioCadastroAutores frm = new _4BI.RelatoriosCadastrais.frmRelatorioCadastroAutores();
            frm.MdiParent = this;
            frm.Show();
        }

        private void relCadastroEditoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            relCadastroEditoresToolStripMenuItem.Enabled = false;
            View._4BI.RelatoriosCadastrais.frmRelatorioCadastroEditoras frm = new _4BI.RelatoriosCadastrais.frmRelatorioCadastroEditoras();
            frm.MdiParent = this;
            frm.Show();
        }

        private void relCadastroGenerosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            relCadastroGenerosToolStripMenuItem.Enabled = false;
            View._4BI.RelatoriosCadastrais.frmRelatorioCadastroGeneros frm = new _4BI.RelatoriosCadastrais.frmRelatorioCadastroGeneros();
            frm.MdiParent = this;
            frm.Show();
        }

        private void relCadastroLivrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
           relCadastroLivrosToolStripMenuItem.Enabled = false;
            View._4BI.RelatoriosCadastrais.frmRelatorioCadastroLivros frm = new _4BI.RelatoriosCadastrais.frmRelatorioCadastroLivros();
            frm.MdiParent = this;
            frm.Show();
        }

        private void bIBLIOTECAVIRTUALToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
