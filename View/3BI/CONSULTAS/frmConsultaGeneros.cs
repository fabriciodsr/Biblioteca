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
    public partial class frmConsultaGeneros : Form
    {
        public frmConsultaGeneros()
        {
            InitializeComponent();
        }

        private void frmConsultaGeneros_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((frmPrincipal)this.MdiParent).gÊNEROSToolStripMenuItem.Enabled = true;
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


        ///apenas numero em ID

        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            ApenasNumero(e);
        }

        private void btnProcurar_Click_1(object sender, EventArgs e)
        {
            if (cmbPesquisa.SelectedIndex == 0)
            {
                CGenero.CGeneroClient oProxy = new CGenero.CGeneroClient();
                oProxy.Open();
                dtgGeneros.DataSource = oProxy.ListaTodosGeneros();
            }
            else if (cmbPesquisa.SelectedIndex == 1)
            {
                int var = Convert.ToInt32(txtPesquisa.Text);
                CGenero.CGeneroClient oProxy = new CGenero.CGeneroClient();
                oProxy.Open();

                if (oProxy.Selecionar(var) != null)
                {
                    List<GENERO> oGenero = new List<GENERO>();
                    oGenero.Add(oProxy.Selecionar(var));
                    dtgGeneros.DataSource = oGenero;
                    dtgGeneros.Refresh();
                }
                else
                {
                    MessageBox.Show("Genero não encontrado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (cmbPesquisa.SelectedIndex == 2)
            {

                CGenero.CGeneroClient oProxy = new CGenero.CGeneroClient();
                oProxy.Open();

                if (oProxy.SelecionarDescricao(txtPesquisa.Text) != null)
                {
                    List<GENERO> oGenero = new List<GENERO>();
                    oGenero.Add(oProxy.SelecionarDescricao(txtPesquisa.Text));

                    dtgGeneros.DataSource = oGenero;
                    dtgGeneros.Refresh();
                }
                else
                {
                    MessageBox.Show("Genero não encontrado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            dtgGeneros.DataSource = null;
            txtPesquisa.Text = "";
            cmbPesquisa.SelectedItem = null;
        }
    }
}
