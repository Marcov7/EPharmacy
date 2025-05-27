using BLL;
using EPharmacy.Data;
using EPharmacy.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Data;
using System.Runtime.ConstrainedExecution;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

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
            c.Descricao = "<Selecione>";
            sexo.Insert(0, c);
            cboSexo.DataSource = sexo.ToList();
            cboSexo.DisplayMember = "Descricao";
            cboSexo.ValueMember = "Descricao";


            var convenio = _context.Convenio.OrderBy(p => p.Descricao).ToList();
            Convenio f = new Convenio();
            f.Id = 0;
            f.Descricao = "<Selecione>";
            convenio.Insert(0, f);
            cboConvenio.DataSource = convenio.ToList();
            cboConvenio.DisplayMember = "Descricao";
            cboConvenio.ValueMember = "Id";


            var modalidade = _context.Modalidade.OrderBy(p => p.Descricao).ToList();
            Modalidade m = new Modalidade();
            m.Id = 0;
            m.Descricao = "<Selecione>";
            modalidade.Insert(0, m);
            cboModalidadeEntrega.DataSource = modalidade.ToList();
            cboModalidadeEntrega.DisplayMember = "Descricao";
            cboModalidadeEntrega.ValueMember = "Id";


            var tipoEntrega = _context.TipoEntrega.OrderBy(p => p.Descricao).ToList();
            TipoEntrega te = new TipoEntrega();
            te.Id = 0;
            te.Descricao = "<Selecione>";
            tipoEntrega.Insert(0, te);
            cboTipoEntrega.DataSource = tipoEntrega.ToList();
            cboTipoEntrega.DisplayMember = "Descricao";
            cboTipoEntrega.ValueMember = "Id";

            // FIM

            dgvLista.RowTemplate.Height = 18;


            ControlaTrocaMask = false;
            txtCelular.Mask = "(00)00000 - 0000";
            btnTrocarMask.ForeColor = Color.Blue;

            ControlaTrocaMaskTel = false;
            txtTelefone.Mask = "(00)0000 - 0000";
            btnTrocarMaskTel.ForeColor = Color.Blue;
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
            dTPNascimento.Clear();
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
            dTPDataPrimeiroAtendimento.Clear();
            //dTPDataInclusaoConvenio.Value = DateTime.Now;   
            cboModalidadeEntrega.SelectedIndex = 0;
            cboTipoEntrega.SelectedIndex = 0;


            txtCarteirinha.Clear();
            txtMatricula.Clear();
            //dTPValidade.Value = DateTime.Now;
            cboConvenio.SelectedIndex = 0;
            txtAutorizacao.Clear();
            chkAtivo.Checked = true;

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
            //dTPDataInclusaoConvenio.Enabled = false;
            cboModalidadeEntrega.Enabled = false;
            cboTipoEntrega.Enabled = false;

            txtCarteirinha.Enabled = false;
            txtMatricula.Enabled = false;
            //dTPValidade.Enabled = false;
            cboConvenio.Enabled = false;
            txtAutorizacao.Enabled = false;
            chkAtivo.Enabled = false;

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

            try
            {
                int Id_ = Convert.ToInt32(txtId.Text);
                var Delete = _context.Paciente.Find(Id_);

                if (Delete != null)
                {

                    var medicamento = _context.Receita.FirstOrDefault(b => b.PacienteId == Id_);

                    if (medicamento != null)
                    {
                        MessageBox.Show("Paciente não pode ser excluído. Tem dados relacionados entre Receita com Paciente!");
                        return;
                    }

                    _context.Paciente.Remove(Delete);
                    _context.SaveChangesAsync();
                    MessageBox.Show("Paciente excluído com sucesso!");

                    Limpar();
                    btnPesquisar_Click(null, null);
                }
                else
                {

                }
            }
            catch
            {
                MessageBox.Show("Paciente não pode ser excluído.");
            }
        }


        private void btnSalvar_Click(object sender, EventArgs e)
        {

            string retorno = "";
            if (txtNome.Text.IsNullOrEmpty())
            {
                retorno += "Preencha o campo Nome\n";
            }
            /*if (txtNomeSocial.Text.IsNullOrEmpty())
            {
                retorno += "Preencha o campo Nome Social\n";
            }*/
            //if (dTPNascimento.Value.Date == DateTime.Now.Date)
            //{
            //    retorno += "Selecione o campo Data de Nascimento\n";
            //}

            //if (UtilitariosBLL.limpaString2(dTPNascimento.Text.Trim()).IsNullOrEmpty())
            //{
            //    retorno += "Digite a Data de Nascimento\n";
            //}

            if (UtilitariosBLL.ConverterParaData(dTPNascimento.Text.Trim()) >= DateTime.Now.Date)
            {
                retorno += "Digite a Data de Nascimento menor que hoje\n";
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
            //if (txtComplemento.Text.IsNullOrEmpty())
            //{
            //    retorno += "Preencha o campo Complemento\n";
            //}
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
            DateTime? dataTemp = UtilitariosBLL.ConverterParaData(dTPDataPrimeiroAtendimento.Text.Trim());
            if (dataTemp != null && dataTemp.Value.Year < 1900)
            {
                retorno += "Digite a Data Primeiro Atendimento maior que 2015\n";
            }
            /*if (Utilitarios.limpaString(txtCelular.Text).Trim().IsNullOrEmpty())
            {
                retorno += "Preencha o campo Celular\n";
            }
            if (Utilitarios.limpaString(txtTelefone.Text).Trim().IsNullOrEmpty())
            {
                retorno += "Preencha o campo Telefone\n";
            }*/
            if (!txtEmail.Text.IsNullOrEmpty())
            {
                //    retorno += "Preencha o campo Email\n";
                //}
                //else
                //{
                bool isValid = UtilitariosBLL.IsValidEmail(txtEmail.Text);

                if (!isValid)
                {
                    retorno += "Preencha o campo e-mail com um e-mail válido.\n";
                }
            }

            /*if (dTPDataPrimeiroAtendimento.Value.Date == DateTime.Now.Date.Date)
            {
                retorno += "Preencha o campo DataPrimeiroAtendimento\n";
            }*/
            //var cpfExiste = _context.Paciente.FirstOrDefault(p => p.CPF == Utilitarios.limpaString(txtCPF.Text).Trim() && p.Id == Utilitarios.limpaString(txtId.Text).Trim());
            var cpfExiste = _context.Paciente.FirstOrDefault(p => p.CPF == UtilitariosBLL.limpaString(txtCPF.Text).Trim());

            if (cpfExiste != null && cpfExiste.Id != null)
            {
                if (cpfExiste.Id.ToString() != txtId.Text)
                {
                    retorno += "CPF já cadastrado\n";
                }
            }

            if (cboTipoEntrega.SelectedIndex == -1 || cboTipoEntrega.SelectedValue.ToString() == "0")
            {
                retorno += "Selecione o campo Tipo Entrega\n";
            }

            /*if (txtAutorizacao.Text.IsNullOrEmpty())
            {
                retorno += "Preencha o campo Autorização\n";
            }*/

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
            string cpf = UtilitariosBLL.limpaString2(txtCPF.Text).Trim();
            //DateTime dataNascimento = dTPNascimento.Value;
            DateTime? dataNascimento = UtilitariosBLL.ConverterParaData(dTPNascimento.Text);
            string sexo = cboSexo.Text;

            string logradouro = txtLogradouro.Text;
            string numero = txtNumero.Text;
            string bairro = txtBairro.Text;
            string municipio = txtMunicipio.Text;
            string complemento = txtComplemento.Text;
            string uf = txtUF.Text;
            string cep = UtilitariosBLL.limpaString2(txtCEP.Text).Trim();
            string zona = txtZona.Text;

            string telefone = UtilitariosBLL.limpaString2(txtTelefone.Text).Trim();
            string celular = UtilitariosBLL.limpaString2(txtCelular.Text).Trim();
            string email = txtEmail.Text;
            //DateTime dataPrimeiroAtendimento = dTPDataPrimeiroAtendimento.Value;
            DateTime? dataPrimeiroAtendimento = UtilitariosBLL.ConverterParaData(dTPDataPrimeiroAtendimento.Text);

            //DateTime? dataInclusaoConvenio = dTPDataInclusaoConvenio.Value.Date == DateTime.Now.Date ? null : dTPDataInclusaoConvenio.Value.Date;
            int? modalidadeId = Convert.ToInt32(cboModalidadeEntrega.SelectedValue) == 0 ? null : Convert.ToInt32(cboModalidadeEntrega.SelectedValue);

            string carteirinha = txtCarteirinha.Text;
            string matricula = UtilitariosBLL.limpaString2(txtMatricula.Text).Trim();
            //DateTime? validade = dTPValidade.Value.Date == DateTime.Now.Date ? null : dTPValidade.Value.Date;
            int? convenioId = Convert.ToInt32(cboConvenio.SelectedValue) == 0 ? null : Convert.ToInt32(cboConvenio.SelectedValue);
            string autorizacao = txtAutorizacao.Text;
            int TipoEntregaId_ = Convert.ToInt32(cboTipoEntrega.SelectedValue);
            bool ativo = chkAtivo.Checked;

            var insert = new Paciente();
            var update = new Paciente();

            if (txtId.Text.IsNullOrEmpty())
            {
                DateTime? dataPrimeiroAtendimento_ = null; ;
                if (dataPrimeiroAtendimento != null)
                    dataPrimeiroAtendimento_ = dataPrimeiroAtendimento.Value;

                insert = new Paciente
                {
                    Nome = nome,
                    NomeSocial = nomeSocial,
                    CPF = cpf,
                    DataNascimento = dataNascimento.Value,
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
                    DataPrimeiroAtendimento = dataPrimeiroAtendimento_,//.Value,
                                                                       //DataInclusaoConvenio = dataInclusaoConvenio,
                    ModalidadeEntregaId = modalidadeId,


                    ConvenioId = convenioId,
                    Matricula = matricula,
                    Carteirinha = carteirinha,
                    //Validade = validade,
                    Autorizacao = autorizacao,
                    TipoEntregaId = TipoEntregaId_,
                    Ativo = ativo,
                    DataCadastro = DateTime.Now.Date,
                    Usuario = GlobalVariables.LoginId,
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
                //update.DataNascimento = dataNascimento.Value;
                if (UtilitariosBLL.ConverterParaData(dataNascimento.ToString()) != null)
                    update.DataNascimento = UtilitariosBLL.ConverterParaData(dataNascimento.ToString()).Value;
                else
                    update.DataNascimento = null;

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


                if (UtilitariosBLL.ConverterParaData(dataPrimeiroAtendimento.ToString()) != null)
                    update.DataPrimeiroAtendimento = UtilitariosBLL.ConverterParaData(dataPrimeiroAtendimento.ToString()).Value;
                else
                    update.DataPrimeiroAtendimento = null;

                //update.DataInclusaoConvenio = dataInclusaoConvenio;
                update.ModalidadeEntregaId = modalidadeId;

                update.ConvenioId = convenioId;
                update.Matricula = matricula;
                update.Carteirinha = carteirinha;
                //update.Validade = validade;
                update.Autorizacao = autorizacao;
                update.TipoEntregaId = TipoEntregaId_;
                update.Ativo = ativo;

                update.DataCadastro = DateTime.Now;
                update.Usuario = GlobalVariables.LoginId;

                _context.SaveChanges();

                Limpar();

                txtId.Text = Id_.ToString();
                btnPesquisar_Click(null, null);
                txtId.Clear();
            }
            //_context.Entry(entidade).State = EntityState.Modified;
            MessageBox.Show(
                "Paciente Gravado com sucesso",
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
            //DateTime dataNascimento = dTPNascimento.Value.Date;
            DateTime? dataNascimento = UtilitariosBLL.ConverterParaData(dTPNascimento.Text);

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

            if (UtilitariosBLL.ConverterParaData(dTPNascimento.Text) < DateTime.Now.Date)
                lista = lista.Where(p => p.DataNascimento == dataNascimento.Value);
            /*if (dTPNascimento.Value.Date < DateTime.Now.Date) 
                lista = lista.Where(p => 
                p.DataNascimento.Day == dataNascimento.Day &&
                p.DataNascimento.Month == dataNascimento.Month &&
                p.DataNascimento.Year == dataNascimento.Year);*/

            var listax = lista.ToList();

            if (listax != null)
                dgvLista.DataSource = listax;


            dgvLista.Columns["ModalidadeEntregaId"].Visible = chkMostrarIds.Checked;
            dgvLista.Columns["TipoEntregaId"].Visible = chkMostrarIds.Checked;
            dgvLista.Columns["ConvenioId"].Visible = chkMostrarIds.Checked;

            dgvLista.Columns["NomeSocial"].HeaderText = "Nome Social";
            dgvLista.Columns["DataNascimento"].HeaderText = "Dt Nascimento";
            dgvLista.Columns["DataPrimeiroAtendimento"].HeaderText = "Dt Primeiro Atendimento";
            dgvLista.Columns["DataInclusaoConvenio"].HeaderText = "Dt Inclusão Convênio";
            dgvLista.Columns["ModalidadeEntregaId"].HeaderText = "Id Modalid. Entrega";
            dgvLista.Columns["TipoEntregaId"].HeaderText = "Id Tp.Entrega";
            dgvLista.Columns["ConvenioId"].HeaderText = "Id Convênio";
            dgvLista.Columns["DataCadastro"].HeaderText = "Dt Cadastro";
        }


        private void btnNovo_Click(object sender, EventArgs e)
        {
            txtId.Clear();
            txtNome.Clear();
            txtNomeSocial.Clear();
            txtCPF.Clear();
            dTPNascimento.Clear();
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
            dTPDataPrimeiroAtendimento.Clear();
            //dTPDataInclusaoConvenio.Value = DateTime.Now;   
            cboModalidadeEntrega.SelectedIndex = 0;

            txtCarteirinha.Clear();
            txtMatricula.Clear();
            //dTPValidade.Value = DateTime.Now;
            cboConvenio.SelectedIndex = 0;
            txtAutorizacao.Clear();
            cboTipoEntrega.SelectedIndex = 0;
            chkAtivo.Checked = true;

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
            txtMatricula.Enabled = true;
            txtCarteirinha.Enabled = true;
            dTPDataPrimeiroAtendimento.Enabled = true;
            //dTPDataInclusaoConvenio.Enabled = true;
            cboModalidadeEntrega.Enabled = true;

            txtCarteirinha.Enabled = true;
            txtMatricula.Enabled = true;
            //dTPValidade.Enabled = true;
            cboConvenio.Enabled = true;
            txtAutorizacao.Enabled = true;
            cboTipoEntrega.Enabled = true;
            chkAtivo.Enabled = true;

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
                txtZona.Text = endereco.zona;
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

                var dataInclusaoConvenioCell = row.Cells["DataInclusaoConvenio"];
                var modalidadeEntregaIdCell = row.Cells["ModalidadeEntregaId"];

                var matriculaCell = row.Cells["Matricula"];
                var carteirinhaCell = row.Cells["Carteirinha"];

                var convenioCell = row.Cells["ConvenioId"];
                var autorizacaoCell = row.Cells["Autorizacao"];
                var tipoEntregaCell = row.Cells["TipoEntregaId"];
                var ativoCell = row.Cells["Ativo"];

                if (idCell.Value != null && nomeCell.Value != null)
                {
                    int id = Convert.ToInt32(idCell.Value);
                    string nome = nomeCell.Value.ToString();
                    string nomeSocial = nomeSocialCell.Value == null ? "" : nomeSocialCell.Value.ToString();
                    string cpf = UtilitariosBLL.limpaString(cpfCell.Value.ToString());


                    string cep = cepCell.Value.ToString();
                    string logradouro = logradouroCell.Value.ToString();
                    string numero = numeroCell.Value.ToString();
                    string bairro = bairroCell.Value.ToString();
                    string municipio = municipioCell.Value.ToString();
                    string uf = ufCell.Value.ToString();

                    string? complemento = null;
                    if (complementoCell.Value != null)
                        complemento = complementoCell.Value.ToString();

                    string? zona = null;
                    if (zonaCell.Value != null)
                        zona = zonaCell.Value.ToString();

                    string? telefone = null;
                    if (telefoneCell.Value != null)
                        telefone = telefoneCell.Value.ToString();

                    string? celular = null;
                    if (celularCell.Value != null)
                        celular = celularCell.Value.ToString();

                    string email = emailCell.Value.ToString();

                    string? matricula = null;
                    if (matriculaCell.Value != null)
                        matricula = matriculaCell.Value.ToString();

                    string? carteirinha = null;
                    if (carteirinhaCell.Value != null)
                        carteirinha = carteirinhaCell.Value.ToString();

                    //DateTime nascimento = nascimentoCell.Value == null ? DateTime.Now.Date : Convert.ToDateTime(nascimentoCell.Value);
                    //DateTime? nascimento = UtilitariosBLL.ConverterParaData(nascimentoCell.Value.ToString());
                    DateTime? nascimento;
                    if (nascimentoCell.Value != null && UtilitariosBLL.ConverterParaData(nascimentoCell.Value.ToString()) != null)
                        nascimento = UtilitariosBLL.ConverterParaData(nascimentoCell.Value.ToString());
                    else
                        nascimento = null;



                    //DateTime nascimento = Convert.ToDateTime(nascimentoCell.Value);
                    //DateTime dataPrimeiroAtendimento = dataPrimeiroAtendimentoCell.Value == null ? DateTime.Now.Date : Convert.ToDateTime(dataPrimeiroAtendimentoCell.Value);
                    //DateTime? dataPrimeiroAtendimento = UtilitariosBLL.ConverterParaData(dataPrimeiroAtendimentoCell.ToString());
                    DateTime? dataPrimeiroAtendimento;
                    if (dataPrimeiroAtendimentoCell.Value != null && UtilitariosBLL.ConverterParaData(dataPrimeiroAtendimentoCell.Value.ToString()) != null)
                        dataPrimeiroAtendimento = UtilitariosBLL.ConverterParaData(dataPrimeiroAtendimentoCell.Value.ToString());
                    else
                        dataPrimeiroAtendimento = null;


                    // Convert.ToDateTime(dataPrimeiroAtendimentoCell.Value);
                    DateTime validade = validadeCell.Value == null ? DateTime.Now.Date : Convert.ToDateTime(validadeCell.Value);

                    DateTime dataInclusaoConvenio = dataInclusaoConvenioCell.Value == null ? DateTime.Now.Date : Convert.ToDateTime(dataInclusaoConvenioCell.Value);
                    int? modalidadeEntregaId = Convert.ToInt32(modalidadeEntregaIdCell.Value);

                    string sexo = sexoCell.Value.ToString();
                    int? convenio = Convert.ToInt32(convenioCell.Value);
                    string? autorizacao = autorizacaoCell.Value != null ? autorizacaoCell.Value.ToString() : "";
                    int? tipoEntrega = Convert.ToInt32(tipoEntregaCell.Value);
                    bool ativo = Convert.ToBoolean(ativoCell.Value);

                    txtId.Enabled = false;
                    txtId.Text = id.ToString();
                    txtNome.Text = nome;
                    txtNomeSocial.Text = nomeSocial;
                    txtCPF.Text = cpf;
                    dTPNascimento.Text = nascimento.ToString();
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
                    dTPDataPrimeiroAtendimento.Text = dataPrimeiroAtendimento.ToString();
                    //dTPValidade.Value = validade;
                    cboSexo.SelectedValue = sexo;
                    cboConvenio.SelectedValue = convenio;
                    txtAutorizacao.Text = autorizacao;
                    //dTPDataInclusaoConvenio.Value = dataInclusaoConvenio;
                    cboModalidadeEntrega.SelectedValue = modalidadeEntregaId;
                    cboTipoEntrega.SelectedValue = tipoEntrega;
                    chkAtivo.Checked = ativo;

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
                    txtMatricula.Enabled = true;
                    txtCarteirinha.Enabled = true;
                    dTPNascimento.Enabled = true;
                    dTPDataPrimeiroAtendimento.Enabled = true;
                    //dTPValidade.Enabled = true;

                    //dTPDataInclusaoConvenio.Enabled = true;                    
                    cboModalidadeEntrega.Enabled = true;

                    cboSexo.Enabled = true;
                    cboConvenio.Enabled = true;
                    txtAutorizacao.Enabled = true;
                    cboTipoEntrega.Enabled = true;
                    chkAtivo.Enabled = true;

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


        private void chkAumentaLarguraColunasGrid_CheckedChanged(object sender, EventArgs e)
        {
            // fazendo ficar com as colunas autoajuestadas ao tamanho
            if (chkAumentaLarguraColunasGrid.Checked)
                dgvLista.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            else
                dgvLista.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
        }

        private void dTPNascimento_Leave(object sender, EventArgs e)
        {
            if (UtilitariosBLL.limpaString2(dTPNascimento.Text.Trim()).IsNullOrEmpty()) return;
            string userInput = dTPNascimento.Text;
            if (DateTime.TryParse(userInput, out DateTime parsedDate)) { }
            else
            {
                dTPNascimento.Text = "";
                MessageBox.Show("Digite uma Data de Nascimento válida.", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void dTPDataPrimeiroAtendimento_Leave(object sender, EventArgs e)
        {
            if (UtilitariosBLL.limpaString2(dTPDataPrimeiroAtendimento.Text.Trim()).IsNullOrEmpty()) return;
            string userInput = dTPDataPrimeiroAtendimento.Text;
            if (DateTime.TryParse(userInput, out DateTime parsedDate)) { }
            else
            {
                dTPDataPrimeiroAtendimento.Text = "";
                MessageBox.Show("Digite uma Data do Primeiro Atendimento válida.", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        bool ControlaTrocaMask = false;
        private void btnTrocarMask_Click(object sender, EventArgs e)
        {
            if (ControlaTrocaMask)
            {
                txtCelular.Mask = "000000000000000";
                btnTrocarMask.ForeColor = Color.Violet;
            }
            else
            {
                txtCelular.Mask = "(00)00000 - 0000";
                btnTrocarMask.ForeColor = Color.Blue;
            }
            ControlaTrocaMask = !ControlaTrocaMask;
        }


        bool ControlaTrocaMaskTel = false;
        private void btnTrocarMaskTel_Click(object sender, EventArgs e)
        {
            if (ControlaTrocaMaskTel)
            {
                txtTelefone.Mask = "000000000000000";
                btnTrocarMaskTel.ForeColor = Color.Violet;
            }
            else
            {
                txtTelefone.Mask = "(00)0000 - 0000";
                btnTrocarMaskTel.ForeColor = Color.Blue;
            }
            ControlaTrocaMaskTel = !ControlaTrocaMaskTel;
        }


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
