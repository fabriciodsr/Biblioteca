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

        private void cmbPesquisaLivro_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btnProcurarLivro_Click(object sender, EventArgs e)
        {

        }

        private void cmbPesquisa_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtPesquisa.Text = "";
        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {

            dtgEmprestimos.Rows.Clear();




            if (cmbPesquisa.SelectedIndex == 0)
            {
                int var = Convert.ToInt32(txtPesquisa.Text);
                CAluno.CAlunoClient oProxy = new CAluno.CAlunoClient();
                oProxy.Open();

                if (oProxy.Selecionar(var) != null)
                {
                    ALUNO oAluno = oProxy.Selecionar(var);

                    txtNomeAluno.Text = oAluno.NOME;
                    txtSobreNome.Text = oAluno.SOBRENOME;
                    txtIdAluno.Text = oAluno.ID_ALUNO.ToString();

                    var aluno = Convert.ToInt32(txtIdAluno.Text);



                    CEmprestimo.CEmprestimoClient oProxyE = new CEmprestimo.CEmprestimoClient();
                    oProxyE.Open();

                    var listaEmprestimos = oProxyE.listaTodosEmprestimosAluno(aluno);
                    int i = 0;
                    foreach (var item in listaEmprestimos)
                    {
                        var Al = listaEmprestimos[i].ID_ALUNO;
                        var Li = listaEmprestimos[i].ID_LIVRO;

                        CAluno.CAlunoClient oProxyAl = new CAluno.CAlunoClient();
                        oProxyAl.Open();
                        var oAlu = oProxyAl.Selecionar(Al);

                        CLivro.CLivroClient oProxyLi = new CLivro.CLivroClient();
                        oProxyLi.Open();
                        var oLi = oProxyLi.SelecionarID(Li);



                        dtgEmprestimos.Rows.Add(listaEmprestimos[i].ID_EMPRESTIMO, oLi.TITULO, listaEmprestimos[i].SITUACAO, listaEmprestimos[i].DATA_DEVOL, listaEmprestimos[i].DATA_EMP, oAlu.NOME);

                        dtgEmprestimos.Refresh();

                        i++;

                    }

                    oProxy.Close();

                }
                else
                {
                    MessageBox.Show("Aluno não encontrado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {

                CAluno.CAlunoClient oProxy = new CAluno.CAlunoClient();
                oProxy.Open();

                if (oProxy.SelecionarNome(txtPesquisa.Text) != null)
                {
                    ALUNO oAluno = oProxy.SelecionarNome(txtPesquisa.Text);

                    txtNomeAluno.Text = oAluno.NOME;
                    txtSobreNome.Text = oAluno.SOBRENOME;
                    txtIdAluno.Text = oAluno.ID_ALUNO.ToString();


                    var aluno = Convert.ToInt32(txtIdAluno.Text);



                    CEmprestimo.CEmprestimoClient oProxyE = new CEmprestimo.CEmprestimoClient();
                    oProxyE.Open();

                    var listaEmprestimos = oProxyE.listaTodosEmprestimosAluno(aluno);
                    int i = 0;
                    foreach (var item in listaEmprestimos)
                    {
                        var Al = listaEmprestimos[i].ID_ALUNO;
                        var Li = listaEmprestimos[i].ID_LIVRO;

                        CAluno.CAlunoClient oProxyAl = new CAluno.CAlunoClient();
                        oProxyAl.Open();
                        var oAlu = oProxyAl.Selecionar(Al);

                        CLivro.CLivroClient oProxyLi = new CLivro.CLivroClient();
                        oProxyLi.Open();
                        var oLi = oProxyLi.SelecionarID(Li);



                        dtgEmprestimos.Rows.Add(listaEmprestimos[i].ID_EMPRESTIMO, oLi.TITULO, listaEmprestimos[i].SITUACAO, listaEmprestimos[i].DATA_DEVOL, listaEmprestimos[i].DATA_EMP, oAlu.NOME);

                        dtgEmprestimos.Refresh();

                        i++;

                    }

                    oProxy.Close();

                }
                else
                {
                    MessageBox.Show("Aluno não encontrado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            




        }

        private void dtgEmprestimos_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            var index = e.RowIndex;

            txtIdEmp.Text = dtgEmprestimos[0, index].ToString();
            txtLivro.Text = dtgEmprestimos[1, index].ToString();
            txtSituacaoEmprestimo.Text = dtgEmprestimos[2, index].ToString();
            //var dataemp = dtgEmprestimos[4, index].



        }

    }
}
