using EPharmacy.BLL;
using EPharmacy.Data;
using EPharmacy.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
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
        private readonly EPharmacyContext _context;

        public frmBaseCadastral()
        {
            InitializeComponent();

            var optionsBuilder = new DbContextOptionsBuilder<EPharmacyContext>();
            optionsBuilder.UseSqlServer(Program.StrConn());
            _context = new EPharmacyContext(optionsBuilder.Options);
        }


        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            ReceitaBLL receitaBLL = new ReceitaBLL();
            dgvLista.DataSource = receitaBLL.GetMedicamentosParaProximos6Meses();
            dgvLista.Columns["ReceitaItensId"].Visible = false;
            dgvLista.Columns["PacienteId"].Visible = false;
            dgvLista.Columns["StatusId"].Visible = false;
            dgvLista.Columns["PacienteId"].Visible = false;
            dgvLista.Columns["MedicamentoId"].Visible = false;
            dgvLista.Columns["PeriodicidadeId"].Visible = false;

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
            //txtMedicamentoId.Clear();
            txtEAN.Clear();
            cboMedicamento.SelectedIndex = 0;
            cboConvenio.SelectedIndex = 0;
            txtCPF.Clear();
            txtMatricula.Clear();
            cboPaciente.SelectedIndex = 0;
            cboStatus.SelectedIndex = 0;

            dTPRefil1.Format = DateTimePickerFormat.Custom;
            dTPRefil1.CustomFormat = " ";
            dTPRefil2.Format = DateTimePickerFormat.Custom;
            dTPRefil2.CustomFormat = " ";
            dTPRefil3.Format = DateTimePickerFormat.Custom;
            dTPRefil3.CustomFormat = " ";
            dTPRefil4.Format = DateTimePickerFormat.Custom;
            dTPRefil4.CustomFormat = " ";
            dTPRefil5.Format = DateTimePickerFormat.Custom;
            dTPRefil5.CustomFormat = " ";
            dTPRefil6.Format = DateTimePickerFormat.Custom;
            dTPRefil6.CustomFormat = " ";
            dTPRefilExtra.Format = DateTimePickerFormat.Custom;
            dTPRefilExtra.CustomFormat = " ";

            dgvLista.DataSource = null;


            txtId.Enabled = false;
            //txtMedicamentoId.Enabled = true;
            txtEAN.Enabled = true;
            cboMedicamento.Enabled = true;
            cboConvenio.Enabled = true;
            txtCPF.Enabled = true;
            txtMatricula.Enabled = true;
            cboPaciente.Enabled = true;
            cboStatus.Enabled = true;
            dgvLista.Enabled = true;

            btnNovo.Enabled = false;
            btnPesquisar.Enabled = true;
            btnSalvar.Enabled = false;
            btnLimpar.Enabled = true;
            btnSair.Enabled = true;
            btnExcluir.Enabled = false;
        }


        private void frmBaseCadastral_Load(object sender, EventArgs e)
        {
            // PREENCHE COMBOS INICIO
            var paciente = _context.Paciente.OrderBy(p => p.Nome).ToList();
            Paciente c = new Paciente();
            c.Id = 0;
            c.Nome = "<Selecione uma opção>";
            paciente.Insert(0, c);
            cboPaciente.DataSource = paciente.ToList();
            cboPaciente.DisplayMember = "Nome";
            cboPaciente.ValueMember = "Id";

            var convenio = _context.Convenio.OrderBy(p => p.Descricao).ToList();
            Convenio f = new Convenio();
            f.Id = 0;
            f.Descricao = "<Selecione uma opção>";
            convenio.Insert(0, f);
            cboConvenio.DataSource = convenio.ToList();
            cboConvenio.DisplayMember = "Descricao";
            cboConvenio.ValueMember = "Id";

            var status = _context.Status.OrderBy(p => p.Descricao).ToList();
            Status st = new Status();
            st.Id = 0;
            st.Descricao = "<Selecione uma opção>";
            status.Insert(0, st);
            cboStatus.DataSource = status.ToList();
            cboStatus.DisplayMember = "Descricao";
            cboStatus.ValueMember = "Id";

            var medicamento = _context.Medicamento.OrderBy(p => p.Produto).ToList();
            Medicamento md = new Medicamento();
            md.Id = 0;
            md.Produto = "<Selecione uma opção>";
            medicamento.Insert(0, md);
            cboMedicamento.DataSource = medicamento.ToList();
            cboMedicamento.DisplayMember = "Produto";
            cboMedicamento.ValueMember = "Id";

            Limpar();

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
                        // corAtual = (corAtual == cor1) ? cor2 : cor1;
                        ncoroAleatorio = random.Next(0, 10);
                        corAtual =  cor[ncoroAleatorio];
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

        private string periodicidade;
        private void dgvLista_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvLista.Rows[e.RowIndex];

                var IdCell = row.Cells["ReceitaItensId"];
                var EANCell = row.Cells["EAN"];
                var matriculaCell = row.Cells["Matricula"];
                var CPFCell = row.Cells["CPF"];
                var medicamentoIdCell = row.Cells["MedicamentoId"];
                var pacienteIdCell = row.Cells["PacienteId"];
                var convenioIdCell = row.Cells["ConvenioId"];
                var statusIdCell = row.Cells["StatusId"];
                var refil1Cell = row.Cells["Refil1"];
                var refil2Cell = row.Cells["Refil2"];
                var refil3Cell = row.Cells["Refil3"];
                var refil4Cell = row.Cells["Refil4"];
                var refil5Cell = row.Cells["Refil5"];
                var refil6Cell = row.Cells["Refil6"];
                var refilExtraCell = row.Cells["RefilExtra"];
                var periodicidadeCell = (row.Cells["Periodicidade"]);

                int? Id = Convert.ToInt32(IdCell.Value);
                string EAN = EANCell.Value.ToString();
                string matricula = matriculaCell.Value.ToString();
                string CPF = CPFCell.Value.ToString();
                int? medicamentoId = Convert.ToInt32(medicamentoIdCell.Value);
                int? pacienteId = Convert.ToInt32(pacienteIdCell.Value);
                int? convenioId = Convert.ToInt32(convenioIdCell.Value);
                int? statusId = Convert.ToInt32(statusIdCell.Value);
                DateTime refil1 = refil1Cell.Value == null ? DateTime.Now.Date : Convert.ToDateTime(refil1Cell.Value);
                DateTime refil2 = refil2Cell.Value == null ? DateTime.Now.Date : Convert.ToDateTime(refil2Cell.Value);
                DateTime refil3 = refil3Cell.Value == null ? DateTime.Now.Date : Convert.ToDateTime(refil3Cell.Value);
                DateTime refil4 = refil4Cell.Value == null ? DateTime.Now.Date : Convert.ToDateTime(refil4Cell.Value);
                DateTime refil5 = refil5Cell.Value == null ? DateTime.Now.Date : Convert.ToDateTime(refil5Cell.Value);
                DateTime refil6 = refil6Cell.Value == null ? DateTime.Now.Date : Convert.ToDateTime(refil6Cell.Value);
                DateTime refilExtra = refilExtraCell.Value == null ? DateTime.Now.Date : Convert.ToDateTime(refilExtraCell.Value);
                periodicidade = periodicidadeCell.Value.ToString();


                txtId.Text = Id.ToString();
                txtEAN.Text = EAN;
                txtMatricula.Text = matricula;
                txtCPF.Text = CPF;
                cboMedicamento.SelectedValue = medicamentoId;
                cboPaciente.SelectedValue = pacienteId;
                cboConvenio.SelectedValue = convenioId;
                cboStatus.SelectedValue = statusId;
                dTPRefil1.Format = DateTimePickerFormat.Short;
                dTPRefil1.Value = refil1.Date;
                dTPRefil2.Format = DateTimePickerFormat.Short;
                dTPRefil2.Value = refil2.Date;
                dTPRefil3.Format = DateTimePickerFormat.Short;
                dTPRefil3.Value = refil3.Date;
                dTPRefil4.Format = DateTimePickerFormat.Short;
                dTPRefil4.Value = refil4.Date;
                dTPRefil5.Format = DateTimePickerFormat.Short;
                dTPRefil5.Value = refil5.Date;
                dTPRefil6.Format = DateTimePickerFormat.Short;
                dTPRefil6.Value = refil6.Date;
                dTPRefilExtra.Format = DateTimePickerFormat.Short;
                dTPRefilExtra.Value = refilExtra.Date;

                // dTPReceita.Value = dataReceita.Date;
                txtId.Enabled = false;
                txtEAN.Enabled = false;
                txtMatricula.Enabled = false;
                txtCPF.Enabled = false;
                cboMedicamento.Enabled = false;
                cboPaciente.Enabled = false;
                cboConvenio.Enabled = false;
                cboStatus.Enabled = false;
                dgvLista.Enabled = true;

                dTPRefil1.Enabled = true;
                dTPRefil2.Enabled = true;
                dTPRefil3.Enabled = true;
                dTPRefil4.Enabled = true;
                dTPRefil5.Enabled = true;
                dTPRefil6.Enabled = true;
                dTPRefilExtra.Enabled = true;

                btnNovo.Enabled = false;
                btnPesquisar.Enabled = true;
                btnSalvar.Enabled = true;
                btnLimpar.Enabled = true;
                btnSair.Enabled = true;
                btnExcluir.Enabled = false;

                // dgvLista_CellClick_Para_dgvReceitaItens();

            }
        }


        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string retorno = "";
            if (dTPRefil1.Value == null)
            {
                retorno += "Preencha o campo Refil 1\n";
            }

            if (dTPRefil2.Value == null)
            {
                retorno += "Preencha o campo Refil 2\n";
            }

            if (dTPRefil3.Value == null)
            {
                retorno += "Preencha o campo Refil 3\n";
            }

            if (dTPRefil4.Value == null)
            {
                retorno += "Preencha o campo Refil 4\n";
            }

            if (dTPRefil5.Value == null)
            {
                retorno += "Preencha o campo Refil 5\n";
            }

            if (dTPRefil6.Value == null)
            {
                retorno += "Preencha o campo Refil 6\n";
            }

            if (dTPRefilExtra.Value == null)
            {
                retorno += "Preencha o campo Refil Extra\n";
            }

            if (!retorno.IsNullOrEmpty())
            {
                MessageBox.Show(retorno, "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DateTime refil1_ = dTPRefil1.Value;
            DateTime refil2_ = dTPRefil2.Value;
            DateTime refil3_ = dTPRefil3.Value;
            DateTime refil4_ = dTPRefil4.Value;
            DateTime refil5_ = dTPRefil5.Value;
            DateTime refil6_ = dTPRefil6.Value;
            DateTime refilExtra_ = dTPRefilExtra.Value;

            var entityUpdate = new ReceitaItens();

            int Id_ = Convert.ToInt32(txtId.Text);
            entityUpdate = _context.ReceitaItens.Find(Id_);

            /*refil2_ = refil1_.AddDays(30);
            refil3_ = refil2_.AddDays(30);
            refil4_ = refil3_.AddDays(30);
            refil5_ = refil4_.AddDays(30);
            refil6_ = refil5_.AddDays(30);
            refilExtra_ = refil6_.AddDays(30);*/

            entityUpdate.Refil1 = refil1_;
            entityUpdate.Refil2 = refil2_;
            entityUpdate.Refil3 = refil3_;
            entityUpdate.Refil4 = refil4_;
            entityUpdate.Refil5 = refil5_;
            entityUpdate.Refil6 = refil6_;
            entityUpdate.RefilExtra = refilExtra_;
            entityUpdate.DataCadastro = DateTime.Now;
            entityUpdate.Usuario = 1;

            _context.SaveChanges();
            Limpar();
            /*txtId.Text = Id_.ToString();*/
            btnPesquisar_Click(null, null);
            /*txtId.Clear();*/

        }


        private void dTPRefil1_ValueChanged(object sender, EventArgs e)
        {
            double dblperiodicidade = Convert.ToDouble(periodicidade);
            dTPRefil2.Value = dTPRefil1.Value.AddDays(dblperiodicidade);
            dTPRefil3.Value = dTPRefil2.Value.AddDays(dblperiodicidade);   
            dTPRefil4.Value = dTPRefil3.Value.AddDays(dblperiodicidade);
            dTPRefil5.Value = dTPRefil4.Value.AddDays(dblperiodicidade);
            dTPRefil6.Value = dTPRefil5.Value.AddDays(dblperiodicidade);
        }


    }
}
