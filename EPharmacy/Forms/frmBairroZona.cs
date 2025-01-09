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
    public partial class frmBairroZona : Form
    {
        private readonly EPharmacyContext _context;
        private int Id;


        public frmBairroZona()
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
            txtBairro.Clear();
            txtMunicipio.Clear();
            txtZona.Clear();
            dgvLista.DataSource = null;

            txtId.Enabled = true;
            txtBairro.Enabled = true;
            txtMunicipio.Enabled = true;
            txtZona.Enabled = true;
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
                "Você tem certeza que deseja Excluir o Fabricante Selecionado?",
                "Confirmação",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (resultado != DialogResult.Yes)
            {
                return;
            }

            int Id_ = Convert.ToInt32(txtId.Text);
            var Delete = _context.Fabricante.Find(Id_);

            if (Delete != null)
            {
                var medicamento = _context.Medicamento.FirstOrDefault(b => b.FabricanteId == Id_);

                if (medicamento != null)
                {
                    MessageBox.Show("Fabricante não pode ser excluído. Tem dados relacionados entre Medicamento com Fabricante!");
                    return;
                }

                _context.Fabricante.Remove(Delete);
                _context.SaveChangesAsync();
                MessageBox.Show("Fabricante excluído com sucesso!");

                Limpar();
                btnPesquisar_Click(null, null);
            }
            else
            {
                MessageBox.Show("Fabricante não encontrado.");
            }
        }


        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string retorno = "";
            if (txtBairro.Text.IsNullOrEmpty())
            {
                retorno += "Preencha o campo Bairro \n";
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

            string bairro = txtBairro.Text;
            string municipio = txtMunicipio.Text;
            string zona = txtZona.Text;

            var TableNew = new BairroZona();
            var TableUpdate = new BairroZona();

            if (txtId.Text.IsNullOrEmpty())
            {
                TableNew = new BairroZona
                {
                    Bairro = bairro,
                    Municipio = municipio,
                    Zona = zona
                };
                _context.BairroZona.Add(TableNew);
                _context.SaveChanges();
                Id = TableNew.Id;
                txtId.Text = Id.ToString();
                Limpar();
                txtId.Text = Id.ToString();
                btnPesquisar_Click(null, null);
                txtId.Clear();
            }
            else
            {
                int Id_ = Convert.ToInt32(txtId.Text);
                TableUpdate = _context.BairroZona.Find(Id_);
                TableUpdate.Bairro = bairro;
                TableUpdate.Municipio = municipio;
                TableUpdate.Zona = zona;
                _context.SaveChanges();
                Limpar();
                txtId.Text = Id_.ToString();
                btnPesquisar_Click(null, null);
                txtId.Clear();
            }

            MessageBox.Show(
                "Bairro Zona Gravado com sucesso",
                "",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation
            );
        }


        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            int? Id_ = txtId.Text.IsNullOrEmpty() ? null : Convert.ToInt32(txtId.Text);
            string bairro = txtBairro.Text;
            string municipio = txtMunicipio.Text;
            string zona = txtZona.Text;

            var entidade = _context.BairroZona.AsQueryable();

            if (Id_ != null)
                entidade = entidade.Where(p => p.Id == Id_);

            if (!string.IsNullOrEmpty(bairro))
                entidade = entidade.Where(p => p.Bairro.Contains(bairro));

            if (!string.IsNullOrEmpty(municipio))
                entidade = entidade.Where(p => p.Municipio.Contains(municipio));

            if (!string.IsNullOrEmpty(zona))
                entidade = entidade.Where(p => p.Zona.Contains(zona));

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
            txtBairro.Clear();
            txtMunicipio.Clear();
            txtZona.Clear();
            dgvLista.DataSource = null;

            txtId.Enabled = false;
            txtBairro.Enabled = true;   
            txtMunicipio.Enabled = true;
            txtZona.Enabled = true;
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
                var bairroCell = row.Cells["Bairro"];
                var municipioCell = row.Cells["municipio"];
                var zonaCell = row.Cells["Zona"];

                if (idCell.Value != null && bairroCell.Value != null)
                {
                    int id = Convert.ToInt32(idCell.Value);
                    string bairro = bairroCell.Value.ToString();
                    string municipio = municipioCell.Value.ToString();
                    string zona = zonaCell.Value.ToString();

                    txtId.Enabled = false;
                    txtId.Text = id.ToString();
                    txtBairro.Text = bairro;
                    txtMunicipio.Text = municipio;
                    txtZona.Text    = zona;

                    txtId.Enabled = false;
                    txtBairro.Enabled = true;
                    txtMunicipio.Enabled = true;
                    txtZona.Enabled = true;

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




