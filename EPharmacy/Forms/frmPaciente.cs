using BLL;
using EPharmacy.Data;
using EPharmacy.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Data;
using System.Runtime.ConstrainedExecution;
using System.Threading.Tasks;

namespace EPharmacy.Forms
{
    public partial class frmPaciente : Form
    {
        private readonly EPharmacyContext _context;
        private int Id;
        private ViaCepService _viaCepService;


        public frmPaciente()
        {
            InitializeComponent();

            var optionsBuilder = new DbContextOptionsBuilder<EPharmacyContext>();
            optionsBuilder.UseSqlServer(Program.StrConn());
            _context = new EPharmacyContext(optionsBuilder.Options);

            _viaCepService = new ViaCepService();
        }



        private void frmPaciente_Load(object sender, EventArgs e)
        {
            // PREENCHE COMBOS INICIO
            var sexo = _context.Sexo.OrderBy(p => p.Descricao).ToList();
            Sexo c = new Sexo();
            //c.Id = 0;
            c.Descricao = "<Selecione uma opção>";
            sexo.Insert(0, c);
            cboSexo.DataSource = sexo.ToList();
            cboSexo.DisplayMember = "Descricao";
            cboSexo.ValueMember = "Descricao";


            var convenio = _context.Convenio.OrderBy(p => p.Descricao).ToList();
            Convenio f = new Convenio();
            f.Id = 0;
            f.Descricao = "<Selecione uma opção>";
            convenio.Insert(0, f);
            cboConvenio.DataSource = convenio.ToList();
            cboConvenio.DisplayMember = "Descricao";
            cboConvenio.ValueMember = "Id";
            // FIM
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
            txtZona.Clear();
            txtCelular.Clear();
            txtTelefone.Clear();
            txtEmail.Clear();
            dTPDataPrimeiroAtendimento.Value = DateTime.Now;

            txtCarteirinha.Clear();
            txtMatricula.Clear();
            dTPValidade.Value = DateTime.Now;
            cboConvenio.SelectedIndex = 0;
            txtAutorizacao.Clear();

            dgvLista.DataSource = null;

            txtId.Enabled = true;
            txtNome.Enabled = true;
            txtNomeSocial.Enabled = true;
            txtCPF.Enabled = true;
            dTPNascimento.Enabled = true;
            cboSexo.Enabled = false;
            txtLogradouro.Enabled = false;
            txtNumero.Enabled = false;
            txtBairro.Enabled = false;
            txtMunicipio.Enabled = false;
            txtComplemento.Enabled = false;
            txtUF.Enabled = false;
            txtCEP.Enabled = false;
            txtZona.Enabled = false;
            txtCelular.Enabled = false;
            txtTelefone.Enabled = false;
            txtEmail.Enabled = false;
            dTPDataPrimeiroAtendimento.Enabled = false;

            txtCarteirinha.Enabled = false;
            txtMatricula.Enabled = false;
            dTPValidade.Enabled = false;
            cboConvenio.Enabled = false;
            txtAutorizacao.Enabled = false;

            dgvLista.Enabled = true;

            btnNovo.Enabled = true;
            btnPesquisar.Enabled = true;
            btnSalvar.Enabled = false;
            btnLimpar.Enabled = true;
            btnSair.Enabled = true;
            btnExcluir.Enabled = false;

            btnBuscar.Enabled = false;
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
            if (UtilitariosBLL.limpaString(txtCPF.Text).Trim().IsNullOrEmpty())
            {
                retorno += "Preencha o campo CPF\n";
            }
            if (!UtilitariosBLL.Validar(UtilitariosBLL.limpaString(txtCPF.Text)))
            {
                retorno += "Preencha o campo CPF com um CPF válido\n";
            }
            if (cboSexo.SelectedIndex == 0)
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
            if (UtilitariosBLL.limpaString(txtCEP.Text).Trim().IsNullOrEmpty())
            {
                retorno += "Preencha o campo CEP\n";
            }
            if (txtZona.Text.IsNullOrEmpty())
            {
                retorno += "Preencha o campo Zona\n";
            }
            /*if (Utilitarios.limpaString(txtCelular.Text).Trim().IsNullOrEmpty())
            {
                retorno += "Preencha o campo Celular\n";
            }
            if (Utilitarios.limpaString(txtTelefone.Text).Trim().IsNullOrEmpty())
            {
                retorno += "Preencha o campo Telefone\n";
            }*/
            if (txtEmail.Text.IsNullOrEmpty())
            {
                retorno += "Preencha o campo Email\n";
            }
            else
            {
                bool isValid = UtilitariosBLL.IsValidEmail(txtEmail.Text);

                if (!isValid)
                {
                    retorno += "Preencha o campo e-mail com um e-mail válido.\n";
                }
            }

            if (dTPDataPrimeiroAtendimento.Value.Date == DateTime.Now.Date.Date)
            {
                retorno += "Preencha o campo DataPrimeiroAtendimento\n";
            }
            //var cpfExiste = _context.Paciente.FirstOrDefault(p => p.CPF == Utilitarios.limpaString(txtCPF.Text).Trim() && p.Id == Utilitarios.limpaString(txtId.Text).Trim());
            var cpfExiste = _context.Paciente.FirstOrDefault(p => p.CPF == UtilitariosBLL.limpaString(txtCPF.Text).Trim());

            if (cpfExiste != null && cpfExiste.Id != null)
            {
                if (cpfExiste.Id.ToString() != txtId.Text)
                {
                    retorno += "CPF já cadastrado\n";
                }
            }
            if (txtAutorizacao.Text.IsNullOrEmpty())
            {
                retorno += "Preencha o campo Autorização\n";
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
            string cpf = UtilitariosBLL.limpaString(txtCPF.Text).Trim();
            DateTime dataNascimento = dTPNascimento.Value;
            string sexo = cboSexo.Text;

            string logradouro = txtLogradouro.Text;
            string numero = txtNumero.Text;
            string bairro = txtBairro.Text;
            string municipio = txtMunicipio.Text;
            string complemento = txtComplemento.Text;
            string uf = txtUF.Text;
            string cep = UtilitariosBLL.limpaString(txtCEP.Text).Trim();
            string zona = txtZona.Text;

            string telefone = UtilitariosBLL.limpaString(txtTelefone.Text).Trim();
            string celular = UtilitariosBLL.limpaString(txtCelular.Text).Trim();
            string email = txtEmail.Text;
            DateTime dataPrimeiroAtendimento = dTPDataPrimeiroAtendimento.Value;

            string carteirinha = txtCarteirinha.Text;
            string matricula = UtilitariosBLL.limpaString(txtMatricula.Text).Trim();
            DateTime? validade = dTPValidade.Value.Date == DateTime.Now.Date ? null : dTPValidade.Value.Date;
            int? convenioId = Convert.ToInt32(cboConvenio.SelectedValue) == 0 ? null : Convert.ToInt32(cboConvenio.SelectedValue);
            string autorizacao = txtAutorizacao.Text;

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
                    Zona = zona,
                    Celular = celular,
                    Telefone = telefone,
                    Email = email,
                    DataPrimeiroAtendimento = dataPrimeiroAtendimento,

                    ConvenioId = convenioId,
                    Matricula = matricula,
                    Carteirinha = carteirinha,
                    Validade = validade,
                    Autorizacao = autorizacao,

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
                update.Zona = zona;

                update.Celular = celular;
                update.Telefone = telefone;
                update.Email = email;
                update.DataPrimeiroAtendimento = dataPrimeiroAtendimento;

                update.ConvenioId = convenioId;
                update.Matricula = matricula;
                update.Carteirinha = carteirinha;
                update.Validade = validade;
                update.Autorizacao = autorizacao;

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
            string cpf = UtilitariosBLL.limpaString(txtCPF.Text).Trim();
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
            txtZona.Clear();
            txtCelular.Clear();
            txtTelefone.Clear();
            txtEmail.Clear();
            txtMatricula.Clear();
            txtCarteirinha.Clear();
            dTPDataPrimeiroAtendimento.Value = DateTime.Now;

            txtCarteirinha.Clear();
            txtMatricula.Clear();
            dTPValidade.Value = DateTime.Now;
            cboConvenio.SelectedIndex = 0;
            txtAutorizacao.Clear();

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
            txtZona.Enabled = true;
            txtCelular.Enabled = true;
            txtTelefone.Enabled = true;
            txtEmail.Enabled = true;
            txtMatricula.Enabled    = true;
            txtCarteirinha.Enabled = true;
            dTPDataPrimeiroAtendimento.Enabled = true;

            txtCarteirinha.Enabled = true;
            txtMatricula.Enabled = true;
            dTPValidade.Enabled = true;
            cboConvenio.Enabled = true;
            txtAutorizacao.Enabled = true;

            dgvLista.Enabled = true;

            btnNovo.Enabled = false;
            btnPesquisar.Enabled = false;
            btnSalvar.Enabled = true;
            btnLimpar.Enabled = true;
            btnSair.Enabled = true;
            btnExcluir.Enabled = false;

            btnBuscar.Enabled = true;
        }


        private async void btnBuscar_Click(object sender, EventArgs e)
        {
            if (UtilitariosBLL.limpaString(txtCEP.Text).Trim().IsNullOrEmpty())
            {
                MessageBox.Show("Preencha o campo CEP para esta operação\n", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            Endereco endereco = await _viaCepService.BuscarEnderecoAsync(UtilitariosBLL.limpaString(txtCEP.Text));

            if (endereco != null)
            {
                txtLogradouro.Text = endereco.logradouro;
                txtBairro.Text = endereco.bairro;
                txtMunicipio.Text = endereco.localidade;
                txtUF.Text = endereco.uf;
            }

        }


        private void dgvLista_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvLista.Rows[e.RowIndex];

                var idCell = row.Cells["Id"];
                var nomeCell = row.Cells["Nome"];
                var nomeSocialCell = row.Cells["NomeSocial"];
                var cpfCell = row.Cells["CPF"];
                var nascimentoCell = row.Cells["DataNascimento"];
                var dataPrimeiroAtendimentoCell = row.Cells["DataPrimeiroAtendimento"];
                var validadeCell = row.Cells["Validade"];
                var sexoCell = row.Cells["Sexo"];
                var cepCell = row.Cells["CEP"];
                var logradouroCell = row.Cells["Logradouro"];
                var numeroCell = row.Cells["Numero"];
                var bairroCell = row.Cells["Bairro"];
                var municipioCell = row.Cells["Municipio"];
                var ufCell = row.Cells["Uf"];
                var complementoCell = row.Cells["Complemento"];
                var zonaCell = row.Cells["Zona"];
                var telefoneCell = row.Cells["Telefone"];
                var celularCell = row.Cells["Celular"];
                var emailCell = row.Cells["Email"];

                var matriculaCell = row.Cells["Matricula"];
                var carteirinhaCell = row.Cells["Carteirinha"];

                var convenioCell = row.Cells["ConvenioId"];
                var autorizacaoCell = row.Cells["Autorizacao"];


                if (idCell.Value != null && nomeCell.Value != null)
                {
                    int id = Convert.ToInt32(idCell.Value);
                    string nome = nomeCell.Value.ToString();
                    string nomeSocial = nomeSocialCell.Value.ToString();
                    string cpf = UtilitariosBLL.limpaString(cpfCell.Value.ToString());


                    string cep = cepCell.Value.ToString();
                    string logradouro = logradouroCell.Value.ToString();
                    string numero = numeroCell.Value.ToString();
                    string bairro = bairroCell.Value.ToString();
                    string municipio = municipioCell.Value.ToString();
                    string uf = ufCell.Value.ToString();

                    string? complemento = null;
                    if(complementoCell.Value != null)
                       complemento = complementoCell.Value.ToString();

                    string? zona = null;
                    if(zonaCell.Value != null)
                       zona = zonaCell.Value.ToString();
                    
                    string? telefone = null;
                    if(telefoneCell.Value != null)
                       telefone = telefoneCell.Value.ToString();

                    string? celular = null;
                    if(celularCell.Value != null)
                       celular = celularCell.Value.ToString();

                    string email = emailCell.Value.ToString();

                    string ? matricula = null;
                    if(matriculaCell.Value != null)
                       matricula = matriculaCell.Value.ToString();

                    string ? carteirinha = null;
                    if(carteirinhaCell.Value != null)
                       carteirinha = carteirinhaCell.Value.ToString();

                    DateTime nascimento = nascimentoCell.Value == null ? DateTime.Now.Date : Convert.ToDateTime(nascimentoCell.Value);
                    //DateTime nascimento = Convert.ToDateTime(nascimentoCell.Value);
                    DateTime dataPrimeiroAtendimento = dataPrimeiroAtendimentoCell.Value == null ? DateTime.Now.Date : Convert.ToDateTime(dataPrimeiroAtendimentoCell.Value);
                    // Convert.ToDateTime(dataPrimeiroAtendimentoCell.Value);
                    DateTime validade = validadeCell.Value == null ? DateTime.Now.Date :  Convert.ToDateTime(validadeCell.Value);

                    string sexo = sexoCell.Value.ToString();
                    int ? convenio = Convert.ToInt32(convenioCell.Value);
                    string? autorizacao = autorizacaoCell.Value != null ? autorizacaoCell.Value.ToString() : "";

                    txtId.Enabled = false;
                    txtId.Text = id.ToString();
                    txtNome.Text = nome;
                    txtNomeSocial.Text = nomeSocial;
                    txtCPF.Text = cpf;
                    dTPNascimento.Value = nascimento;
                    txtCEP.Text = cep;
                    txtLogradouro.Text = logradouro;
                    txtNumero.Text = numero;
                    txtBairro.Text = bairro;
                    txtMunicipio.Text = municipio;
                    txtUF.Text = uf;
                    txtComplemento.Text = complemento;
                    txtZona.Text = zona;
                    txtTelefone.Text = telefone;
                    txtCelular.Text = celular;
                    txtEmail.Text = email;
                    txtMatricula.Text = matricula;
                    txtCarteirinha.Text = carteirinha;
                    dTPDataPrimeiroAtendimento.Value = dataPrimeiroAtendimento;
                    dTPValidade.Value = validade;
                    cboSexo.SelectedValue = sexo;
                    cboConvenio.SelectedValue = convenio;
                    txtAutorizacao.Text = autorizacao;            


                    txtId.Enabled = false;
                    txtNome.Enabled = true;
                    txtNomeSocial.Enabled = true;
                    txtCPF.Enabled = true;
                    txtCEP.Enabled = true;
                    txtLogradouro.Enabled = true;
                    txtNumero.Enabled = true;
                    txtBairro.Enabled = true;
                    txtMunicipio.Enabled = true;
                    txtUF.Enabled = true;
                    txtComplemento.Enabled = true;
                    txtZona.Enabled = true;
                    txtTelefone.Enabled = true;
                    txtCelular.Enabled = true;
                    txtEmail.Enabled = true;
                    txtMatricula.Enabled    = true;
                    txtCarteirinha.Enabled  = true;
                    dTPNascimento.Enabled = true;
                    dTPDataPrimeiroAtendimento.Enabled = true;
                    dTPValidade.Enabled = true;

                    cboSexo.Enabled = true;
                    cboConvenio.Enabled = true;
                    txtAutorizacao.Enabled = true;

                    dgvLista.Enabled = true;

                    btnNovo.Enabled = true;
                    btnPesquisar.Enabled = true;
                    btnSalvar.Enabled = true;
                    btnLimpar.Enabled = true;
                    btnSair.Enabled = true;
                    btnExcluir.Enabled = true;
                    btnBuscar.Enabled = true;
                }
            }
        }

    }
}
