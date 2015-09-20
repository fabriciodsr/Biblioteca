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
    public partial class frmCadastroAutor : Form
    {



        public frmCadastroAutor()
        {
            InitializeComponent();
        }


        int var = 0;




        ///CLOSE


        private void frmCadastroAutor_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((frmPrincipal)this.MdiParent).aUTORToolStripMenuItem.Enabled = true;

        }




        ///LIMPA CAMPOS


        private void LimpaCampos()
        {
            txtBiografia.Text = "";
            txtID.Text = "";
            txtNome.Text = "";
            txtSite.Text = "";
            txtSobreNome.Text = "";
            txtPesquisa.Text = "";
        }





        ///BOTÃO SALVAR
        /// 


        private void btnInserir_Click(object sender, EventArgs e)
        {

            if (VerificaControles())
            {
                AUTOR oAutor = new AUTOR();

                oAutor.BIOGRAFIA = txtBiografia.Text;
                oAutor.NOME = txtNome.Text;
                oAutor.SITE = txtSite.Text;
                oAutor.SOBRENOME = txtSobreNome.Text;


                CAutor.CAutorClient oProxy = new CAutor.CAutorClient();
                oProxy.Open();


                if (var == 0)
                {
                    try
                    {
                        if (oProxy.Cadastrar(oAutor))
                        {
                            MessageBox.Show("Cadastro realizado com sucesso!", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LimpaCampos();
                        }
                        else
                        {
                            if (MessageBox.Show("Autor existente! Deseja carregar os dados do Autor?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                            {



                                btnInserir.Enabled = false;

                                btnDeletar.Enabled = true;

                                btnAlterar.Enabled = true;

                                AUTOR xAutor = oProxy.SelecionarNome(oAutor.NOME);


                                txtNome.Text = xAutor.NOME;
                                txtSobreNome.Text = xAutor.SOBRENOME;
                                txtBiografia.Text = xAutor.BIOGRAFIA;
                                txtID.Text = Convert.ToString(xAutor.ID_AUTOR);
                                txtSite.Text = xAutor.SITE;

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
                        if (oProxy.Alterar(oAutor))
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





        ///BOTÃO ALTERAR
        /// 



        private void btnAlterar_Click(object sender, EventArgs e)
        {
            HabilitaCampos();

            btnInserir.Enabled = true;

            btnAlterar.Enabled = false;

            txtNome.Enabled = false;

            var = 1;
        }


        ///BOTÃO PROCURAR
        /// 



        private void btnProcurar_Click(object sender, EventArgs e)
        {
            if (cmbPesquisa.SelectedIndex == 0)
            {
                int var = Convert.ToInt32(txtPesquisa.Text);
                CAutor.CAutorClient oProxy = new CAutor.CAutorClient();
                oProxy.Open();

                if (oProxy.Selecionar(var) != null)
                {
                    AUTOR oAutor = oProxy.Selecionar(var);

                    txtNome.Text = oAutor.NOME;
                    txtSobreNome.Text = oAutor.SOBRENOME;
                    txtBiografia.Text = oAutor.BIOGRAFIA;
                    txtSite.Text = oAutor.SITE;
                    txtID.Text = oAutor.ID_AUTOR.ToString();

                    DesabilitaCampos();

                    btnAlterar.Enabled = true;

                    btnDeletar.Enabled = true;

                    btnInserir.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Autor não encontrado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {

                CAutor.CAutorClient oProxy = new CAutor.CAutorClient();
                oProxy.Open();

                if (oProxy.SelecionarNome(txtPesquisa.Text) != null)
                {
                    AUTOR oAutor = oProxy.SelecionarNome(txtPesquisa.Text);

                    txtNome.Text = oAutor.NOME;
                    txtSobreNome.Text = oAutor.SOBRENOME;
                    txtBiografia.Text = oAutor.BIOGRAFIA;
                    txtSite.Text = oAutor.SITE;
                    txtID.Text = oAutor.ID_AUTOR.ToString();

                    DesabilitaCampos();

                    btnAlterar.Enabled = true;

                    btnDeletar.Enabled = true;

                    btnInserir.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Autor não encontrado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }




        ///BOTÃO CANCELAR
        /// 
        /// 

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpaCampos();

            HabilitaCampos();

            var = 0;

            btnAlterar.Enabled = false;

            btnDeletar.Enabled = false;

            btnInserir.Enabled = true;
        }




        ///LOAD
        /// 



        private void frmCadastroAutor_Load(object sender, EventArgs e)
        {
            cmbPesquisa.SelectedIndex = 0;

        }



        ///VERIFICA CONTROLES

        private bool VerificaControles()
        {
            if (
                txtBiografia.Text.Trim() != "" &&
                txtNome.Text.Trim() != "" &&
                txtSite.Text.Trim() != "" &&
                txtSobreNome.Text.Trim() != ""
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
            txtBiografia.Enabled = false;
            txtNome.Enabled = false;
            txtSite.Enabled = false;
            txtSobreNome.Enabled = false;
            txtID.Enabled = false;
        }



        ///HABILITA CAMPOS
        /// 


        private void HabilitaCampos()
        {
            txtBiografia.Enabled = true;
            txtNome.Enabled = true;
            txtSite.Enabled = true;
            txtSobreNome.Enabled = true;
        }



        ///BOTÃO DELETAR
        /// 


        private void btnDeletar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja deletar os dados do autor?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                int var = Convert.ToInt32(txtID.Text);

                CAutor.CAutorClient oProxy = new CAutor.CAutorClient();
                oProxy.Open();

                try
                {
                    oProxy.Deletar(var);

                    LimpaCampos();

                    HabilitaCampos();


                    MessageBox.Show("Autor deletado com sucesso!", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    btnAlterar.Enabled = false;

                    btnInserir.Enabled = true;

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
