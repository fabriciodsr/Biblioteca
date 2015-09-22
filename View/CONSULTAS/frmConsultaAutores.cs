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
    public partial class frmConsultaAutores : Form
    {
        public frmConsultaAutores()
        {
            InitializeComponent();
        }

        private void frmConsultaAutores_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((frmPrincipal)this.MdiParent).aUTORESToolStripMenuItem.Enabled = true;
        }

        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            if (cmbPesquisa.SelectedIndex == 0)
            {
                CAutor.CAutorClient oProxy = new CAutor.CAutorClient();
                oProxy.Open();
                dtgAutores.DataSource = oProxy.ListaTodosAutores();
            }
            else if (cmbPesquisa.SelectedIndex == 1)
            {
                int var = Convert.ToInt32(txtPesquisa.Text);
                CAutor.CAutorClient oProxy = new CAutor.CAutorClient();
                oProxy.Open();

                if (oProxy.Selecionar(var) != null)
                {
                    List<AUTOR> oAutores = new List<AUTOR>();
                    oAutores.Add(oProxy.Selecionar(var));
                    dtgAutores.DataSource = oAutores;
                    dtgAutores.Refresh();
                }
                else
                {
                    MessageBox.Show("Autor não encontrado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (cmbPesquisa.SelectedIndex == 2)
            {

                CAutor.CAutorClient oProxy = new CAutor.CAutorClient();
                oProxy.Open();

                if (oProxy.SelecionarNome(txtPesquisa.Text) != null)
                {
                    List<AUTOR> oAutor = new List<AUTOR>();
                    oAutor.Add(oProxy.SelecionarNome(txtPesquisa.Text));

                    dtgAutores.DataSource = oAutor;
                    dtgAutores.Refresh();
                }
                else
                {
                    MessageBox.Show("Autor não encontrado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
          }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            dtgAutores.DataSource = null;
            txtPesquisa.Text = "";
            cmbPesquisa.SelectedItem = null;

        }
    }
}
