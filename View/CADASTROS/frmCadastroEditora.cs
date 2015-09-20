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
    public partial class frmCadastroEditora : Form
    {



        public frmCadastroEditora()
        {
            InitializeComponent();
        }



        int var = 0;




        ///CLOSE



        private void frmCadastroEditora_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((frmPrincipal)this.MdiParent).eDITORAToolStripMenuItem.Enabled = true;
        }



        ///LIMPA CAMPOS


        private void LimpaCampos()
        {
            txtBairro.Text = "";
            txtCEP.Text = "";
            txtCidade.Text = "";
            txtEmail.Text = "";
            txtEnd.Text = "";
            txtID.Text = "";
            txtNome.Text = "";
            txtTel1.Text = "";
            txtTel2.Text = "";
            txtPesquisa.Text = "";
            cmbPais.SelectedItem = null;
            cmbUF.SelectedItem = null;

        }




        ///BOTÃO SALVAR


        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (VerificaControles())
            {
                EDITORA oEditora = new EDITORA();

                oEditora.NOME = txtNome.Text;
                oEditora.BAIRRO = txtBairro.Text;
                oEditora.CEP = txtCEP.Text;
                oEditora.CIDADE = txtCidade.Text;
                oEditora.EMAIL = txtEmail.Text;
                oEditora.ENDERECO = txtEnd.Text;
                oEditora.TEL_1 = txtTel1.Text;
                oEditora.TEL_2 = txtTel2.Text;
                oEditora.PAIS = cmbPais.SelectedItem.ToString();
                oEditora.UF = cmbUF.SelectedItem.ToString();


                CEditora.CEditoraClient oProxy = new CEditora.CEditoraClient();
                oProxy.Open();


                if (var == 0)
                {
                    try
                    {
                        if (oProxy.Cadastrar(oEditora))
                        {
                            MessageBox.Show("Cadastro realizado com sucesso!", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LimpaCampos();
                        }
                        else
                        {
                            if (MessageBox.Show("Editora existente! Deseja carregar os dados da Editora?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                            {



                                btnSalvar.Enabled = false;

                                btnDeletar.Enabled = true;

                                btnAlterar.Enabled = true;

                                EDITORA xEditora= oProxy.SelecionarNome(oEditora.NOME);

                                txtNome.Text = xEditora.NOME;
                                txtBairro.Text = xEditora.BAIRRO;
                                txtCEP.Text = xEditora.CEP;
                                txtCidade.Text = xEditora.CIDADE;
                                txtEmail.Text = xEditora.EMAIL;
                                txtEnd.Text = xEditora.ENDERECO;
                                txtTel1.Text = xEditora.TEL_1;
                                txtTel2.Text = xEditora.TEL_2;
                                cmbPais.SelectedItem = xEditora.PAIS;
                                cmbUF.SelectedItem = xEditora.UF;
                                txtID.Text = Convert.ToString(xEditora.ID_EDITORA);


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
                        if (oProxy.Alterar(oEditora))
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


        private void btnAlterar_Click(object sender, EventArgs e)
        {
            HabilitaCampos();

            btnSalvar.Enabled = true;

            btnAlterar.Enabled = false;

            txtNome.Enabled = false;

            var = 1;
        }




        ///PROCURAR

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            if (cmbPesquisa.SelectedIndex == 0)
            {
                int var = Convert.ToInt32(txtPesquisa.Text);
                CEditora.CEditoraClient oProxy = new CEditora.CEditoraClient();
                oProxy.Open();

                if (oProxy.Selecionar(var) != null)
                {
                    EDITORA oEditora = oProxy.Selecionar(var);

                    txtNome.Text = oEditora.NOME;
                    txtBairro.Text = oEditora.BAIRRO;
                    txtCEP.Text = oEditora.CEP;
                    txtCidade.Text = oEditora.CIDADE;
                    txtEmail.Text = oEditora.EMAIL;
                    txtEnd.Text = oEditora.ENDERECO;
                    txtTel1.Text = oEditora.TEL_1;
                    txtTel2.Text = oEditora.TEL_2;
                    cmbPais.SelectedItem = oEditora.PAIS;
                    cmbUF.SelectedItem = oEditora.UF;
                    txtID.Text = Convert.ToString(oEditora.ID_EDITORA);

                    DesabilitaCampos();

                    btnAlterar.Enabled = true;

                    btnDeletar.Enabled = true;

                    btnSalvar.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Editora não encontrada!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {

                CEditora.CEditoraClient oProxy = new CEditora.CEditoraClient();
                oProxy.Open();

                if (oProxy.SelecionarNome(txtPesquisa.Text) != null)
                {
                    EDITORA oEditora = oProxy.SelecionarNome(txtPesquisa.Text);

                    txtNome.Text = oEditora.NOME;
                    txtBairro.Text = oEditora.BAIRRO;
                    txtCEP.Text = oEditora.CEP;
                    txtCidade.Text = oEditora.CIDADE;
                    txtEmail.Text = oEditora.EMAIL;
                    txtEnd.Text = oEditora.ENDERECO;
                    txtTel1.Text = oEditora.TEL_1;
                    txtTel2.Text = oEditora.TEL_2;
                    cmbPais.SelectedItem = oEditora.PAIS;
                    cmbUF.SelectedItem = oEditora.UF;
                    txtID.Text = Convert.ToString(oEditora.ID_EDITORA);

                    DesabilitaCampos();

                    btnAlterar.Enabled = true;

                    btnDeletar.Enabled = true;

                    btnSalvar.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Editora não encontrada!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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



        private void frmCadastroEditora_Load(object sender, EventArgs e)
        {
            cmbPais.DataSource = ListaPais.ListaPaises();

            cmbPesquisa.SelectedIndex = 0;

        }





        ///VERIFICA CONTROLES


        private bool VerificaControles()
        {
            if (

                txtNome.Text.Trim() != "" &&
                txtBairro.Text.Trim() != "" &&
                txtCEP.Text.Trim() != "" &&
                txtCidade.Text.Trim() != "" &&
                txtEmail.Text.Trim() != "" &&
                txtEnd.Text.Trim() != "" &&
                txtTel1.Text.Trim() != "" &&
                txtTel2.Text.Trim() != "" &&
                cmbPais.SelectedItem != null &&
                cmbUF.SelectedItem != null
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
            txtNome.Enabled = false;
            txtBairro.Enabled = false;
            txtCEP.Enabled = false;
            txtCidade.Enabled = false;
            txtEmail.Enabled = false;
            txtEnd.Enabled = false;
            txtTel1.Enabled = false;
            txtTel2.Enabled = false;
            cmbPais.Enabled = false;
            cmbUF.Enabled = false;
            txtID.Enabled = false;
        }





        ///HABILITA CAMPOS


        private void HabilitaCampos()
        {
            txtNome.Enabled = true;
            txtBairro.Enabled = true;
            txtCEP.Enabled = true;
            txtCidade.Enabled = true;
            txtEmail.Enabled = true;
            txtEnd.Enabled = true;
            txtTel1.Enabled = true;
            txtTel2.Enabled = true;
            cmbPais.Enabled = true;
            cmbUF.Enabled = true;
        }




        ///DELETAR



        private void btnDeletar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja deletar os dados da Editora?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                int var = Convert.ToInt32(txtID.Text);

                CEditora.CEditoraClient oProxy = new CEditora.CEditoraClient();
                oProxy.Open();

                try
                {
                    oProxy.Deletar(var);

                    LimpaCampos();

                    HabilitaCampos();


                    MessageBox.Show("Editora deletada com sucesso!", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);


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
    }
    
}
