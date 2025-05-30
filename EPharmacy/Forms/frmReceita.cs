﻿using BLL;
using EPharmacy.Data;
using EPharmacy.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Data;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Status = EPharmacy.Models.Status;

namespace EPharmacy.Forms
{
    public partial class frmReceita : Form
    {
        private readonly EPharmacyContext _context;
        private int Id;
        private bool ControlaDsiparoDeEvento = false;

        public frmReceita()
        {
            InitializeComponent();

            var optionsBuilder = new DbContextOptionsBuilder<EPharmacyContext>();
            optionsBuilder.UseSqlServer(Program.StrConn());
            _context = new EPharmacyContext(optionsBuilder.Options);
        }


        private void frmReceita_Load(object sender, EventArgs e)
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

            //var tipoEntrega = _context.TipoEntrega.OrderBy(p => p.Descricao).ToList();
            //TipoEntrega f = new TipoEntrega();
            //f.Id = 0;
            //f.Descricao = "<Selecione uma opção>";
            //tipoEntrega.Insert(0, f);
            //cboTipoEntrega.DataSource = tipoEntrega.ToList();
            //cboTipoEntrega.DisplayMember = "Descricao";
            //cboTipoEntrega.ValueMember = "Id";

            var periodicidadeRefil = _context.PeriodicidadeRefil.OrderBy(p => p.Descricao).ToList();
            PeriodicidadeRefil p = new PeriodicidadeRefil();
            p.Id = 0;
            p.Descricao = "<Selecione>";
            periodicidadeRefil.Insert(0, p);
            cboPeriodicidadeRefil.DataSource = periodicidadeRefil.ToList();
            cboPeriodicidadeRefil.DisplayMember = "Descricao";
            cboPeriodicidadeRefil.ValueMember = "Id";

            // cboPeriodicidadeRefilAnterior
            var periodicidadeRefilAnterior = _context.PeriodicidadeRefil.OrderBy(p => p.Descricao).ToList();
            PeriodicidadeRefil pan = new PeriodicidadeRefil();
            pan.Id = 0;
            pan.Descricao = "<Selecione>";
            periodicidadeRefilAnterior.Insert(0, pan);
            cboPeriodicidadeRefilAnterior.DataSource = periodicidadeRefilAnterior.ToList();
            cboPeriodicidadeRefilAnterior.DisplayMember = "Descricao";
            cboPeriodicidadeRefilAnterior.ValueMember = "Id";

            //var convenio = _context.Convenio.OrderBy(p => p.Descricao).ToList();
            //Convenio co = new Convenio();
            //co.Id = 0;
            //co.Descricao = "<Selecione uma opção>";
            //convenio.Insert(0, co);
            //cboConvenio.DataSource = convenio.ToList();
            //cboConvenio.DisplayMember = "Descricao";
            //cboConvenio.ValueMember = "Id";

            var clinica = _context.Clinica.OrderBy(p => p.Descricao).ToList();
            Clinica cl = new Clinica();
            cl.Id = 0;
            cl.Descricao = "<Selecione>";
            clinica.Insert(0, cl);
            cboClinica.DataSource = clinica.ToList();
            cboClinica.DisplayMember = "Descricao";
            cboClinica.ValueMember = "Id";

            var medico = _context.Medico.OrderBy(p => p.Nome).ToList();
            Medico me = new Medico();
            me.Id = 0;
            me.Nome = "<Selecione>";
            medico.Insert(0, me);
            cboMedico.DataSource = medico.ToList();
            cboMedico.DisplayMember = "Nome";
            cboMedico.ValueMember = "Id";

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
            md.Produto = "";
            medicamento.Insert(0, md);
            cboMedicamento.DataSource = medicamento.ToList();
            cboMedicamento.DisplayMember = "Produto";
            cboMedicamento.ValueMember = "Id";
            // FIM

            // Adiciona uma coluna de botões ao DataGridView
            DataGridViewButtonColumn btnExcluirColumn = new DataGridViewButtonColumn();
            btnExcluirColumn.Name = "btnExcluirdGVReceitaItens";
            btnExcluirColumn.HeaderText = "Excluir";
            btnExcluirColumn.Text = "<Excluir>";
            btnExcluirColumn.UseColumnTextForButtonValue = true; // Isso faz com que o texto "Excluir" apareça nos botões
            dGVReceitaItens.Columns.Add(btnExcluirColumn);
            // Associando o evento de clique da célula
            dGVReceitaItens.CellContentClick += new DataGridViewCellEventHandler(dGVReceitaItens_CellContentClick);


            // alterar a altura da linhas do grid
            dgvLista.RowTemplate.Height = 17;
            dGVReceitaItens.RowTemplate.Height = 18;

            // fazendo ficar com as colunas autoajuestadas ao tamanho
            dgvLista.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dGVReceitaItens.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            Limpar();
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
            txtDescricao.Clear();

            dTPReceita.Text = "";
            //dTPReceita.Value = DateTime.Now;
            //dTPReceitaOld.Format = DateTimePickerFormat.Custom;
            //dTPReceitaOld.CustomFormat = " ";

