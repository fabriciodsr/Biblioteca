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

                    /*AUTOR oAutor1 = new AUTOR();

                    oAutor1 = oLivro.AUTOR.ElementAtOrDefault<AUTOR>(0);

                    txtAutor1.Text = oAutor1.NOME;*/

                    /*
                    try
                    {
                        AUTOR oAutor2 = new AUTOR();

                        oAutor2 = oLivro.AUTOR.ElementAtOrDefault<AUTOR>(1);

                        txtAutor1.Text = oAutor2.NOME;
                    }
                    catch
                    {

                    }*/

                    dtp_Publicacao.Value = oLivro.DATA_PUBLIC;


                    GENERO oGenero = new GENERO();

                    //oGenero = oLivro.GENERO.ElementAtOrDefault<GENERO>(0);

                    txtGenero.Text = oGenero.DESCRICAO;

                    txtEditora.Text = oLivro.EDITORA.NOME;
                   


                }
                else
                {
                    MessageBox.Show("Livro não encontrado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }



            }
            else if (cmbPesquisa.SelectedIndex == 1)
            {
                CLivro.CLivroClient oProxy2 = new CLivro.CLivroClient();
                oProxy2.Open();

                if (oProxy2.SelecionarTitulo(txtProcurarLivro.Text) != null)
                {
                    LIVRO oLivro = oProxy2.SelecionarTitulo(txtProcurarLivro.Text);

                    txtIDLivro.Text = Convert.ToString(oLivro.ID_LIVRO);
                    txtTitulo.Text = oLivro.TITULO;
                    txtVolume.Text = Convert.ToString(oLivro.VOLUME);

                    /*AUTOR oAutor1 = new AUTOR();

                    oAutor1 = oLivro.AUTOR.ElementAtOrDefault<AUTOR>(0);

                    txtAutor1.Text = oAutor1.NOME;*/

                    /*
                    try
                    {
                        AUTOR oAutor2 = new AUTOR();

                        oAutor2 = oLivro.AUTOR.ElementAtOrDefault<AUTOR>(1);

                        txtAutor1.Text = oAutor2.NOME;
                    }
                    catch
                    {

                    }*/

                    dtp_Publicacao.Value = oLivro.DATA_PUBLIC;


                    GENERO oGenero = new GENERO();

                    //oGenero = oLivro.GENERO.ElementAtOrDefault<GENERO>(0);

                    txtGenero.Text = oGenero.DESCRICAO;

                    txtEditora.Text = oLivro.EDITORA.NOME;
                }
                else
                {
                    MessageBox.Show("Livro não encontrado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {

        }
    }
}
