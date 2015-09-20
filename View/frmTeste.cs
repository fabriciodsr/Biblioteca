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
    public partial class frmTeste : Form
    {
        public frmTeste()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CTeste.CTesteClient oProxy = new CTeste.CTesteClient();
            oProxy.Open();
            dtgTeste.DataSource = oProxy.ListaAlunos();
        }
    }
}
