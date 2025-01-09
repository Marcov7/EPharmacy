using ControleEntregada.Forms;
using EPharmacy.Forms;

namespace EPharmacy
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }


        private void medicamentoToolStripMenuItem_Click(object sender, EventArgs e)
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


        private void preçoDeMedicamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form filho in this.MdiChildren)
            {
                if (filho is frmMedicamentoPreco)
                {
                    filho.Activate();
                    return;
                }
            }

            frmMedicamentoPreco formulario = new frmMedicamentoPreco(0)
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


        private void usuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form filho in this.MdiChildren)
            {
                if (filho is frmUsuarioSistema)
                {
                    filho.Activate();
                    return;
                }
            }

            frmUsuarioSistema formulario = new frmUsuarioSistema
            {
                MdiParent = this,
            };
            formulario.Show();
            formulario.Location = new Point(220, 50);
        }


        private void cadastroDePacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form filho in this.MdiChildren)
            {
                if (filho is frmPaciente)
                {
                    filho.Activate();
                    return;
                }
            }

            frmPaciente formulario = new frmPaciente
            {
                MdiParent = this,
            };
            formulario.Show();
            formulario.Location = new Point(90, 30);
        }


        private void tipoEntregaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form filho in this.MdiChildren)
            {
                if (filho is frmTipoEntrega)
                {
                    filho.Activate();
                    return;
                }
            }

            frmTipoEntrega formulario = new frmTipoEntrega
            {
                MdiParent = this,
            };
            formulario.Show();
            formulario.Location = new Point(180, 30);
        }


        private void modalidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form filho in this.MdiChildren)
            {
                if (filho is frmModalidade)
                {
                    filho.Activate();
                    return;
                }
            }

            frmModalidade formulario = new frmModalidade
            {
                MdiParent = this,
            };
            formulario.Show();
            formulario.Location = new Point(180, 30);
        }


        private void convenioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form filho in this.MdiChildren)
            {
                if (filho is frmConvenio)
                {
                    filho.Activate();
                    return;
                }
            }

            frmConvenio formulario = new frmConvenio
            {
                MdiParent = this,
            };
            formulario.Show();
            formulario.Location = new Point(180, 30);
        }


        private void periodicidadeRefilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form filho in this.MdiChildren)
            {
                if (filho is frmPeriodicidadeRefil)
                {
                    filho.Activate();
                    return;
                }
            }

            frmPeriodicidadeRefil formulario = new frmPeriodicidadeRefil
            {
                MdiParent = this,
            };
            formulario.Show();
            formulario.Location = new Point(180, 30);
        }


        private void clinicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form filho in this.MdiChildren)
            {
                if (filho is frmClinica)
                {
                    filho.Activate();
                    return;
                }
            }

            frmClinica formulario = new frmClinica
            {
                MdiParent = this,
            };
            formulario.Show();
            formulario.Location = new Point(180, 30);
        }


        private void medicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form filho in this.MdiChildren)
            {
                if (filho is frmMedico)
                {
                    filho.Activate();
                    return;
                }
            }

            frmMedico formulario = new frmMedico
            {
                MdiParent = this,
            };
            formulario.Show();
            formulario.Location = new Point(180, 30);
        }


        private void receitaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            foreach (Form filho in this.MdiChildren)
            {
                if (filho is frmReceita)
                {
                    filho.Activate();
                    return;
                }
            }

            frmReceita formulario = new frmReceita
            {
                MdiParent = this,
            };
            formulario.Show();
            formulario.Location = new Point(20, 2);
        }


        private void receitaItensToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void baseCadastralToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form filho in this.MdiChildren)
            {
                if (filho is frmBaseCadastral)
                {
                    filho.Activate();
                    return;
                }
            }

            frmBaseCadastral formulario = new frmBaseCadastral
            {
                MdiParent = this,
            };
            formulario.Show();
            formulario.Location = new Point(0, 0);
        }


        private void parâmetrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form filho in this.MdiChildren)
            {
                if (filho is frmParametros)
                {
                    filho.Activate();
                    return;
                }
            }

            frmParametros formulario = new frmParametros
            {
                MdiParent = this,
            };
            formulario.Show();
            formulario.Location = new Point(5, 5);
        }


        private void pedidoToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }


        private void pedidoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            //foreach (Form filho in this.MdiChildren)
            //{
            //    if (filho is frmPedido)
            //    {
            //        filho.Activate();
            //        return;
            //    }
            //}

            //frmPedido formulario = new frmPedido
            //{
            //    MdiParent = this,
            //};
            //formulario.Show();
            //formulario.Location = new Point(5, 5);
        }


        private void bairroZonaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form filho in this.MdiChildren)
            {
                if (filho is frmBairroZona)
                {
                    filho.Activate();
                    return;
                }
            }

            frmBairroZona formulario = new frmBairroZona
            {
                MdiParent = this,
            };
            formulario.Show();
            formulario.Location = new Point(5, 5);
        }

        private void pedidoToolStripMenuItem2_Click_1(object sender, EventArgs e)
        {
            foreach (Form filho in this.MdiChildren)
            {
                if (filho is frmPedido)
                {
                    filho.Activate();
                    return;
                }
            }

            frmPedido formulario = new frmPedido
            {
                MdiParent = this,
            };
            formulario.Show();
            formulario.Location = new Point(5, 5);
        }
    }
}

