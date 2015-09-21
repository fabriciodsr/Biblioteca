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

            CAutor.CAutorClient oProxy = new CAutor.CAutorClient();
            oProxy.Open();

            var Lista = oProxy.ListaTodosAutores();

            foreach (var p in Lista)
            {
                cmbAutor1.Items.Add(p.NOME);
                cmbAutor2.Items.Add(p.NOME);
            }

            oProxy.Close();



            CGenero.CGeneroClient oProxy2 = new CGenero.CGeneroClient();
            oProxy2.Open();

            var Lista2 = oProxy2.ListaTodosGeneros();

            foreach (var p in Lista2)
            {
                cmbGenero.Items.Add(p.DESCRICAO);
            }

            oProxy2.Close();



            CEditora.CEditoraClient oProxy3 = new CEditora.CEditoraClient();
            oProxy3.Open();

            var Lista3 = oProxy3.ListaTodasEditoras();

            foreach (var p in Lista3)
            {
                cmbEditora.Items.Add(p.NOME);
            }

            oProxy3.Close();


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
    }
}
