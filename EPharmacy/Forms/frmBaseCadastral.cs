﻿using BLL;
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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace EPharmacy.Forms
{
    public partial class frmBaseCadastral : Form
    {
        private readonly EPharmacyContext _context;
        private EntidadeApoio entidadeApoio;


        public frmBaseCadastral()
        {
            InitializeComponent();

            this.WindowState = FormWindowState.Maximized;

            var optionsBuilder = new DbContextOptionsBuilder<EPharmacyContext>();
            optionsBuilder.UseSqlServer(Program.StrConn());
            _context = new EPharmacyContext(optionsBuilder.Options);
        }


        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string EAN = "";
            if (!UtilitariosBLL.limpaString(txtEAN.Text).IsNullOrEmpty())
            {
                EAN = UtilitariosBLL.limpaString(txtEAN.Text);
            }

            int? MedicamentoId = null;
            if (cboMedicamento.SelectedIndex > 0)
            {
                MedicamentoId = Convert.ToInt32(cboMedicamento.SelectedValue);
            }

            int? ConvenioId = null;
            if (cboConvenio.SelectedIndex > 0)
            {
                ConvenioId = Convert.ToInt32(cboConvenio.SelectedValue);
            }

            string CPF = "";
            if (!UtilitariosBLL.limpaString2(txtCPF.Text).IsNullOrEmpty())
            {
                CPF = UtilitariosBLL.limpaString(txtCPF.Text);
            }

            string Matricula = "";
            if (!UtilitariosBLL.limpaString2(txtMatricula.Text).IsNullOrEmpty())
            {
                Matricula = UtilitariosBLL.limpaString(txtMatricula.Text);
            }

            int? PacienteId = null;
            if (cboPaciente.SelectedIndex > 0)
            {
                PacienteId = Convert.ToInt32(cboPaciente.SelectedValue);
            }

            int? StatusId = null;
            if (cboStatus.SelectedIndex > 0)
            {
                StatusId = Convert.ToInt32(cboStatus.SelectedValue);
            }

            string? bairro = null;
            if (cboBairro.SelectedIndex > 0)
            {
                bairro = cboBairro.Text;
            }

            string? zona = null;
            if (cboZona.SelectedIndex > 0)
            {
                zona = cboZona.Text;
            }

            int? tipoReceitaId = null;
            if (cboTipoReceita.SelectedIndex > 0)
            {
                tipoReceitaId = Convert.ToInt32(cboTipoReceita.SelectedValue);
            }

            DateTime? datafiltro = null;
            if (!UtilitariosBLL.limpaString2(txtMesAno.Text).IsNullOrEmpty())
            {
                string dataFiltro = "01/" + txtMesAno.Text;
                if (!DateTime.TryParse(dataFiltro, out DateTime dataComparacao))
                {
                    MessageBox.Show("Formato de data inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                datafiltro = dataComparacao;
            }


            ReceitaBLL receitaBLL = new ReceitaBLL();
            dgvLista.DataSource = receitaBLL.GetMedicamentosParaProximos6Meses(datafiltro, EAN, MedicamentoId, ConvenioId, CPF, Matricula, PacienteId, StatusId, bairro, zona, tipoReceitaId);
            dgvLista.Columns["ReceitaItensId"].Visible = chkMostrarIds.Checked;
            dgvLista.Columns["PacienteId"].Visible = chkMostrarIds.Checked;
            dgvLista.Columns["StatusId"].Visible = chkMostrarIds.Checked;
            dgvLista.Columns["PacienteId"].Visible = chkMostrarIds.Checked;
            dgvLista.Columns["MedicamentoId"].Visible = chkMostrarIds.Checked;
            dgvLista.Columns["PeriodicidadeId"].Visible = chkMostrarIds.Checked;
            dgvLista.Columns["ReceitaId"].Visible = chkMostrarIds.Checked;
            //dgvLista.Columns["ReceitaDescricao"].Visible = chkMostrarIds.Checked;
            dgvLista.Columns["TipoReceitaId"].Visible = chkMostrarIds.Checked;
            dgvLista.Columns["ConvenioId"].Visible = chkMostrarIds.Checked;


            dgvLista.Columns["ReceitaItensId"].HeaderText = "Id Rec Itens";
            dgvLista.Columns["PacienteId"].HeaderText = "Id Paciente";
            dgvLista.Columns["StatusId"].HeaderText = "Id tatus";
            dgvLista.Columns["PacienteId"].HeaderText = "Id Paciente";
            dgvLista.Columns["MedicamentoId"].HeaderText = "Id Medicam.";
            dgvLista.Columns["PeriodicidadeId"].HeaderText = "Id Periodic.";
            dgvLista.Columns["ReceitaId"].HeaderText = "Id Receita";
            dgvLista.Columns["ReceitaDescricao"].HeaderText = "Descricao Receita";
            dgvLista.Columns["TipoReceitaId"].HeaderText = "Id Tp.Receita";
            dgvLista.Columns["TipoReceita"].HeaderText = "Tp.Receita";
            dgvLista.Columns["ConvenioId"].HeaderText = "Id Convenio";
            dgvLista.Columns["PrecoAcordado"].HeaderText = "Preço Acordado";
            dgvLista.Columns["DataReceitaAnterior"].HeaderText = "Dt Rec.Anterior";
            dgvLista.Columns["DataInclusaoConvenio"].HeaderText = "Dt Inclusão Convênio";
            dgvLista.Columns["DataReceita"].HeaderText = "Dt Receita";
            //dgvLista.Columns["DataReceita"].HeaderText = "Dt Receita";
            dgvLista.Columns["ClasseTerapeutica"].HeaderText = "Classe Terapeutica";
            dgvLista.Columns["TipoEntrega"].HeaderText = "Tp.Entrega";

            HighlightRowsByNameChange();

            btnExportar.Enabled = true;
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
            txtMesAno.Clear();
            cboBairro.SelectedIndex = 0;
            cboZona.SelectedIndex = 0;
            cboTipoReceita.SelectedIndex = 0;

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
            cboStatusParaGravar.SelectedIndex = 0;

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
            txtMesAno.Enabled = true;
            cboBairro.Enabled = true;
            cboZona.Enabled = true;
            cboTipoReceita.Enabled = true;
            dgvLista.Enabled = true;

            btnExportar.Enabled = false;
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

            var statusParaGravar = _context.Status.OrderBy(p => p.Descricao).ToList();
            Status stpg = new Status();
            stpg.Id = 0;
            stpg.Descricao = "<Selecione uma opção>";
            statusParaGravar.Insert(0, stpg);
            cboStatusParaGravar.DataSource = statusParaGravar.ToList();
            cboStatusParaGravar.DisplayMember = "Descricao";
            cboStatusParaGravar.ValueMember = "Id";

            var medicamento = _context.Medicamento.OrderBy(p => p.Produto).ToList();
            Medicamento md = new Medicamento();
            md.Id = 0;
            md.Produto = "<Selecione uma opção>";
            medicamento.Insert(0, md);
            cboMedicamento.DataSource = medicamento.ToList();
            cboMedicamento.DisplayMember = "Produto";
            cboMedicamento.ValueMember = "Id";

            var bairroZona = _context.BairroZona.OrderBy(p => p.Bairro).Distinct().ToList();
            BairroZona bz = new BairroZona();
            //bz.Id = 0;
            bz.Bairro = "<Selecione uma opção>";
            bairroZona.Insert(0, bz);
            cboBairro.DataSource = bairroZona.ToList();
            cboBairro.DisplayMember = "Bairro";
            cboBairro.ValueMember = "Bairro";

            // zona
            var zona = _context.BairroZona
                   .OrderBy(p => p.Zona)
                   .Select(p => p.Zona)
                   .Distinct()
                   .ToList();

            BairroZona bzz = new BairroZona();
            bzz.Zona = "<Selecione uma opção>";

            // Criando uma lista de BairroZona que inclui a opção inicial
            var listaZona = new List<BairroZona> { bzz };

            // Adicionando as zonas distintas
            listaZona.AddRange(_context.BairroZona
                                        .Where(p => zona.Contains(p.Zona))
                                        .Select(p => new BairroZona { Zona = p.Zona })
                                        .Distinct()
                                        .ToList());

            // Agora, o ComboBox pode receber a lista de BairroZona
            cboZona.DataSource = listaZona;
            cboZona.DisplayMember = "Zona";
            cboZona.ValueMember = "Zona";
            // fim zona


            var tipoReceita = _context.TipoReceita.OrderBy(p => p.Descricao).ToList();
            TipoReceita tr = new TipoReceita();
            tr.Id = 0;
            tr.Descricao = "<Selecione uma opção>";
            tipoReceita.Insert(0, tr);
            cboTipoReceita.DataSource = tipoReceita.ToList();
            cboTipoReceita.DisplayMember = "Descricao";
            cboTipoReceita.ValueMember = "Id";


            // alterar a altura da linhas do grid
            dgvLista.RowTemplate.Height = 17;

            // fazendo ficar com as colunas autoajuestadas ao tamanho
            dgvLista.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            Limpar();

        }


        private void chkAumentaLarguraColunasGrid_CheckedChanged_1(object sender, EventArgs e)
        {
            // fazendo ficar com as colunas autoajuestadas ao tamanho
            if (chkAumentaLarguraColunasGrid.Checked)
            {
                dgvLista.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
            else
            {
                dgvLista.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            }
        }


        private void HighlightRowsByNameChange()
        {
            // Defina as cores para alternar
            Color[] cor = new Color[11]; // Cria um vetor de inteiros com 11 posições
            cor[0] = ColorTranslator.FromHtml("#ffffff");
            cor[1] = ColorTranslator.FromHtml("#ececec");
            cor[2] = ColorTranslator.FromHtml("#d9d9d9");
            cor[3] = ColorTranslator.FromHtml("#c7c7c6");
            cor[4] = ColorTranslator.FromHtml("#b4b4b3");
            cor[5] = ColorTranslator.FromHtml("#a1a1a0");
            cor[6] = ColorTranslator.FromHtml("#8e8e8d");
            cor[7] = ColorTranslator.FromHtml("#7b7b7a");
            cor[8] = ColorTranslator.FromHtml("#686867");
            cor[9] = ColorTranslator.FromHtml("#565654");
            cor[10] = ColorTranslator.FromHtml("#434341");

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
                        corAtual = cor[ncoroAleatorio];
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
            //////foreach (DataGridViewRow row in dgvLista.Rows)
            //////{
            // Supondo que a condição está na coluna "Status"
            //var statusValue = row.Cells["Status"].Value?.ToString();

            //if (statusValue == "Aprovado")
            //{
            //////////row.DefaultCellStyle.BackColor = Color.LightGreen; // Cor de fundo
            //////////row.DefaultCellStyle.ForeColor = Color.Black;     // Cor do texto
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
            ////////}


            if (dgvLista.Columns[e.ColumnIndex].Name == "PrecoAcordado" || dgvLista.Columns[e.ColumnIndex].Name == "Total")
            {
                if (e.Value != null && decimal.TryParse(e.Value.ToString(), out decimal cellValue))
                {
                    // Se o valor for zero, mudar a cor de fundo da célula
                    if (cellValue == 0)
                    {
                        e.CellStyle.BackColor = Color.Red;       // Cor de fundo vermelha
                        e.CellStyle.ForeColor = Color.White;     // Cor da fonte branca
                    }
                }
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
                var bairroCell = row.Cells["Bairro"];
                var zonaCell = row.Cells["Zona"];
                var tipoReceitaIdCell = row.Cells["TipoReceitaId"];

                var refil1Cell = row.Cells["Refil1"];
                var refil2Cell = row.Cells["Refil2"];
                var refil3Cell = row.Cells["Refil3"];
                var refil4Cell = row.Cells["Refil4"];
                var refil5Cell = row.Cells["Refil5"];
                var refil6Cell = row.Cells["Refil6"];
                var refilExtraCell = row.Cells["RefilExtra"];
                var statusParaGravarIdCell = row.Cells["StatusId"];
                var periodicidadeCell = (row.Cells["Periodicidade"]);

                int? Id = Convert.ToInt32(IdCell.Value);
                string EAN = EANCell.Value.ToString();
                string matricula = matriculaCell.Value.ToString();
                string CPF = CPFCell.Value.ToString();
                int? medicamentoId = Convert.ToInt32(medicamentoIdCell.Value);
                int? pacienteId = Convert.ToInt32(pacienteIdCell.Value);
                int? convenioId = Convert.ToInt32(convenioIdCell.Value);
                int? statusId = Convert.ToInt32(statusIdCell.Value);

                string? bairro = bairroCell.Value.ToString();
                string? zona = zonaCell.Value.ToString();
                int? tipoReceitaId = Convert.ToInt32(tipoReceitaIdCell.Value);

                DateTime refil1 = refil1Cell.Value == null ? DateTime.Now.Date : Convert.ToDateTime(refil1Cell.Value);
                DateTime? refil2 = refil2Cell.Value == null ? DateTime.Now.Date : Convert.ToDateTime(refil2Cell.Value);
                DateTime? refil3 = refil3Cell.Value == null ? DateTime.Now.Date : Convert.ToDateTime(refil3Cell.Value);
                DateTime? refil4 = refil4Cell.Value == null ? DateTime.Now.Date : Convert.ToDateTime(refil4Cell.Value);
                DateTime? refil5 = refil5Cell.Value == null ? DateTime.Now.Date : Convert.ToDateTime(refil5Cell.Value);
                DateTime? refil6 = refil6Cell.Value == null ? DateTime.Now.Date : Convert.ToDateTime(refil6Cell.Value);
                DateTime? refilExtra = refilExtraCell.Value == null ? null : Convert.ToDateTime(refilExtraCell.Value);
                int? statusParaGravar = Convert.ToInt32(statusParaGravarIdCell.Value);
                periodicidade = periodicidadeCell.Value.ToString();

                entidadeApoio = new EntidadeApoio();
                entidadeApoio.Data = UtilitariosBLL.limpaString2(txtMesAno.Text).IsNullOrEmpty() ? null : Convert.ToDateTime("01/" + txtMesAno.Text);
                entidadeApoio.EAN = UtilitariosBLL.limpaString2(txtEAN.Text);
                entidadeApoio.Matricula = UtilitariosBLL.limpaString2(txtMatricula.Text);
                entidadeApoio.CPF = UtilitariosBLL.limpaString2(txtCPF.Text);
                entidadeApoio.MedicamentoId = Convert.ToInt32(cboMedicamento.SelectedValue) > 0 ? Convert.ToInt32(cboMedicamento.SelectedValue) : null;
                entidadeApoio.PacienteId = Convert.ToInt32(cboPaciente.SelectedValue) > 0 ? Convert.ToInt32(cboPaciente.SelectedValue) : null;
                entidadeApoio.ConvenioId = Convert.ToInt32(cboConvenio.SelectedValue) > 0 ? Convert.ToInt32(cboConvenio.SelectedValue) : null;
                entidadeApoio.StatusId = Convert.ToInt32(cboStatus.SelectedValue) > 0 ? Convert.ToInt32(cboStatus.SelectedValue) : null;
                entidadeApoio.Bairro = cboBairro.SelectedIndex > 0 ? cboBairro.SelectedValue.ToString() : null;
                entidadeApoio.Zona = cboZona.SelectedIndex > 0 ? cboZona.SelectedValue.ToString() : null;
                entidadeApoio.TipoReceitaId = Convert.ToInt32(cboTipoReceita.SelectedValue) > 0 ? Convert.ToInt32(cboTipoReceita.SelectedValue) : null;


                /* //--> comentados para mater a receita na tela. afeta o salvar.  */
                txtId.Text = Id.ToString();
                //-->txtEAN.Text = EAN;
                txtMatricula.Text = matricula;
                txtCPF.Text = CPF;
                //-->cboMedicamento.SelectedValue = medicamentoId;
                cboPaciente.SelectedValue = pacienteId;
                cboConvenio.SelectedValue = convenioId;
                //-->cboStatus.SelectedValue = statusId;
                cboBairro.SelectedValue = bairro;
                cboZona.SelectedValue = zona;
                //-->cboTipoReceita.SelectedValue = tipoReceitaId;


                dTPRefil1.Format = DateTimePickerFormat.Short;
                dTPRefil1.Value = refil1.Date;
                dTPRefil2.Format = DateTimePickerFormat.Short;
                //dTPRefil2.Value = refil2.Date;
                dTPRefil3.Format = DateTimePickerFormat.Short;
                //dTPRefil3.Value = refil3.Date;
                dTPRefil4.Format = DateTimePickerFormat.Short;
                //dTPRefil4.Value = refil4.Date;
                dTPRefil5.Format = DateTimePickerFormat.Short;
                //dTPRefil5.Value = refil5.Date;
                dTPRefil6.Format = DateTimePickerFormat.Short;
                //dTPRefil6.Value = refil6.Date;
                dTPRefilExtra.Format = DateTimePickerFormat.Short;
                cboStatusParaGravar.SelectedValue = statusParaGravar;

                if (refil2 != null)
                {
                    dTPRefil2.Value = refil2.Value;
                }
                else
                {
                    dTPRefil2.Value = dTPRefil2.MinDate;
                    dTPRefil2.Format = DateTimePickerFormat.Custom;
                    dTPRefil2.CustomFormat = " ";
                }

                if (refil3 != null)
                {
                    dTPRefil3.Value = refil3.Value;
                }
                else
                {
                    dTPRefil3.Value = dTPRefil3.MinDate;
                    dTPRefil3.Format = DateTimePickerFormat.Custom;
                    dTPRefil3.CustomFormat = " ";
                }

                if (refil4 != null)
                {
                    dTPRefil4.Value = refil4.Value;
                }
                else
                {
                    dTPRefil4.Value = dTPRefil4.MinDate;
                    dTPRefil4.Format = DateTimePickerFormat.Custom;
                    dTPRefil4.CustomFormat = " ";
                }

                if (refil5 != null)
                {
                    dTPRefil5.Value = refil5.Value;
                }
                else
                {
                    dTPRefil5.Value = dTPRefil5.MinDate;
                    dTPRefil5.Format = DateTimePickerFormat.Custom;
                    dTPRefil5.CustomFormat = " ";
                }

                if (refil6 != null)
                {
                    dTPRefil6.Value = refil6.Value;
                }
                else
                {
                    dTPRefil6.Value = dTPRefil6.MinDate;
                    dTPRefil6.Format = DateTimePickerFormat.Custom;
                    dTPRefil6.CustomFormat = " ";
                }

                if (refilExtra != null)
                {
                    dTPRefilExtra.Value = refilExtra.Value;
                }
                else
                {
                    dTPRefilExtra.Value = dTPRefilExtra.MinDate;
                    dTPRefilExtra.Format = DateTimePickerFormat.Custom;
                    dTPRefilExtra.CustomFormat = " ";
                }

                //DateTime refilExtra = refilExtraCell.Value == null ? DateTime.Now.Date : Convert.ToDateTime(refilExtraCell.Value);


                // dTPReceita.Value = dataReceita.Date;
                txtId.Enabled = false;
                txtEAN.Enabled = false;
                txtMatricula.Enabled = false;
                txtCPF.Enabled = false;
                cboMedicamento.Enabled = false;
                cboPaciente.Enabled = false;
                cboConvenio.Enabled = false;
                cboStatus.Enabled = false;

                cboBairro.Enabled = false;
                cboZona.Enabled = false;
                cboTipoReceita.Enabled = false;

                dgvLista.Enabled = true;

                dTPRefil1.Enabled = true;
                dTPRefil2.Enabled = true;
                dTPRefil3.Enabled = true;
                dTPRefil4.Enabled = true;
                dTPRefil5.Enabled = true;
                dTPRefil6.Enabled = true;
                dTPRefilExtra.Enabled = true;
                cboStatusParaGravar.Enabled = true;

                btnExportar.Enabled = true;
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

            /*
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
            */

            if (cboStatusParaGravar.SelectedIndex == 0)
            {
                retorno += "Preencha o campo Status\n";
            }

            if (!retorno.IsNullOrEmpty())
            {
                MessageBox.Show(retorno, "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            DateTime refil1_ = dTPRefil1.Value;
            /* DateTime refil2_ = dTPRefil2.Value;
             DateTime refil3_ = dTPRefil3.Value;
             DateTime refil4_ = dTPRefil4.Value;
             DateTime refil5_ = dTPRefil5.Value;
             DateTime refil6_ = dTPRefil6.Value;*/
            DateTime? refil2_ = null;
            DateTime? refil3_ = null;
            DateTime? refil4_ = null;
            DateTime? refil5_ = null; 
            DateTime? refil6_ = null;
            DateTime? refilExtra_ = null;

            if (dTPRefil2.Value.Date != new DateTime(1753, 1, 1)) refil2_ = dTPRefil2.Value;
            if (dTPRefil3.Value.Date != new DateTime(1753, 1, 1)) refil3_ = dTPRefil3.Value;
            if (dTPRefil4.Value.Date != new DateTime(1753, 1, 1)) refil4_ = dTPRefil4.Value;
            if (dTPRefil5.Value.Date != new DateTime(1753, 1, 1)) refil5_ = dTPRefil5.Value;
            if (dTPRefil6.Value.Date != new DateTime(1753, 1, 1)) refil6_ = dTPRefil6.Value;
            if (dTPRefilExtra.Value.Date != new DateTime(1753, 1, 1)) refilExtra_ = dTPRefilExtra.Value;
            int statatusParaGravar_ = Convert.ToInt32 (cboStatusParaGravar.SelectedValue);

            var entityUpdate = new ReceitaItens();

            int Id_ = Convert.ToInt32(txtId.Text);
            entityUpdate = _context.ReceitaItens.Find(Id_);

            entityUpdate.Refil1 = refil1_;
            entityUpdate.Refil2 = refil2_;
            entityUpdate.Refil3 = refil3_;
            entityUpdate.Refil4 = refil4_;
            entityUpdate.Refil5 = refil5_;
            entityUpdate.Refil6 = refil6_;
            entityUpdate.RefilExtra = refilExtra_;
            entityUpdate.StatusId = statatusParaGravar_;
            entityUpdate.DataCadastro = DateTime.Now;
            entityUpdate.Usuario = GlobalVariables.LoginId;

            _context.SaveChanges();


            ReceitaBLL rd = new ReceitaBLL();
            rd.AdicionaRegitrosEmPedido(entityUpdate);

            //Limpar();
            /*txtId.Text = Id_.ToString();*/


            /* RECARREGANDO OS FILTROS QUE ESTAVAM ANTES DE ALTERAR. PONDO A RECEITA DE VOLTA NA TELA */
            txtMesAno.Text = entidadeApoio.Data == null || entidadeApoio.Data.ToString().Trim().Length < 5 ? "" : entidadeApoio.Data.Value.Month.ToString().PadLeft(2, '0') + "/" + entidadeApoio.Data.Value.Year.ToString();
            txtEAN.Text = entidadeApoio.EAN;
            txtMatricula.Text = entidadeApoio.Matricula;
            txtCPF.Text = entidadeApoio.CPF;
            cboMedicamento.SelectedValue = entidadeApoio.MedicamentoId == null ? "0" : entidadeApoio.MedicamentoId;
            cboPaciente.SelectedValue = entidadeApoio.PacienteId == null ? "0" : entidadeApoio.PacienteId;
            cboConvenio.SelectedValue = entidadeApoio.ConvenioId == null ? "0" : entidadeApoio.ConvenioId;
            cboStatus.SelectedValue = entidadeApoio.StatusId == null ? "0" : entidadeApoio.StatusId;
            cboBairro.SelectedValue = entidadeApoio.Bairro == null ? "0" : entidadeApoio.Bairro;
            cboZona.SelectedValue = entidadeApoio.Zona == null ? "0" : entidadeApoio.Zona;
            cboTipoReceita.SelectedValue = entidadeApoio.TipoReceitaId == null ? "0" : entidadeApoio.TipoReceitaId;

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


        private void dTPRefilExtra_ValueChanged(object sender, EventArgs e)
        {
            if (dTPRefilExtra.Value.Date != new DateTime(1753, 1, 1))
            {
                //DateTime refilExtra_ = dTPRefilExtra.Value;
                dTPRefilExtra.CustomFormat = "dd/MM/yyyy";
            }
        }


        private void btnExportar_Click(object sender, EventArgs e)
        {
            string Data = DateTime.Now.Year.ToString().PadLeft(4, '0') + DateTime.Now.Month.ToString().PadLeft(2, '0') + DateTime.Now.Day.ToString().PadLeft(2, '0');
            string Tempo = DateTime.Now.Hour.ToString().PadLeft(2, '0') + DateTime.Now.Minute.ToString().PadLeft(2, '0');
            string NomeArquivo = "BSC" + Data + Tempo + ".xlsx";
            string Path = null;

            var parametro = _context.Parametros.FirstOrDefault(p => p.Descricao == "PastaParaArmazenarArquivos");

            if (parametro == null)
            {
                MessageBox.Show("Parâmetro com Descrição 'PercentePraCalculo' não encontrado.", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Path = parametro.Valor;

            string retorno = ExportExcel.ExportDataGridViewToExcel(dgvLista, NomeArquivo, Path);

            if (!retorno.IsNullOrEmpty())
            {
                MessageBox.Show(retorno, "Confirmação", MessageBoxButtons.OK, retorno.Contains("Erro") ? MessageBoxIcon.Error : MessageBoxIcon.Exclamation);
                return;
            }

        }
    }
}
