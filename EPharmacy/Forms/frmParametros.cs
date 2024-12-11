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
    public partial class frmParametros : Form
    {
        private readonly EPharmacyContext _context;
        private int Id;


        public frmParametros()
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
            txtValorParametro.Value = 0;
            txtDirecaoMaisMenos.Clear();
            dgvLista.DataSource = null;

            txtId.Enabled = true;
            txtDescricao.Enabled = true;
            txtValorParametro.Enabled = true;
            txtDirecaoMaisMenos.Enabled = true;
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
                var paciente = _context.Paciente.FirstOrDefault(b => b.TipoEntregaId == Id_);

                if (paciente != null)
                {
                    MessageBox.Show("Tipo Entrega não pode ser excluído. Tem dados relacionados entre Receita com Tipo Entrega!");
                    return;
                }

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
            if (txtDescricao.Text.IsNullOrEmpty())
            {
                retorno += "Preencha o campo Descrição \n";
            }

            if (txtValorParametro.Value <= 0 || txtValorParametro.Value.ToString().IsNullOrEmpty())
            {
                retorno += "Preencha o campo Valor do Parâmetro\n";
            }

            if (txtDirecaoMaisMenos.Text.IsNullOrEmpty())
            {
                retorno += "Preencha o campo Direcao Mais ou Menos \n";
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
            Decimal valorParametro_ = txtValorParametro.Value;
            string direcaoMaisMenos_ = txtDirecaoMaisMenos.Text;

            var entityNew = new Parametros();
            var entityUpdate = new Parametros();

            if (txtId.Text.IsNullOrEmpty())
            {
                entityNew = new Parametros
                {
                    Descricao = Descricao_,
                    Valor = valorParametro_,
                    DirecaoMaisMenos = direcaoMaisMenos_,
                };
                _context.Parametros.Add(entityNew);
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
                entityUpdate = _context.Parametros.Find(Id_);
                entityUpdate.Descricao = Descricao_;
                entityUpdate.Valor = valorParametro_;
                entityUpdate.DirecaoMaisMenos = direcaoMaisMenos_;
                _context.SaveChanges();
                Limpar();
                txtId.Text = Id_.ToString();
                btnPesquisar_Click(null, null);
                txtId.Clear();
            }

            MessageBox.Show(
                "Parâmetro Gravado com sucesso",
                "",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation
            );
        }


        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            int? Id_ = txtId.Text.IsNullOrEmpty() ? null : Convert.ToInt32(txtId.Text);
            string Descricao_ = txtDescricao.Text;

            var entidade = _context.Parametros.AsQueryable();

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
            txtValorParametro.Value = 0;
            txtDirecaoMaisMenos.Clear();
            dgvLista.DataSource = null;

            txtId.Enabled = false;
            txtDescricao.Enabled = true;
            txtValorParametro.Enabled = true;
            txtDirecaoMaisMenos.Enabled = true;
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
                var valorParametrosCell = row.Cells["Valor"];
                var direcaoMaisMenosCell = row.Cells["DirecaoMaisMenos"];

                if (idCell.Value != null && descricaoCell.Value != null)
                {
                    int id = Convert.ToInt32(idCell.Value);
                    string descricao = descricaoCell.Value.ToString();
                    decimal valorParametros = Convert.ToDecimal(valorParametrosCell.Value);
                    string direcaoMaisMenos = direcaoMaisMenosCell.Value.ToString();


                    txtId.Enabled = false;
                    txtId.Text = id.ToString();
                    txtDescricao.Text = descricao;
                    txtDirecaoMaisMenos.Text = direcaoMaisMenos;
                    txtValorParametro.Value = valorParametros;

                    txtId.Enabled = false;
                    txtDescricao.Enabled = true;
                    txtDirecaoMaisMenos.Enabled = true;
                    txtValorParametro.Enabled = true;
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


        private void btnCalcularNovoPreco_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
                "Você tem certeza que deseja Calcular Novo? Este comando altera todos os preços dos produtos",
                "Confirmação",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (resultado != DialogResult.Yes)
            {
                return;
            }

            MedicamentoBLL classe = new MedicamentoBLL();
            string retorno = classe.CalcularNovoPreco();

            MessageBox.Show(
                retorno,
                "",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation
            );
        }

    }
}
