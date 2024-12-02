using EPharmacy;
using EPharmacy.Data;
using EPharmacy.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Data;
using System.Drawing;


namespace ControleEntregada.Forms
{
    public partial class frmMedicamento : Form
    {
        private readonly EPharmacyContext _context;
        private int Id;

        public frmMedicamento()
        {
            InitializeComponent();

            var optionsBuilder = new DbContextOptionsBuilder<EPharmacyContext>();
            optionsBuilder.UseSqlServer(Program.StrConn());
            _context = new EPharmacyContext(optionsBuilder.Options);
        }


        private void Medicamento_Load(object sender, EventArgs e)
        {
            // PREENCHE COMBOS INICIO
            var classeTerapeutica = _context.ClasseTerapeutica.OrderBy(p => p.Descricao).ToList();
            ClasseTerapeutica c = new ClasseTerapeutica();
            c.Id = 0;
            c.Descricao = "<Selecione uma opção>";
            classeTerapeutica.Insert(0, c);
            cboClasseTerapeutica.DataSource = classeTerapeutica.ToList();
            cboClasseTerapeutica.DisplayMember = "Descricao";
            cboClasseTerapeutica.ValueMember = "Id";

            var tipoReceita = _context.TipoReceita.OrderBy(p => p.Descricao).ToList();
            TipoReceita t = new TipoReceita();
            t.Id = 0;
            t.Descricao = "<Selecione uma opção>";
            tipoReceita.Insert(0, t);
            cboTipoReceita.DataSource = tipoReceita.ToList();
            cboTipoReceita.DisplayMember = "Descricao";
            cboTipoReceita.ValueMember = "Id";

            var substancia = _context.Substancia.OrderBy(p => p.Descricao).ToList();
            Substancia s = new Substancia();
            s.Id = 0;
            s.Descricao = "<Selecione uma opção>";
            substancia.Insert(0, s);
            cboSubstancia.DataSource = substancia.ToList();
            cboSubstancia.DisplayMember = "Descricao";
            cboSubstancia.ValueMember = "Id";

            var fabricante = _context.Fabricante.OrderBy(p => p.Descricao).ToList();
            Fabricante f = new Fabricante();
            f.Id = 0;
            f.Descricao = "<Selecione uma opção>";
            fabricante.Insert(0, f);
            cboFabricante.DataSource = fabricante.ToList();
            cboFabricante.DisplayMember = "Descricao";
            cboFabricante.ValueMember = "Id";
            // FIM

            // Adiciona uma coluna de botões ao DataGridView
            /*
            DataGridViewButtonColumn btnPrecoColumn = new DataGridViewButtonColumn();
            btnPrecoColumn.Name = "btnExcluirdGVReceitaItens";
            btnPrecoColumn.HeaderText = "Preço";
            btnPrecoColumn.Text = "<Preço>";
            btnPrecoColumn.UseColumnTextForButtonValue = true; // Isso faz com que o texto "Excluir" apareça nos botões
            dgvMedicamentos.Columns.Add(btnPrecoColumn);
            // Associando o evento de clique da célula
            dgvMedicamentos.CellContentClick += new DataGridViewCellEventHandler(dgvMedicamentos_CellContentClick);*/

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
            txtEAN.Clear();
            txtProduto.Clear();
            cboClasseTerapeutica.SelectedIndex = 0;
            cboTipoReceita.SelectedIndex = 0;
            cboSubstancia.SelectedIndex = 0;
            cboFabricante.SelectedIndex = 0;
            dgvMedicamentos.DataSource = null;

            txtId.Enabled = false;
            txtEAN.Enabled = true;
            txtProduto.Enabled = true;
            cboClasseTerapeutica.Enabled = true;
            cboTipoReceita.Enabled = true;
            cboSubstancia.Enabled = true;
            cboFabricante.Enabled = true;
            dgvMedicamentos.Enabled = false;

            btnNovo.Enabled = false;
            btnPesquisar.Enabled = false;
            btnSalvar.Enabled = true;
            btnLimpar.Enabled = true;
            btnSair.Enabled = true;
            btnExcluir.Enabled = false;
        }


