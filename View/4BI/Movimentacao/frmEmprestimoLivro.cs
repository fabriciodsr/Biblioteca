using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View._4BI.Movimentacao
{
    public partial class frmEmprestimoLivro : Form
    {
        public frmEmprestimoLivro(string id, string titulo, string aluno, string situacao, string dataEmp, string dataDev)
        {
            InitializeComponent();

            txtAluno.Text = aluno;

            txtID.Text = id;

            txtLivro.Text = titulo;

            txtSituacao.Text = situacao;

            dtpEmp.Value = Convert.ToDateTime(dataEmp);

            dtpDevol.Value = Convert.ToDateTime(dataDev);
        }


        private void frmEmprestimoLivro_Load(object sender, EventArgs e)
        {


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void txtSituacao_TextChanged(object sender, EventArgs e)
        {
            if(txtSituacao.Text == "ok")
            {
                txtSituacao.ForeColor = Color.Blue;
            }
            else
            {
                txtSituacao.ForeColor = Color.Red;

            }
        }

        private void btnRenovar_Click(object sender, EventArgs e)
        {

            var ident = Convert.ToInt32(txtID.Text);

            CEmprestimo.CEmprestimoClient oProxyRen = new CEmprestimo.CEmprestimoClient();
            oProxyRen.Open();
            try
            {
                oProxyRen.RenovarEmprestimo(ident);

                MessageBox.Show("Seu empréstimo foi renovado por mais 10 dias!", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnDevolução_Click(object sender, EventArgs e)
        {
            

        }
    }
}
