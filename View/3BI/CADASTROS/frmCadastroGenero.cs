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
    public partial class frmCadastroGenero : Form
    {



        public frmCadastroGenero()
        {
            InitializeComponent();
        }

        int var = 0;


        ///CLOSE


        private void frmCadastroGenero_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((frmPrincipal)this.MdiParent).gENEROToolStripMenuItem.Enabled = true;
        }



        ///LIMPA CAMPOS


        private void LimpaCampos()
        {
            txtDescricao.Text = "";
            txtID.Text = "";
            txtPesquisa.Text = "";
            cmbAndar.SelectedItem = null;
            cmbCorredor.SelectedItem = null;
            cmbPrateleira.SelectedItem = null;
        }



        ///BOTÃO SALVAR


        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (VerificaControles())
            {
                GENERO oGenero = new GENERO();

                oGenero.DESCRICAO = txtDescricao.Text;
                oGenero.PRATELEIRA= cmbPrateleira.SelectedItem.ToString();
                oGenero.CORREDOR = cmbCorredor.SelectedItem.ToString();
                oGenero.ANDAR= cmbAndar.SelectedItem.ToString();


                CGenero.CGeneroClient oProxy = new CGenero.CGeneroClient();
                oProxy.Open();


                if (var == 0)
                {
                    try
                    {
                        if (oProxy.Cadastrar(oGenero))
                        {
                            MessageBox.Show("Cadastro realizado com sucesso!", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LimpaCampos();
                        }
                        else
                        {
                            if (MessageBox.Show("Gênero existente! Deseja carregar os dados do Gênero?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                            {



                                btnSalvar.Enabled = false;

                                btnDeletar.Enabled = true;

                                btnAlterar.Enabled = true;

                                GENERO xGenero = oProxy.SelecionarDescricao(oGenero.DESCRICAO);

                                txtID.Text = Convert.ToString(xGenero.ID_GENERO);
                                txtDescricao.Text = xGenero.DESCRICAO;
                                cmbAndar.SelectedItem = xGenero.ANDAR;
                                cmbCorredor.SelectedItem = xGenero.CORREDOR;
                                cmbPrateleira.SelectedItem = xGenero.PRATELEIRA;


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
                        if (oProxy.Alterar(oGenero))
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






        ///ALTERAR
        /// 


        private void btnAlterar_Click(object sender, EventArgs e)
        {

            HabilitaCampos();

            btnSalvar.Enabled = true;

            btnAlterar.Enabled = false;

            txtDescricao.Enabled = false;

            var = 1;
        }




        ///PROCURAR



        private void btnProcurar_Click(object sender, EventArgs e)
        {
            if (cmbPesquisa.SelectedIndex == 0)
            {
                int var = Convert.ToInt32(txtPesquisa.Text);
                CGenero.CGeneroClient oProxy = new CGenero.CGeneroClient();
                oProxy.Open();

                if (oProxy.Selecionar(var) != null)
                {
                    GENERO oGenero = oProxy.Selecionar(var);

                    txtDescricao.Text = oGenero.DESCRICAO;
                    cmbAndar.SelectedItem = oGenero.ANDAR;
                    cmbCorredor.SelectedItem = oGenero.CORREDOR;
                    cmbPrateleira.SelectedItem = oGenero.PRATELEIRA;
                    txtID.Text = Convert.ToString(oGenero.ID_GENERO);


                    DesabilitaCampos();

                    btnAlterar.Enabled = true;

                    btnDeletar.Enabled = true;

                    btnSalvar.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Gênero não encontrado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {

                CGenero.CGeneroClient oProxy = new CGenero.CGeneroClient();
                oProxy.Open();

                if (oProxy.SelecionarDescricao(txtPesquisa.Text) != null)
                {
                    GENERO oGenero = oProxy.SelecionarDescricao(txtPesquisa.Text);

                    txtDescricao.Text = oGenero.DESCRICAO;
                    cmbAndar.SelectedItem = oGenero.ANDAR;
                    cmbCorredor.SelectedItem = oGenero.CORREDOR;
                    cmbPrateleira.SelectedItem = oGenero.PRATELEIRA;
                    txtID.Text = Convert.ToString(oGenero.ID_GENERO);

                    DesabilitaCampos();

                    btnAlterar.Enabled = true;

                    btnDeletar.Enabled = true;

                    btnSalvar.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Gênero não encontrado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }




        ///BOTÃO CANCELAR


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpaCampos();

            HabilitaCampos();

            var = 0;

            btnAlterar.Enabled = false;

            btnDeletar.Enabled = false;

            btnSalvar.Enabled = true;
        }




        ///LOAD
        /// 

        private void frmCadastroGenero_Load(object sender, EventArgs e)
        {
            cmbPesquisa.SelectedIndex = 0;

        }



        ///VERIFICA CONTROLES


        private bool VerificaControles()
        {
            if (

                txtDescricao.Text.Trim() != "" &&
                cmbAndar.SelectedItem != null &&
                cmbCorredor.SelectedItem != null &&
                cmbPesquisa.SelectedItem != null

                )
            {

                return true;

            }
            else
            {
                return false;
            }
        }



        ///DESABILITA CAMPOS


        private void DesabilitaCampos()
        {
            txtDescricao.Enabled = false;
            cmbAndar.Enabled = false;
            cmbCorredor.Enabled = false;
            cmbPrateleira.Enabled = false;
            txtID.Enabled = false;
        }




        ///HABILITA CAMPOS


        private void HabilitaCampos()
        {
            txtDescricao.Enabled = true;
            cmbAndar.Enabled = true;
            cmbCorredor.Enabled = true;
            cmbPrateleira.Enabled = true;
        }




        ///DELETAR


        private void btnDeletar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja deletar os dados do Gênero?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                int var = Convert.ToInt32(txtID.Text);

                CGenero.CGeneroClient oProxy = new CGenero.CGeneroClient();
                oProxy.Open();

                try
                {
                    oProxy.Deletar(var);

                    LimpaCampos();

                    HabilitaCampos();


                    MessageBox.Show("Gênero deletado com sucesso!", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    btnAlterar.Enabled = false;

                    btnSalvar.Enabled = true;

                    btnDeletar.Enabled = false;
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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




        ///VALIDA O CAMPO DE PESQUISA POR ID - APENAS NÚMERO


        private void txtPesquisa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cmbPesquisa.SelectedIndex == 0)
            {
                ApenasNumero(e);
            }
        }


        ///lIMPA CONTROLE PESQUISA AO MUDAR O CMBPESQUISA


        private void cmbPesquisa_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtPesquisa.Text = "";
        }
    }
}