        private void btnSalvar_Click(object sender, EventArgs e)
        {

            string retorno = "";
            if (txtEAN.Text.IsNullOrEmpty())
            {
                retorno += "Preencha o campo EAM \n";
            }
            if (txtProduto.Text.IsNullOrEmpty())
            {
                retorno += "Preencha o campo nome do Produto \n";
            }
            if (cboClasseTerapeutica.SelectedIndex == -1 || cboClasseTerapeutica.SelectedValue.ToString() == "0")
            {
                retorno += "Selecione o campo Classe Terapeutica\n";
            }
            if (cboTipoReceita.SelectedIndex == -1 || cboTipoReceita.SelectedValue.ToString() == "0")
            {
                retorno += "Selecione o campo Tipo Receita\n";
            }
            if (cboSubstancia.SelectedIndex == -1 || cboSubstancia.SelectedValue.ToString() == "0")
            {
                retorno += "Selecione o campo Substância\n";
            }
            if (cboFabricante.SelectedIndex == -1 || cboFabricante.SelectedValue.ToString() == "0")
            {
                retorno += "Selecione o campo Fabricante\n";
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

            string Produto_ = txtProduto.Text;
            string EAN_ = txtEAN.Text;
            int ClasseTerapeutica_ = Convert.ToInt32(cboClasseTerapeutica.SelectedValue);
            int TipoReceita_ = Convert.ToInt32(cboTipoReceita.SelectedValue);
            int Substancia_ = Convert.ToInt32(cboSubstancia.SelectedValue);
            int Fabricante_ = Convert.ToInt32(cboFabricante.SelectedValue);

            var medicamentoNew = new Medicamento();
            var medicamentoUpdate = new Medicamento();

            if (txtId.Text.IsNullOrEmpty())
            {
                medicamentoNew = new Medicamento
                {
                    EAN = EAN_,
                    Produto = Produto_,
                    ClasseTerapeuticaId = ClasseTerapeutica_,
                    TipoReceitaId = TipoReceita_,
                    SubstanciaId = Substancia_,
                    FabricanteId = Fabricante_,
                    DataCadastro = DateTime.Now.Date,
                    Usuario = 1,
                };
                _context.Medicamento.Add(medicamentoNew);
                _context.SaveChanges();
                Id = medicamentoNew.Id;
                txtId.Text = Id.ToString();

                Limpar();

                txtId.Text = Id.ToString();
                AtualizarDataGrid();
                txtId.Clear();
            }
            else
            {
                int Id_ = Convert.ToInt32(txtId.Text);
                // medicamentoUpdate = _context.Medicamento.Single(b => b.Id == Id_);
                medicamentoUpdate = _context.Medicamento.Find(Id_);

                medicamentoUpdate.EAN = EAN_;
                medicamentoUpdate.Produto = Produto_;
                medicamentoUpdate.ClasseTerapeuticaId = ClasseTerapeutica_;
                medicamentoUpdate.TipoReceitaId = TipoReceita_;
                medicamentoUpdate.SubstanciaId = Substancia_;
                medicamentoUpdate.FabricanteId = Fabricante_;
                medicamentoUpdate.DataCadastro = DateTime.Now;
                medicamentoUpdate.Usuario = 1;

                //   _context.Medicamento.Add(medicamentoUpdate);
                _context.SaveChanges();

                Limpar();

                txtId.Text = Id_.ToString();
                AtualizarDataGrid();
                txtId.Clear();
            }
            //_context.Entry(entidade).State = EntityState.Modified;
            MessageBox.Show(
                "Medicamento Gravado com sucesso",
                "",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation
            );
        }


        private void AtualizarDataGrid()
        {
            btnPesquisar_Click(null, null);
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
            txtProduto.Clear();
            cboClasseTerapeutica.SelectedIndex = 0;
            cboTipoReceita.SelectedIndex = 0;
            cboSubstancia.SelectedIndex = 0;
            cboFabricante.SelectedIndex = 0;
            dgvMedicamentos.DataSource = null;

            txtId.Enabled = true;
            txtEAN.Enabled = true;
            txtProduto.Enabled = true;
            cboClasseTerapeutica.Enabled = true;
            cboTipoReceita.Enabled = true;
            cboSubstancia.Enabled = true;
            cboFabricante.Enabled = true;
            dgvMedicamentos.Enabled = true;

            btnNovo.Enabled = true;
            btnPesquisar.Enabled = true;
            btnSalvar.Enabled = false;
            btnLimpar.Enabled = true;
            btnSair.Enabled = true;
            btnExcluir.Enabled = false;
        }


        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            int? Id_ = txtId.Text.IsNullOrEmpty() ? null : Convert.ToInt32(txtId.Text);
            string Produto_ = txtProduto.Text;
            string EAN_ = txtEAN.Text;
            int? ClasseTerapeutica_ = cboClasseTerapeutica.SelectedIndex > 0 ? Convert.ToInt32(cboClasseTerapeutica.SelectedValue) : null;
            int? TipoReceita_ = cboTipoReceita.SelectedIndex > 0 ? Convert.ToInt32(cboTipoReceita.SelectedValue) : null;
            int? Substancia_ = cboSubstancia.SelectedIndex > 0 ? Convert.ToInt32(cboSubstancia.SelectedValue) : null;
            int? Fabricante_ = cboFabricante.SelectedIndex > 0 ? Convert.ToInt32(cboFabricante.SelectedValue) : null;

            var medicamento = _context.Medicamento.AsQueryable();

            if (Id_ != null)
                medicamento = medicamento.Where(p => p.Id == Id_);

            if (!string.IsNullOrEmpty(Produto_))
                medicamento = medicamento.Where(p => p.Produto.Contains(Produto_));

            if (!string.IsNullOrEmpty(EAN_))
                medicamento = medicamento.Where(p => p.EAN.Contains(EAN_));

            if (ClasseTerapeutica_ != null)
                medicamento = medicamento.Where(p => p.ClasseTerapeuticaId == ClasseTerapeutica_);

            if (TipoReceita_ != null)
                medicamento = medicamento.Where(p => p.TipoReceitaId == TipoReceita_);

            if (Substancia_ != null)
                medicamento = medicamento.Where(p => p.SubstanciaId == Substancia_);

            if (Fabricante_ != null)
                medicamento = medicamento.Where(p => p.FabricanteId == Fabricante_);

            var medicamentox = medicamento.ToList();

            if (medicamentox != null)
                dgvMedicamentos.DataSource = medicamentox;

        }


