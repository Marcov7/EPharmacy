using BLL;
using EPharmacy;
using EPharmacy.Data;
using EPharmacy.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace ControleEntregada.Forms
{
    public partial class frmMedicamentoPreco : Form
    {
        private readonly EPharmacyContext _context;

        public frmMedicamentoPreco(int? MedicamentoId)
        {
            InitializeComponent();

            var optionsBuilder = new DbContextOptionsBuilder<EPharmacyContext>();
            optionsBuilder.UseSqlServer(Program.StrConn());
            _context = new EPharmacyContext(optionsBuilder.Options);
            var x = 0;

            // alterar a altura da linhas do grid
            dgvMedicamentos.RowTemplate.Height = 17;

            // fazendo ficar com as colunas autoajuestadas ao tamanho
            dgvMedicamentos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            /*
            txtPrecoFabricaOld.Mask = "000000.00"; 
            txtPrecoFabricaOld.ValidatingType = typeof(decimal);
            txtPrecoFabricaOld.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            txtPMCBrasindice.Mask = "000000.00";
            txtPMCBrasindice.ValidatingType = typeof(decimal);
            txtPMCBrasindice.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            txtPrecoAcordo.Mask = "000000.00";
            txtPrecoAcordo.ValidatingType = typeof(decimal);
            txtPrecoAcordo.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;*/

            txtPrecoFabrica.DecimalPlaces = 2;
            txtPrecoFabrica.Minimum = 0;
            txtPrecoFabrica.Maximum = 1000000;

            txtPMCBrasindice.DecimalPlaces = 2;
            txtPMCBrasindice.Minimum = 0;
            txtPMCBrasindice.Maximum = 1000000;

            txtPrecoAcordo.DecimalPlaces = 2;
            txtPrecoAcordo.Minimum = 0;
            txtPrecoAcordo.Maximum = 1000000;

        }


        private void btnSair_Click_1(object sender, EventArgs e)
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


        private void btnNovo_Click_1(object sender, EventArgs e)
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
            txtMedicamentoId.Clear();
            txtEAN.Clear();
            txtProduto.Clear();
            txtPMCBrasindice.Value = 0;
            txtPrecoFabrica.Value = 0;
            txtPrecoAcordo.Value = 0;
            txtUnidadesCaixa.Clear();
            txtPrecoUnitario.Value = 0;

            txtId.Enabled = false;
            txtMedicamentoId.Enabled = true;
            txtEAN.Enabled = false;
            txtProduto.Enabled = false;
            txtPMCBrasindice.Enabled = true;
            txtPrecoFabrica.Enabled = true;
            txtPrecoAcordo.Enabled = false;
            txtUnidadesCaixa.Enabled = true;
            txtPrecoUnitario.Enabled = false; 

            btnNovo.Enabled = false;
            btnPesquisar.Enabled = false;
            btnSalvar.Enabled = true;
            btnLimpar.Enabled = true;
            btnSair.Enabled = true;
            btnExcluir.Enabled = false;
            btnCalcular.Enabled = true;
            btnCalcularPrecounitario.Enabled = true;
        }


        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string retorno = "";
            if (txtMedicamentoId.Text.IsNullOrEmpty())
            {
                retorno += "Preencha o campo Medicamento Id \n";
            }
            if (txtPrecoFabrica.Text.IsNullOrEmpty())
            {
                retorno += "Preencha o campo Preço Fábrica \n";
            }
            if (txtPMCBrasindice.Text.IsNullOrEmpty())
            {
                retorno += "Preencha o campo PMC Brasindice \n";
            }
            if (txtPrecoAcordo.Text.IsNullOrEmpty())
            {
                retorno += "Preencha o campo Preço Acordado \n";
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

            int medicamentoId_ = Convert.ToInt32(txtMedicamentoId.Text);
            decimal precoFabrica_ = Convert.ToDecimal(txtPrecoFabrica.Text);
            decimal precoPMC_ = Convert.ToDecimal(txtPMCBrasindice.Text);
            decimal precoAcordado_ = Convert.ToDecimal(txtPrecoAcordo.Text);

            int? unidadesCaixa_;
            decimal? precoUnitario_;
            if (txtUnidadesCaixa.Text.IsNullOrEmpty() || txtPrecoUnitario.Value == 0) 
            {
                unidadesCaixa_ = null;
                precoUnitario_ = null;
            }
            else
            {
                unidadesCaixa_ = Convert.ToInt32(txtUnidadesCaixa.Text);
                precoUnitario_ = Convert.ToDecimal(txtPrecoUnitario.Value);
            }


            var entityNew = new MedicamentoPreco();
            var entityUpdate = new MedicamentoPreco();

            if (txtId.Text.IsNullOrEmpty())
            {
                entityNew = new MedicamentoPreco
                {
                    MedicamentoId = medicamentoId_,
                    PrecoFabrica = precoFabrica_,
                    PrecoPmcBrasindice = precoPMC_,
                    PrecoAcordado = precoAcordado_,
                    UnidadesCaixa = unidadesCaixa_,
                    PrecoUnitario = precoUnitario_,
                    Usuario = GlobalVariables.LoginId,
                    DataCadastro = DateTime.Now.Date,
                };
                _context.MedicamentoPreco.Add(entityNew);
                _context.SaveChanges();
                Limpar();
                btnPesquisar_Click(null, null);
            }
            else
            {
                int Id_ = Convert.ToInt32(txtId.Text);
                entityUpdate = _context.MedicamentoPreco.Find(Id_);
                entityUpdate.MedicamentoId = medicamentoId_;
                entityUpdate.PrecoFabrica = precoFabrica_;
                entityUpdate.PrecoPmcBrasindice = precoPMC_;
                entityUpdate.PrecoAcordado = precoAcordado_;
                entityUpdate.PrecoUnitario = precoUnitario_;
                entityUpdate.UnidadesCaixa = unidadesCaixa_;
                entityUpdate.Usuario = GlobalVariables.LoginId;
                entityUpdate.DataCadastro = DateTime.Now.Date;
                _context.SaveChanges();
                Limpar();
                btnPesquisar_Click(null, null);
            }

            MessageBox.Show(
                "Preço de Medicamento Novo Gravado com sucesso.",
                "",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation
            );
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
            txtMedicamentoId.Clear();
            txtEAN.Clear();
            txtProduto.Clear();
            txtPrecoFabrica.Value = 0;
            txtPMCBrasindice.Value = 0;
            txtPrecoAcordo.Value = 0;
            txtUnidadesCaixa.Clear();
            txtPrecoUnitario.Value = 0;
            dgvMedicamentos.DataSource = null;


            txtId.Enabled = true;
            txtMedicamentoId.Enabled = true;
            txtEAN.Enabled = true;
            txtProduto.Enabled = true;
            txtPMCBrasindice.Enabled = false;
            txtPrecoAcordo.Enabled = false;
            txtUnidadesCaixa.Enabled = false;
            txtPrecoUnitario.Enabled = false;   
            txtPrecoFabrica.Enabled = false;
            dgvMedicamentos.Enabled = true;

            btnNovo.Enabled = true;
            btnPesquisar.Enabled = true;
            btnSalvar.Enabled = false;
            btnLimpar.Enabled = true;
            btnSair.Enabled = true;
            btnExcluir.Enabled = false;
            btnCalcular.Enabled = false;
            btnCalcularPrecounitario.Enabled = false;    
        }


        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
                "Você tem certeza que deseja Excluir o Preço do Medicamento Selecionado?",
                "Confirmação",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (resultado != DialogResult.Yes)
            {
                return;
            }

            int Id_;

            if (!txtId.Text.IsNullOrEmpty())
            {
                Id_ = Convert.ToInt32(txtId.Text);
                var medicamentoDelete = _context.MedicamentoPreco.Find(Id_);


                if (medicamentoDelete != null)
                {
                    //var receitaItens = _context.ReceitaItens.FirstOrDefault(b => b.MedicamentoId == Id_);
                    //var medicamento = _context.MedicamentoPreco.FirstOrDefault(b => b.MedicamentoId == Id_);

                    //if (medicamentoPreco != null)
                    //{
                    //    MessageBox.Show("Medicamento não pode ser excluído. Tem dados relacionados em Preço Medicamento!");
                    //    return;
                    //}

                    //if (receitaItens != null)
                    //{
                    //    MessageBox.Show("Medicamento não pode ser excluído. Tem dados relacionados em Itens em Receita!");
                    //    return;
                    //}

                    _context.MedicamentoPreco.Remove(medicamentoDelete);
                    _context.SaveChangesAsync();
                    MessageBox.Show("Preço de  Medicamento excluído com sucesso!");

                    Limpar();
                    btnPesquisar_Click(null, null);
                }
                else
                {
                    MessageBox.Show("Preço de Medicamento não encontrado.");
                }
            }
        }


        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            dgvMedicamentos.DataSource = null;

            // Recuperando os filtros dos campos de pesquisa
            string Produto_ = txtProduto.Text;
            string EAN_ = txtEAN.Text;

            // Filtrando os medicamentos conforme o Produto e EAN
            var medicamentosFiltrados = _context.Medicamento.AsQueryable();

            if (!string.IsNullOrEmpty(Produto_))
                medicamentosFiltrados = medicamentosFiltrados.Where(p => p.Produto.Contains(Produto_));

            if (!string.IsNullOrEmpty(EAN_))
                medicamentosFiltrados = medicamentosFiltrados.Where(p => p.EAN.Contains(EAN_));

            // Recuperando os preços dos medicamentos
            var medicamentoPreco = _context.MedicamentoPreco.AsQueryable();

            // Você pode filtrar por MedicamentoPrecoId se necessário
            int? MedicamentoPrecoId_ = string.IsNullOrEmpty(txtId.Text) ? (int?)null : Convert.ToInt32(txtId.Text);
            if (MedicamentoPrecoId_ != null)
                medicamentoPreco = medicamentoPreco.Where(p => p.Id == MedicamentoPrecoId_);

            int? MedicamentoId_ = string.IsNullOrEmpty(txtMedicamentoId.Text) ? (int?)null : Convert.ToInt32(txtMedicamentoId.Text);
            if (MedicamentoId_ != null)
                medicamentoPreco = medicamentoPreco.Where(p => p.MedicamentoId == MedicamentoId_);

            // Realizando o Join entre medicamentos e preços
            var query = from m in medicamentosFiltrados
                        join mp in medicamentoPreco on m.Id equals mp.MedicamentoId
                        select new
                        {
                            Id = mp.Id,
                            MedicamentoId = m.Id,
                            m.Produto,
                            m.EAN,
                            mp.PrecoFabrica,
                            mp.PrecoPmcBrasindice,
                            mp.PrecoAcordado,
                            mp.UnidadesCaixa,
                            mp.PrecoUnitario
                        };

            // Executa a consulta e converte em lista
            var medicamentosComPreco = query.ToList();

            // Define a fonte de dados para o DataGridView
            if (medicamentosComPreco != null && medicamentosComPreco.Count > 0)
                dgvMedicamentos.DataSource = medicamentosComPreco;
            else
                MessageBox.Show("Nenhum medicamento encontrado.");
        }


        private void dgvMedicamentos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvMedicamentos.Rows[e.RowIndex];

                var idCell = row.Cells["Id"];
                var medicamentoIdCell = row.Cells["MedicamentoId"];
                var precoAcordadoCell = row.Cells["precoAcordado"];
                var precoPMCCell = row.Cells["PrecoPmcBrasindice"];
                var precoFabricaCell = row.Cells["PrecoFabrica"];
                var unidadesCaixaCell = row.Cells["UnidadesCaixa"];
                var precoUnitarioCell = row.Cells["PrecoUnitario"];

                if (idCell.Value != null && medicamentoIdCell.Value != null)
                {
                    int id = Convert.ToInt32(idCell.Value);
                    string medicamentoId = medicamentoIdCell.Value.ToString();
                    string precoFabrica = precoFabricaCell.Value.ToString();
                    string precoPMC = precoPMCCell.Value.ToString();
                    string precoAcordado = precoAcordadoCell.Value.ToString();
                    int? unidadesCaixa = unidadesCaixaCell != null ? Convert.ToInt32(unidadesCaixaCell.Value) : null;
                    decimal? precoUnitario = precoUnitarioCell.Value != null ? Convert.ToDecimal(precoUnitarioCell.Value) : null;

                    txtId.Text = id.ToString();
                    txtMedicamentoId.Text = medicamentoId.ToString();
                    txtPrecoFabrica.Text = precoFabrica.ToString();
                    txtPMCBrasindice.Text = precoPMC.ToString();
                    txtPrecoAcordo.Text = precoAcordado.ToString();
                    txtUnidadesCaixa.Text = unidadesCaixa.ToString();
                    txtPrecoUnitario.Text = precoUnitario.ToString();

                    txtId.Enabled = false;
                    txtMedicamentoId.Enabled = true;
                    txtPrecoFabrica.Enabled = true;
                    txtPMCBrasindice.Enabled = true;
                    txtPrecoAcordo.Enabled = false;
                    txtUnidadesCaixa.Enabled = true;
                    txtPrecoUnitario.Enabled = false;
                    dgvMedicamentos.Enabled = true;

                    btnNovo.Enabled = true;
                    btnPesquisar.Enabled = true;
                    btnSalvar.Enabled = true;
                    btnLimpar.Enabled = true;
                    btnSair.Enabled = true;
                    btnExcluir.Enabled = true;
                    btnCalcular.Enabled = true;
                    btnCalcularPrecounitario.Enabled = true;
                }
            }
        }


        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string parametroPacordado;
            var parametros = _context.Parametros.AsQueryable();

            parametros = parametros.Where(p => p.Descricao.Contains("PercentePrecoAcordo"));


            var parametrosList = parametros.ToList();

            bool sucesso = decimal.TryParse(parametrosList[0].Valor, out decimal Valor);
            if (!sucesso)
            {
                Console.WriteLine("Erro no valor. Verifique a tabela de Parâmentro e tente novamente");
            }

            decimal ValorParametros = Valor / 100;

            if (txtPMCBrasindice.Value != 0 && ValorParametros != 0)
            {
                txtPrecoAcordo.Value = txtPMCBrasindice.Value * Convert.ToDecimal(1 - ValorParametros);
                txtPrecoAcordo.Show();

            }
        }


        private void bntCalcularPrecounitario_Click(object sender, EventArgs e)
        {
            if (UtilitariosBLL.limpaString2(txtUnidadesCaixa.Text).IsNullOrEmpty() || txtPrecoAcordo.Value <= 0)
            {
                MessageBox.Show("Preecnha os campos Qtdd Cx e Preço Unitário", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtUnidadesCaixa.Text.Trim() == "0" || txtUnidadesCaixa.Text.IsNullOrEmpty())
            {
                txtUnidadesCaixa.Text = "";
                txtPrecoUnitario.Value = 0;
                txtPrecoUnitario.Show();
                return;
            }
                  
            txtPrecoUnitario.Value = txtPrecoAcordo.Value / Convert.ToDecimal(txtUnidadesCaixa.Text);
            txtPrecoUnitario.Show();

        }





        /*
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
      
            string Produto_ = txtProduto.Text;
            string EAN_ = txtEAN.Text;
            var medicamento = _context.Medicamento.AsQueryable();
            if (!string.IsNullOrEmpty(Produto_)) medicamento = medicamento.Where(p => p.Produto.Contains(Produto_));
            if (!string.IsNullOrEmpty(EAN_)) medicamento = medicamento.Where(p => p.EAN.Contains(EAN_));

            var soMedicamento = medicamento.ToList();

            int? MedicamentoPrecoId_ = txtId.Text.IsNullOrEmpty() ? null : Convert.ToInt32(txtId.Text);
            var medicamentoPreco = _context.MedicamentoPreco.AsQueryable();
            if (MedicamentoPrecoId_ != null) 
                medicamentoPreco = medicamentoPreco.Where(p => p.Id == MedicamentoPrecoId_);

            if (soMedicamento.Count() > 0)
            {
           
                var query = from m in medicamento
                            join mp in medicamentoPreco on m.Id equals mp.MedicamentoId
                            select new
                            {
                                mp.MedicamentoId,
                                m.Produto,
                                m.EAN,
                                mp.Id,
                                mp.PrecoFabrica,
                                mp.PrecoPmcBrasindice,
                                mp.PrecoAcordado
                            };

           
                var medicamentosComPreco = query.ToList();
            }

            var medicamentoPrecox = medicamentoPreco.ToList();
            if (medicamentoPrecox != null) 
                dgvMedicamentos.DataSource = medicamentoPrecox;
        }
        */
    }
}
