using BLL;
using EPharmacy.Data;
using EPharmacy.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Data;

namespace EPharmacy.Forms
{
    public partial class frmMedico : Form
    {
        private readonly EPharmacyContext _context;
        private int Id;


        public frmMedico()
        {
            InitializeComponent();

            var optionsBuilder = new DbContextOptionsBuilder<EPharmacyContext>();
            optionsBuilder.UseSqlServer(Program.StrConn());
            _context = new EPharmacyContext(optionsBuilder.Options);
        }


        private void frmMedico_Load(object sender, EventArgs e)
        {
            // PREENCHE COMBOS INICIO
            var especialidade = _context.Especialidade.OrderBy(p => p.Descricao).ToList();
            Especialidade c = new Especialidade();
            c.Id = 0;
            c.Descricao = "<Selecione uma opção>";
            especialidade.Insert(0, c);
            cboEspecialidade.DataSource = especialidade.ToList();
            cboEspecialidade.DisplayMember = "Descricao";
            cboEspecialidade.ValueMember = "Id";
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
            txtNome.Clear();
            txtCRM.Clear();
            cboEspecialidade.SelectedIndex = 0;
            dgvLista.DataSource = null;

            txtId.Enabled = true;
            txtNome.Enabled = true;
            txtCRM.Enabled = true;
            cboEspecialidade.Enabled = true;
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
                "Você tem certeza que deseja Excluir o Tipo Entrega Selecionado?",
                "Confirmação",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (resultado != DialogResult.Yes)
            {
                return;
            }

            int Id_ = Convert.ToInt32(txtId.Text);
            var Delete = _context.TipoEntrega.Find(Id_);

            if (Delete != null)
            {
                //var receita = _context.Receita.FirstOrDefault(b => b.TipoEntregaId == Id_);

                //if (receita != null)
                //{
                //    MessageBox.Show("Tipo Entrega não pode ser excluído. Tem dados relacionados entre Receita com Tipo Entrega!");
                //    return;
                //}

                _context.TipoEntrega.Remove(Delete);
                _context.SaveChangesAsync();
                MessageBox.Show("Tipo Entrega excluído com sucesso!");

                Limpar();
                btnPesquisar_Click(null, null);
            }
            else
            {
                MessageBox.Show("Tipo Entrega não encontrado.");
            }
        }


        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string retorno = "";
            if (txtNome.Text.IsNullOrEmpty())
            {
                retorno += "Preencha o campo Descrição \n";
            }
            if (txtCRM.Text.IsNullOrEmpty())
            {
                retorno += "Preencha o campo CRM \n";
            }
            if (cboEspecialidade.SelectedIndex == -1 || cboEspecialidade.SelectedValue.ToString() == "0")
            {
                retorno += "Selecione o campo Especialidada\n";
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

            string Nome = txtNome.Text;
            string CRM = txtCRM.Text;
            int Especialidade = Convert.ToInt32(cboEspecialidade.SelectedValue);

            var entityNew = new Medico();
            var entityUpdate = new Medico();

            if (txtId.Text.IsNullOrEmpty())
            {
                entityNew = new Medico
                {
                    Nome = Nome,
                    CRM = CRM,  
                    EspecialidadeId = Especialidade,
                    DataCadastro = DateTime.Now,
                    Usuario = 1
                };
                _context.Medico.Add(entityNew);
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
                entityUpdate = _context.Medico.Find(Id_);
                entityUpdate.Nome = Nome;
                entityUpdate.CRM = CRM;
                entityUpdate.EspecialidadeId = Especialidade;
                _context.SaveChanges();
                Limpar();
                txtId.Text = Id_.ToString();
                btnPesquisar_Click(null, null);
                txtId.Clear();
            }

            MessageBox.Show(
                "Tipo Entrega Gravado com sucesso",
                "",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation
            );
        }


        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            int? Id_ = txtId.Text.IsNullOrEmpty() ? null : Convert.ToInt32(txtId.Text);
            string? Nome_ = txtNome.Text;
            string? CRM_ = UtilitariosBLL.limpaString(txtCRM.Text);
            int? Especialidade_ = cboEspecialidade.SelectedIndex > 0 ? Convert.ToInt32(cboEspecialidade.SelectedValue) : null;

            var entidade = _context.Medico.AsQueryable();

            if (Id_ != null)
                entidade = entidade.Where(p => p.Id == Id_);

            /*if (!string.IsNullOrEmpty(Nome_))
                entidade = entidade.Where(p => p.Nome.Contains(Nome_));

            if (!string.IsNullOrEmpty(CRM_))
                entidade = entidade.Where(p => p.CRM.Contains(CRM_));

            if (Especialidade_ != null)
                entidade = entidade.Where(p => p.EspecialidadeId == Especialidade_);*/


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
            txtNome.Clear();
            txtCRM.Clear();
            cboEspecialidade.SelectedIndex = 0;
            dgvLista.DataSource = null;

            txtId.Enabled = false;
            txtNome.Enabled = true;
            txtCRM.Enabled = true;
            cboEspecialidade.Enabled = true;
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
                var NomeCell = row.Cells["Nome"];
                var CRMCell = row.Cells["CRM"];
                var EspecialidadeCell = row.Cells["EspecialidadeId"];

                if (idCell.Value != null && NomeCell.Value != null)
                {
                    int id = Convert.ToInt32(idCell.Value);
                    string Nome = NomeCell.Value.ToString();
                    string CRM = CRMCell.Value.ToString();
                    int? Especialidade = Convert.ToInt32(EspecialidadeCell.Value); 

                    txtId.Enabled = false;
                    txtId.Text = id.ToString();
                    txtNome.Text = Nome;
                    txtCRM.Text = CRM;
                    cboEspecialidade.SelectedValue = Especialidade;

                    txtId.Enabled = false;
                    txtNome.Enabled = true;
                    txtCRM.Enabled = true;
                    cboEspecialidade.SelectedValue = 0;
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
