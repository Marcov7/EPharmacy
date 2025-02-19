using BLL;
using EPharmacy.Data;
using EPharmacy.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Data;

namespace EPharmacy.Forms
{
    public partial class frmUsuarioSistema : Form
    {

        private readonly EPharmacyContext _context;
        private int Id;


        public frmUsuarioSistema()
        {
            InitializeComponent();

            var optionsBuilder = new DbContextOptionsBuilder<EPharmacyContext>();
            optionsBuilder.UseSqlServer(Program.StrConn());
            _context = new EPharmacyContext(optionsBuilder.Options);

            // fazendo ficar com as colunas autoajuestadas ao tamanho
            dgvLista.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
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
            txtLogin.Clear();
            txtSenha.Clear();
            txtEmail.Clear();
            dgvLista.DataSource = null;

            txtId.Enabled = true;
            txtNome.Enabled = true;
            txtLogin.Enabled = true;
            txtSenha.Enabled = false;
            txtEmail.Enabled = true;
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
                "Você tem certeza que deseja Excluir o Usuário Selecionado?",
                "Confirmação",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (resultado != DialogResult.Yes)
            {
                return;
            }

            int Id_ = Convert.ToInt32(txtId.Text);
            var Delete = _context.UsuarioSistema.Find(Id_);

            if (Delete != null)
            {
            //    var medicamento = _context.Medicamento.FirstOrDefault(b => b.Usuario == Id_);

            //    if (medicamento != null)
            //    {
            //        MessageBox.Show("Usuário não pode ser excluído. Tem dados relacionados entre Medicamento com Usuário!");
            //        return;
            //    }

                _context.UsuarioSistema.Remove(Delete);
                _context.SaveChangesAsync();
                MessageBox.Show("Usuário excluído com sucesso!");

                Limpar();
                btnPesquisar_Click(null, null);
            }
            else
            {
                MessageBox.Show("Usuário não encontrado.");
            }
        }


        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string retorno = "";
            if (txtNome.Text.IsNullOrEmpty())
            {
                retorno += "Preencha o campo Nome \n";
            }
            if (txtLogin.Text.IsNullOrEmpty())
            {
                retorno += "Preencha o campo Login \n";
            }
            if (txtSenha.Text.IsNullOrEmpty())
            {
                retorno += "Preencha o campo Senha \n";
            }
            if (txtEmail.Text.IsNullOrEmpty())
            {
                retorno += "Preencha o campo Email \n";
            }
            if (!UtilitariosBLL.IsValidEmail( txtEmail.Text))
            {
                retorno += "Preencha o campo Email com uma Email válido \n";
            }

            if (!retorno.IsNullOrEmpty())
            {
                MessageBox.Show(retorno, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            string Nome_ = txtNome.Text;
            string Login_ = txtLogin.Text;
            string Senha_ = txtSenha.Text;
            string Email_ = txtEmail.Text;

            var entityNew = new UsuarioSistema();
            var entityUpdate = new UsuarioSistema();

            if (txtId.Text.IsNullOrEmpty())
            {
                retorno = "";
                var LoginExistente = _context.UsuarioSistema.FirstOrDefault(b => b.Login == Login_);
                if (LoginExistente != null)
                {
                    retorno += "Preencha o campo Login com um Login novo \n";
                }
                if (!UtilitariosBLL.ContemNumeroLetraCaractereEspecialRegex(Senha_))
                {
                    retorno += "Preencha o campo Senha com Número, Caracater Especial e Letra \n";
                }
                if (!UtilitariosBLL.Contem6Caracteres(Senha_))
                {
                    retorno += "Preencha o campo Senha com 6 caracteres \n";
                }
                var EmailExistente = _context.UsuarioSistema.FirstOrDefault(b => b.Email == Email_);
                if (EmailExistente != null)
                {
                    retorno += "Preencha o campo Email com um Email novo \n";
                }

                if (!retorno.IsNullOrEmpty())
                {
                    MessageBox.Show(retorno, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                entityNew = new UsuarioSistema
                {
                    Nome = Nome_,
                    Login = Login_,
                    Senha = Senha_,
                    Email = Email_,
                    DataCadastro = DateTime.Now,
                    Usuario = GlobalVariables.LoginId,
                };
                _context.UsuarioSistema.Add(entityNew);
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

                retorno = "";
                var LoginExistente = _context.UsuarioSistema.FirstOrDefault(b => b.Login == Login_ && b.Id != Id_);
                if (LoginExistente != null)
                {
                    retorno += "Preencha o campo Login com um Login novo \n";
                }
                if (!UtilitariosBLL.ContemNumeroLetraCaractereEspecialRegex(Senha_))
                {
                    retorno += "Preencha o campo Senha com Número, Caracater Especial e Letra \n";
                }
                if (!UtilitariosBLL.Contem6Caracteres(Senha_))
                {
                    retorno += "Preencha o campo Senha com 6 caracteres \n";
                }
                var EmailExistente = _context.UsuarioSistema.FirstOrDefault(b => b.Email == Email_ && b.Id != Id_);
                if (EmailExistente != null)
                {
                    retorno += "Preencha o campo Email com um Email novo \n";
                }

                if (!retorno.IsNullOrEmpty())
                {
                    MessageBox.Show(retorno, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                entityUpdate = _context.UsuarioSistema.Find(Id_);
                entityUpdate.Nome = Nome_;
                entityUpdate.Login = Login_;
                entityUpdate.Senha = Senha_;
                entityUpdate.Email = Email_;
                entityUpdate.DataCadastro = DateTime.Now;
                entityUpdate.Usuario = GlobalVariables.LoginId;

                _context.SaveChanges();
                Limpar();
                txtId.Text = Id_.ToString();
                btnPesquisar_Click(null, null);
                txtId.Clear();
            }

            MessageBox.Show(
                "Usuário Gravado com sucesso",
                "",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation
            );
        }


        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            int? Id_ = txtId.Text.IsNullOrEmpty() ? null : Convert.ToInt32(txtId.Text);
            string Nome_ = txtNome.Text;
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
            txtNome.Clear();
            txtLogin.Clear();
            txtSenha.Clear();
            txtEmail.Clear();
            dgvLista.DataSource = null;

            txtId.Enabled = false;
            txtNome.Enabled = true;
            txtLogin.Enabled = true;
            txtSenha.Enabled = true;
            txtEmail.Enabled = true;
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
                    txtNome.Text = nome;
                    txtLogin.Text = login;
                    txtSenha.Text = senha;
                    txtEmail.Text = email;

                    txtId.Enabled = false;
                    txtNome.Enabled = true;
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
