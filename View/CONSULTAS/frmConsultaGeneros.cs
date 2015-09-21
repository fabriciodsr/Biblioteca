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

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            
            if(txtID.Text == "0")
            {
                CGenero.CGeneroClient oProxy = new CGenero.CGeneroClient();
                oProxy.Open();
                dtgGeneros.DataSource = oProxy.ListaTodosGeneros();

                oProxy.Close();
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


        ///apenas numero em ID

        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            ApenasNumero(e);
        }
    }
}
