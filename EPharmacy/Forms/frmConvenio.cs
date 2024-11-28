using EPharmacy.Data;
using EPharmacy.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Data;

namespace EPharmacy.Forms
{
    public partial class frmConvenio : Form
    {
        private readonly EPharmacyContext _context;
        private int Id;


        public frmConvenio()
        {
            InitializeComponent();

            var optionsBuilder = new DbContextOptionsBuilder<EPharmacyContext>();
            optionsBuilder.UseSqlServer(Program.StrConn());
            _context = new EPharmacyContext(optionsBuilder.Options);
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
            dgvLista.DataSource = null;

            txtId.Enabled = true;
            txtDescricao.Enabled = true;
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
                "Você tem certeza que deseja Excluir o Convênio Selecionado?",
                "Confirmação",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (resultado != DialogResult.Yes)
            {
                return;
            }

            int Id_ = Convert.ToInt32(txtId.Text);
            var Delete = _context.Convenio.Find(Id_);

            if (Delete != null)
            {
                var receita = _context.Receita.FirstOrDefault(b => b.ConvenioId == Id_);

                if (receita != null)
                {
                    MessageBox.Show("Convênio não pode ser excluído. Tem dados relacionados entre Receita com Convênio!");
                    return;
                }

                _context.Convenio.Remove(Delete);
                _context.SaveChangesAsync();
                MessageBox.Show("Convênio excluído com sucesso!");

                Limpar();
                btnPesquisar_Click(null, null);
            }
            else
            {
                MessageBox.Show("Convênio não encontrado.");
            }
        }


        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string retorno = "";
            if (txtDescricao.Text.IsNullOrEmpty())
            {
                retorno += "Preencha o campo Descrição \n";
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

            var entityNew = new Convenio();
            var entityUpdate = new Convenio();

            if (txtId.Text.IsNullOrEmpty())
            {
                entityNew = new Convenio
                {
                    Descricao = Descricao_,
                };
                _context.Convenio.Add(entityNew);
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
                entityUpdate = _context.Convenio.Find(Id_);
                entityUpdate.Descricao = Descricao_;
                _context.SaveChanges();
                Limpar();
                txtId.Text = Id_.ToString();
                btnPesquisar_Click(null, null);
                txtId.Clear();
            }

            MessageBox.Show(
                "Convênio Gravado com sucesso",
                "",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation
            );
        }


        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            int? Id_ = txtId.Text.IsNullOrEmpty() ? null : Convert.ToInt32(txtId.Text);
            string Descricao_ = txtDescricao.Text;

            var entidade = _context.Convenio.AsQueryable();

            if (Id_ != null)
                entidade = entidade.Where(p => p.Id == Id_);

            if (!string.IsNullOrEmpty(Descricao_))
                entidade = entidade.Where(p => p.Descricao.Contains(Descricao_));

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
            dgvLista.DataSource = null;

            txtId.Enabled = false;
            txtDescricao.Enabled = true;
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
                var descricaoCell = row.Cells["Descricao"];

                if (idCell.Value != null && descricaoCell.Value != null)
                {
                    int id = Convert.ToInt32(idCell.Value);
                    string descricao = descricaoCell.Value.ToString();

                    txtId.Enabled = false;
                    txtId.Text = id.ToString();
                    txtDescricao.Text = descricao;

                    txtId.Enabled = false;
                    txtDescricao.Enabled = true;
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
