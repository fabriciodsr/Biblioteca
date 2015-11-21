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
    public partial class frmConsultaLivros : Form
    {
        public frmConsultaLivros()
        {
            InitializeComponent();
        }

        private void frmConsultaLivros_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((frmPrincipal)this.MdiParent).lIVROSToolStripMenuItem.Enabled = true;
        }

        private void frmConsultaLivros_Load(object sender, EventArgs e)
        {

            
        }

        private void txtVolume_KeyPress(object sender, KeyPressEventArgs e)
        {
            ApenasNumero(e);
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

        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            ApenasNumero(e);
        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            if (cmbPesquisa.SelectedIndex == 0)
            {
                CLivro.CLivroClient oProxy = new CLivro.CLivroClient();
                oProxy.Open();
                dtgLivros.DataSource = oProxy.ListaTodosLivros();
            }
            else if (cmbPesquisa.SelectedIndex == 1)
            {
                int var = Convert.ToInt32(txtPesquisa.Text);
                CLivro.CLivroClient oProxy = new CLivro.CLivroClient();
                oProxy.Open();

                if (oProxy.SelecionarID(var) != null)
                {
                    List<LIVRO> oLivro = new List<LIVRO>();
                    oLivro.Add(oProxy.SelecionarID(var));
                    dtgLivros.DataSource = oLivro;
                    dtgLivros.Refresh();
                }
                else
                {
                    MessageBox.Show("Livro não encontrado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (cmbPesquisa.SelectedIndex == 2)
            {

                CLivro.CLivroClient oProxy = new CLivro.CLivroClient();
                oProxy.Open();

                if (oProxy.SelecionarTitulo(txtPesquisa.Text) != null)
                {
                    List<LIVRO> oLivro = new List<LIVRO>();
                    oLivro.Add(oProxy.SelecionarTitulo(txtPesquisa.Text));

                    dtgLivros.DataSource = oLivro;
                    dtgLivros.Refresh();
                }
                else
                {
                    MessageBox.Show("Livro não encontrado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            dtgLivros.DataSource = null;
            txtPesquisa.Text = "";
            cmbPesquisa.SelectedItem = null;
        }
    }
}
