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
            c.Descricao = "<Selecione>";
            classeTerapeutica.Insert(0, c);
            cboClasseTerapeutica.DataSource = classeTerapeutica.ToList();
            cboClasseTerapeutica.DisplayMember = "Descricao";
            cboClasseTerapeutica.ValueMember = "Id";

            var tipoReceita = _context.TipoReceita.OrderBy(p => p.Descricao).ToList();
            TipoReceita t = new TipoReceita();
            t.Id = 0;
            t.Descricao = "<Selecione>";
            tipoReceita.Insert(0, t);
            cboTipoReceita.DataSource = tipoReceita.ToList();
            cboTipoReceita.DisplayMember = "Descricao";
            cboTipoReceita.ValueMember = "Id";

            var substancia = _context.Substancia.OrderBy(p => p.Descricao).ToList();
            Substancia s = new Substancia();
            s.Id = 0;
            s.Descricao = "<Selecione>";
            substancia.Insert(0, s);
            cboSubstancia.DataSource = substancia.ToList();
            cboSubstancia.DisplayMember = "Descricao";
            cboSubstancia.ValueMember = "Id";

            var fabricante = _context.Fabricante.OrderBy(p => p.Descricao).ToList();
            Fabricante f = new Fabricante();
            f.Id = 0;
            f.Descricao = "<Selecione>";
            fabricante.Insert(0, f);
            cboFabricante.DataSource = fabricante.ToList();
            cboFabricante.DisplayMember = "Descricao";
            cboFabricante.ValueMember = "Id";



            var ncm = _context.Ncm.OrderBy(p => p.Descricao).ToList();
            Ncm nc = new Ncm();
            nc.Id = 0;
            nc.Descricao = "<Selecione>";
            ncm.Insert(0, nc);
            cboNcm.DataSource = ncm.ToList();
            cboNcm.DisplayMember = "Descricao";
            cboNcm.ValueMember = "Id";



            var lista = new List<Lista>
            {
                new Lista { Id = 0, Descricao = "Selecione" },
                new Lista { Id = 1, Descricao = "Positiva" },
                new Lista { Id = 2, Descricao = "Negativa" },
                new Lista { Id = 3, Descricao = "Neutra" },
            };
            cboLista.DataSource = lista;
            cboLista.DisplayMember = "Descricao";  // o que aparece
            cboLista.ValueMember = "Id";  // o valor associado


            var regime = new List<Regime>
            {
                new Regime { Id = 0, Descricao = "Selecione" },
                new Regime { Id = 1, Descricao = "Monitorado " },
                new Regime { Id = 2, Descricao = "Liberado" },
            };
            cboRegime.DataSource = regime;
            cboRegime.DisplayMember = "Descricao";  // o que aparece
            cboRegime.ValueMember = "Id";  // o valor associado
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

            // alterar a altura da linhas do grid
            dgvMedicamentos.RowTemplate.Height = 17;

            // fazendo ficar com as colunas autoajuestadas ao tamanho
            dgvMedicamentos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

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

            cboNcm.SelectedIndex = 0;
            cboLista.SelectedIndex = 0;
            cboRegime.SelectedIndex = 0;

            dgvMedicamentos.DataSource = null;

            txtId.Enabled = false;
            txtEAN.Enabled = true;
            txtProduto.Enabled = true;
            cboClasseTerapeutica.Enabled = true;
            cboTipoReceita.Enabled = true;
            cboSubstancia.Enabled = true;
            cboFabricante.Enabled = true;

            cboNcm.Enabled = true;
            cboLista.Enabled = true;
            cboRegime.Enabled = true;

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
            string TUSS_ = txtTUSS.Text;

            int ?NcmId_ = Convert.ToInt32(cboNcm.SelectedValue);
            int ?ListaId_ = Convert.ToInt32(cboLista.SelectedValue);
            int ?RegimeId_ = Convert.ToInt32(cboRegime.SelectedValue);

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
                    TUSS = TUSS_,

                    NcmId = NcmId_== 0 ? null : NcmId_.Value, 
                    ListaId = ListaId_ == 0 ? null : ListaId_.Value,
                    RegimeId = RegimeId_ == 0 ? null : RegimeId_.Value,

                    DataCadastro = DateTime.Now.Date,
                    Usuario = GlobalVariables.LoginId,
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
                medicamentoUpdate.TUSS = TUSS_;

                medicamentoUpdate.NcmId = NcmId_ == 0 ? null : NcmId_.Value;
                medicamentoUpdate.ListaId = ListaId_ == 0 ? null : ListaId_.Value;
                medicamentoUpdate.RegimeId = RegimeId_ == 0 ? null : RegimeId_.Value;

                medicamentoUpdate.DataCadastro = DateTime.Now;
                medicamentoUpdate.Usuario = GlobalVariables.LoginId;

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
            txtTUSS.Clear();

            cboNcm.SelectedIndex = 0;
            cboLista.SelectedIndex = 0;
            cboRegime.SelectedIndex = 0;

            dgvMedicamentos.DataSource = null;

            txtId.Enabled = true;
            txtEAN.Enabled = true;
            txtProduto.Enabled = true;
            cboClasseTerapeutica.Enabled = true;
            cboTipoReceita.Enabled = true;
            cboSubstancia.Enabled = true;
            cboFabricante.Enabled = true;
            txtTUSS.Enabled = true;

            cboNcm.Enabled = true;
            cboLista.Enabled = true;
            cboRegime.Enabled = true;

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

            int? ncmId_ = cboNcm.SelectedIndex > 0 ? Convert.ToInt32(cboNcm.SelectedValue) : null;
            int? listaId_ = cboLista.SelectedIndex > 0 ? Convert.ToInt32(cboLista.SelectedValue) : null;
            int? regimeId_ = cboRegime.SelectedIndex > 0 ? Convert.ToInt32(cboRegime.SelectedValue) : null;

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


            if (ncmId_ != null)
                medicamento = medicamento.Where(p => p.NcmId == ncmId_);
            if (listaId_ != null)
                medicamento = medicamento.Where(p => p.ListaId == listaId_);
            if (regimeId_ != null)
                medicamento = medicamento.Where(p => p.RegimeId == regimeId_);

            var medicamentoz = from r in medicamento
                               join p in _context.Fabricante on r.FabricanteId.Value equals p.Id into fabricanteJoin
                               from p in fabricanteJoin.DefaultIfEmpty()
                               join m in _context.Substancia on r.SubstanciaId.Value equals m.Id into SubstanciaJoin
                               from m in SubstanciaJoin.DefaultIfEmpty()
                               join t in _context.TipoReceita on r.TipoReceitaId.Value equals t.Id into TipoReceitaJoin
                               from t in TipoReceitaJoin.DefaultIfEmpty()
                               join c in _context.ClasseTerapeutica on r.ClasseTerapeuticaId.Value equals c.Id into ClasseTerapeuticaJoin
                               from c in ClasseTerapeuticaJoin.DefaultIfEmpty()

                               join x in _context.Ncm on r.NcmId.Value equals x.Id into NcmJoin
                               from x in NcmJoin.DefaultIfEmpty()

                               select new
                               {
                                   Id = r.Id,
                                   EAN = r.EAN,
                                   Produto = r.Produto,
                                   ClasseTerapeuticaId = c.Id,
                                   ClasseTerapeutica = c.Descricao,
                                   TipoReceitaId = t.Id,
                                   TipoReceita = t.Descricao,
                                   SubstanciaId = m.Id,
                                   Substancia = m.Descricao,
                                   FabricanteId = p.Id,
                                   Fabricante = p.Descricao,
                                   r.TUSS,
                                   NcmId = r.NcmId == null ? 0 : r.NcmId.Value,
                                   Ncm = x.Descricao,
                                   ListaId = r.ListaId == null ? 0 : r.ListaId.Value,
                                   Lista = Lista.ObterLista(r.ListaId.Value).Descricao,
                                   RegimeId = r.RegimeId == null ? 0 : r.RegimeId.Value,
                                   Regime = Regime.ObterRegime(r.RegimeId.Value).Descricao
                               };


            var medicamentox = medicamentoz.ToList();

            if (medicamentox != null)
                dgvMedicamentos.DataSource = medicamentox;

            dgvMedicamentos.Columns["ClasseTerapeuticaId"].HeaderText = "Id Classe Terapeutica";
            dgvMedicamentos.Columns["TipoReceitaId"].HeaderText = "Id TipoReceita";
            dgvMedicamentos.Columns["FabricanteId"].HeaderText = "Id Fabricante";
            dgvMedicamentos.Columns["SubstanciaId"].HeaderText = "Id Substância";
            dgvMedicamentos.Columns["ClasseTerapeutica"].HeaderText = "Classe Terapeutica";
            dgvMedicamentos.Columns["TipoReceita"].HeaderText = "Tp Receita";

            dgvMedicamentos.Columns["Id"].Visible = chkMostrarIds.Checked;
            dgvMedicamentos.Columns["ClasseTerapeuticaId"].Visible = chkMostrarIds.Checked;
            dgvMedicamentos.Columns["TipoReceitaId"].Visible = chkMostrarIds.Checked;
            dgvMedicamentos.Columns["FabricanteId"].Visible = chkMostrarIds.Checked;
            dgvMedicamentos.Columns["SubstanciaId"].Visible = chkMostrarIds.Checked;

            dgvMedicamentos.Columns["NcmId"].Visible = chkMostrarIds.Checked;
            dgvMedicamentos.Columns["ListaId"].Visible = chkMostrarIds.Checked;
            dgvMedicamentos.Columns["RegimeId"].Visible = chkMostrarIds.Checked;
        }


        private void dgvMedicamentos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvMedicamentos.Rows[e.RowIndex];

                var idCell = row.Cells["Id"];
                var eanCell = row.Cells["EAN"];
                var produtoCell = row.Cells["Produto"];
                var classeTerapeuticaCell = row.Cells["ClasseTerapeuticaId"] == null ? null : row.Cells["ClasseTerapeuticaId"];
                var tipoReceitaCell = row.Cells["TipoReceitaId"];
                var fabricanteCell = row.Cells["FabricanteId"];
                var substanciaCell = row.Cells["SubstanciaId"];

                var ncmIdCell = row.Cells["NcmId"];
                var listaIdCell = row.Cells["listaId"];
                var regimeIdCell = row.Cells["regimeId"];

                var TUSSCell = row.Cells["TUSS"];

                if (idCell.Value != null && produtoCell.Value != null)
                {
                    int id = Convert.ToInt32(idCell.Value);
                    string ean = eanCell.Value.ToString();
                    string produto = produtoCell.Value.ToString();
                    int classeTerapeutica = Convert.ToInt32(classeTerapeuticaCell.Value);
                    int tipoReceita = Convert.ToInt32(tipoReceitaCell.Value);
                    int fabricante = Convert.ToInt32(fabricanteCell.Value);
                    int substancia = Convert.ToInt32(substanciaCell.Value);
                    string TUSS = TUSSCell.Value == null ? null : TUSSCell.Value.ToString();

                    int ncmId = Convert.ToInt32(ncmIdCell.Value);
                    int listaId = Convert.ToInt32(listaIdCell.Value);
                    int regimeId = Convert.ToInt32(regimeIdCell.Value);

                    txtId.Enabled = false;
                    txtId.Text = id.ToString();
                    txtEAN.Text = ean;
                    txtProduto.Text = produto;
                    cboClasseTerapeutica.SelectedValue = classeTerapeutica;
                    cboTipoReceita.SelectedValue = tipoReceita;
                    cboFabricante.SelectedValue = fabricante;
                    cboSubstancia.SelectedValue = substancia;
                    txtTUSS.Text = TUSS;

                    cboNcm.SelectedValue = ncmId;
                    cboLista.SelectedValue = listaId;
                    cboRegime.SelectedValue = regimeId;

                    txtId.Enabled = false;
                    txtEAN.Enabled = true;
                    txtProduto.Enabled = true;
                    cboClasseTerapeutica.Enabled = true;
                    cboTipoReceita.Enabled = true;
                    cboSubstancia.Enabled = true;
                    cboFabricante.Enabled = true;
                    txtTUSS.Enabled = true;

                    cboNcm.Enabled = true;
                    cboLista.Enabled = true;
                    cboRegime.Enabled = true;

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


        private void chkAumentaLarguraColunasGrid_CheckedChanged(object sender, EventArgs e)
        {
            // fazendo ficar com as colunas autoajuestadas ao tamanho
            if (chkAumentaLarguraColunasGrid.Checked)
            {
                dgvMedicamentos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
            else
            {
                dgvMedicamentos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
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



        // Tornar o texto colado como a opção selecionada na combo
        private void cboSelecaoPadrao_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            System.Windows.Forms.ComboBox comboBox = sender as System.Windows.Forms.ComboBox;
            if (comboBox == null) return;

            string enteredText = comboBox.Text;

            if (!string.IsNullOrEmpty(enteredText))
            {
                int index = comboBox.FindStringExact(enteredText);

                if (index != -1)
                {
                    comboBox.SelectedIndex = index; // Seleciona o item encontrado
                }
                else
                { }
            }
            else
            { }
        }

    }

}

