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
    public partial class frmCadastroAluno : Form
    {
        public frmCadastroAluno()
        {
            InitializeComponent();

            
        }

        int var = 0;



        ///LOAD

        private void frmCadastroAluno_Load(object sender, EventArgs e)
        {
            cmbPais.DataSource = ListaPais.ListaPaises();

            cmbPesquisa.SelectedIndex = 0;
        }





        ///BOTÃO SALVAR
        /// 


        private void btnSalvar_Click(object sender, EventArgs e)
        {

            if(VerificaControles())
            {
                ALUNO oAluno = new ALUNO();

                oAluno.NOME = txtNome.Text;
                oAluno.SOBRENOME = txtSobreNome.Text;
                oAluno.NASC = dtpNasc.Value;
                oAluno.CPF = txtCPF.Text;
                oAluno.ENDERECO = txtEnd.Text;
                oAluno.BAIRRO = txtBairro.Text;
                oAluno.CIDADE = txtCidade.Text;
                oAluno.UF = cmbUF.SelectedItem.ToString();
                oAluno.PAIS = cmbPais.SelectedItem.ToString();
                oAluno.CEP = txtCEP.Text;
                oAluno.TEL_RES = txtTelRes.Text;
                oAluno.TEL_CEL = txtTelCel.Text;
                oAluno.EMAIL = txtEmail.Text;

                CAluno.CAlunoClient oProxy = new CAluno.CAlunoClient();
                oProxy.Open();

                if (var == 0)
                {

                    try
                    {
                        if (oProxy.Cadastrar(oAluno))
                        {

                            MessageBox.Show("Cadastro realizado com sucesso!", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LimpaCampos();

                        }
                        else
                        {
                            if (MessageBox.Show("Aluno existente! Deseja carregar os dados do aluno?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                            {
                                string var = oAluno.CPF;

                                btnSalvar.Enabled = false;

                                btnDeletar.Enabled = true;

                                btnAlterar.Enabled = true;



                                ALUNO xAluno = oProxy.SelecionarCPF(var);

                                int var2 = xAluno.ID_ALUNO;

                                txtNome.Text = xAluno.NOME;
                                txtSobreNome.Text = xAluno.SOBRENOME;
                                dtpNasc.Value = xAluno.NASC;
                                txtCPF.Text = xAluno.CPF;
                                txtEnd.Text = xAluno.ENDERECO;
                                txtBairro.Text = xAluno.BAIRRO;
                                txtCidade.Text = xAluno.CIDADE;
                                cmbUF.SelectedItem = xAluno.UF;
                                cmbPais.SelectedItem = xAluno.PAIS;
                                txtCEP.Text = xAluno.CEP;
                                txtTelRes.Text = xAluno.TEL_RES;
                                txtTelCel.Text = xAluno.TEL_CEL;
                                txtEmail.Text = xAluno.EMAIL;
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
                            if (oProxy.Alterar(oAluno))
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



        ///BOTÃO CANCELAR
        
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpaCampos();

            var = 0;

            HabilitaCampos();

            btnAlterar.Enabled = false;

            btnDeletar.Enabled = false;

            btnSalvar.Enabled = true;


        }






        ///LIMPA CAMPOS
        /// 
        
        private void LimpaCampos()
        {
            txtBairro.Text = "";
            txtCEP.Text = "";
            txtCidade.Text = "";
            txtCPF.Text = "";
            txtEmail.Text = "";
            txtEnd.Text = "";
            txtID.Text = "";
            txtNome.Text = "";
            txtSobreNome.Text = "";
            txtTelCel.Text = "";
            txtTelRes.Text = "";
            txtPesquisa.Text = "";
            cmbUF.SelectedItem = null;
            cmbPais.SelectedItem = null;
            dtpNasc.Value = System.DateTime.Now;
        }






        ///CLOSE
        /// 


        private void frmCadastroAluno_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((frmPrincipal)this.MdiParent).aLUNOToolStripMenuItem.Enabled = true;
        }



        ///BOTÃO ALTERAR
        ///


        private void btnAlterar_Click(object sender, EventArgs e)
        {
            HabilitaCampos();

            txtCPF.Enabled = false;

            btnSalvar.Enabled = true;

            btnAlterar.Enabled = false;

            var = 1;

        }





        ///PROCURAR



        private void btnProcurar_Click(object sender, EventArgs e)
        {
           
            if(cmbPesquisa.SelectedIndex == 0)
            {
                int var = Convert.ToInt32(txtPesquisa.Text);
                CAluno.CAlunoClient oProxy = new CAluno.CAlunoClient();
                oProxy.Open();

                if (oProxy.Selecionar(var) != null)
                {
                    ALUNO oAluno = oProxy.Selecionar(var);

                    txtNome.Text = oAluno.NOME;
                    txtSobreNome.Text = oAluno.SOBRENOME;
                    dtpNasc.Value = oAluno.NASC;
                    txtCPF.Text = oAluno.CPF;
                    txtEnd.Text = oAluno.ENDERECO;
                    txtBairro.Text = oAluno.BAIRRO;
                    txtCidade.Text = oAluno.CIDADE;
                    cmbUF.SelectedItem = oAluno.UF;
                    cmbPais.SelectedItem = oAluno.PAIS;
                    txtCEP.Text = oAluno.CEP;
                    txtTelRes.Text = oAluno.TEL_RES;
                    txtTelCel.Text = oAluno.TEL_CEL;
                    txtEmail.Text = oAluno.EMAIL;
                    txtID.Text = oAluno.ID_ALUNO.ToString();

                    DesabilitaCampos();

                    btnAlterar.Enabled = true;

                    btnDeletar.Enabled = true;

                    btnSalvar.Enabled = false;
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
                    dtpNasc.Value = oAluno.NASC;
                    txtCPF.Text = oAluno.CPF;
                    txtEnd.Text = oAluno.ENDERECO;
                    txtBairro.Text = oAluno.BAIRRO;
                    txtCidade.Text = oAluno.CIDADE;
                    cmbUF.SelectedItem = oAluno.UF;
                    cmbPais.SelectedItem = oAluno.PAIS;
                    txtCEP.Text = oAluno.CEP;
                    txtTelRes.Text = oAluno.TEL_RES;
                    txtTelCel.Text = oAluno.TEL_CEL;
                    txtEmail.Text = oAluno.EMAIL;
                    txtID.Text = oAluno.ID_ALUNO.ToString();

                    DesabilitaCampos();

                    btnAlterar.Enabled = true;

                    btnDeletar.Enabled = true;

                    btnSalvar.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Aluno não encontrado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


                  
        }



        ///HABILITA CAMPOS
        /// 


        private void HabilitaCampos()
        {
            txtBairro.Enabled = true;
            txtCEP.Enabled = true;
            txtCidade.Enabled = true;
            txtCPF.Enabled = true;
            txtEmail.Enabled = true;
            txtEnd.Enabled = true;
            txtID.Enabled = false;
            txtNome.Enabled = true;
            txtSobreNome.Enabled = true;
            txtTelCel.Enabled = true;
            txtTelRes.Enabled = true;
            txtPesquisa.Text = "";
            cmbUF.Enabled = true;
            cmbPais.Enabled = true;
            dtpNasc.Enabled = true;
        }





        ///DESABILITA CAMPOS
        /// 


        private void DesabilitaCampos()
        {
            txtBairro.Enabled = false;
            txtCEP.Enabled = false;
            txtCidade.Enabled = false;
            txtCPF.Enabled = false;
            txtEmail.Enabled = false;
            txtEnd.Enabled = false;
            txtID.Enabled = false;
            txtNome.Enabled = false;
            txtSobreNome.Enabled = false;
            txtTelCel.Enabled = false;
            txtTelRes.Enabled = false;
            txtPesquisa.Text = "";
            cmbUF.Enabled = false;
            cmbPais.Enabled = false;
            dtpNasc.Enabled = false;
        }




        ///VERIFICA CONTROLES
        /// 



        private bool VerificaControles()
        {
            if (
                txtBairro.Text.Trim() != "" &&
                txtCEP.Text.Trim() != "" &&
                txtCidade.Text.Trim() != "" &&
                txtCPF.Text.Trim() != "" &&
                txtEmail.Text.Trim() != "" &&
                txtEnd.Text.Trim() != "" &&
                txtNome.Text.Trim() != "" &&
                txtSobreNome.Text.Trim() != "" &&
                txtTelCel.Text.Trim() != "" &&
                txtTelRes.Text.Trim() != "" &&
                cmbUF.SelectedItem != null &&
                cmbPais.SelectedItem != null
                )
            {
                
                return true;

            }
            else
            {
                return false;
            }
        }



        ///BOTÃO DELETAR
        /// 



        private void btnDeletar_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Deseja deletar os dados do aluno?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                int var = Convert.ToInt32(txtID.Text);

                CAluno.CAlunoClient oProxy = new CAluno.CAlunoClient();
                oProxy.Open();

                try
                {
                    oProxy.Deletar(var);

                    LimpaCampos();

                    HabilitaCampos();


                    MessageBox.Show("Aluno deletado com sucesso!", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);


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
