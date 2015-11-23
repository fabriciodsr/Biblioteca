using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controller;
using Model;

namespace View._4BI.Movimentacao
{
    public partial class frmEmprestimo : Form
    {
        public frmEmprestimo()
        {
            InitializeComponent();
        }

        private void cmbPesquisa_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtPesquisa.Text = "";
        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            if (cmbPesquisa.SelectedIndex == 0)
            {
                int var = Convert.ToInt32(txtPesquisa.Text);
                CAluno.CAlunoClient oProxy = new CAluno.CAlunoClient();
                oProxy.Open();

                if (oProxy.Selecionar(var) != null)
                {
                    ALUNO oAluno = oProxy.Selecionar(var);

                    txtNome.Text = oAluno.NOME;
                    txtSobreNome.Text = oAluno.SOBRENOME;
                    txtID.Text = oAluno.ID_ALUNO.ToString();


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

                    txtNome.Text = oAluno.NOME;
                    txtSobreNome.Text = oAluno.SOBRENOME;
                    txtID.Text = oAluno.ID_ALUNO.ToString();


                }
                else
                {
                    MessageBox.Show("Aluno não encontrado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if ((txtID.Text.Trim() != "") && (txtIDLivro.Text.Trim() != ""))
            {
                btnInserir.Enabled = true;
            }
        }

        private void frmEmprestimo_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((frmPrincipal)this.MdiParent).eMPRESTIMOToolStripMenuItem.Enabled = true;

        }

        private void cmbPesquisaLivro_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtProcurarLivro.Text = "";
        }

        private void btnProcurarLivro_Click(object sender, EventArgs e)
        {
            if(txtProcurarLivro.Text.Trim() != "")
            {
                //PESQUISA PELO ID

                if (cmbPesquisaLivro.SelectedIndex == 0)
                {
                    int var2 = Convert.ToInt32(txtProcurarLivro.Text);

                    CLivro.CLivroClient oProxy2 = new CLivro.CLivroClient();
                    oProxy2.Open();

                    if (oProxy2.SelecionarID(var2) != null)
                    {
                        LIVRO oLivro = oProxy2.SelecionarID(var2);

                        txtIDLivro.Text = Convert.ToString(oLivro.ID_LIVRO);
                        txtTitulo.Text = oLivro.TITULO;
                        txtVolume.Text = Convert.ToString(oLivro.VOLUME);
                        dtp_Publicacao.Value = oLivro.DATA_PUBLIC;

                        CGenero.CGeneroClient oProxygen = new CGenero.CGeneroClient();
                        oProxygen.Open();
                        var idGenero = oLivro.ID_GENERO;
                        GENERO oGenero = oProxygen.Selecionar(idGenero);
                        txtGenero.Text = oGenero.DESCRICAO;
                        oProxygen.Close();

                        CEditora.CEditoraClient oProxyEdit = new CEditora.CEditoraClient();
                        oProxyEdit.Open();
                        var idEditora = oLivro.ID_EDITORA;
                        EDITORA oEditora = oProxyEdit.Selecionar(idEditora);
                        txtEditora.Text = oEditora.NOME;
                        oProxyEdit.Close();

                        CLivroAutor.CLivroAutorClient oProxyLA = new CLivroAutor.CLivroAutorClient();
                        oProxyLA.Open();

                        //var autores = oProxyLA.ListarAutores(oLivro.ID_LIVRO);

                        var autores = LivroAutorMetod.ListarAutores(oLivro.ID_LIVRO);


                        txtAutor1.Text = autores[0].NOME;

                        if (autores.Count()>1)
                        {
                            txtAutor2.Text = autores[1].NOME;

                        }

                        oProxyLA.Close();




                    }
                    else
                    {
                        MessageBox.Show("Livro não encontrado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }



                }

                //PESQUISA PELO TITULO

                else
                {
                    CLivro.CLivroClient oProxy2 = new CLivro.CLivroClient();
                    oProxy2.Open();

                    if (oProxy2.SelecionarTitulo(txtProcurarLivro.Text) != null)
                    {
                        LIVRO oLivro = oProxy2.SelecionarTitulo(txtProcurarLivro.Text);

                        txtIDLivro.Text = Convert.ToString(oLivro.ID_LIVRO);
                        txtTitulo.Text = oLivro.TITULO;
                        txtVolume.Text = Convert.ToString(oLivro.VOLUME);
                        dtp_Publicacao.Value = oLivro.DATA_PUBLIC;

                        CGenero.CGeneroClient oProxygen = new CGenero.CGeneroClient();
                        oProxygen.Open();
                        var idGenero = oLivro.ID_GENERO;
                        GENERO oGenero = oProxygen.Selecionar(idGenero);
                        txtGenero.Text = oGenero.DESCRICAO;
                        oProxygen.Close();

                        CEditora.CEditoraClient oProxyEdit = new CEditora.CEditoraClient();
                        oProxyEdit.Open();
                        var idEditora = oLivro.ID_EDITORA;
                        EDITORA oEditora = oProxyEdit.Selecionar(idEditora);
                        txtEditora.Text = oEditora.NOME;
                        oProxyEdit.Close();

                        CLivroAutor.CLivroAutorClient oProxyLA = new CLivroAutor.CLivroAutorClient();
                        oProxyLA.Open();

                        //var autores = oProxyLA.ListarAutores(oLivro.ID_LIVRO);

                        var autores = LivroAutorMetod.ListarAutores(oLivro.ID_LIVRO);

                        txtAutor1.Text = autores[0].NOME;

                        if (autores.Count()>1)
                        {
                            txtAutor2.Text = autores[1].NOME;

                        }

                        oProxyLA.Close();

                    }


                    else
                    {
                        MessageBox.Show("Livro não encontrado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            if ((txtID.Text.Trim()!= "") && (txtIDLivro.Text.Trim() != ""))
            {
                btnInserir.Enabled = true;
            }
                
            
            
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            dtgEmprestimos.Rows.Clear();

            var aluno = Convert.ToInt32(txtID.Text);

            var livro = Convert.ToInt32(txtIDLivro.Text);


            CEmprestimo.CEmprestimoClient oProxy = new CEmprestimo.CEmprestimoClient();
            oProxy.Open();

            try
            {
                oProxy.Emprestar(aluno, livro);

                MessageBox.Show("Empréstimo realizado com sucesso!", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void frmEmprestimo_Load(object sender, EventArgs e)
        {
            ((frmPrincipal)this.MdiParent).eMPRESTIMOToolStripMenuItem.Enabled = false;
        }
    }
}