            cboPaciente.SelectedIndex = 0;
            txtCPF.Text = "";
            //cboTipoEntrega.SelectedIndex = 0;
            //cboConvenio.SelectedIndex = 0;
            //cboClinica.SelectedIndex = 1;
            // cboMedico.SelectedIndex = 0;
            //dTPDataReceitaAnterior.Value = dTPDataReceitaAnterior.MaxDate;
            dTPDataReceitaAnterior.Format = DateTimePickerFormat.Custom;
            dTPDataReceitaAnterior.CustomFormat = " ";

            cboPeriodicidadeRefil.SelectedIndex = 0;
            dgvLista.DataSource = null;
            dGVReceitaItens.DataSource = null;

            txtId.Enabled = true;
            txtDescricao.Enabled = true;

            dTPReceita.Enabled = true;
            cboPaciente.Enabled = true;
            txtCPF.Enabled = true;
            //cboTipoEntrega.Enabled = false;
            //cboPeriodicidadeRefil.Enabled = true;
            //cboConvenio.Enabled = false;
            //cboClinica.Enabled = false;
            //cboMedico.Enabled = false;
            cboMedicamento.Enabled = true;
            dgvLista.Enabled = false;

            txtReceitaItemId.Enabled = false;
            txtReceitaId.Enabled = false;
            cboMedicamento.Enabled = false;
            dTPDataReceitaAnterior.Enabled = false;
            cboPeriodicidadeRefil.Enabled = false;
            cboStatus.Enabled = false;
            txtObs.Enabled = false;
            txtQtdd.Enabled = false;

            dGVReceitaItens.Enabled = false;

            btnNovo.Enabled = true;
            btnPesquisar.Enabled = true;
            btnSalvar.Enabled = false;
            btnLimpar.Enabled = true;
            btnSair.Enabled = true;
            btnExcluir.Enabled = false;

            btnAdicionar.Enabled = false;
        }


        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
                "Você tem certeza que deseja Excluir a Receita Selecionada?",
                "Confirmação",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (resultado != DialogResult.Yes)
            {
                return;
            }

