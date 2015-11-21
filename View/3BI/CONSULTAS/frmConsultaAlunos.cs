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
    public partial class frmConsultaAlunos : Form
    {
        public frmConsultaAlunos()
        {
            InitializeComponent();
        }

        private void frmConsultaAlunos_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((frmPrincipal)this.MdiParent).aLUNOSToolStripMenuItem.Enabled = true;
        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {

            if (cmbPesquisa.SelectedIndex == 0)
            {
                dtgAlunos.DataSource = AlunoMetod.SelecionarTodos();
            }
            else if (cmbPesquisa.SelectedIndex == 1)
            {
                int var = Convert.ToInt32(txtPesquisa.Text);
                CAluno.CAlunoClient oProxy = new CAluno.CAlunoClient();
                oProxy.Open();

                if (oProxy.Selecionar(var) != null)
                {
                    List<ALUNO> oAlunos = new List<ALUNO>();
                    oAlunos.Add(oProxy.Selecionar(var));
                    dtgAlunos.DataSource = oAlunos;
                    dtgAlunos.Refresh();
                }
                else
                {
                    MessageBox.Show("Aluno não encontrado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (cmbPesquisa.SelectedIndex == 2)
            {

                CAluno.CAlunoClient oProxy = new CAluno.CAlunoClient();
                oProxy.Open();

                if (oProxy.SelecionarNome(txtPesquisa.Text) != null)
                {
                    List<ALUNO> oAlunos = new List<ALUNO>();
                    oAlunos.Add(oProxy.SelecionarNome(txtPesquisa.Text)); 

                    dtgAlunos.DataSource = oAlunos;
                    dtgAlunos.Refresh();
                }
                else
                {
                    MessageBox.Show("Aluno não encontrado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (cmbPesquisa.SelectedIndex == 3)
            {
                CAluno.CAlunoClient oProxy = new CAluno.CAlunoClient();
                oProxy.Open();

                if (oProxy.SelecionarCPF(txtPesquisa.Text) != null)
                {
                    List<ALUNO> oAlunos = new List<ALUNO>();
                    oAlunos.Add(oProxy.SelecionarCPF(txtPesquisa.Text));

                    dtgAlunos.DataSource = oAlunos;
                    dtgAlunos.Refresh();
                }
                else
                {
                    MessageBox.Show("Aluno não encontrado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            dtgAlunos.DataSource = null;
            txtPesquisa.Text = "";
            cmbPesquisa.SelectedItem = null;
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
            if(cmbPesquisa.SelectedIndex == 1)
            {
                ApenasNumero(e);
            }
        }

        private void cmbPesquisa_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtPesquisa.Text = "";
        }
    }
}
