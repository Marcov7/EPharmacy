using EPharmacy.BLL;
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
            HighlightRowsByNameChange();
        }


        private void btnSair_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
                "Você tem certeza que deseja fechar o formulário?",
                "Confirmação",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (resultado == DialogResult.Yes)
            {
                this.Close();
            }
        }


        private void btnLimpar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
              "Você tem certeza que deseja Limpar?",
              "Confirmação",
              MessageBoxButtons.YesNo,
              MessageBoxIcon.Question
            );

            if (resultado != DialogResult.Yes)
            {
                return;
            }

            Limpar();
        }


        private void Limpar()
        {
            txtId.Clear();
            txtMedicamentoId.Clear();
            txtEAN.Clear();
            dTPData.Value = DateTime.Now.Date;
            dgvLista.DataSource = null;

            txtId.Enabled = true;
            txtMedicamentoId.Enabled = true;
            txtEAN.Enabled = true;
            dTPData.Enabled = true;
            dgvLista.Enabled = true;

            btnNovo.Enabled = true;
            btnPesquisar.Enabled = true;
            btnSalvar.Enabled = false;
            btnLimpar.Enabled = true;
            btnSair.Enabled = true;
            btnExcluir.Enabled = false;
        }


        private void frmBaseCadastral_Load(object sender, EventArgs e)
        {

        }


        private void HighlightRowsByNameChange()
        {
            // Defina as cores para alternar
            Color[] cor = new Color[11]; // Cria um vetor de inteiros com 11 posições
             cor[0] = Color.LightGoldenrodYellow;
             cor[1] = Color.LightBlue;
             cor[2] = Color.LightGreen;
             cor[3] = Color.LightCoral;
             cor[4] = Color.LightCyan;
             cor[5] = Color.LightPink;
             cor[6] = Color.LightSeaGreen;
             cor[7] = Color.LightSkyBlue;
             cor[8] = Color.LightYellow;
             cor[9] = Color.LightSteelBlue;
             cor[10] = Color.LightSlateGray;
            
            Random random = new Random();
            // Gerar um número aleatório entre 0 e 11
            int ncoroAleatorio = random.Next(0, 10);
            int ultimo = ncoroAleatorio;

            Color cor1 = cor[ncoroAleatorio];         
            ncoroAleatorio = random.Next(0, 10);
            if (ncoroAleatorio == ultimo)
            {
                if (ultimo < 10)
                    ncoroAleatorio = ++ncoroAleatorio;
                else
                    ncoroAleatorio = --ncoroAleatorio;
            }
            Color cor2 = cor[ncoroAleatorio];
            // Variável para controlar a cor atual
            Color corAtual = cor1;

            // Obtenha o valor inicial (supondo que as linhas estão ordenadas por "nome")
            string ultimoNome = null;

            foreach (DataGridViewRow row in dgvLista.Rows)
            {
                if (row.Cells["nome"].Value != null)
                {
                    string nomeAtual = row.Cells["nome"].Value.ToString();

                    // Se o nome atual for diferente do anterior, alterne a cor
                    if (ultimoNome != nomeAtual)
                    {
                        corAtual = (corAtual == cor1) ? cor2 : cor1;
                        ultimoNome = nomeAtual;
                    }

                    // Aplique a cor atual na linha
                    row.DefaultCellStyle.BackColor = corAtual;
                }
            }
        }


        // Não serviu
        private void dgvLista_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            foreach (DataGridViewRow row in dgvLista.Rows)
            {
                // Supondo que a condição está na coluna "Status"
                //var statusValue = row.Cells["Status"].Value?.ToString();

                //if (statusValue == "Aprovado")
                //{
                    row.DefaultCellStyle.BackColor = Color.LightGreen; // Cor de fundo
                    row.DefaultCellStyle.ForeColor = Color.Black;     // Cor do texto
                //}
                //else if (statusValue == "Reprovado")
                //{
                //    row.DefaultCellStyle.BackColor = Color.LightCoral;
                //    row.DefaultCellStyle.ForeColor = Color.White;
                //}
                //else
                //{
                //    row.DefaultCellStyle.BackColor = Color.White;
                //    row.DefaultCellStyle.ForeColor = Color.Black;
                //}
            }
        }
    }
}
