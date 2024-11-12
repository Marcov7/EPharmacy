using ControleEntregada.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

            frmMedicamentoPreco  formulario = new frmMedicamentoPreco
            {
                MdiParent = this,
            };
            formulario.Show();
            formulario.Location = new Point(20,0);
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
    }
}
