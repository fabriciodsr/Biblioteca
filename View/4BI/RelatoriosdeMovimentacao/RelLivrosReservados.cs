﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controller;
using Model;

namespace View._4BI.RelatoriosdeMovimentacao
{
    public partial class RelLivrosReservados : Form
    {
        public RelLivrosReservados()
        {
            InitializeComponent();
        }

        private void btnPesquisarReserva_Click(object sender, EventArgs e)
        {
            CRelatorioReserva.CRelatorioReservaClient oProxy = new CRelatorioReserva.CRelatorioReservaClient();
            oProxy.Open();
            if (rdbLivro.Checked)
            {
                dtgRelatorio.DataSource = oProxy.GerarRelatorioID();
                dtgRelatorio.Refresh();
            }
            else if (rdbAluno.Checked)
            {
                dtgRelatorio.DataSource = oProxy.GerarRelatorioAluno();
                dtgRelatorio.Refresh();
            }
            oProxy.Close();
        }
    }
}