        private void dgvMedicamentos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvMedicamentos.Rows[e.RowIndex];

                var idCell = row.Cells["Id"];
                var eanCell = row.Cells["EAN"];
                var produtoCell = row.Cells["Produto"];
                var classeTerapeuticaCell = row.Cells["ClasseTerapeuticaId"];
                var tipoReceitaCell = row.Cells["TipoReceitaId"];
                var fabricanteCell = row.Cells["FabricanteId"];
                var substanciaCell = row.Cells["SubstanciaId"];

                if (idCell.Value != null && produtoCell.Value != null)
                {
                    int id = Convert.ToInt32(idCell.Value);
                    string ean = eanCell.Value.ToString();
                    string produto = produtoCell.Value.ToString();
                    int classeTerapeutica = Convert.ToInt32(classeTerapeuticaCell.Value);
                    int tipoReceita = Convert.ToInt32(tipoReceitaCell.Value);
                    int fabricante = Convert.ToInt32(fabricanteCell.Value);
                    int substancia = Convert.ToInt32(substanciaCell.Value);

                    txtId.Enabled = false;
                    txtId.Text = id.ToString();
                    txtEAN.Text = ean;
                    txtProduto.Text = produto;
                    cboClasseTerapeutica.SelectedValue = classeTerapeutica;
                    cboTipoReceita.SelectedValue = tipoReceita;
                    cboFabricante.SelectedValue = fabricante;
                    cboSubstancia.SelectedValue = substancia;


                    txtId.Enabled = false;
                    txtEAN.Enabled = true;
                    txtProduto.Enabled = true;
                    cboClasseTerapeutica.Enabled = true;
                    cboTipoReceita.Enabled = true;
                    cboSubstancia.Enabled = true;
                    cboFabricante.Enabled = true;
                    dgvMedicamentos.Enabled = true;

                    btnNovo.Enabled = true;
                    btnPesquisar.Enabled = true;
                    btnSalvar.Enabled = true;
                    btnLimpar.Enabled = true;
                    btnSair.Enabled = true;
                    btnExcluir.Enabled = true;
                }
            }
        }


        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
              "Você tem certeza que deseja Excluir o Medicamento Selecionado?",
              "Confirmação",
              MessageBoxButtons.YesNo,
              MessageBoxIcon.Question
          );

            if (resultado != DialogResult.Yes)
            {
                return;
            }

            int Id_ = Convert.ToInt32(txtId.Text);
            var medicamentoDelete = _context.Medicamento.Find(Id_);

            if (medicamentoDelete != null)
            {
                var receitaItens = _context.ReceitaItens.FirstOrDefault(b => b.MedicamentoId == Id_);
                var medicamentoPreco = _context.MedicamentoPreco.FirstOrDefault(b => b.MedicamentoId == Id_);

                if (medicamentoPreco != null)
                {
                    MessageBox.Show("Medicamento não pode ser excluído. Tem dados relacionados em Preço Medicamento!");
                    return;
                }

                if (receitaItens != null)
                {
                    MessageBox.Show("Medicamento não pode ser excluído. Tem dados relacionados em Itens em Receita!");
                    return;
                }

                _context.Medicamento.Remove(medicamentoDelete);
                _context.SaveChangesAsync();
                MessageBox.Show("Medicamento excluído com sucesso!");

                Limpar();
                AtualizarDataGrid();
            }
            else
            {
                MessageBox.Show("Medicamento não encontrado.");
            }
        }


        /*
        private void dgvMedicamentos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (Form filho in this.MdiChildren)
            {
                if (filho is frmMedicamentoPreco)
                {
                    filho.Activate();
                    return;
                }
            }

            int ? MedicamentoId = null;
            if (!txtId.Text.IsNullOrEmpty())
                MedicamentoId = Convert.ToInt32(txtId.Text);

            frmMedicamentoPreco formulario = new frmMedicamentoPreco(MedicamentoId);
            formulario.Show();
            formulario.Location = new Point(20, 0);

        }*/
    }

}

