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
    public partial class frmCadastroLivro : Form
    {
        public frmCadastroLivro()
        {
            InitializeComponent();
        }

        int var = 0;



        private void frmCadastroLivro_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((frmPrincipal)this.MdiParent).lIVROToolStripMenuItem.Enabled = true;
        }




        private void btnAlterar_Click(object sender, EventArgs e)
        {
            HabilitaCampos();

            txtID.Enabled = false;

            btnSalvar.Enabled = true;

            btnAlterar.Enabled = false;

            var = 1;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (VerificaControles())
            {
                LIVRO oLivro = new LIVRO();

                oLivro.TITULO = txtTitulo.Text;
                oLivro.VOLUME = Convert.ToInt32(txtVolume.Text);
                oLivro.DATA_PUBLIC = dtp_Publicacao.Value;
                oLivro.QTD_EXEMP = Convert.ToInt32(txtQuantidade.Text);
                oLivro.SUMARIO = txtSumario.Text;
                oLivro.ID_EDITORA = cmbEditora.SelectedIndex;
                oLivro.ID_GENERO = cmbGenero1.SelectedIndex;

                int Autor1 = cmbAutor1.SelectedIndex;
                int Autor2 = cmbAutor2.SelectedIndex;
                        
                CLivro.CLivroClient oProxy = new CLivro.CLivroClient();
                oProxy.Open();

                if (var == 0)
                {

                    try
                    {
                        if (oProxy.Cadastrar(oLivro))
                        {
                            
                            

                            CLivroAutor.CLivroAutorClient oProxyNpraN = new CLivroAutor.CLivroAutorClient();
                            oProxyNpraN.Open();
                            oProxyNpraN.InserirNpraN(oLivro, Autor1, Autor2);
                            oProxyNpraN.Close();

                            MessageBox.Show("Cadastro realizado com sucesso!", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LimpaCampos();
                        }
                        else
                        {
                            if (MessageBox.Show("Livro existente! Deseja carregar os dados do livro?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                            {
                                string var = oLivro.TITULO;

                                btnSalvar.Enabled = false;

                                btnDeletar.Enabled = true;

                                btnAlterar.Enabled = true;



                                LIVRO xLivro = oProxy.SelecionarTitulo(var);

                                int var2 = xLivro.ID_LIVRO;

                                txtTitulo.Text = xLivro.TITULO;
                                txtQuantidade.Text = xLivro.QTD_EXEMP.ToString();
                                txtSumario.Text = xLivro.SUMARIO;
                                dtp_Publicacao.Value = xLivro.DATA_PUBLIC;
                                cmbEditora.Text = xLivro.EDITORA.NOME;
                               // cmbAutor1.Text = xLivro.AUTOR.ElementAt(0).NOME;
                                //cmbAutor2.Text = xLivro.AUTOR.ElementAt(1).NOME;
                                //cmbGenero1.Text = xLivro.GENERO.ElementAt(0).DESCRICAO;
                                //???????? = .GENERO; 
                                //???????? = oLivro.Emprestimo;
                                //???????? = oLivro.RESERVA;
                                txtID.Text = Convert.ToString(var2);


                                DesabilitaCampos();
                            }
                            else
                            {
                                LimpaCampos();
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {

                    try
                    {
                        if (oProxy.Alterar(oLivro))
                        {
                            MessageBox.Show("Alteração realizada com sucesso!", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LimpaCampos();

                            btnAlterar.Enabled = false;

                            HabilitaCampos();

                            var = 0;

                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }



                }
            }
            else
            {
                MessageBox.Show("Preencha todos os campos!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }



        ///CANCELAR



        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpaCampos();

            var = 0;

            HabilitaCampos();

            btnAlterar.Enabled = false;

            btnDeletar.Enabled = false;

            btnSalvar.Enabled = true;
        }



        ///DELETAR



        private void btnDeletar_Click(object sender, EventArgs e)
        {

        }



        ///LOAD


        private void frmCadastroLivro_Load(object sender, EventArgs e)
        {
            CAutor.CAutorClient oProxy = new CAutor.CAutorClient();
            oProxy.Open();

            var Lista = oProxy.ListaTodosAutores();
            
            foreach (var p in Lista)
            {
                cmbAutor1.Items.Add(p.NOME);
                cmbAutor2.Items.Add(p.NOME);
            }

            oProxy.Close();



            CGenero.CGeneroClient oProxy2 = new CGenero.CGeneroClient();
            oProxy2.Open();

            var Lista2 = oProxy2.ListaTodosGeneros();

            foreach (var p in Lista2)
            {
                cmbGenero1.Items.Add(p.DESCRICAO);
            }

            oProxy2.Close();



            CEditora.CEditoraClient  oProxy3 = new CEditora.CEditoraClient();
            oProxy3.Open();

            var Lista3 = oProxy3.ListaTodasEditoras();

            foreach (var p in Lista3)
            {
                cmbEditora.Items.Add(p.NOME);
            }

            oProxy3.Close();



        }

        ///HABILITA CAMPOS

        private void HabilitaCampos()
        {
            txtTitulo.Enabled = true;
            //????????.Enabled = true;
            txtQuantidade.Enabled = true;
            txtSumario.Enabled = true;
            dtp_Publicacao.Enabled = true;
            cmbEditora.Enabled = true;
            txtVolume.Enabled = true;
            //????????.Enabled = true; 
            //????????.Enabled = true;
            //????????.Enabled = true;
            txtID.Enabled = true;
            txtPesquisa.Enabled = true;
        }


        ///DESABILITA CAMPOS

        private void DesabilitaCampos()
        {
            txtTitulo.Enabled = false;
            //????????.Enabled = false;
            txtQuantidade.Enabled = false;
            txtSumario.Enabled = false;
            dtp_Publicacao.Enabled = false;
            cmbEditora.Enabled = false;
            txtVolume.Enabled = false;
            //????????.Enabled = false; 
            //????????.Enabled = false;
            //????????.Enabled = false;
            txtID.Enabled = false;
            txtPesquisa.Enabled = false;
        }

        ///VERIFICA CONTROLES

        private bool VerificaControles()
        {
            if (
                    txtTitulo.Text.Trim() != "" &&
                    txtQuantidade.Text.Trim() != "" &&
                    txtSumario.Text.Trim() != "" &&
                    dtp_Publicacao.Value != System.DateTime.Now &&
                    cmbEditora.SelectedItem != null &&
                    cmbGenero1.SelectedItem != null &&
                    cmbAutor1.SelectedItem != null &&
                    cmbAutor2.SelectedItem != null &&
                    txtVolume.Text.Trim() != "" 
                )
            {

                return true;

            }
            else
            {
                return false;
            }
        }

        ///LIMPA CAMPOS

        private void LimpaCampos()
        {
            txtTitulo.Text = "";
            txtQuantidade.Text = "";
            txtSumario.Text = "";
            dtp_Publicacao.Value = System.DateTime.Now;
            cmbEditora.SelectedItem = null;
            cmbAutor1.SelectedItem = null;
            cmbAutor2.SelectedItem = null;
            cmbGenero1.SelectedItem = null;
            txtVolume.Text = "";
            txtID.Text = "";
            txtPesquisa.Text = "";
        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            if (cmbPesquisa.SelectedIndex == 0)
            {

                CLivro.CLivroClient oProxy = new CLivro.CLivroClient();
                oProxy.Open();

                if (oProxy.SelecionarTitulo(txtPesquisa.Text) != null)
                {
                    LIVRO oLivro = oProxy.SelecionarTitulo(txtPesquisa.Text);

                    txtTitulo.Text = oLivro.TITULO;
                    //???????? = oLivro.QTD_DISP_EMPR;
                    //txtQuantidade.Text = oLivro.QTD_EXMPLARES.ToString();
                    txtSumario.Text = oLivro.SUMARIO;
                    dtp_Publicacao.Value = oLivro.DATA_PUBLIC;
                    cmbEditora.SelectedIndex = oLivro.ID_EDITORA;
                    txtVolume.Text = oLivro.VOLUME.ToString();
                    //???????? = .GENERO; 
                    //???????? = oLivro.Emprestimo;
                    //???????? = oLivro.RESERVA;
                    txtID.Text = oLivro.ID_LIVRO.ToString();

                    DesabilitaCampos();

                    btnAlterar.Enabled = true;

                    btnDeletar.Enabled = true;

                    btnSalvar.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Livro não encontrado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {

                CLivro.CLivroClient oProxy = new CLivro.CLivroClient();
                oProxy.Open();

                int var = Convert.ToInt32(txtPesquisa.Text);

                if (oProxy.SelecionarID(var) != null)
                {
                    LIVRO oLivro = oProxy.SelecionarID(var);

                    txtTitulo.Text = oLivro.TITULO;
                    //???????? = oLivro.QTD_DISP_EMPR;
                    //txtQuantidade.Text = oLivro.QTD_EXMPLARES.ToString();
                    txtSumario.Text = oLivro.SUMARIO;
                    dtp_Publicacao.Value = oLivro.DATA_PUBLIC;
                    cmbEditora.SelectedIndex = oLivro.ID_EDITORA;
                    txtVolume.Text = oLivro.VOLUME.ToString();
                    //???????? = .GENERO; 
                    //???????? = oLivro.Emprestimo;
                    //???????? = oLivro.RESERVA;
                    txtID.Text = oLivro.ID_LIVRO.ToString();

                    DesabilitaCampos();

                    btnAlterar.Enabled = true;

                    btnDeletar.Enabled = true;

                    btnSalvar.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Livro não encontrado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }



        ///APENAS NÚMERO



        private static void ApenasNumero(KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) ||    //Letras
                char.IsSymbol(e.KeyChar) ||    //Símbolos
                char.IsWhiteSpace(e.KeyChar) || //Espaço
                char.IsPunctuation(e.KeyChar)) //Pontuação
                e.Handled = true;
        }

        private void txtVolume_KeyPress(object sender, KeyPressEventArgs e)
        {
            ApenasNumero(e);
        }

        private void txtQuantidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            ApenasNumero(e);
        }
    }
}
