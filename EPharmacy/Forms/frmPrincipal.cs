using ControleEntregada.Forms;
using EPharmacy;
using EPharmacy.Data;
using EPharmacy.Forms;
using EPharmacy.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Azure.Core.HttpHeader;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EPharmacy
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }


        private void medicamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form filho in this.MdiChildren)
            {
                if (filho is frmMedicamento)
                {
                    filho.Activate();
                    return;
                }
            }

            frmMedicamento formulario = new frmMedicamento
            {
                MdiParent = this,
            };
            formulario.Show();
            formulario.Location = new Point(20, 0);
        }


        private void preçoMedicamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form filho in this.MdiChildren)
            {
                if (filho is frmMedicamentoPreco)
                {
                    filho.Activate();
                    return;
                }
            }

            frmMedicamentoPreco formulario = new frmMedicamentoPreco
            {
                MdiParent = this,
            };
            formulario.Show();
            formulario.Location = new Point(20, 0);
        }


        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
               "Você tem certeza que deseja Sair?",
               "Confirmação",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Question
           );

            if (resultado == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void fabricanteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form filho in this.MdiChildren)
            {
                if (filho is frmFabricante)
                {
                    filho.Activate();
                    return;
                }
            }

            frmFabricante formulario = new frmFabricante
            {
                MdiParent = this,
            };
            formulario.Show();
            formulario.Location = new Point(220, 50);
        }

        private void classeTerapeuticaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form filho in this.MdiChildren)
            {
                if (filho is frmClasseTerapeutica)
                {
                    filho.Activate();
                    return;
                }
            }

            frmClasseTerapeutica formulario = new frmClasseTerapeutica
            {
                MdiParent = this,
            };
            formulario.Show();
            formulario.Location = new Point(220, 50);
        }


        private void substanciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form filho in this.MdiChildren)
            {
                if (filho is frmSubstancia)
                {
                    filho.Activate();
                    return;
                }
            }

            frmSubstancia formulario = new frmSubstancia
            {
                MdiParent = this,
            };
            formulario.Show();
            formulario.Location = new Point(220, 50);
        }

        private void tipoReceitaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form filho in this.MdiChildren)
            {
                if (filho is frmTipoReceita)
                {
                    filho.Activate();
                    return;
                }
            }

            frmTipoReceita formulario = new frmTipoReceita
            {
                MdiParent = this,
            };
            formulario.Show();
            formulario.Location = new Point(220, 50);
        }

    }
}

