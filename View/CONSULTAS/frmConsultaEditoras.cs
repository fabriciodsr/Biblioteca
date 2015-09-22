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
    public partial class frmConsultaEditoras : Form
    {
        public frmConsultaEditoras()
        {
            InitializeComponent();
        }

        private void frmConsultaEditoras_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((frmPrincipal)this.MdiParent).eDITORASToolStripMenuItem.Enabled = true;
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

        

        private void btnProcurar_Click_1(object sender, EventArgs e)
        {
            if (cmbPesquisa.SelectedIndex == 0)
            {
                CEditora.CEditoraClient oProxy = new CEditora.CEditoraClient();
                oProxy.Open();
                dtgEditoras.DataSource = oProxy.ListaTodasEditoras();
            }
            else if (cmbPesquisa.SelectedIndex == 1)
            {
                int var = Convert.ToInt32(txtPesquisa.Text);
                CEditora.CEditoraClient oProxy = new CEditora.CEditoraClient();
                oProxy.Open();

                if (oProxy.Selecionar(var) != null)
                {
                    List<EDITORA> oEditoras = new List<EDITORA>();
                    oEditoras.Add(oProxy.Selecionar(var));
                    dtgEditoras.DataSource = oEditoras;
                    dtgEditoras.Refresh();
                }
                else
                {
                    MessageBox.Show("Editora não encontrado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (cmbPesquisa.SelectedIndex == 2)
            {

                CEditora.CEditoraClient oProxy = new CEditora.CEditoraClient();
                oProxy.Open();

                if (oProxy.SelecionarNome(txtPesquisa.Text) != null)
                {
                    List<EDITORA> oAutor = new List<EDITORA>();
                    oAutor.Add(oProxy.SelecionarNome(txtPesquisa.Text));

                    dtgEditoras.DataSource = oAutor;
                    dtgEditoras.Refresh();
                }
                else
                {
                    MessageBox.Show("Editora não encontrado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }
    }
}
