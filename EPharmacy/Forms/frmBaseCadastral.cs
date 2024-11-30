﻿using EPharmacy.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EPharmacy.Forms
{
    public partial class frmBaseCadastral : Form
    {
        public frmBaseCadastral()
        {
            InitializeComponent();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            ReceitaBLL receitaBLL = new ReceitaBLL();
            dgvLista.DataSource = receitaBLL.GetMedicamentosParaProximos6Meses();
        }
    }
}
