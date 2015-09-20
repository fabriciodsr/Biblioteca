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
            ((frmPrincipal)this.MdiParent).lIVROSToolStripMenuItem.Enabled = true;
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
                //oLivro.QTD_DISP_EMPR = ??????????
                oLivro.QTD_EXMPLARES = Convert.ToInt32(txtQuantidade.Text);
                oLivro.SUMARIO = txtSumario.Text;
                oLivro.DATA_PUBLIC = dtp_Publicacao.Value;
                oLivro.ID_EDITORA = cmbEditora.SelectedIndex;
                oLivro.VOLUME = Convert.ToInt32(txtVolume.Text);
                //oLivro.GENERO = 
                //oLivro.Emprestimo = ???????????
                //oLivro.RESERVA = ???????


                CLivro.CLivroClient oProxy = new CLivro.CLivroClient();
                oProxy.Open();

                if (var == 0)
                {

                    try
                    {
                        if (oProxy.Cadastrar(oLivro))
                        {

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

                                txtTitulo.Text = oLivro.TITULO;
                                //???????? = oLivro.QTD_DISP_EMPR;
                                txtQuantidade.Text = oLivro.QTD_EXMPLARES.ToString();
                                txtSumario.Text = oLivro.SUMARIO;
                                dtp_Publicacao.Value = oLivro.DATA_PUBLIC;
                                cmbEditora.SelectedIndex = oLivro.ID_EDITORA;
                                txtVolume.Text = oLivro.VOLUME.ToString();
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpaCampos();

            var = 0;

            HabilitaCampos();

            btnAlterar.Enabled = false;

            btnDeletar.Enabled = false;

            btnSalvar.Enabled = true;
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {

        }

        private void frmCadastroLivro_Load(object sender, EventArgs e)
        {

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
                    txtVolume.Text.Trim() != "" &&
                    txtID.Text.Trim() != "" &&
                    txtPesquisa.Text.Trim() != ""
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
                    txtQuantidade.Text = oLivro.QTD_EXMPLARES.ToString();
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
                    txtQuantidade.Text = oLivro.QTD_EXMPLARES.ToString();
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
    }
}
