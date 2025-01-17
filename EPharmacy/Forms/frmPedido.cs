using BLL;
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
    public partial class frmPedido : Form
    {

        private readonly EPharmacyContext _context;
        private bool ControlaDisparoDeEvento = false;
        private EntidadeApoio entidadeApoio;

        public frmPedido()
        {
            InitializeComponent();

            this.WindowState = FormWindowState.Maximized;

            var optionsBuilder = new DbContextOptionsBuilder<EPharmacyContext>();
            optionsBuilder.UseSqlServer(Program.StrConn());
            _context = new EPharmacyContext(optionsBuilder.Options);

            txtReal.DecimalPlaces = 0;
            txtReal.Minimum = 0.0M;
            txtReal.Maximum = 999.0M;
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
            dgvLista.DataSource = receitaBLL.GetMedicamentosParaProximos6MesesPedido(datafiltro, EAN, MedicamentoId, ConvenioId, CPF, Matricula, PacienteId, StatusId, bairro, zona, tipoReceitaId);
            //dGVReceitaItensEntrega.DataSource = null;

            dgvLista.Columns["ReceitaItensEntregaId"].Visible = chkMostrarIds.Checked;
            dgvLista.Columns["RefilId"].Visible = chkMostrarIds.Checked;
            dgvLista.Columns["StatusEntregaId"].Visible = chkMostrarIds.Checked;
       
            dgvLista.Columns["ReceitaItensId"].Visible = chkMostrarIds.Checked;
            dgvLista.Columns["PacienteId"].Visible = chkMostrarIds.Checked;
            dgvLista.Columns["StatusId"].Visible = chkMostrarIds.Checked;
            dgvLista.Columns["PacienteId"].Visible = chkMostrarIds.Checked;
            dgvLista.Columns["MedicamentoId"].Visible = chkMostrarIds.Checked;
            dgvLista.Columns["PeriodicidadeId"].Visible = chkMostrarIds.Checked;
            dgvLista.Columns["ReceitaId"].Visible = chkMostrarIds.Checked;
            dgvLista.Columns["ReceitaDescricao"].Visible = chkMostrarIds.Checked;
            dgvLista.Columns["TipoReceitaId"].Visible = chkMostrarIds.Checked;
            dgvLista.Columns["ConvenioId"].Visible = chkMostrarIds.Checked;

            dgvLista.Columns["ReceitaItensEntregaId"].HeaderText = "Id Rec.Itens Entrega";
            dgvLista.Columns["RefilId"].HeaderText = "Id Refil";
            dgvLista.Columns["StatusEntregaId"].HeaderText = "Id Status Entrega";

            dgvLista.Columns["ReceitaItensId"].HeaderText = "Id Rec.Itens";
            dgvLista.Columns["PacienteId"].HeaderText = "Id Paciente"; 
            dgvLista.Columns["StatusId"].HeaderText = "Id Status"; 
            dgvLista.Columns["PacienteId"].HeaderText = "Id Paciente"; 
            dgvLista.Columns["MedicamentoId"].HeaderText = "Id Medicam."; 
            dgvLista.Columns["PeriodicidadeId"].HeaderText = "Id Periodic."; 
            dgvLista.Columns["ReceitaId"].HeaderText = "Id Receita"; 
            dgvLista.Columns["ReceitaDescricao"].HeaderText = "Descrição Receita"; 
            dgvLista.Columns["TipoReceitaId"].HeaderText = "Id Tp.Receita"; 
            dgvLista.Columns["ConvenioId"].HeaderText = "Id Convênio";
            dgvLista.Columns["StatusEntrega"].HeaderText = "Status Entrega";
            dgvLista.Columns["DataInclusaoConvenio"].HeaderText = "Dt Inclusão Convênio";
            dgvLista.Columns["DataEntrega"].HeaderText = "Dt Entrega";
            dgvLista.Columns["PrecoAcordado"].HeaderText = "Preço Acordado";
            dgvLista.Columns["DataReceitaAnterior"].HeaderText = "Dt Rec.Anterior";
            dgvLista.Columns["DataReceita"].HeaderText = "Dt Receita";
            dgvLista.Columns["TipoReceita"].HeaderText = "Tp.Receita";
            dgvLista.Columns["TipoEntrega"].HeaderText = "Tp.Entrega";
            dgvLista.Columns["ClasseTerapeutica"].HeaderText = "Classe Terapeutica";
            dgvLista.Columns["NotaFiscal"].HeaderText = "Nota Fiscal";

            dgvLista.Columns["Refil1"].Visible = chkMostrarIds.Checked;
            dgvLista.Columns["Refil2"].Visible = chkMostrarIds.Checked;
            dgvLista.Columns["Refil3"].Visible = chkMostrarIds.Checked;
            dgvLista.Columns["Refil4"].Visible = chkMostrarIds.Checked;
            dgvLista.Columns["Refil5"].Visible = chkMostrarIds.Checked;
            dgvLista.Columns["Refil6"].Visible = chkMostrarIds.Checked;
            dgvLista.Columns["RefilExtra"].Visible = chkMostrarIds.Checked;


            HighlightRowsByNameChange();

            btnExportar.Enabled = true;

            AjustaOutraDataConsolidadaPesquisa(txtMesAno.Text);
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
            txtLote.Clear();
            txtNotaFiscal.Clear();
            txtReal.Value = 0.0M;
            cboRefil.SelectedIndex = 0;
            dTPRefil.Value = DateTime.Now.Date;
            cboStatusEntrega.SelectedIndex = 0;



            //dTPRefil1.Format = DateTimePickerFormat.Custom;
            //dTPRefil1.CustomFormat = " ";

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

            txtLote.Enabled = false;
            txtNotaFiscal.Enabled = false;
            txtReal.Enabled = false;
            cboRefil.Enabled = false;
            dTPRefil.Enabled = false;
            cboStatusEntrega.Enabled = false;

            dgvLista.Enabled = true;

            btnExportar.Enabled = false;
            btnNovo.Enabled = false;
            btnPesquisar.Enabled = true;
            btnSalvar.Enabled = false;
            btnLimpar.Enabled = true;
            btnSair.Enabled = true;
            btnExcluir.Enabled = false;
        }


        private void frmPedido_Load(object sender, EventArgs e)
        {
            // PREENCHE COMBOS INICIO
            var paciente = _context.Paciente.OrderBy(p => p.Nome).ToList();
            Paciente c = new Paciente();
            c.Id = 0;
            c.Nome = "<Selecione>";
            paciente.Insert(0, c);
            cboPaciente.DataSource = paciente.ToList();
            cboPaciente.DisplayMember = "Nome";
            cboPaciente.ValueMember = "Id";

            var convenio = _context.Convenio.OrderBy(p => p.Descricao).ToList();
            Convenio f = new Convenio();
            f.Id = 0;
            f.Descricao = "<Selecione>";
            convenio.Insert(0, f);
            cboConvenio.DataSource = convenio.ToList();
            cboConvenio.DisplayMember = "Descricao";
            cboConvenio.ValueMember = "Id";

            var status = _context.Status.OrderBy(p => p.Descricao).ToList();
            Status st = new Status();
            st.Id = 0;
            st.Descricao = "<Selecione>";
            status.Insert(0, st);
            cboStatus.DataSource = status.ToList();
            cboStatus.DisplayMember = "Descricao";
            cboStatus.ValueMember = "Id";

            var medicamento = _context.Medicamento.OrderBy(p => p.Produto).ToList();
            Medicamento md = new Medicamento();
            md.Id = 0;
            md.Produto = "<Selecione>";
            medicamento.Insert(0, md);
            cboMedicamento.DataSource = medicamento.ToList();
            cboMedicamento.DisplayMember = "Produto";
            cboMedicamento.ValueMember = "Id";

            var bairroZona = _context.BairroZona.OrderBy(p => p.Bairro).Distinct().ToList();
            BairroZona bz = new BairroZona();
            //bz.Id = 0;
            bz.Bairro = "<Selecione>";
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
            bzz.Zona = "<Selecione>";

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
            tr.Descricao = "<Selecione>";
            tipoReceita.Insert(0, tr);
            cboTipoReceita.DataSource = tipoReceita.ToList();
            cboTipoReceita.DisplayMember = "Descricao";
            cboTipoReceita.ValueMember = "Id";


            var statusEntrega = _context.StatusEntrega.OrderBy(p => p.Descricao).ToList();
            StatusEntrega se = new StatusEntrega();
            se.Id = 0;
            se.Descricao = "<Selecione>";
            statusEntrega.Insert(0, se);
            cboStatusEntrega.DataSource = statusEntrega.ToList();
            cboStatusEntrega.DisplayMember = "Descricao";
            cboStatusEntrega.ValueMember = "Id";


            var refil = _context.Refil.OrderBy(p => p.Descricao).ToList();
            Refil rf = new Refil();
            rf.Id = 0;
            rf.Descricao = "<Selecione>";
            refil.Insert(0, rf);
            cboRefil.DataSource = refil.ToList();
            cboRefil.DisplayMember = "Descricao";
            cboRefil.ValueMember = "Id";


            // alterar a altura da linhas do grid
            dgvLista.RowTemplate.Height = 17;
            //dGVReceitaItensEntrega.RowTemplate.Height = 18;

            // fazendo ficar com as colunas autoajuestadas ao tamanho
            dgvLista.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            //dGVReceitaItensEntrega.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;


            // Adiciona uma coluna de botões ao DataGridView
            DataGridViewButtonColumn btnExcluirColumn = new DataGridViewButtonColumn();
            btnExcluirColumn.Name = "btnExcluirdGVReceitaItensEntrega";
            btnExcluirColumn.HeaderText = "Excluir";
            btnExcluirColumn.Text = "<Excluir>";
            btnExcluirColumn.UseColumnTextForButtonValue = true; // Isso faz com que o texto "Excluir" apareça nos botões
            //dGVReceitaItensEntrega.Columns.Add(btnExcluirColumn);
            // Associando o evento de clique da célula
            //dGVReceitaItensEntrega.CellContentClick += new DataGridViewCellEventHandler(dGVReceitaItensEntrega_CellContentClick);

            Limpar();
            AjustaDataHojeConsolidadaPesquisa();

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


        private void dGVReceitaItensEntrega_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (ControlaDisparoDeEvento == true)
            {
                ControlaDisparoDeEvento = false;
                return;
            }

            //if (e.ColumnIndex == dGVReceitaItensEntrega.Columns["btnExcluirdGVReceitaItensEntrega"].Index)
            //{
                var result = MessageBox.Show("Tem certeza de que deseja excluir esta linha?", "Confirmar Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {

                    int rowIndex = e.RowIndex;

                Int32 Id_ = 0; // Convert.ToInt32(dGVReceitaItensEntrega.Rows[rowIndex].Cells["Id"].Value);

                    var Delete = _context.ReceitaItensEntrega.Find(Id_);

                    if (Delete != null)
                    {
                        _context.ReceitaItensEntrega.Remove(Delete);
                        _context.SaveChangesAsync();

                        EPharmacyContext _contextx;
                        var optionsBuilderx = new DbContextOptionsBuilder<EPharmacyContext>();
                        optionsBuilderx.UseSqlServer(Program.StrConn());
                        _contextx = new EPharmacyContext(optionsBuilderx.Options);
                        var lista = _contextx.ReceitaItensEntrega.AsQueryable();
                        lista = lista.Where(p => p.Id == Convert.ToInt32(Id_));
                        //dGVReceitaItensEntrega.DataSource = lista.ToList();

                        ControlaDisparoDeEvento = true;
                    }
                    else
                    {
                        MessageBox.Show("Item de Receita não encontrado.");
                    }

                }
            //}
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

                //var refil1Cell = row.Cells["Refil1"];

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

                //DateTime refil1 = refil1Cell.Value == null ? DateTime.Now.Date : Convert.ToDateTime(refil1Cell.Value);
                periodicidade = periodicidadeCell.Value.ToString();

                entidadeApoio = new EntidadeApoio();

                //entidadeApoio.Id = Convert.ToInt32(txtId.Text); 
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
                // //-->txtEAN.Text = EAN;
                txtMatricula.Text = matricula;
                txtCPF.Text = CPF;
                // //-->cboMedicamento.SelectedValue = medicamentoId;
                cboPaciente.SelectedValue = pacienteId;
                cboConvenio.SelectedValue = convenioId;
                // //-->cboStatus.SelectedValue = statusId;
                cboBairro.SelectedValue = bairro;
                cboZona.SelectedValue = zona;
                // //-->cboTipoReceita.SelectedValue = tipoReceitaId;

  

                //dTPRefil1.Format = DateTimePickerFormat.Short;
                //dTPRefil1.Value = refil1.Date;
                //dTPRefilExtra.Format = DateTimePickerFormat.Short;


                //if (refilExtra != null)
                //{
                //    dTPRefilExtra.Value = refilExtra.Value;
                //}
                //else
                //{
                //    dTPRefilExtra.Value = dTPRefilExtra.MinDate;
                //    dTPRefilExtra.Format = DateTimePickerFormat.Custom;
                //    dTPRefilExtra.CustomFormat = " ";
                //}

                //DateTime refilExtra = refilExtraCell.Value == null ? DateTime.Now.Date : Convert.ToDateTime(refilExtraCell.Value);

                // Parte de ReceitaItensEntrada
                var ReceitaItensEntregaIdCell = row.Cells["ReceitaItensEntregaId"];
                var NumLoteCell = row.Cells["Lote"];
                var NumNotaFiscalCell = row.Cells["NotaFiscal"];
                var RealCell = row.Cells["Real"];
                var RefilIdCell = row.Cells["RefilId"];
                var DataRefilCell = row.Cells["DataEntrega"];
                var StatusEntregaIdCell = row.Cells["StatusEntregaId"];


                int? receitaItensEntregaId = Convert.ToInt32(ReceitaItensEntregaIdCell.Value);
                string? numLote = NumLoteCell.Value != null ? NumLoteCell.Value.ToString() : null;
                string? numNotaFiscal = NumNotaFiscalCell.Value != null ? NumNotaFiscalCell.Value.ToString() : "";
                int? real = RealCell.Value != null ? Convert.ToInt32(RealCell.Value) : null;
                int? refilId = RefilIdCell.Value != null ? Convert.ToInt32(RefilIdCell.Value) : null;
                DateTime? dataRefil = DataRefilCell.Value != null ? Convert.ToDateTime(DataRefilCell.Value) : null;
                int? statusEntregaId = StatusEntregaIdCell.Value != null ? Convert.ToInt32(StatusEntregaIdCell.Value) : 0;

                txtReceitaItensEntregaId.Text = receitaItensEntregaId.ToString();
                txtLote.Text = numLote;
                txtNotaFiscal.Text = numNotaFiscal;
                txtReal.Text = real.ToString();
                cboRefil.SelectedValue = refilId;
                dTPRefil.Value = dataRefil.Value;
                cboStatusEntrega.SelectedValue = statusEntregaId;


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

                txtLote.Enabled = true;
                txtNotaFiscal.Enabled = true;
                txtReal.Enabled = true;
                cboRefil.Enabled = true;
                dTPRefil.Enabled = true;
                cboStatusEntrega.Enabled = true;
                dgvLista.Enabled = true;

                btnExportar.Enabled = true;
                btnNovo.Enabled = false;
                btnPesquisar.Enabled = true;
                btnSalvar.Enabled = true;
                btnLimpar.Enabled = true;
                btnSair.Enabled = true;
                btnExcluir.Enabled = false;

                // usado pelo novo grid
                var receitaItensIdCell = row.Cells["ReceitaItensId"];
                int? receitaItensId = Convert.ToInt32(receitaItensIdCell.Value);
                txtReceitaItensId.Text = receitaItensId == null ? string.Empty : receitaItensId.ToString();
               
                preenchedGVReceitaItensEntrega();

            }
        }


        private void preenchedGVReceitaItensEntrega()
        {

            int? receitaItensId = UtilitariosBLL.limpaString2(txtReceitaItensId.Text).IsNullOrEmpty() ? null : Convert.ToInt32(UtilitariosBLL.limpaString2(txtReceitaItensId.Text));
            var lista = _context.ReceitaItensEntrega.AsQueryable();
            var ListaStatusEntrega = _context.StatusEntrega.AsQueryable();
            var ListaRefil = _context.Refil.AsQueryable();
            var status = _context.Status.AsQueryable();

            if (receitaItensId != null)
                lista = lista.Where(p => p.ReceitaItensId == receitaItensId);


            var query = from m in lista
                        join mp in ListaStatusEntrega on m.StatusEntregaId equals mp.Id
                        join pr in ListaRefil on m.RefilId equals pr.Id
                        select new
                        {
                            m.Id,
                            ReceitaItens = m.ReceitaItensId,
                            m.NumLote,
                            m.NumNotaFiscal,
                            // StatusEntregaId = mp.Id,
                            StatusEntrega = mp.Id + "-" + mp.Sigla + "-" + mp.Descricao,
                            m.Real,
                            // RefilId = pr.Id,
                            Refil = pr.Id + "-" + pr.Descricao,
                            m.DataRefil,
                        };

            var listax = query.ToList();

            if (listax != null)
            {
               // dGVReceitaItensEntrega.DataSource = listax;

                txtReceitaItensId.Enabled = false;
                txtReceitaItensEntregaId.Enabled = false;
                txtLote.Enabled = true;
                txtNotaFiscal.Enabled = true;
                txtReal.Enabled = true;   
                cboRefil.Enabled = true;
                dTPRefil.Enabled = true;
                cboStatusEntrega.Enabled = true;
                btnAdicionar.Enabled = true;
               // dGVReceitaItensEntrega.Enabled = true;
            }

        }


        private void btnSalvar_Click(object sender, EventArgs e)
        {
            btnAdicionar_Click(null, null);
        }


        //private void dTPRefil1_ValueChanged(object sender, EventArgs e)
        //{
        //    double dblperiodicidade = Convert.ToDouble(periodicidade);
        //    dTPRefil2.Value = dTPRefil1.Value.AddDays(dblperiodicidade);

        //}


        //private void dTPRefilExtra_ValueChanged(object sender, EventArgs e)
        //{
        //    if (dTPRefilExtra.Value.Date != new DateTime(1753, 1, 1))
        //    {
        //        dTPRefilExtra.CustomFormat = "dd/MM/yyyy";
        //    }
        //}


        private void btnExportar_Click(object sender, EventArgs e)
        {

            string Data = DateTime.Now.Year.ToString().PadLeft(4, '0') + DateTime.Now.Month.ToString().PadLeft(2, '0') + DateTime.Now.Day.ToString().PadLeft(2,'0');
            string Tempo = DateTime.Now.Hour.ToString().PadLeft(2, '0') + DateTime.Now.Minute.ToString().PadLeft(2, '0');
            string NomeArquivo = "PDD" + Data + Tempo + ".xlsx";
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


        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            string retorno = "";

            if (UtilitariosBLL.limpaString2(txtReceitaItensId.Text).IsNullOrEmpty())
            {
                retorno += "Preencha o campo Id da Receita Itens\n";
            }

            //if (UtilitariosBLL.limpaString2(txtLote.Text).IsNullOrEmpty())
            //{
            //    retorno += "Preencha o campo Lote\n";
            //}

            //if (UtilitariosBLL.limpaString2(txtNotaFiscal.Text).IsNullOrEmpty())
            //{
            //    retorno += "Preencha o campo Nota Fiscal\n";
            //}

            //if (UtilitariosBLL.limpaString2(txtReal.Text).IsNullOrEmpty())
            //{
            //    retorno += "Preencha o campo Qtdd Real\n";
            //}

            if (cboRefil.SelectedIndex == -1 || cboRefil.SelectedValue.ToString() == "0")
                {
                retorno += "Preencha o campo Refil\n";
            }

            if (cboStatusEntrega.SelectedIndex == -1 || cboStatusEntrega.SelectedValue.ToString() == "0")
                {
                retorno += "Preencha o campo Status Entrega\n";
            }


            if (!retorno.IsNullOrEmpty())
            {
                MessageBox.Show(retorno, "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int receitaItensEntregaId = Convert.ToInt32(txtReceitaItensEntregaId.Text);
            int receitaItensId = Convert.ToInt32(txtReceitaItensId.Text);
            string? numLote = txtLote.Text;
            string? numNotaFiscal = txtNotaFiscal.Text;
            int? real = !txtReal.Text.IsNullOrEmpty() ? Convert.ToInt32(txtReal.Text) : null;
            int? refilId = Convert.ToInt32(cboRefil.SelectedValue);
            int? statusEntregaId = Convert.ToInt32(cboStatusEntrega.SelectedValue);
            DateTime? dataRefil = dTPRefil.Value;

            var entityNew = new ReceitaItensEntrega();
            entityNew.Id = receitaItensEntregaId;
            entityNew = _context.ReceitaItensEntrega.Find(receitaItensEntregaId);

            entityNew.ReceitaItensId = receitaItensId;
            entityNew.NumLote = numLote;
            entityNew.NumNotaFiscal = numNotaFiscal;
            entityNew.RefilId = refilId;
            entityNew.Real = real;
            entityNew.DataRefil = dataRefil;
            entityNew.StatusEntregaId = statusEntregaId;
            entityNew.DataCadastro = DateTime.Now;
            entityNew.Usuario = GlobalVariables.LoginId;

            _context.SaveChanges();

            // dGVReceitaItensEntrega_CellClick();
            txtLote.Clear();
            txtNotaFiscal.Clear();
            cboRefil.SelectedIndex = 0;
            txtReal.Value = 0.00M;
            dTPRefil.Value = DateTime.Now.Date;
            cboStatusEntrega.SelectedIndex = 0;

            //preenchedGVReceitaItensEntrega();
            //string Data = txtMesAno.Text;
            //Limpar();
            //AjustaOutraDataConsolidadaPesquisa(Data);

            /* RECARREGANDO OS FILTROS QUE ESTAVAM ANTES DE ALTERAR. PONDO A RECEITA DE VOLTA NA TELA */
            txtMesAno.Text = entidadeApoio.Data == null || entidadeApoio.Data.ToString().Trim().Length < 5 ? "" : entidadeApoio.Data.Value.Month.ToString().PadLeft(2, '0') + "/" + entidadeApoio.Data.Value.Year.ToString();
            txtEAN.Text = entidadeApoio.EAN;
            txtMatricula.Text = entidadeApoio.Matricula;
            txtCPF.Text = entidadeApoio.CPF;
            cboMedicamento.SelectedValue = entidadeApoio.MedicamentoId == null ? "0" : entidadeApoio.MedicamentoId;
            cboPaciente.SelectedValue = entidadeApoio.PacienteId == null ? "0" : entidadeApoio.PacienteId;
            cboConvenio.SelectedValue = entidadeApoio.ConvenioId == null ? "0" : entidadeApoio.ConvenioId;
            cboStatus.SelectedValue =  entidadeApoio.StatusId == null ? "0" : entidadeApoio.StatusId;
            cboBairro.SelectedValue = entidadeApoio.Bairro == null ? "0" : entidadeApoio.Bairro;
            cboZona.SelectedValue = entidadeApoio.Zona == null ? "0" : entidadeApoio.Zona;
            cboTipoReceita.SelectedValue = entidadeApoio.TipoReceitaId == null ? "0" : entidadeApoio.TipoReceitaId;

            btnPesquisar_Click(null, null);
        }
    

        public void AjustaDataHojeConsolidadaPesquisa()
        {
            string Mes = DateTime.Now.Date.Month.ToString();
            string Ano = DateTime.Now.Date.Year.ToString();
            var Data = Mes.PadLeft(2, '0') + "/" + Ano.PadLeft(4, '0'); ;
            txtMesAno.Text = Data;
        }


        public void AjustaOutraDataConsolidadaPesquisa(string Data)
        {
            txtMesAno.Text = Data;
        }

    }
}