            try
            {
                int Id_ = Convert.ToInt32(txtId.Text);
                var Delete = _context.Receita.Find(Id_);

                if (Delete != null)
                {
                    var receitaItens = _context.ReceitaItens.FirstOrDefault(b => b.ReceitaId == Id_);

                    if (receitaItens != null)
                    {
                        MessageBox.Show("Receita não pode ser excluído. Tem dados relacionados entre Receita com Receita Itens!");
                        return;
                    }

                    _context.Receita.Remove(Delete);
                    _context.SaveChangesAsync();
                    MessageBox.Show("Receita excluída com sucesso!");

                    Limpar();
                    btnPesquisar_Click(null, null);
                }
                else
                {
                    MessageBox.Show("Receita não encontrada.");
                }
            }
            catch
            {
                MessageBox.Show("Receita não ser excluída. Verifique se há Receita Item que precisa ser excluir primeiro.");
            }
        }


        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string retorno = "";
            /*if (txtDescricao.Text.IsNullOrEmpty())
            {
                retorno += "Preencha o campo Nome \n";
            }*/
            if (cboPaciente.SelectedIndex == -1 || cboPaciente.SelectedValue.ToString() == "0")
            {
                retorno += "Selecione o campo Paciente\n";
            }
            //if (dTPReceitaOld.Value == null)
            //{
            //    retorno += "Selecione o campo Data da Receita\n";
            //}

            if (UtilitariosBLL.limpaString2(dTPReceita.Text.Trim()).IsNullOrEmpty())
            {
                retorno += "Digite a Data da Receita\n";
            }
            else
            {
                if (UtilitariosBLL.ConverterParaData(dTPReceita.Text).Value.Year < 2000)
                {
                    retorno += "Digite a Data da Receita a partir de 2000\n";
                }
            }

            //if (cboTipoEntrega.SelectedIndex == -1 || cboTipoEntrega.SelectedValue.ToString() == "0")
            //{
            //    retorno += "Selecione o campo Tipo Entrega\n";
            //}

            //if (cboConvenio.SelectedIndex == -1 || cboConvenio.SelectedValue.ToString() == "0")
            //{
            //    retorno += "Selecione o campo Convênio\n";
            //}
            //if (cboClinica.SelectedIndex == -1 || cboClinica.SelectedValue.ToString() == "0")
            //{
            //    retorno += "Selecione o campo Clínica\n";
            //    //cboClinica.SelectedValue = "1";
            //}
            //if (cboMedico.SelectedIndex == -1 || cboMedico.SelectedValue.ToString() == "0")
            //{
            //    retorno += "Selecione o campo Médico\n";
            //}

            if (!retorno.IsNullOrEmpty())
            {
                MessageBox.Show(retorno, "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult resultado = MessageBox.Show(
                "Você tem certeza que deseja Salvar?",
                "Confirmação",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (resultado != DialogResult.Yes)
            {
                return;
            }

            string Descricao_ = txtDescricao.Text;
            //DateTime DataUltimaReceita_ = dTPDataReceitaAnterior.Value.Date;
            //DateTime DataReceita_ = dTPReceitaOld.Value.Date;
            DateTime? DataReceita_ = UtilitariosBLL.ConverterParaData(dTPReceita.Text);
            int PacienteId_ = Convert.ToInt32(cboPaciente.SelectedValue);
            //int TipoEntregaId_ = Convert.ToInt32(cboTipoEntrega.SelectedValue);
            //int ConvenioId_ = Convert.ToInt32(cboConvenio.SelectedValue);
            //int ClinicaId_ = Convert.ToInt32(cboClinica.SelectedValue);
            //int MedicoId_ = Convert.ToInt32(cboMedico.SelectedValue);

            var entityNew = new Receita();
            var entityUpdate = new Receita();

            if (txtId.Text.IsNullOrEmpty())
            {
                entityNew = new Receita
                {
                    Descricao = Descricao_,
                    //DataReceitaAnterior = DataUltimaReceita_,
                    DataReceita = DataReceita_.Value,
                    PacienteId = PacienteId_,
                    //TipoEntregaId = TipoEntregaId_,
                    //ConvenioId = ConvenioId_,
                    //ClinicaId = ClinicaId_,
                    //MedicoId = MedicoId_,
                    DataCadastro = DateTime.Now,
                    Usuario = GlobalVariables.LoginId,
                };
                _context.Receita.Add(entityNew);
                _context.SaveChanges();
                Id = entityNew.Id;
                txtId.Text = Id.ToString();
                Limpar();
                txtId.Text = Id.ToString();
                btnPesquisar_Click(null, null);
                txtId.Clear();
            }
            else
            {
                int Id_ = Convert.ToInt32(txtId.Text);
                entityUpdate = _context.Receita.Find(Id_);
                entityUpdate.Descricao = Descricao_;
                //entityUpdate.DataReceitaAnterior = DataUltimaReceita_;
                entityUpdate.DataReceita = DataReceita_.Value;
                entityUpdate.PacienteId = PacienteId_;
                //entityUpdate.TipoEntregaId = TipoEntregaId_;
                //entityUpdate.ConvenioId = ConvenioId_;
                //entityUpdate.ClinicaId = ClinicaId_;
                //entityUpdate.MedicoId = MedicoId_;
                entityUpdate.DataCadastro = DateTime.Now;
                entityUpdate.Usuario = GlobalVariables.LoginId;


                //if (cboPeriodicidadeRefil.SelectedIndex == -1 || cboPeriodicidadeRefil.SelectedValue.ToString() == "0")
                //{
                //    retorno += "Selecione o campo Periodicidade Refil\n";
                //}

                //int PeriodicidadeRefilId_ = Convert.ToInt32(cboPeriodicidadeRefil.SelectedValue);
                //entityUpdate.PeriodicidadeRefilId = PeriodicidadeRefilId_;

                _context.SaveChanges();
                Limpar();
                txtId.Text = Id_.ToString();
                btnPesquisar_Click(null, null);
                txtId.Clear();
            }

            MessageBox.Show(
                "Receita Gravado com sucesso",
                "",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation
            );
        }


        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            int? Id_ = txtId.Text.IsNullOrEmpty() ? null : Convert.ToInt32(txtId.Text);
            string Descriaco_ = txtDescricao.Text;
            //DateTime dataReceita_ = dTPReceitaOld.Value.Date;
            DateTime? dataReceita_ = UtilitariosBLL.ConverterParaData(dTPReceita.Text);
            int? pacienteId_ = cboPaciente.SelectedIndex > 0 ? Convert.ToInt32(cboPaciente.SelectedValue) : null;
            string cpf_ = UtilitariosBLL.limpaString2(txtCPF.Text);

            var lista = _context.Receita.AsQueryable();
            var listaPaciente = _context.Paciente.AsQueryable();

            if (Id_ != null)
                lista = lista.Where(p => p.Id == Id_);

            if (!string.IsNullOrEmpty(Descriaco_))
                lista = lista.Where(p => p.Descricao.Contains(Descriaco_));

            // if (dTPReceitaOld.Value.Date < DateTime.Now.Date)
            if (dataReceita_ < DateTime.Now.Date)
                lista = lista.Where(p => p.DataReceita.Date == dataReceita_);

            if (pacienteId_ > 0)
                lista = lista.Where(p => p.PacienteId == pacienteId_);

            if (!string.IsNullOrEmpty(cpf_))
            {
                lista = from d in lista
                        join p in _context.Paciente on d.PacienteId equals p.Id
                        where p.CPF.Contains(cpf_)
                        select d;
            }

            var listaCompleta = from r in lista
                                join p in _context.Paciente on r.PacienteId equals p.Id into pacienteJoin
                                from p in pacienteJoin.DefaultIfEmpty()
                                    //join m in _context.Medico on r.MedicoId equals m.Id into medicoJoin
                                    //from m in medicoJoin.DefaultIfEmpty()
                                    //join c in _context.Clinica on r.ClinicaId equals c.Id into clinicaJoin
                                    //from c in clinicaJoin.DefaultIfEmpty()
                                select new
                                {

                                    Id = r.Id,
                                    Descricao = r.Descricao,
                                    DataReceita = r.DataReceita,
                                    PacienteId = p.Id,
                                    CPF = p.CPF,
                                    Paciente = p.Nome,
                                    //MedicoId = m.Id,
                                    //Medico = m.Nome,
                                    //clinicaId = c.Id,
                                    //Clinica = c.Descricao
                                };

            var listax = listaCompleta.ToList();
            //var listax = lista.ToList();

            if (listax != null)
            {
                dgvLista.DataSource = listax;
                dgvLista.Enabled = true;

                dGVReceitaItens.DataSource = null;

                dgvLista.Columns["Id"].HeaderText = "Id Receita";
                dgvLista.Columns["PacienteId"].HeaderText = "Id Paciente";  // Alterar o título da coluna "PacienteId"
                //dgvLista.Columns["ClinicaId"].HeaderText = "Id Clinica";
                //dgvLista.Columns["MedicoId"].HeaderText = "Id Medico";
                dgvLista.Columns["DataReceita"].HeaderText = "Dt Receita";


                dgvLista.Columns["Id"].Visible = chkMostrarIds.Checked;
                dgvLista.Columns["PacienteId"].Visible = chkMostrarIds.Checked;
                //dgvLista.Columns["ClinicaId"].Visible = chkMostrarIds.Checked;
                //dgvLista.Columns["MedicoId"].Visible = chkMostrarIds.Checked;
            }
        }


        private void btnNovo_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
                "Você tem certeza que deseja Criar um Novo?",
                "Confirmação",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (resultado != DialogResult.Yes)
            {
                return;
            }

            txtId.Clear();
            txtDescricao.Clear();
            //dTPDataReceitaAnterior.Value = DateTime.Now;
            //dTPReceitaOld.Value = DateTime.Now;
            dTPReceita.Text = "";
            cboPaciente.SelectedIndex = 0;
            txtCPF.Text = "";
            //cboTipoEntrega.SelectedIndex = 0;
            cboPeriodicidadeRefil.SelectedIndex = 0;
            //cboConvenio.SelectedIndex = 0;
            //cboClinica.SelectedIndex = 1;
            //cboMedico.SelectedIndex = 0;
            dgvLista.DataSource = null;
            dGVReceitaItens.DataSource = null;

            txtId.Enabled = false;
            txtDescricao.Enabled = true;
            cboPaciente.Enabled = true;
            txtCPF.Enabled = false;
            //cboTipoEntrega.Enabled = true;
            //cboConvenio.Enabled = true;
            //cboClinica.Enabled = true;
            //cboMedico.Enabled = true;

            txtReceitaItemId.Enabled = false;
            dTPDataReceitaAnterior.Enabled = false;
            cboPeriodicidadeRefil.Enabled = false;
            cboMedicamento.Enabled = false;
            cboStatus.Enabled = false;
            txtObs.Enabled = false;
            txtQtdd.Enabled = false;

            dgvLista.Enabled = false;

            btnNovo.Enabled = false;
            btnPesquisar.Enabled = false;
            btnSalvar.Enabled = true;
            btnLimpar.Enabled = true;
            btnSair.Enabled = true;
            btnExcluir.Enabled = false;
            btnAdicionar.Enabled = false;

            dGVReceitaItens.Enabled = false;
        }


        private void dgvLista_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvLista.Rows[e.RowIndex];

                var idCell = row.Cells["Id"];
                var descricaoCell = row.Cells["Descricao"];
                var dataReceitaCell = row.Cells["DataReceita"];
                //var dataUltimaReceitaCell = row.Cells["DataReceitaAnterior"];
                var pacienteCell = row.Cells["PacienteId"];
                //var tipoEntregaCell = row.Cells["tipoEntregaId"];

                //var convenioCell = row.Cells["ConvenioId"];
                //var clinicaCell = row.Cells["ClinicaId"];
                //var medicoCell = row.Cells["medicoId"];

                if (idCell.Value != null && descricaoCell.Value != null)
                {
                    int id = Convert.ToInt32(idCell.Value);
                    string descricao = descricaoCell.Value.ToString();
                    //DateTime dataReceita = dataReceitaCell.Value == null ? DateTime.Now.Date : Convert.ToDateTime(dataReceitaCell.Value);
                    //DateTime? dataReceita = dataReceitaCell.Value == null ? null : Convert.ToDateTime(dataReceitaCell.Value);
                    DateTime? dataReceita = UtilitariosBLL.ConverterParaData(dataReceitaCell.Value.ToString());

                    //DateTime dataUltimaReceita = dataUltimaReceitaCell.Value == null ? DateTime.Now.Date : Convert.ToDateTime(dataUltimaReceitaCell.Value);
                    int? paciente = Convert.ToInt32(pacienteCell.Value);
                    //int? tipoEntrega = Convert.ToInt32(tipoEntregaCell.Value);
                    //int? convenio = Convert.ToInt32(convenioCell.Value);
                    //int? clinica = Convert.ToInt32(clinicaCell.Value);
                    //int? medico = Convert.ToInt32(medicoCell.Value);


                    dTPReceita.Text = dataReceita.ToString();
                    //dTPReceitaOld.Format = DateTimePickerFormat.Custom;
                    //dTPReceitaOld.CustomFormat = " ";
                    //if (dataReceita != null)
                    //{
                    //    dTPReceitaOld.Value = dataReceita.Value;
                    //}
                    //else
                    //{
                    //    dTPReceitaOld.Value = dTPReceitaOld.MinDate;
                    //    dTPReceitaOld.Format = DateTimePickerFormat.Custom;
                    //    dTPReceitaOld.CustomFormat = " ";
                    //}


                    txtId.Text = id.ToString();
                    txtDescricao.Text = descricao;
                    //dTPReceita.Value = dataReceita.Date;
                    //dTPDataReceitaAnterior.Value = dataUltimaReceita.Date;
                    cboPaciente.SelectedValue = paciente;
                    //cboTipoEntrega.SelectedValue = tipoEntrega;
                    //cboConvenio.SelectedValue = convenio;
                    //cboClinica.SelectedValue = clinica;
                    //cboMedico.SelectedValue = medico;

                    txtId.Enabled = false;
                    txtDescricao.Enabled = true;
                    dTPReceita.Enabled = true;
                    //dTPDataReceitaAnterior.Enabled = true;
                    cboPaciente.Enabled = true;
                    //cboTipoEntrega.Enabled = true;
                    //cboConvenio.Enabled = true;
                    //cboClinica.Enabled = true;
                    //cboMedico.Enabled = true;
                    dgvLista.Enabled = true;

                    btnNovo.Enabled = true;
                    btnPesquisar.Enabled = true;
                    btnSalvar.Enabled = true;
                    btnLimpar.Enabled = true;
                    btnSair.Enabled = true;
                    btnExcluir.Enabled = true;

                    dgvLista_CellClick_Para_dgvReceitaItens();
                }
            }
        }


        private void dgvLista_CellClick_Para_dgvReceitaItens()
        {
            int? Id_ = txtId.Text.IsNullOrEmpty() ? null : Convert.ToInt32(txtId.Text);
            txtReceitaId.Text = Id_.ToString();
            string Descriaco_ = txtDescricao.Text;
            //DateTime dataReceita_ = dTPReceitaOld.Value.Date;
            DateTime? dataReceita_ = UtilitariosBLL.ConverterParaData(dTPReceita.Text);

            var lista = _context.ReceitaItens.AsQueryable();
            var medicamento = _context.Medicamento.AsQueryable();
            var periodicidade = _context.PeriodicidadeRefil.AsQueryable();
            var status = _context.Status.AsQueryable();

            if (Id_ != null)
                lista = lista.Where(p => p.ReceitaId == Id_);


            var query = from m in lista
                        join mp in medicamento on m.MedicamentoId equals mp.Id
                        join pr in periodicidade on m.PeriodicidadeRefilId equals pr.Id
                        join st in status on m.StatusId equals st.Id
                        select new
                        {
                            m.Id,
                            ReceitaId = m.ReceitaId,
                            MedicamentoId = mp.Id,
                            mp.Produto,
                            mp.EAN,
                            m.DataReceitaAnterior,
                            PeriodicidadeId = pr.Id,
                            Periodicidade = pr.Descricao,
                            Status = st.Descricao,
                            m.Qtdd,
                            m.Obs
                        };

            // Executa a consulta e converte em lista
            var listax = query.ToList();

            //var listax = lista.ToList();

            if (listax != null)
            {
                dGVReceitaItens.DataSource = listax;

                dGVReceitaItens.Columns["Id"].HeaderText = "Id Rec. Itens";
                dGVReceitaItens.Columns["ReceitaId"].HeaderText = "Id Receita";  // Alterar o título da coluna "PacienteId"
                dGVReceitaItens.Columns["MedicamentoId"].HeaderText = "Id Medicam.";
                dGVReceitaItens.Columns["PeriodicidadeId"].HeaderText = "Id Periodic.";
                dGVReceitaItens.Columns["DataReceitaAnterior"].HeaderText = "Dt Rec. Anterior";


                dGVReceitaItens.Columns["Id"].Visible = chkMostrarIds.Checked;
                dGVReceitaItens.Columns["ReceitaId"].Visible = chkMostrarIds.Checked;
                dGVReceitaItens.Columns["MedicamentoId"].Visible = chkMostrarIds.Checked;
                dGVReceitaItens.Columns["PeriodicidadeId"].Visible = chkMostrarIds.Checked;

                txtReceitaItemId.Enabled = false;
                txtReceitaId.Enabled = false;
                cboMedicamento.Enabled = true;
                dTPDataReceitaAnterior.Enabled = false;
                cboPeriodicidadeRefil.Enabled = true;
                cboStatus.Enabled = true;
                txtObs.Enabled = true;
                txtQtdd.Enabled = true;
                btnAdicionar.Enabled = true;
                dGVReceitaItens.Enabled = true;

                // ja coloca o status como Ativo
                cboStatus.SelectedIndex = 1;
            }
        }


        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            string retorno = "";
            if (txtReceitaId.Text.IsNullOrEmpty())
            {
                retorno += "Preencha o campo Id da Receita\n";
            }
            if (cboMedicamento.SelectedIndex == -1 || cboMedicamento.SelectedValue.ToString() == "0")
            {
                retorno += "Selecione o campo Medicamento\n";
            }

            //sob subspeita de não obrigatoriedade
            //if (dTPDataReceitaAnterior.Value == DateTime.Now.Date)
            //{
            //    retorno += "Selecione o campo Data Receita Anterior\n";
            //}

            if (cboPeriodicidadeRefil.SelectedIndex == -1 || cboPeriodicidadeRefil.SelectedValue.ToString() == "0")
            {
                retorno += "Selecione o campo Periodicidade do Refil\n";
            }
            if (cboStatus.SelectedIndex == -1 || cboStatus.SelectedValue.ToString() == "0")
            {
                retorno += "Selecione o campo Status\n";
            }

            if (UtilitariosBLL.limpaString2(txtQtdd.Text).IsNullOrEmpty())
            {
                retorno += "Preencha o campo Qtdd \n";
            }

            if (!retorno.IsNullOrEmpty())
            {
                MessageBox.Show(retorno, "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string receitaId_ = txtReceitaId.Text;
            int medicamentoId_ = Convert.ToInt32(cboMedicamento.SelectedValue);
            DateTime? dataReceitaAnterior_ = dTPDataReceitaAnterior.Value.Date == dTPDataReceitaAnterior.MaxDate ? null : dTPDataReceitaAnterior.Value;
            int periodicidadeRefilId_ = Convert.ToInt32(cboPeriodicidadeRefil.SelectedValue);
            int statusId_ = Convert.ToInt32(cboStatus.SelectedValue);
            string? obs_ = txtObs.Text;
            int? qtdd_ = txtQtdd.Text.IsNullOrEmpty() ? null : Convert.ToInt32(txtQtdd.Text);

            var entityNew = new ReceitaItens();
            var entityUpdate = new ReceitaItens();

            entityNew = new ReceitaItens
            {
                ReceitaId = Convert.ToInt32(receitaId_),
                MedicamentoId = medicamentoId_,
                DataReceitaAnterior = dataReceitaAnterior_,
                PeriodicidadeRefilId = periodicidadeRefilId_,
                StatusId = statusId_,
                Obs = obs_,
                Qtdd = qtdd_,
                DataCadastro = DateTime.Now,
                Usuario = GlobalVariables.LoginId,
            };
            _context.ReceitaItens.Add(entityNew);
            _context.SaveChanges();

            dgvLista_CellClick_Para_dgvReceitaItens();
            //txtReceitaItemId.Clear();
            //txtReceitaId.Clear();
            cboMedicamento.SelectedIndex = 0;
            cboPeriodicidadeRefil.SelectedIndex = 0;
            cboStatus.SelectedIndex = 1;
            txtObs.Clear();
            txtQtdd.Clear();


        }


        private void dGVReceitaItens_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (ControlaDsiparoDeEvento == true)
            {
                ControlaDsiparoDeEvento = false;
                return;
            }

            // Verifique se a célula clicada está na coluna de botões
            if (e.ColumnIndex == dGVReceitaItens.Columns["btnExcluirdGVReceitaItens"].Index)
            {
                // Confirmar exclusão
                var result = MessageBox.Show("Tem certeza de que deseja excluir esta linha?", "Confirmar Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Remove a linha clicada
                    //dGVReceitaItens.Rows.RemoveAt(e.RowIndex);
                    // Acessando a linha clicada
                    int rowIndex = e.RowIndex;

                    // Acessando os valores das células na linha clicada
                    var Id_ = dGVReceitaItens.Rows[rowIndex].Cells["Id"].Value;

                    //MessageBox.Show($"Id: {Id}");

                    /* ----------------------------------- */
                    var Delete = _context.ReceitaItens.Find(Id_);

                    if (Delete != null)
                    {
                        _context.ReceitaItens.Remove(Delete);
                        _context.SaveChangesAsync();

                        EPharmacyContext _contextx;
                        var optionsBuilderx = new DbContextOptionsBuilder<EPharmacyContext>();
                        optionsBuilderx.UseSqlServer(Program.StrConn());
                        _contextx = new EPharmacyContext(optionsBuilderx.Options);
                        var lista = _contextx.ReceitaItens.AsQueryable();
                        lista = lista.Where(p => p.Id == Convert.ToInt32(Id_));
                        dGVReceitaItens.DataSource = lista.ToList();

                        // coloquei esse controle pq estava disparando o evendo do grid ao executar isso dGVReceitaItens.DataSource
                        ControlaDsiparoDeEvento = true;
                    }
                    else
                    {
                        MessageBox.Show("Item de Receita não encontrado.");
                    }

                    /* ------------------------------------ */

                }
            }
        }


        private void cboMedicamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            int? pacienteId_ = cboPaciente.SelectedIndex > 0 ? Convert.ToInt32(cboPaciente.SelectedValue) : null;
            int? receitaIdAtual = txtReceitaId.Text.IsNullOrEmpty() ? null : Convert.ToInt32(txtReceitaId.Text);

            var lista = _context.Receita.AsQueryable();
            var listaR = _context.ReceitaItens.AsQueryable();

            if (pacienteId_ > 0) lista = lista.OrderByDescending(p => p.DataReceita).Where(p => p.PacienteId == pacienteId_);

            if (pacienteId_ > 0)
            {

                lista = (IQueryable<Receita>)(from r in lista
                                              join ri in _context.ReceitaItens on r.Id equals ri.ReceitaId
                                              join me in _context.Medicamento on ri.MedicamentoId equals me.Id
                                              where r.PacienteId == pacienteId_ &&
                                                    ri.MedicamentoId == Convert.ToInt32(cboMedicamento.SelectedValue) &&
                                                    ri.ReceitaId != receitaIdAtual
                                              select r);
                var listax = lista.OrderByDescending(p => p.Id).FirstOrDefault();


                listaR = (IQueryable<ReceitaItens>)(from r in lista
                                                    join ri in _context.ReceitaItens on r.Id equals ri.ReceitaId
                                                    join me in _context.Medicamento on ri.MedicamentoId equals me.Id
                                                    where r.PacienteId == pacienteId_ &&
                                                          ri.MedicamentoId == Convert.ToInt32(cboMedicamento.SelectedValue) &&
                                                          ri.ReceitaId != receitaIdAtual
                                                    select ri);
                var listaRx = listaR.OrderByDescending(p => p.Id).FirstOrDefault();

                if (listax != null)
                {
                    DateTime dataReceita = listax.DataReceita;
                    dTPDataReceitaAnterior.Value = dataReceita;
                    dTPDataReceitaAnterior.Format = DateTimePickerFormat.Short;
                    txtQtddAnterior.Text = listaRx.Qtdd.ToString();
                    var PeriodicidadeRefilIdLocal = listaRx.PeriodicidadeRefilId;
                    cboPeriodicidadeRefilAnterior.SelectedValue = PeriodicidadeRefilIdLocal;
                }
                else
                {
                    dTPDataReceitaAnterior.Value = dTPDataReceitaAnterior.MaxDate;
                    dTPDataReceitaAnterior.Format = DateTimePickerFormat.Custom;
                    dTPDataReceitaAnterior.CustomFormat = " ";
                    cboPeriodicidadeRefilAnterior.SelectedIndex = -1;

                    txtQtddAnterior.Text = "";
                }
            }
        }


        private void cboMedicamento_SelectedIndexChangedOLD(object sender, EventArgs e)
        {
            int? pacienteId_ = cboPaciente.SelectedIndex > 0 ? Convert.ToInt32(cboPaciente.SelectedValue) : null;
            int? receitaIdAtual = txtReceitaId.Text.IsNullOrEmpty() ? null : Convert.ToInt32(txtReceitaId.Text);

            var lista = _context.Receita.AsQueryable();

            if (pacienteId_ > 0) lista = lista.OrderByDescending(p => p.DataReceita).Where(p => p.PacienteId == pacienteId_);

            if (pacienteId_ > 0)
            {
                lista = from r in lista
                        join ri in _context.ReceitaItens on r.Id equals ri.ReceitaId
                        join me in _context.Medicamento on ri.MedicamentoId equals me.Id
                        where r.PacienteId == pacienteId_ &&
                        ri.MedicamentoId == Convert.ToInt32(cboMedicamento.SelectedValue) &&
                        ri.ReceitaId != receitaIdAtual
                        select r;


                var listax = lista.OrderByDescending(p => p.Id).FirstOrDefault();

                if (listax != null)
                {
                    DateTime dataReceta = listax.DataReceita;
                    dTPDataReceitaAnterior.Value = dataReceta;
                    dTPDataReceitaAnterior.Format = DateTimePickerFormat.Short;

                    // txtQtddAnterior.Text =  <<< AQUI COMO PEGO O CAMPO QTDD QUE ESTÁ EM ReceitaItens >>>
                }
                else
                {
                    dTPDataReceitaAnterior.Value = dTPDataReceitaAnterior.MaxDate;
                    dTPDataReceitaAnterior.Format = DateTimePickerFormat.Custom;
                    dTPDataReceitaAnterior.CustomFormat = " ";
                }
            }
        }


        private void chkAumentaLarguraColunasGrid_CheckedChanged_1(object sender, EventArgs e)
        {
            // fazendo ficar com as colunas autoajuestadas ao tamanho
            if (chkAumentaLarguraColunasGrid.Checked)
            {
                dgvLista.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dGVReceitaItens.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
            else
            {
                dgvLista.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
                dGVReceitaItens.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            }
        }


        private void dTPReceita_Leave(object sender, EventArgs e)
        {
            if (UtilitariosBLL.limpaString2(dTPReceita.Text.Trim()).IsNullOrEmpty()) return;

            string userInput = dTPReceita.Text;
            if (DateTime.TryParse(userInput, out DateTime parsedDate))
            { }
            else
            {
                dTPReceita.Text = "";
                MessageBox.Show("Digite uma Data da Receita válida.", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void cboPaciente_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtCPF.Clear();
            if (cboPaciente.SelectedItem != null)
            {
                var pacienteSelecionado = (Paciente)cboPaciente.SelectedItem;
                txtCPF.Text = pacienteSelecionado.CPF;

                dTPReceita.Clear();
                txtId.Clear();

                if (cboPaciente.SelectedIndex <= 0) return;

                int xpacienteId_ = Convert.ToInt32(cboPaciente.SelectedValue);

                var lista = _context.Medicamento.AsQueryable();

                if (xpacienteId_ > 0)
                {
                    lista = from me in lista
                            join ri in _context.ReceitaItens on me.Id equals ri.MedicamentoId
                            join r in _context.Receita on ri.ReceitaId equals r.Id

                            where r.PacienteId == xpacienteId_
                            select me;

                    var listax = lista.Distinct().ToList();

                    dGVMedicamentosReceitasPac.DataSource = listax;

                    dGVMedicamentosReceitasPac.ColumnHeadersHeight = 8; // altura do cabeçalho das colunas
                    dGVMedicamentosReceitasPac.RowHeadersWidth = 8; ;

                    dGVMedicamentosReceitasPac.Columns["Produto"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                    dGVMedicamentosReceitasPac.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                    dGVMedicamentosReceitasPac.Columns["EAN"].DefaultCellStyle.Font = new Font("Segoe UI", 7);
                    dGVMedicamentosReceitasPac.Columns["Produto"].DefaultCellStyle.Font = new Font("Segoe UI", 7);

                    dGVMedicamentosReceitasPac.Columns["Produto"].Width = 195;
                    dGVMedicamentosReceitasPac.Columns["EAN"].Width = 75;

                    dGVMedicamentosReceitasPac.Columns["Id"].HeaderText = "Id Medicamento";
                    dGVMedicamentosReceitasPac.Columns["Produto"].HeaderText = "Produto";
                    dGVMedicamentosReceitasPac.Columns["EAN"].HeaderText = "EAN";

                    dGVMedicamentosReceitasPac.Columns["Id"].Visible = false;
                    dGVMedicamentosReceitasPac.Columns["ClasseTerapeuticaId"].Visible = false;
                    dGVMedicamentosReceitasPac.Columns["TipoReceitaId"].Visible = false;
                    dGVMedicamentosReceitasPac.Columns["FabricanteId"].Visible = false;
                    dGVMedicamentosReceitasPac.Columns["SubstanciaId"].Visible = false;
                    dGVMedicamentosReceitasPac.Columns["TUSS"].Visible = false;
                    dGVMedicamentosReceitasPac.Columns["NcmId"].Visible = false;
                    dGVMedicamentosReceitasPac.Columns["ListaId"].Visible = false;
                    dGVMedicamentosReceitasPac.Columns["RegimeId"].Visible = false;
                    dGVMedicamentosReceitasPac.Columns["Ativo"].Visible = false;
                    dGVMedicamentosReceitasPac.Columns["DataCadastro"].Visible = false;
                    dGVMedicamentosReceitasPac.Columns["Usuario"].Visible = false;

                    btnPesquisar_Click(null, null);
                }

            }
        }


        private void dGVMedicamentosReceitasPac_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dGVMedicamentosReceitasPac.Rows[e.RowIndex];

                var ProdutoCell = row.Cells["Produto"];

                if (ProdutoCell.Value != null)
                {
                    string Produto = ProdutoCell.Value.ToString();
                    cboMedicamento.SelectedText = "";
                    cboMedicamento.Text = Produto;

                    //cboMedicamento.SelectedText= Produto;
                }
            }
        }



        private void btnAtualizaListaMedicamentos_Click(object sender, EventArgs e)
        {
            cboPaciente_SelectedIndexChanged(null, null);
        }



        // Tornar o texto colado como a opção selecionada na combo
        private void cboSelecaoPadrao_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            System.Windows.Forms.ComboBox comboBox = sender as System.Windows.Forms.ComboBox;
            if (comboBox == null) return;

            string enteredText = comboBox.Text;

            // Se o texto não estiver vazio
            if (!string.IsNullOrEmpty(enteredText))
            {
                // Tenta encontrar o item que corresponde exatamente ao texto digitado/colado
                int index = comboBox.FindStringExact(enteredText);

                if (index != -1) // Se encontrou uma correspondência exata
                {
                    comboBox.SelectedIndex = index; // Seleciona o item encontrado
                }
                else
                {
                    // Opcional: Se não encontrou correspondência exata, você pode:
                    // 1. Limpar o texto:
                    // comboBox.Text = "";
                    // 2. Avisar o usuário:
                    // MessageBox.Show("Opção inválida. Por favor, selecione uma opção da lista.");
                    // e.Cancel = true; // Impede que o foco saia do ComboBox
                    // 3. Tentar uma busca parcial (FindString)
                    // int partialIndex = comboBox.FindString(enteredText);
                    // if (partialIndex != -1) { comboBox.SelectedIndex = partialIndex; }
                }
            }
            else // Se o texto estiver vazio, pode querer desselecionar ou manter o estado
            {
                // Opcional: Se o campo ficou vazio, desseleciona
                // comboBox.SelectedIndex = -1;
            }
        }

    }

}


