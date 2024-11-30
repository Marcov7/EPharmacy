﻿using BLL;
using EPharmacy;
using EPharmacy.Data;
using EPharmacy.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Data;

namespace ControleEntregada.Forms
{
    public partial class frmMedicamentoPreco : Form
    {
        private readonly EPharmacyContext _context;

        public frmMedicamentoPreco()
        {
            InitializeComponent();

            var optionsBuilder = new DbContextOptionsBuilder<EPharmacyContext>();
            optionsBuilder.UseSqlServer(Program.StrConn());
            _context = new EPharmacyContext(optionsBuilder.Options);
            var x = 0;
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
            txtEAN.Clear();
            txtProduto.Clear();
            txtPMCBrasindice.Clear();
            txtPrecoFabrica.Clear();
            txtPrecoAcordo.Clear();


            txtId.Enabled = false;
            txtEAN.Enabled = true;
            txtProduto.Enabled = true;
            txtPMCBrasindice.Enabled = true;
            txtPrecoFabrica.Enabled = true;
            txtPrecoAcordo.Enabled = true;


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
            decimal precoFabrica_ = Convert.ToDecimal(UtilitariosBLL.limpaString(txtPrecoFabrica.Text));
            decimal precoPMC_ = Convert.ToDecimal(UtilitariosBLL.limpaString(txtPMCBrasindice.Text));
            decimal precoAcordado_ = Convert.ToDecimal(UtilitariosBLL.limpaString(txtPrecoAcordo.Text));

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
                    Usuario = 1,
                    DataCadastro = DateTime.Now.Date,
            };
                _context.MedicamentoPreco.Add(entityNew);
                _context.SaveChanges();
                btnPesquisar_Click(null, null);
            }
            else
            {
                int Id_ = Convert.ToInt32(txtId.Text);
                entityUpdate = _context.MedicamentoPreco.Find(Id_);
                entityUpdate.MedicamentoId = medicamentoId_;
                entityUpdate.PrecoFabrica = precoFabrica_;
                entityUpdate.PrecoAcordado = precoAcordado_;
                entityUpdate.Usuario = 1;
                entityUpdate.DataCadastro = DateTime.Now.Date;
                _context.SaveChanges();
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
            txtEAN.Clear();
            txtProduto.Clear();
            txtPMCBrasindice.Clear();
            txtPrecoAcordo.Clear();
            txtPrecoFabrica.Clear();
            dgvMedicamentos.DataSource = null;

            txtId.Enabled = true;
            txtEAN.Enabled = true;
            txtProduto.Enabled = true;
            txtPMCBrasindice.Enabled = false;
            txtPrecoAcordo.Enabled = false;
            txtPrecoFabrica.Enabled = false;
            dgvMedicamentos.Enabled = true;

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

            if (txtId.Text.IsNullOrEmpty())
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

            // Realizando o Join entre medicamentos e preços
            var query = from m in medicamentosFiltrados
                        join mp in medicamentoPreco on m.Id equals mp.MedicamentoId
                        select new
                        {
                            MedicamentoPrecoId = mp.Id,
                            MedicamentoId = m.Id,
                            m.Produto,
                            m.EAN,
                            PrecoFabrica = mp.PrecoFabrica,
                            PrecoPmcBrasindice = mp.PrecoPmcBrasindice,
                            PrecoAcordado = mp.PrecoAcordado
                        };

            // Executa a consulta e converte em lista
            var medicamentosComPreco = query.ToList();

            // Define a fonte de dados para o DataGridView
            if (medicamentosComPreco != null && medicamentosComPreco.Count > 0)
                dgvMedicamentos.DataSource = medicamentosComPreco;
            else
                MessageBox.Show("Nenhum medicamento encontrado.");
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
