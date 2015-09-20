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
    public partial class frmCadastroAutor : Form
    {



        public frmCadastroAutor()
        {
            InitializeComponent();
        }


        int var = 0;



        private void frmCadastroAutor_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((frmPrincipal)this.MdiParent).aUTORToolStripMenuItem.Enabled = true;

        }



        private void LimpaCampos()
        {
            txtBiografia.Text = "";
            txtID.Text = "";
            txtNome.Text = "";
            txtSite.Text = "";
            txtSobreNome.Text = "";
            txt_ID.Text = "";
            txt_Pesquisa.Text = "";
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            AUTOR oAutor = new AUTOR();

            oAutor.BIOGRAFIA = txtBiografia.Text;
            oAutor.NOME = txtNome.Text;
            oAutor.SITE = txtSite.Text;
            oAutor.SOBRENOME = txtSobreNome.Text;


            CAutor.CAutorClient oProxy = new CAutor.CAutorClient();
            oProxy.Open();

            try
            {
                if (oProxy.Cadastrar(oAutor))
                {
                    MessageBox.Show("Cadastro realizado com sucesso!", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpaCampos();
                }
                else
                {
                    if (MessageBox.Show("Autor existente! Deseja carregar os dados do Autor?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        txtNome.Text = oAutor.NOME;
                        txtSobreNome.Text = oAutor.SOBRENOME;
                        txtBiografia.Text = oAutor.BIOGRAFIA;
                        txtID.Text = Convert.ToString(oAutor.ID_AUTOR);
                        txtSite.Text = oAutor.SITE;
                        

                        txtNome.Enabled = false;
                        txtSobreNome.Enabled = false;
                        txtBiografia.Enabled = false;
                        txtSite.Enabled = false;
                        txtID.Enabled = false;
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

        private void btnAlterar_Click(object sender, EventArgs e)
        {

        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpaCampos();

            txtNome.Enabled = true;
            txtSobreNome.Enabled = true;
            txtBiografia.Enabled = true;
            txtSite.Enabled = true;
        }

        private void frmCadastroAutor_Load(object sender, EventArgs e)
        {
            cmbPesquisa.SelectedIndex = 0;

        }
    }
}
