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
    public partial class frmReceita : Form
    {
        private readonly EPharmacyContext _context;
        private int Id;


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
            c.Nome = "<Selecione uma opção>";
            paciente.Insert(0, c);
            cboPaciente.DataSource = paciente.ToList();
            cboPaciente.DisplayMember = "Nome";
            cboPaciente.ValueMember = "Id";

            var tipoEntrega = _context.TipoEntrega.OrderBy(p => p.Descricao).ToList();
            TipoEntrega f = new TipoEntrega();
            f.Id = 0;
            f.Descricao = "<Selecione uma opção>";
            tipoEntrega.Insert(0, f);
            cboTipoEntrega.DataSource = tipoEntrega.ToList();
            cboTipoEntrega.DisplayMember = "Descricao";
            cboTipoEntrega.ValueMember = "Id";

            var periodicidadeRefil = _context.PeriodicidadeRefil.OrderBy(p => p.Descricao).ToList();
            PeriodicidadeRefil p = new PeriodicidadeRefil();
            p.Id = 0;
            p.Descricao = "<Selecione uma opção>";
            periodicidadeRefil.Insert(0, p);
            cboPeriodicidadeRefil.DataSource = periodicidadeRefil.ToList();
            cboPeriodicidadeRefil.DisplayMember = "Descricao";
            cboPeriodicidadeRefil.ValueMember = "Id";

            var convenio = _context.Convenio.OrderBy(p => p.Descricao).ToList();
            Convenio co = new Convenio();
            co.Id = 0;
            co.Descricao = "<Selecione uma opção>";
            convenio.Insert(0, co);
            cboConvenio.DataSource = convenio.ToList();
            cboConvenio.DisplayMember = "Descricao";
            cboConvenio.ValueMember = "Id";

            var clinica = _context.Clinica.OrderBy(p => p.Descricao).ToList();
            Clinica cl = new Clinica();
            cl.Id = 0;
            cl.Descricao = "<Selecione uma opção>";
            clinica.Insert(0, cl);
            cboClinica.DataSource = clinica.ToList();
            cboClinica.DisplayMember = "Descricao";
            cboClinica.ValueMember = "Id";

            //var medico = _context.Medico.OrderBy(p => p.Nome).ToList();
            //Medico me = new Medico();
            //me.Id = 0;
            //me.Nome = "<Selecione uma opção>";
            //medico.Insert(0, me);
            //cboMedico.DataSource = medico.ToList();
            //cboMedico.DisplayMember = "Nome";
            //cboMedico.ValueMember = "Id";

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
            // FIM
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
            dTPUltimaReceita.Value = DateTime.Now;
            cboPaciente.SelectedIndex = 0;
            cboTipoEntrega.SelectedIndex = 0;
            cboConvenio.SelectedIndex = 0;
            cboClinica.SelectedIndex = 0;
            // cboMedico.SelectedIndex = 0;
            cboPeriodicidadeRefil.SelectedIndex = 0;
            dgvLista.DataSource = null;

            txtId.Enabled = true;
            txtDescricao.Enabled = true;
            dTPUltimaReceita.Enabled = true;
            cboPaciente.Enabled = true;
            cboTipoEntrega.Enabled = true;
            cboPeriodicidadeRefil.Enabled = true;
            cboConvenio.Enabled = true;
            cboClinica.Enabled = true;
            cboMedico.Enabled = true;
            cboMedicamento.Enabled = true;
            dgvLista.Enabled = true;

            btnNovo.Enabled = true;
            btnPesquisar.Enabled = true;
            btnSalvar.Enabled = false;
            btnLimpar.Enabled = true;
            btnSair.Enabled = true;
            btnExcluir.Enabled = false;
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

            int Id_ = Convert.ToInt32(txtId.Text);
            var Delete = _context.Receita.Find(Id_);

            if (Delete != null)
            {
                //var medicamento = _context.Receita.FirstOrDefault(b => b.Usuario == Id_);

                //if (medicamento != null)
                //{
                //    MessageBox.Show("Usuário não pode ser excluído. Tem dados relacionados entre Medicamento com Usuário!");
                //    return;
                //}

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


        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string retorno = "";
            if (txtDescricao.Text.IsNullOrEmpty())
            {
                retorno += "Preencha o campo Nome \n";
            }
            if (cboPaciente.SelectedIndex == -1 || cboPaciente.SelectedValue.ToString() == "0")
            {
                retorno += "Selecione o campo Paciente\n";
            }
            if (dTPUltimaReceita.Value.Date == DateTime.Now.Date)
            {
                retorno += "Selecione o campo Data Receita\n";
            }
            if (cboTipoEntrega.SelectedIndex == -1 || cboTipoEntrega.SelectedValue.ToString() == "0")
            {
                retorno += "Selecione o campo Tipo Entrega\n";
            }
            if (cboPeriodicidadeRefil.SelectedIndex == -1 || cboPeriodicidadeRefil.SelectedValue.ToString() == "0")
            {
                retorno += "Selecione o campo Periodicidade Refil\n";
            }
            if (cboConvenio.SelectedIndex == -1 || cboConvenio.SelectedValue.ToString() == "0")
            {
                retorno += "Selecione o campo Convênio\n";
            }
            if (cboClinica.SelectedIndex == -1 || cboClinica.SelectedValue.ToString() == "0")
            {
                retorno += "Selecione o campo Clínica\n";
            }
            if (cboMedico.SelectedIndex == -1 || cboMedico.SelectedValue.ToString() == "0")
            {
                retorno += "Selecione o campo Médico\n";
            }

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
            DateTime DataReceita_ = dTPUltimaReceita.Value.Date;
            int PacienteId_ = Convert.ToInt32(cboPaciente.SelectedValue);
            int TipoEntregaId_ = Convert.ToInt32(cboTipoEntrega.SelectedValue);
            //int PeriodicidadeRefilId_ = Convert.ToInt32(cboPeriodicidadeRefil.SelectedValue);
            int ConvenioId_ = Convert.ToInt32(cboConvenio.SelectedValue);
            int ClinicaId_ = Convert.ToInt32(cboClinica.SelectedValue);
            int MedicoId_ = Convert.ToInt32(cboMedico.SelectedValue);

            var entityNew = new Receita();
            var entityUpdate = new Receita();

            if (txtId.Text.IsNullOrEmpty())
            {
                entityNew = new Receita
                {
                    Descricao = Descricao_,
                    DataReceita = DataReceita_,
                    PacienteId = PacienteId_,
                    TipoEntregaId = TipoEntregaId_,
                    //PeriodicidadeRefilId = PeriodicidadeRefilId_,
                    ConvenioId = ConvenioId_,
                    ClinicaId = ClinicaId_,
                    MedicoId = MedicoId_,
                    DataCadastro = DateTime.Now,
                    Usuario = 1,
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
                entityUpdate.DataReceita = DataReceita_;
                entityUpdate.PacienteId = PacienteId_;
                entityUpdate.TipoEntregaId = TipoEntregaId_;
                //entityUpdate.PeriodicidadeRefilId = PeriodicidadeRefilId_;
                entityUpdate.ConvenioId = ConvenioId_;
                entityUpdate.ClinicaId = ClinicaId_;
                entityUpdate.MedicoId = MedicoId_;
                entityUpdate.DataCadastro = DateTime.Now;
                entityUpdate.Usuario = 1;

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
            string Nome_ = txtDescricao.Text;
            string Login_ = txtLogin.Text;
            string Email_ = txtEmail.Text;

            var entidade = _context.UsuarioSistema.AsQueryable();

            if (Id_ != null)
                entidade = entidade.Where(p => p.Id == Id_);

            if (!string.IsNullOrEmpty(Nome_))
                entidade = entidade.Where(p => p.Nome.Contains(Nome_));

            if (!string.IsNullOrEmpty(Login_))
                entidade = entidade.Where(p => p.Login.Contains(Login_));

            if (!string.IsNullOrEmpty(Email_))
                entidade = entidade.Where(p => p.Email.Contains(Email_));

            var entidadex = entidade.ToList();

            if (entidadex != null)
                dgvLista.DataSource = entidadex;
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
            dTPUltimaReceita.Value = DateTime.Now;
            cboPaciente.SelectedIndex = 0;
            cboTipoEntrega.SelectedIndex = 0;
            cboPeriodicidadeRefil.SelectedIndex = 0;
            cboConvenio.SelectedIndex = 0;
            cboClinica.SelectedIndex = 0;
            //cboMedico.SelectedIndex = 0;
            dgvLista.DataSource = null;

            txtId.Enabled = false;
            txtDescricao.Enabled = true;
            dTPUltimaReceita.Enabled = true;
            cboPaciente.Enabled = true;
            cboTipoEntrega.Enabled = true;
            cboPeriodicidadeRefil.Enabled = true;
            cboConvenio.Enabled = true;
            cboClinica.Enabled = true;
            cboMedico.Enabled = true;
            cboMedicamento.Enabled = true;
            dgvLista.Enabled = false;

            btnNovo.Enabled = false;
            btnPesquisar.Enabled = false;
            btnSalvar.Enabled = true;
            btnLimpar.Enabled = true;
            btnSair.Enabled = true;
            btnExcluir.Enabled = false;
        }


        private void dgvLista_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvLista.Rows[e.RowIndex];

                var idCell = row.Cells["Id"];
                var nomeCell = row.Cells["Nome"];
                var loginCell = row.Cells["Login"];
                var senhaCell = row.Cells["Senha"];
                var emailCell = row.Cells["Email"];

                if (idCell.Value != null && nomeCell.Value != null)
                {
                    int id = Convert.ToInt32(idCell.Value);
                    string nome = nomeCell.Value.ToString();
                    string login = loginCell.Value.ToString();
                    string senha = senhaCell.Value.ToString();
                    string email = emailCell.Value.ToString();

                    txtId.Text = id.ToString();
                    txtDescricao.Text = nome;
                    txtLogin.Text = login;
                    txtSenha.Text = senha;
                    txtEmail.Text = email;

                    txtId.Enabled = false;
                    txtDescricao.Enabled = true;
                    txtLogin.Enabled = true;
                    txtSenha.Enabled = true;
                    txtEmail.Enabled = true;
                    dgvLista.Enabled = true;

                    btnNovo.Enabled = true;
                    btnPesquisar.Enabled = true;
                    btnSalvar.Enabled = true;
                    btnLimpar.Enabled = true;
                    btnSair.Enabled = true;
                    btnExcluir.Enabled = true;
                }
            }
        }


    }
}
