namespace EPharmacy.Forms
{
    partial class frmPaciente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnPesquisar = new Button();
            btnNovo = new Button();
            btnExcluir = new Button();
            btnSalvar = new Button();
            btnLimpar = new Button();
            btnSair = new Button();
            dgvLista = new DataGridView();
            label3 = new Label();
            label2 = new Label();
            label6 = new Label();
            label5 = new Label();
            label8 = new Label();
            label1 = new Label();
            label4 = new Label();
            label7 = new Label();
            txtLogradouro = new TextBox();
            txtNomeSocial = new TextBox();
            dTPNascimento = new DateTimePicker();
            cboSexo = new ComboBox();
            txtNome = new TextBox();
            txtId = new MaskedTextBox();
            txtComplemento = new TextBox();
            txtUF = new TextBox();
            txtEmail = new TextBox();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            txtNumero = new TextBox();
            label12 = new Label();
            txtBairro = new TextBox();
            label13 = new Label();
            txtMunicipio = new TextBox();
            label14 = new Label();
            txtCPF = new MaskedTextBox();
            txtCEP = new MaskedTextBox();
            label15 = new Label();
            txtCelular = new MaskedTextBox();
            dTPDataPrimeiroAtendimento = new DateTimePicker();
            label16 = new Label();
            txtCarteirinha = new TextBox();
            label17 = new Label();
            txtMatricula = new MaskedTextBox();
            label18 = new Label();
            label20 = new Label();
            cboConvenio = new ComboBox();
            txtAutorizacao = new TextBox();
            label21 = new Label();
            txtZona = new TextBox();
            label22 = new Label();
            btnBuscar = new Button();
            txtTelefone = new MaskedTextBox();
            label23 = new Label();
            cboModalidadeEntrega = new ComboBox();
            label24 = new Label();
            cboTipoEntrega = new ComboBox();
            label19 = new Label();
            chkAtivo = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)dgvLista).BeginInit();
            SuspendLayout();
            // 
            // btnPesquisar
            // 
            btnPesquisar.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPesquisar.Location = new Point(363, 534);
            btnPesquisar.Margin = new Padding(4, 3, 4, 3);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(110, 27);
            btnPesquisar.TabIndex = 81;
            btnPesquisar.Text = "&Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = true;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // btnNovo
            // 
            btnNovo.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNovo.Location = new Point(242, 534);
            btnNovo.Margin = new Padding(4, 3, 4, 3);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(110, 27);
            btnNovo.TabIndex = 80;
            btnNovo.Text = "&Novo";
            btnNovo.UseVisualStyleBackColor = true;
            btnNovo.Click += btnNovo_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Enabled = false;
            btnExcluir.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExcluir.Location = new Point(605, 534);
            btnExcluir.Margin = new Padding(4, 3, 4, 3);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(110, 27);
            btnExcluir.TabIndex = 82;
            btnExcluir.Text = "&Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Enabled = false;
            btnSalvar.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalvar.Location = new Point(484, 534);
            btnSalvar.Margin = new Padding(4, 3, 4, 3);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(110, 27);
            btnSalvar.TabIndex = 83;
            btnSalvar.Text = "&Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpar.Location = new Point(726, 534);
            btnLimpar.Margin = new Padding(4, 3, 4, 3);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(110, 27);
            btnLimpar.TabIndex = 84;
            btnLimpar.Text = "&Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // btnSair
            // 
            btnSair.BackColor = SystemColors.Control;
            btnSair.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSair.Location = new Point(847, 534);
            btnSair.Margin = new Padding(4, 3, 4, 3);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(110, 27);
            btnSair.TabIndex = 85;
            btnSair.Text = "Sai&r";
            btnSair.UseVisualStyleBackColor = false;
            btnSair.Click += btnSair_Click;
            // 
            // dgvLista
            // 
            dgvLista.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLista.Location = new Point(22, 222);
            dgvLista.Margin = new Padding(4, 3, 4, 3);
            dgvLista.Name = "dgvLista";
            dgvLista.Size = new Size(1116, 300);
            dgvLista.TabIndex = 79;
            dgvLista.CellClick += dgvLista_CellClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(185, 72);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(71, 13);
            label3.TabIndex = 76;
            label3.Text = "Logradouro";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(25, 72);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(31, 13);
            label2.TabIndex = 75;
            label2.Text = "CEP";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(673, 22);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(30, 13);
            label6.TabIndex = 74;
            label6.Text = "CPF";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(419, 22);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(78, 13);
            label5.TabIndex = 77;
            label5.Text = "Nome Social";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(787, 22);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(104, 13);
            label8.TabIndex = 73;
            label8.Text = "Data Nascimento";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(1029, 22);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(35, 13);
            label1.TabIndex = 72;
            label1.Text = "Sexo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(65, 22);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(39, 13);
            label4.TabIndex = 71;
            label4.Text = "Nome";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(25, 22);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(18, 13);
            label7.TabIndex = 78;
            label7.Text = "Id";
            // 
            // txtLogradouro
            // 
            txtLogradouro.Enabled = false;
            txtLogradouro.Location = new Point(183, 86);
            txtLogradouro.Margin = new Padding(4, 3, 4, 3);
            txtLogradouro.MaxLength = 255;
            txtLogradouro.Multiline = true;
            txtLogradouro.Name = "txtLogradouro";
            txtLogradouro.Size = new Size(343, 23);
            txtLogradouro.TabIndex = 69;
            // 
            // txtNomeSocial
            // 
            txtNomeSocial.Location = new Point(418, 36);
            txtNomeSocial.Margin = new Padding(4, 3, 4, 3);
            txtNomeSocial.MaxLength = 255;
            txtNomeSocial.Multiline = true;
            txtNomeSocial.Name = "txtNomeSocial";
            txtNomeSocial.Size = new Size(246, 23);
            txtNomeSocial.TabIndex = 66;
            // 
            // dTPNascimento
            // 
            dTPNascimento.Location = new Point(783, 36);
            dTPNascimento.Margin = new Padding(4, 3, 4, 3);
            dTPNascimento.Name = "dTPNascimento";
            dTPNascimento.Size = new Size(237, 23);
            dTPNascimento.TabIndex = 65;
            // 
            // cboSexo
            // 
            cboSexo.Enabled = false;
            cboSexo.Location = new Point(1025, 36);
            cboSexo.Margin = new Padding(4, 3, 4, 3);
            cboSexo.MaxLength = 255;
            cboSexo.Name = "cboSexo";
            cboSexo.Size = new Size(113, 23);
            cboSexo.TabIndex = 64;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(66, 36);
            txtNome.Margin = new Padding(4, 3, 4, 3);
            txtNome.MaxLength = 255;
            txtNome.Multiline = true;
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(350, 23);
            txtNome.TabIndex = 70;
            // 
            // txtId
            // 
            txtId.Location = new Point(22, 36);
            txtId.Margin = new Padding(4, 3, 4, 3);
            txtId.Mask = "00000";
            txtId.Name = "txtId";
            txtId.Size = new Size(40, 23);
            txtId.TabIndex = 63;
            // 
            // txtComplemento
            // 
            txtComplemento.Enabled = false;
            txtComplemento.Location = new Point(22, 141);
            txtComplemento.Margin = new Padding(4, 3, 4, 3);
            txtComplemento.MaxLength = 255;
            txtComplemento.Multiline = true;
            txtComplemento.Name = "txtComplemento";
            txtComplemento.Size = new Size(269, 23);
            txtComplemento.TabIndex = 64;
            // 
            // txtUF
            // 
            txtUF.Enabled = false;
            txtUF.Location = new Point(294, 141);
            txtUF.Margin = new Padding(4, 3, 4, 3);
            txtUF.MaxLength = 255;
            txtUF.Multiline = true;
            txtUF.Name = "txtUF";
            txtUF.Size = new Size(158, 23);
            txtUF.TabIndex = 68;
            // 
            // txtEmail
            // 
            txtEmail.Enabled = false;
            txtEmail.Location = new Point(702, 141);
            txtEmail.Margin = new Padding(4, 3, 4, 3);
            txtEmail.MaxLength = 255;
            txtEmail.Multiline = true;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(194, 23);
            txtEmail.TabIndex = 69;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(22, 125);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(82, 13);
            label9.TabIndex = 72;
            label9.Text = "Complemento";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(293, 125);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(71, 13);
            label10.TabIndex = 75;
            label10.Text = "Estado (Uf)";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(701, 125);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(37, 13);
            label11.TabIndex = 76;
            label11.Text = "Email";
            // 
            // txtNumero
            // 
            txtNumero.Enabled = false;
            txtNumero.Location = new Point(529, 86);
            txtNumero.Margin = new Padding(4, 3, 4, 3);
            txtNumero.MaxLength = 255;
            txtNumero.Multiline = true;
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(94, 23);
            txtNumero.TabIndex = 69;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(530, 72);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(50, 13);
            label12.TabIndex = 76;
            label12.Text = "Número";
            // 
            // txtBairro
            // 
            txtBairro.Enabled = false;
            txtBairro.Location = new Point(626, 86);
            txtBairro.Margin = new Padding(4, 3, 4, 3);
            txtBairro.MaxLength = 255;
            txtBairro.Multiline = true;
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(217, 23);
            txtBairro.TabIndex = 69;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(628, 72);
            label13.Margin = new Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new Size(40, 13);
            label13.TabIndex = 76;
            label13.Text = "Bairro";
            // 
            // txtMunicipio
            // 
            txtMunicipio.Enabled = false;
            txtMunicipio.Location = new Point(847, 86);
            txtMunicipio.Margin = new Padding(4, 3, 4, 3);
            txtMunicipio.MaxLength = 255;
            txtMunicipio.Multiline = true;
            txtMunicipio.Name = "txtMunicipio";
            txtMunicipio.Size = new Size(179, 23);
            txtMunicipio.TabIndex = 68;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(850, 72);
            label14.Margin = new Padding(4, 0, 4, 0);
            label14.Name = "label14";
            label14.Size = new Size(61, 13);
            label14.TabIndex = 75;
            label14.Text = "Municipio";
            // 
            // txtCPF
            // 
            txtCPF.Location = new Point(668, 36);
            txtCPF.Margin = new Padding(4, 3, 4, 3);
            txtCPF.Mask = "000.000.000-00";
            txtCPF.Name = "txtCPF";
            txtCPF.Size = new Size(112, 23);
            txtCPF.TabIndex = 63;
            // 
            // txtCEP
            // 
            txtCEP.Enabled = false;
            txtCEP.Location = new Point(22, 86);
            txtCEP.Margin = new Padding(4, 3, 4, 3);
            txtCEP.Mask = "00.000-000";
            txtCEP.Name = "txtCEP";
            txtCEP.Size = new Size(82, 23);
            txtCEP.TabIndex = 63;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.Location = new Point(456, 125);
            label15.Margin = new Padding(4, 0, 4, 0);
            label15.Name = "label15";
            label15.Size = new Size(46, 13);
            label15.TabIndex = 76;
            label15.Text = "Celular";
            // 
            // txtCelular
            // 
            txtCelular.Enabled = false;
            txtCelular.Location = new Point(456, 141);
            txtCelular.Margin = new Padding(4, 3, 4, 3);
            txtCelular.Mask = "(00)00000-0000";
            txtCelular.Name = "txtCelular";
            txtCelular.Size = new Size(115, 23);
            txtCelular.TabIndex = 63;
            // 
            // dTPDataPrimeiroAtendimento
            // 
            dTPDataPrimeiroAtendimento.Enabled = false;
            dTPDataPrimeiroAtendimento.Location = new Point(901, 141);
            dTPDataPrimeiroAtendimento.Margin = new Padding(4, 3, 4, 3);
            dTPDataPrimeiroAtendimento.Name = "dTPDataPrimeiroAtendimento";
            dTPDataPrimeiroAtendimento.Size = new Size(237, 23);
            dTPDataPrimeiroAtendimento.TabIndex = 65;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.Location = new Point(904, 125);
            label16.Margin = new Padding(4, 0, 4, 0);
            label16.Name = "label16";
            label16.Size = new Size(157, 13);
            label16.TabIndex = 73;
            label16.Text = "Data Primeiro Atendimento";
            // 
            // txtCarteirinha
            // 
            txtCarteirinha.Enabled = false;
            txtCarteirinha.Location = new Point(472, 193);
            txtCarteirinha.Margin = new Padding(4, 3, 4, 3);
            txtCarteirinha.MaxLength = 255;
            txtCarteirinha.Multiline = true;
            txtCarteirinha.Name = "txtCarteirinha";
            txtCarteirinha.Size = new Size(143, 23);
            txtCarteirinha.TabIndex = 68;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.Location = new Point(409, 176);
            label17.Margin = new Padding(4, 0, 4, 0);
            label17.Name = "label17";
            label17.Size = new Size(59, 13);
            label17.TabIndex = 75;
            label17.Text = "Matricula";
            // 
            // txtMatricula
            // 
            txtMatricula.Enabled = false;
            txtMatricula.Location = new Point(407, 193);
            txtMatricula.Margin = new Padding(4, 3, 4, 3);
            txtMatricula.Mask = "0000000000";
            txtMatricula.Name = "txtMatricula";
            txtMatricula.Size = new Size(64, 23);
            txtMatricula.TabIndex = 63;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label18.Location = new Point(474, 176);
            label18.Margin = new Padding(4, 0, 4, 0);
            label18.Name = "label18";
            label18.Size = new Size(68, 13);
            label18.TabIndex = 76;
            label18.Text = "Carteirinha";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label20.Location = new Point(25, 176);
            label20.Margin = new Padding(4, 0, 4, 0);
            label20.Name = "label20";
            label20.Size = new Size(60, 13);
            label20.TabIndex = 86;
            label20.Text = "Convenio";
            // 
            // cboConvenio
            // 
            cboConvenio.Enabled = false;
            cboConvenio.FormattingEnabled = true;
            cboConvenio.Location = new Point(24, 193);
            cboConvenio.Margin = new Padding(4, 3, 4, 3);
            cboConvenio.Name = "cboConvenio";
            cboConvenio.Size = new Size(381, 23);
            cboConvenio.TabIndex = 87;
            // 
            // txtAutorizacao
            // 
            txtAutorizacao.Enabled = false;
            txtAutorizacao.Location = new Point(616, 193);
            txtAutorizacao.Margin = new Padding(4, 3, 4, 3);
            txtAutorizacao.MaxLength = 255;
            txtAutorizacao.Multiline = true;
            txtAutorizacao.Name = "txtAutorizacao";
            txtAutorizacao.Size = new Size(157, 23);
            txtAutorizacao.TabIndex = 68;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label21.Location = new Point(620, 176);
            label21.Margin = new Padding(4, 0, 4, 0);
            label21.Name = "label21";
            label21.Size = new Size(74, 13);
            label21.TabIndex = 76;
            label21.Text = "Autorização";
            // 
            // txtZona
            // 
            txtZona.Enabled = false;
            txtZona.Location = new Point(1029, 86);
            txtZona.Margin = new Padding(4, 3, 4, 3);
            txtZona.MaxLength = 30;
            txtZona.Multiline = true;
            txtZona.Name = "txtZona";
            txtZona.Size = new Size(109, 23);
            txtZona.TabIndex = 68;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label22.Location = new Point(1029, 72);
            label22.Margin = new Padding(4, 0, 4, 0);
            label22.Name = "label22";
            label22.Size = new Size(36, 13);
            label22.TabIndex = 75;
            label22.Text = "Zona";
            // 
            // btnBuscar
            // 
            btnBuscar.Enabled = false;
            btnBuscar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnBuscar.Location = new Point(104, 85);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(63, 24);
            btnBuscar.TabIndex = 88;
            btnBuscar.Text = "BUSCAR";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtTelefone
            // 
            txtTelefone.Enabled = false;
            txtTelefone.Location = new Point(576, 141);
            txtTelefone.Margin = new Padding(4, 3, 4, 3);
            txtTelefone.Mask = "(00)0000-0000";
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(121, 23);
            txtTelefone.TabIndex = 63;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label23.Location = new Point(574, 125);
            label23.Margin = new Padding(4, 0, 4, 0);
            label23.Name = "label23";
            label23.Size = new Size(57, 13);
            label23.TabIndex = 76;
            label23.Text = "Telefone";
            // 
            // cboModalidadeEntrega
            // 
            cboModalidadeEntrega.Enabled = false;
            cboModalidadeEntrega.FormattingEnabled = true;
            cboModalidadeEntrega.Location = new Point(775, 193);
            cboModalidadeEntrega.Margin = new Padding(4, 3, 4, 3);
            cboModalidadeEntrega.Name = "cboModalidadeEntrega";
            cboModalidadeEntrega.Size = new Size(152, 23);
            cboModalidadeEntrega.TabIndex = 87;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label24.Location = new Point(775, 176);
            label24.Margin = new Padding(4, 0, 4, 0);
            label24.Name = "label24";
            label24.Size = new Size(138, 13);
            label24.TabIndex = 86;
            label24.Text = "Modalidade de Entrega";
            // 
            // cboTipoEntrega
            // 
            cboTipoEntrega.Enabled = false;
            cboTipoEntrega.Location = new Point(929, 193);
            cboTipoEntrega.Margin = new Padding(4, 3, 4, 3);
            cboTipoEntrega.MaxLength = 255;
            cboTipoEntrega.Name = "cboTipoEntrega";
            cboTipoEntrega.Size = new Size(146, 23);
            cboTipoEntrega.TabIndex = 99;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label19.Location = new Point(928, 176);
            label19.Margin = new Padding(4, 0, 4, 0);
            label19.Name = "label19";
            label19.Size = new Size(80, 13);
            label19.TabIndex = 100;
            label19.Text = "Tipo Entrega";
            // 
            // chkAtivo
            // 
            chkAtivo.AutoSize = true;
            chkAtivo.Location = new Point(1089, 197);
            chkAtivo.Name = "chkAtivo";
            chkAtivo.Size = new Size(56, 19);
            chkAtivo.TabIndex = 101;
            chkAtivo.Text = "Ativo";
            chkAtivo.UseVisualStyleBackColor = true;
            // 
            // frmPaciente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1164, 573);
            Controls.Add(chkAtivo);
            Controls.Add(cboTipoEntrega);
            Controls.Add(label19);
            Controls.Add(btnBuscar);
            Controls.Add(label24);
            Controls.Add(label20);
            Controls.Add(cboModalidadeEntrega);
            Controls.Add(cboConvenio);
            Controls.Add(btnPesquisar);
            Controls.Add(btnNovo);
            Controls.Add(btnExcluir);
            Controls.Add(btnSalvar);
            Controls.Add(btnLimpar);
            Controls.Add(btnSair);
            Controls.Add(dgvLista);
            Controls.Add(label21);
            Controls.Add(label18);
            Controls.Add(label23);
            Controls.Add(label15);
            Controls.Add(label11);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label3);
            Controls.Add(label17);
            Controls.Add(label10);
            Controls.Add(label22);
            Controls.Add(label14);
            Controls.Add(label2);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label16);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(label1);
            Controls.Add(label4);
            Controls.Add(label7);
            Controls.Add(txtEmail);
            Controls.Add(txtBairro);
            Controls.Add(txtNumero);
            Controls.Add(txtLogradouro);
            Controls.Add(txtAutorizacao);
            Controls.Add(txtCarteirinha);
            Controls.Add(txtUF);
            Controls.Add(txtZona);
            Controls.Add(txtMunicipio);
            Controls.Add(txtNomeSocial);
            Controls.Add(dTPDataPrimeiroAtendimento);
            Controls.Add(dTPNascimento);
            Controls.Add(txtComplemento);
            Controls.Add(cboSexo);
            Controls.Add(txtMatricula);
            Controls.Add(txtTelefone);
            Controls.Add(txtCelular);
            Controls.Add(txtCPF);
            Controls.Add(txtNome);
            Controls.Add(txtCEP);
            Controls.Add(txtId);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Name = "frmPaciente";
            Text = "Paciente";
            Load += frmPaciente_Load;
            ((System.ComponentModel.ISupportInitialize)dgvLista).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnPesquisar;
        private Button btnNovo;
        private Button btnExcluir;
        private Button btnSalvar;
        private Button btnLimpar;
        private Button btnSair;
        private DataGridView dgvLista;
        private Label label3;
        private Label label2;
        private Label label6;
        private Label label5;
        private Label label8;
        private Label label1;
        private Label label4;
        private Label label7;
        private TextBox txtLogradouro;
        private TextBox txtNomeSocial;
       // private TextBox txtNascimento;

        private DateTimePicker dTPNascimento;
        private ComboBox cboSexo;
        private TextBox txtNome;
        private MaskedTextBox txtId;
        private TextBox txtComplemento;
        private TextBox txtUF;
        private TextBox txtEmail;
        private Label label9;
        private Label label10;
        private Label label11;
        private TextBox txtNumero;
        private Label label12;
        private TextBox txtBairro;
        private Label label13;
        private TextBox txtMunicipio;
        private Label label14;
        private MaskedTextBox txtCPF;
        private MaskedTextBox txtCEP;
        private Label label15;
        private MaskedTextBox txtCelular;
        private DateTimePicker dTPDataPrimeiroAtendimento;
        private Label label16;
        private TextBox txtCarteirinha;
        private Label label17;
        private MaskedTextBox txtMatricula;
        private Label label18;
        private DateTimePicker dTPValidade;
        private Label label19;
        private Label label20;
        private ComboBox cboConvenio;
        private TextBox txtAutorizacao;
        private Label label21;
        private TextBox txtZona;
        private Label label22;
        private Button btnBuscar;
        private MaskedTextBox txtTelefone;
        private Label label23;
        private ComboBox comboBox1;
        private Label label24;
        private DateTimePicker dTPDataInclusaoConvenio;
        private Label label25;
        private ComboBox cboModalidadeEntrega;
        private ComboBox cboTipoEntrega;
        private CheckBox chkAtivo;
    }
}