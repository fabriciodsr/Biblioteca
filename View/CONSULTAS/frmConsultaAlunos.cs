﻿using System;
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
    }
}
