﻿using System;
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

        private void frmCadastroAluno_Load(object sender, EventArgs e)
        {
            cmbPais.DataSource = ListaPais.ListaPaises();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
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

                        ALUNO xAluno = oProxy.SelecionarCPF(var);


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
                        txtID.Text = xAluno.ID_ALUNO.ToString();

                        txtNome.Enabled = false;
                        txtSobreNome.Enabled = false;
                        txtCPF.Enabled = false;
                        txtID.Enabled = false;
                        dtpNasc.Enabled = false;                
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
        
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpaCampos();

            txtNome.Enabled = true;
            txtSobreNome.Enabled = true;
            txtCPF.Enabled = true;
            dtpNasc.Enabled = true;
        }

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
            txt_ID.Text = "";
            txt_Nome.Text = "";
            cmbUF.SelectedItem = null;
            cmbPais.SelectedItem = null;
            dtpNasc.Value = System.DateTime.Now;
        }

        private void frmCadastroAluno_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((frmPrincipal)this.MdiParent).aLUNOToolStripMenuItem.Enabled = true;
        }

        private void btnAlterar_Click(object sender, EventArgs e)
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

            try
            {
                if (oProxy.Alterar(oAluno))
                {
                    MessageBox.Show("Alteração realizada com sucesso!", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpaCampos();

                    txtNome.Enabled = true;
                    txtSobreNome.Enabled = true;
                    txtCPF.Enabled = true;
                    dtpNasc.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {
           
            int var = Convert.ToInt32(txt_ID.Text);
            CAluno.CAlunoClient oProxy = new CAluno.CAlunoClient();
            oProxy.Open();

            if (oProxy.Selecionar(var)!= null)
            {
                ALUNO oAluno = AlunoMetod.Selecionar(var);

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

                txtNome.Enabled = false;
                txtSobreNome.Enabled = false;
                txtCPF.Enabled = false;
                dtpNasc.Enabled = false;
            }
            else
            {
                MessageBox.Show("Aluno não encontrado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }           
        }
    }
}
