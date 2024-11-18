using BLL;
using EPharmacy.Data;
using EPharmacy.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace EPharmacy.Forms
{
    public partial class frmPaciente : Form
    {
        private readonly EPharmacyContext _context;
        private int Id;

        public frmPaciente()
        {
            InitializeComponent();

            var optionsBuilder = new DbContextOptionsBuilder<EPharmacyContext>();
            optionsBuilder.UseSqlServer(Program.StrConn());
            _context = new EPharmacyContext(optionsBuilder.Options);
        }


        private void frmPaciente_Load(object sender, EventArgs e)
        {
            // PREENCHE COMBOS INICIO
            var sexo = _context.Sexo.OrderBy(p => p.Descricao).ToList();
            Sexo c = new Sexo();
            c.Id = 0;
            c.Descricao = "<Selecione uma opção>";
            sexo.Insert(0, c);
            cboSexo.DataSource = sexo.ToList();
            cboSexo.DisplayMember = "Descricao";
            cboSexo.ValueMember = "Id";
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
            txtNomeSocial.Clear();
            txtCPF.Clear();
            dTPNascimento.Value = DateTime.Now;
            cboSexo.SelectedIndex = 0;
            txtLogradouro.Clear();
            txtNumero.Clear();
            txtBairro.Clear();
            txtMunicipio.Clear();
            txtComplemento.Clear();
            txtUF.Clear();
            txtCEP.Clear();
            txtTelefone.Clear();
            txtEmail.Clear();
            dTPDataPrimeiroAtendimento.Value = DateTime.Now;
            dgvLista.DataSource = null;

            txtId.Enabled = true;
            txtNome.Enabled = true;
            txtNomeSocial.Enabled = true;
            txtCPF.Enabled = true;
            dTPNascimento.Enabled = true;
            cboSexo.Enabled = true;
            txtLogradouro.Enabled = true;
            txtNumero.Enabled = true;
            txtBairro.Enabled = true;
            txtMunicipio.Enabled = true;
            txtComplemento.Enabled = true;
            txtUF.Enabled = true;
            txtCEP.Enabled = true;
            txtTelefone.Enabled = true;
            txtEmail.Enabled = true;
            dTPDataPrimeiroAtendimento.Enabled = false;
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
                  "Você tem certeza que deseja Excluir o Paciente Selecionado?",
                  "Confirmação",
                  MessageBoxButtons.YesNo,
                  MessageBoxIcon.Question
            );

            if (resultado != DialogResult.Yes)
            {
                return;
            }

            int Id_ = Convert.ToInt32(txtId.Text);
            var Delete = _context.Paciente.Find(Id_);

            if (Delete != null)
            {
                /*
                var medicamento = _context.Paciente.FirstOrDefault(b => b.PacienteId == Id_);

                if (medicamento != null)
                {
                    MessageBox.Show("Paciente não pode ser excluído. Tem dados relacionados entre Medicamento com Paciente!");
                    return;
                }*/

                _context.Paciente.Remove(Delete);
                _context.SaveChangesAsync();
                MessageBox.Show("Paciente excluído com sucesso!");

                Limpar();
                btnPesquisar_Click(null, null);
            }
            else
            {
                MessageBox.Show("Paciente não encontrado.");
            }
        }


        private void btnSalvar_Click(object sender, EventArgs e)
        {

            string retorno = "";
            if (txtNome.Text.IsNullOrEmpty())
            {
                retorno += "Preencha o campo Nome\n";
            }
            if (txtNomeSocial.Text.IsNullOrEmpty())
            {
                retorno += "Preencha o campo Nome Social\n";
            }
            if (dTPNascimento.Value.Date == DateTime.Now.Date)
            {
                retorno += "Selecione o campo Data de Nascimento\n";
            }
            if (Utilitarios.limpaString(txtCPF.Text).Trim().IsNullOrEmpty())
            {
                retorno += "Preencha o campo CPF\n";
            }
            if (!Utilitarios.Validar(Utilitarios.limpaString(txtCPF.Text)))
            {
                retorno += "Preencha o campo CPF com um CPF válido\n";
            }
            if (cboSexo.SelectedIndex == -1 || cboSexo.SelectedValue.ToString() == "0")
            {
                retorno += "Selecione o campo Sexo\n";
            }           
            if (txtLogradouro.Text.IsNullOrEmpty())
            {
                retorno += "Preencha o campo Logradouro\n";
            }
            if (txtNumero.Text.IsNullOrEmpty())
            {
                retorno += "Preencha o campo Numero\n";
            }
            if (txtBairro.Text.IsNullOrEmpty())
            {
                retorno += "Preencha o campo Bairro\n";
            }
            if (txtMunicipio.Text.IsNullOrEmpty())
            {
                retorno += "Preencha o campo Municipio\n";
            }
            if (txtComplemento.Text.IsNullOrEmpty())
            {
                retorno += "Preencha o campo Complemento\n";
            }
            if (txtUF.Text.IsNullOrEmpty())
            {
                retorno += "Preencha o campo Uf\n";
            }
            if (Utilitarios.limpaString(txtCEP.Text).Trim().IsNullOrEmpty())
            {
                retorno += "Preencha o campo CEP\n";
            }
            if (Utilitarios.limpaString(txtTelefone.Text).Trim().IsNullOrEmpty())
            {
                retorno += "Preencha o campo Telefone\n";
            }
            if (txtEmail.Text.IsNullOrEmpty())
            {
                retorno += "Preencha o campo Email\n";
            }
            if (dTPDataPrimeiroAtendimento.Value.Date == DateTime.Now.Date.Date)
            {
                retorno += "Preencha o campo DataPrimeiroAtendimento\n";
            }
            var cpfExiste = _context.Paciente.FirstOrDefault(p => p.CPF == Utilitarios.limpaString(txtCPF.Text).Trim()) ;
            if (cpfExiste != null)
            {
                retorno += "CPF já cadastrado\n";
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

            string nome = txtNome.Text;
            string nomeSocial = txtNomeSocial.Text;
            string cpf = Utilitarios.limpaString(txtCPF.Text).Trim();
            DateTime dataNascimento = dTPNascimento.Value;
            string sexo = cboSexo.Text;

            string logradouro = txtLogradouro.Text;
            string numero = txtNumero.Text;
            string bairro = txtBairro.Text;
            string municipio = txtMunicipio.Text;
            string complemento = txtComplemento.Text;
            string uf = txtUF.Text;
            string cep = Utilitarios.limpaString(txtCEP.Text).Trim();

            string telefone = Utilitarios.limpaString(txtTelefone.Text).Trim();
            string email = txtEmail.Text;
            DateTime dataPrimeiroAtendimento = dTPDataPrimeiroAtendimento.Value;

            var insert = new Paciente();
            var update = new Paciente();

            if (txtId.Text.IsNullOrEmpty())
            {
                insert = new Paciente
                {
                    Nome = nome,
                    NomeSocial = nomeSocial,
                    CPF = cpf,
                    DataNascimento = dataNascimento,
                    Sexo = sexo,
                    Logradouro = logradouro,
                    Numero = numero,
                    Bairro = bairro,    
                    Municipio = municipio,  
                    Uf = uf,
                    Complemento = complemento,
                    CEP = cep,
                    Telefone = telefone,    
                    Email = email, 
                    DataPrimeiroAtendimento=    dataPrimeiroAtendimento,
                    DataCadastro = DateTime.Now.Date,
                    Usuario = 1,
                };

                /*    */
                  
                  
                  
                 
                /*    */
                _context.Paciente.Add(insert);
                _context.SaveChanges();
                Id = insert.Id;
                txtId.Text = Id.ToString();

                Limpar();

                txtId.Text = Id.ToString();
                btnPesquisar_Click(null, null);
                txtId.Clear();
            }
            else
            {
                int Id_ = Convert.ToInt32(txtId.Text);
                update = _context.Paciente.Find(Id_);

                update.Nome = nome;
                update.NomeSocial = nomeSocial;
                update.CPF = cpf;
                update.DataNascimento = dataNascimento;
                update.Sexo = sexo;

                update.Logradouro = logradouro;
                update.Numero = numero;
                update.Bairro = bairro;
                update.Municipio = municipio;
                update.Complemento = complemento;
                update.Uf = uf;
                update.CEP = cep;

                update.Telefone = telefone; 
                update.Email = email;
                update.DataPrimeiroAtendimento = dataPrimeiroAtendimento;
                update.DataCadastro = DateTime.Now;
                update.Usuario = 1;

                _context.SaveChanges();

                Limpar();

                txtId.Text = Id_.ToString();
                btnPesquisar_Click(null, null);
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


        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            int? Id_ = txtId.Text.IsNullOrEmpty() ? null : Convert.ToInt32(txtId.Text);
            string nome = txtNome.Text;
            string nomeSocial = txtNomeSocial.Text;
            string cpf = Utilitarios.limpaString(txtCPF.Text).Trim();
            DateTime dataNascimento = dTPNascimento.Value.Date;
      

            var lista = _context.Paciente.AsQueryable();

            //if (!string.IsNullOrEmpty(cpf) && !Utilitarios.Validar(cpf))
            //{
            //    MessageBox.Show("Preencha o campo CPF com um CPF válido\n", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //} 

            if (Id_ != null)
                lista = lista.Where(p => p.Id == Id_);

            if (!string.IsNullOrEmpty(nome))
                lista = lista.Where(p => p.Nome.Contains(nome));

            if (!string.IsNullOrEmpty(nomeSocial))
                lista = lista.Where(p => p.NomeSocial.Contains(nomeSocial));

            if (!string.IsNullOrEmpty(cpf))
                lista = lista.Where(p => p.CPF.Contains(cpf));

            if (dTPNascimento.Value.Date < DateTime.Now.Date)
                lista = lista.Where(p => p.DataNascimento.Date == dataNascimento.Date);
            /*if (dTPNascimento.Value.Date < DateTime.Now.Date) 
                lista = lista.Where(p => 
                p.DataNascimento.Day == dataNascimento.Day &&
                p.DataNascimento.Month == dataNascimento.Month &&
                p.DataNascimento.Year == dataNascimento.Year);*/

            var listax = lista.ToList();

            if (listax != null)
                dgvLista.DataSource = listax;

        }


        private void btnNovo_Click(object sender, EventArgs e)
        {
            txtId.Clear();
            txtNome.Clear();
            txtNomeSocial.Clear();
            txtCPF.Clear();
            dTPNascimento.Value = DateTime.Now;
            cboSexo.SelectedIndex = 0;
            txtLogradouro.Clear();
            txtNumero.Clear();
            txtBairro.Clear();
            txtMunicipio.Clear();
            txtComplemento.Clear();
            txtUF.Clear();
            txtCEP.Clear();
            txtTelefone.Clear();
            txtEmail.Clear();
            dTPDataPrimeiroAtendimento.Value = DateTime.Now;
            dgvLista.DataSource = null;

            txtId.Enabled = false;
            txtNome.Enabled = true;
            txtNomeSocial.Enabled = true;
            txtCPF.Enabled = true;
            dTPNascimento.Enabled = true;
            cboSexo.Enabled = true;
            txtLogradouro.Enabled = true;
            txtNumero.Enabled = true;
            txtBairro.Enabled = true;
            txtMunicipio.Enabled = true;
            txtComplemento.Enabled = true;
            txtUF.Enabled = true;
            txtCEP.Enabled = true;
            txtTelefone.Enabled = true;
            txtEmail.Enabled = true;
            dTPDataPrimeiroAtendimento.Enabled = true;
            dgvLista.Enabled = true;

            btnNovo.Enabled = false;
            btnPesquisar.Enabled = false;
            btnSalvar.Enabled = true;
            btnLimpar.Enabled = true;
            btnSair.Enabled = true;
            btnExcluir.Enabled = false;
        }

    }
}
