namespace EPharmacy.Forms
{
    partial class frmBaseCadastral
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
            txtEAN = new MaskedTextBox();
            label3 = new Label();
            label20 = new Label();
            cboConvenio = new ComboBox();
            label17 = new Label();
            txtMatricula = new MaskedTextBox();
            label4 = new Label();
            cboStatus = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label6 = new Label();
            txtCPF = new MaskedTextBox();
            cboMedicamento = new ComboBox();
            cboPaciente = new ComboBox();
            label5 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            txtId = new MaskedTextBox();
            chkMostrarIds = new CheckBox();
            txtMesAno = new MaskedTextBox();
            label13 = new Label();
            cboBairro = new ComboBox();
            label14 = new Label();
            cboZona = new ComboBox();
            label15 = new Label();
            cboTipoReceita = new ComboBox();
            label16 = new Label();
            btnExportar = new Button();
            chkAumentaLarguraColunasGrid = new CheckBox();
            cboStatusParaGravar = new ComboBox();
            label18 = new Label();
            dTPRefil1 = new MaskedTextBox();
            dTPRefil2 = new MaskedTextBox();
            dTPRefil3 = new MaskedTextBox();
            dTPRefil4 = new MaskedTextBox();
            dTPRefil5 = new MaskedTextBox();
            dTPRefil6 = new MaskedTextBox();
            dTPRefilExtra = new MaskedTextBox();
            btnSalvar2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvLista).BeginInit();
            SuspendLayout();
            // 
            // btnPesquisar
            // 
            btnPesquisar.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPesquisar.Location = new Point(840, 642);
            btnPesquisar.Margin = new Padding(4, 3, 4, 3);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(110, 27);
            btnPesquisar.TabIndex = 80;
            btnPesquisar.Text = "&Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = true;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // btnNovo
            // 
            btnNovo.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNovo.Location = new Point(465, 642);
            btnNovo.Margin = new Padding(4, 3, 4, 3);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(110, 27);
            btnNovo.TabIndex = 79;
            btnNovo.Text = "&Novo";
            btnNovo.UseVisualStyleBackColor = true;
            btnNovo.Visible = false;
            // 
            // btnExcluir
            // 
            btnExcluir.Enabled = false;
            btnExcluir.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExcluir.Location = new Point(590, 642);
            btnExcluir.Margin = new Padding(4, 3, 4, 3);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(110, 27);
            btnExcluir.TabIndex = 81;
            btnExcluir.Text = "&Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Visible = false;
            // 
            // btnSalvar
            // 
            btnSalvar.Enabled = false;
            btnSalvar.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalvar.ForeColor = Color.Red;
            btnSalvar.Location = new Point(963, 642);
            btnSalvar.Margin = new Padding(4, 3, 4, 3);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(110, 27);
            btnSalvar.TabIndex = 82;
            btnSalvar.Text = "&Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpar.Location = new Point(1087, 642);
            btnLimpar.Margin = new Padding(4, 3, 4, 3);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(110, 27);
            btnLimpar.TabIndex = 83;
            btnLimpar.Text = "&Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // btnSair
            // 
            btnSair.BackColor = SystemColors.Control;
            btnSair.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSair.Location = new Point(1212, 642);
            btnSair.Margin = new Padding(4, 3, 4, 3);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(110, 27);
            btnSair.TabIndex = 84;
            btnSair.Text = "Sai&r";
            btnSair.UseVisualStyleBackColor = false;
            btnSair.Click += btnSair_Click;
            // 
            // dgvLista
            // 
            dgvLista.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLista.Location = new Point(13, 95);
            dgvLista.Margin = new Padding(4, 3, 4, 3);
            dgvLista.Name = "dgvLista";
            dgvLista.Size = new Size(1333, 541);
            dgvLista.TabIndex = 78;
            dgvLista.CellClick += dgvLista_CellClick;
            dgvLista.CellFormatting += dgvLista_CellFormatting;
            // 
            // txtEAN
            // 
            txtEAN.Location = new Point(76, 23);
            txtEAN.Margin = new Padding(4, 3, 4, 3);
            txtEAN.Mask = "0000000000000";
            txtEAN.Name = "txtEAN";
            txtEAN.Size = new Size(76, 23);
            txtEAN.TabIndex = 87;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(78, 9);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(32, 13);
            label3.TabIndex = 85;
            label3.Text = "EAN";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label20.Location = new Point(467, 9);
            label20.Margin = new Padding(4, 0, 4, 0);
            label20.Name = "label20";
            label20.Size = new Size(60, 13);
            label20.TabIndex = 93;
            label20.Text = "Convenio";
            // 
            // cboConvenio
            // 
            cboConvenio.Enabled = false;
            cboConvenio.FormattingEnabled = true;
            cboConvenio.Location = new Point(466, 23);
            cboConvenio.Margin = new Padding(4, 3, 4, 3);
            cboConvenio.Name = "cboConvenio";
            cboConvenio.Size = new Size(96, 23);
            cboConvenio.TabIndex = 94;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.Location = new Point(565, 9);
            label17.Margin = new Padding(4, 0, 4, 0);
            label17.Name = "label17";
            label17.Size = new Size(59, 13);
            label17.TabIndex = 92;
            label17.Text = "Matricula";
            // 
            // txtMatricula
            // 
            txtMatricula.Enabled = false;
            txtMatricula.Location = new Point(563, 23);
            txtMatricula.Margin = new Padding(4, 3, 4, 3);
            txtMatricula.Mask = "0000000000";
            txtMatricula.Name = "txtMatricula";
            txtMatricula.Size = new Size(73, 23);
            txtMatricula.TabIndex = 91;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(716, 9);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(57, 13);
            label4.TabIndex = 96;
            label4.Text = "Paciente";
            // 
            // cboStatus
            // 
            cboStatus.Enabled = false;
            cboStatus.FormattingEnabled = true;
            cboStatus.Location = new Point(1260, 23);
            cboStatus.Margin = new Padding(4, 3, 4, 3);
            cboStatus.Name = "cboStatus";
            cboStatus.Size = new Size(86, 23);
            cboStatus.TabIndex = 94;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(1262, 9);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(43, 13);
            label1.TabIndex = 93;
            label1.Text = "Status";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(152, 9);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(82, 13);
            label2.TabIndex = 96;
            label2.Text = "Medicamento";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(639, 9);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(30, 13);
            label6.TabIndex = 98;
            label6.Text = "CPF";
            // 
            // txtCPF
            // 
            txtCPF.Location = new Point(636, 23);
            txtCPF.Margin = new Padding(4, 3, 4, 3);
            txtCPF.Mask = "000.000.000-00";
            txtCPF.Name = "txtCPF";
            txtCPF.Size = new Size(77, 23);
            txtCPF.TabIndex = 97;
            // 
            // cboMedicamento
            // 
            cboMedicamento.Enabled = false;
            cboMedicamento.FormattingEnabled = true;
            cboMedicamento.Location = new Point(153, 23);
            cboMedicamento.Margin = new Padding(4, 3, 4, 3);
            cboMedicamento.Name = "cboMedicamento";
            cboMedicamento.Size = new Size(312, 23);
            cboMedicamento.TabIndex = 94;
            // 
            // cboPaciente
            // 
            cboPaciente.Enabled = false;
            cboPaciente.FormattingEnabled = true;
            cboPaciente.Location = new Point(714, 23);
            cboPaciente.Margin = new Padding(4, 3, 4, 3);
            cboPaciente.Name = "cboPaciente";
            cboPaciente.Size = new Size(230, 23);
            cboPaciente.TabIndex = 94;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Red;
            label5.Location = new Point(13, 56);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(44, 13);
            label5.TabIndex = 85;
            label5.Text = "Refil 1";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(128, 64, 0);
            label7.Location = new Point(125, 56);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(44, 13);
            label7.TabIndex = 85;
            label7.Text = "Refil 2";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Olive;
            label8.Location = new Point(236, 56);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(44, 13);
            label8.TabIndex = 85;
            label8.Text = "Refil 3";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Green;
            label9.Location = new Point(347, 56);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(44, 13);
            label9.TabIndex = 85;
            label9.Text = "Refil 4";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Teal;
            label10.Location = new Point(457, 56);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(44, 13);
            label10.TabIndex = 85;
            label10.Text = "Refil 5";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.Navy;
            label11.Location = new Point(562, 56);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(44, 13);
            label11.TabIndex = 85;
            label11.Text = "Refil 6";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.Purple;
            label12.Location = new Point(679, 56);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(66, 13);
            label12.TabIndex = 85;
            label12.Text = "Refil Extra";
            // 
            // txtId
            // 
            txtId.Location = new Point(999, -6);
            txtId.Margin = new Padding(4, 3, 4, 3);
            txtId.Mask = "00000";
            txtId.Name = "txtId";
            txtId.Size = new Size(38, 23);
            txtId.TabIndex = 87;
            txtId.Visible = false;
            // 
            // chkMostrarIds
            // 
            chkMostrarIds.AutoSize = true;
            chkMostrarIds.Location = new Point(12, 646);
            chkMostrarIds.Name = "chkMostrarIds";
            chkMostrarIds.Size = new Size(85, 19);
            chkMostrarIds.TabIndex = 100;
            chkMostrarIds.Text = "Mostrar Ids";
            chkMostrarIds.UseVisualStyleBackColor = true;
            // 
            // txtMesAno
            // 
            txtMesAno.BackColor = Color.AliceBlue;
            txtMesAno.Location = new Point(13, 23);
            txtMesAno.Margin = new Padding(4, 3, 4, 3);
            txtMesAno.Mask = "00/0000";
            txtMesAno.Name = "txtMesAno";
            txtMesAno.Size = new Size(59, 23);
            txtMesAno.TabIndex = 97;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.MediumBlue;
            label13.Location = new Point(14, 9);
            label13.Margin = new Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new Size(58, 13);
            label13.TabIndex = 98;
            label13.Text = "Mês/Ano";
            // 
            // cboBairro
            // 
            cboBairro.Enabled = false;
            cboBairro.FormattingEnabled = true;
            cboBairro.Location = new Point(949, 23);
            cboBairro.Margin = new Padding(4, 3, 4, 3);
            cboBairro.Name = "cboBairro";
            cboBairro.Size = new Size(115, 23);
            cboBairro.TabIndex = 94;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(952, 9);
            label14.Margin = new Padding(4, 0, 4, 0);
            label14.Name = "label14";
            label14.Size = new Size(40, 13);
            label14.TabIndex = 93;
            label14.Text = "Bairro";
            // 
            // cboZona
            // 
            cboZona.Enabled = false;
            cboZona.FormattingEnabled = true;
            cboZona.Location = new Point(1065, 23);
            cboZona.Margin = new Padding(4, 3, 4, 3);
            cboZona.Name = "cboZona";
            cboZona.Size = new Size(96, 23);
            cboZona.TabIndex = 94;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.Location = new Point(1063, 9);
            label15.Margin = new Padding(4, 0, 4, 0);
            label15.Name = "label15";
            label15.Size = new Size(36, 13);
            label15.TabIndex = 93;
            label15.Text = "Zona";
            // 
            // cboTipoReceita
            // 
            cboTipoReceita.Enabled = false;
            cboTipoReceita.FormattingEnabled = true;
            cboTipoReceita.Location = new Point(1162, 23);
            cboTipoReceita.Margin = new Padding(4, 3, 4, 3);
            cboTipoReceita.Name = "cboTipoReceita";
            cboTipoReceita.Size = new Size(96, 23);
            cboTipoReceita.TabIndex = 94;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.Location = new Point(1159, 9);
            label16.Margin = new Padding(4, 0, 4, 0);
            label16.Name = "label16";
            label16.Size = new Size(80, 13);
            label16.TabIndex = 93;
            label16.Text = "Tipo Receita";
            // 
            // btnExportar
            // 
            btnExportar.Enabled = false;
            btnExportar.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExportar.Location = new Point(715, 642);
            btnExportar.Margin = new Padding(4, 3, 4, 3);
            btnExportar.Name = "btnExportar";
            btnExportar.Size = new Size(110, 27);
            btnExportar.TabIndex = 82;
            btnExportar.Text = "&Exportar XLS";
            btnExportar.UseVisualStyleBackColor = true;
            btnExportar.Click += btnExportar_Click;
            // 
            // chkAumentaLarguraColunasGrid
            // 
            chkAumentaLarguraColunasGrid.AutoSize = true;
            chkAumentaLarguraColunasGrid.Checked = true;
            chkAumentaLarguraColunasGrid.CheckState = CheckState.Checked;
            chkAumentaLarguraColunasGrid.Location = new Point(123, 646);
            chkAumentaLarguraColunasGrid.Name = "chkAumentaLarguraColunasGrid";
            chkAumentaLarguraColunasGrid.Size = new Size(184, 19);
            chkAumentaLarguraColunasGrid.TabIndex = 152;
            chkAumentaLarguraColunasGrid.Text = "Largura do Tamanho do Dado";
            chkAumentaLarguraColunasGrid.UseVisualStyleBackColor = true;
            chkAumentaLarguraColunasGrid.CheckedChanged += chkAumentaLarguraColunasGrid_CheckedChanged_1;
            // 
            // cboStatusParaGravar
            // 
            cboStatusParaGravar.Enabled = false;
            cboStatusParaGravar.FormattingEnabled = true;
            cboStatusParaGravar.Location = new Point(790, 69);
            cboStatusParaGravar.Margin = new Padding(4, 3, 4, 3);
            cboStatusParaGravar.Name = "cboStatusParaGravar";
            cboStatusParaGravar.Size = new Size(100, 23);
            cboStatusParaGravar.TabIndex = 94;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label18.Location = new Point(792, 56);
            label18.Margin = new Padding(4, 0, 4, 0);
            label18.Name = "label18";
            label18.Size = new Size(43, 13);
            label18.TabIndex = 93;
            label18.Text = "Status";
            // 
            // dTPRefil1
            // 
            dTPRefil1.Location = new Point(15, 68);
            dTPRefil1.Mask = "00/00/0000";
            dTPRefil1.Name = "dTPRefil1";
            dTPRefil1.Size = new Size(106, 23);
            dTPRefil1.TabIndex = 153;
            dTPRefil1.ValidatingType = typeof(DateTime);
            dTPRefil1.Leave += dTPRefil1_Leave;
            // 
            // dTPRefil2
            // 
            dTPRefil2.Location = new Point(125, 68);
            dTPRefil2.Mask = "00/00/0000";
            dTPRefil2.Name = "dTPRefil2";
            dTPRefil2.Size = new Size(106, 23);
            dTPRefil2.TabIndex = 153;
            dTPRefil2.ValidatingType = typeof(DateTime);
            dTPRefil2.Leave += dTPRefil2_Leave;
            // 
            // dTPRefil3
            // 
            dTPRefil3.Location = new Point(236, 69);
            dTPRefil3.Mask = "00/00/0000";
            dTPRefil3.Name = "dTPRefil3";
            dTPRefil3.Size = new Size(106, 23);
            dTPRefil3.TabIndex = 153;
            dTPRefil3.ValidatingType = typeof(DateTime);
            dTPRefil3.Leave += dTPRefil3_Leave;
            // 
            // dTPRefil4
            // 
            dTPRefil4.Location = new Point(347, 69);
            dTPRefil4.Mask = "00/00/0000";
            dTPRefil4.Name = "dTPRefil4";
            dTPRefil4.Size = new Size(106, 23);
            dTPRefil4.TabIndex = 153;
            dTPRefil4.ValidatingType = typeof(DateTime);
            dTPRefil4.Leave += dTPRefil4_Leave;
            // 
            // dTPRefil5
            // 
            dTPRefil5.Location = new Point(457, 69);
            dTPRefil5.Mask = "00/00/0000";
            dTPRefil5.Name = "dTPRefil5";
            dTPRefil5.Size = new Size(106, 23);
            dTPRefil5.TabIndex = 153;
            dTPRefil5.ValidatingType = typeof(DateTime);
            dTPRefil5.Leave += dTPRefil5_Leave;
            // 
            // dTPRefil6
            // 
            dTPRefil6.Location = new Point(567, 69);
            dTPRefil6.Mask = "00/00/0000";
            dTPRefil6.Name = "dTPRefil6";
            dTPRefil6.Size = new Size(106, 23);
            dTPRefil6.TabIndex = 153;
            dTPRefil6.ValidatingType = typeof(DateTime);
            // 
            // dTPRefilExtra
            // 
            dTPRefilExtra.Location = new Point(679, 69);
            dTPRefilExtra.Mask = "00/00/0000";
            dTPRefilExtra.Name = "dTPRefilExtra";
            dTPRefilExtra.Size = new Size(106, 23);
            dTPRefilExtra.TabIndex = 153;
            dTPRefilExtra.ValidatingType = typeof(DateTime);
            dTPRefilExtra.Leave += dTPRefilExtra_Leave;
            // 
            // btnSalvar2
            // 
            btnSalvar2.Enabled = false;
            btnSalvar2.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalvar2.ForeColor = Color.Red;
            btnSalvar2.Location = new Point(949, 65);
            btnSalvar2.Margin = new Padding(4, 3, 4, 3);
            btnSalvar2.Name = "btnSalvar2";
            btnSalvar2.Size = new Size(110, 27);
            btnSalvar2.TabIndex = 154;
            btnSalvar2.Text = "Salvar";
            btnSalvar2.UseVisualStyleBackColor = true;
            btnSalvar2.Click += btnSalvar_Click;
            // 
            // frmBaseCadastral
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FloralWhite;
            ClientSize = new Size(1355, 667);
            Controls.Add(btnSalvar2);
            Controls.Add(dTPRefilExtra);
            Controls.Add(dTPRefil6);
            Controls.Add(dTPRefil5);
            Controls.Add(dTPRefil4);
            Controls.Add(dTPRefil3);
            Controls.Add(dTPRefil2);
            Controls.Add(dTPRefil1);
            Controls.Add(chkAumentaLarguraColunasGrid);
            Controls.Add(chkMostrarIds);
            Controls.Add(label13);
            Controls.Add(label6);
            Controls.Add(txtMesAno);
            Controls.Add(txtCPF);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(label18);
            Controls.Add(label1);
            Controls.Add(label16);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(label20);
            Controls.Add(cboPaciente);
            Controls.Add(cboStatusParaGravar);
            Controls.Add(cboStatus);
            Controls.Add(cboMedicamento);
            Controls.Add(cboTipoReceita);
            Controls.Add(cboZona);
            Controls.Add(cboBairro);
            Controls.Add(cboConvenio);
            Controls.Add(label17);
            Controls.Add(txtMatricula);
            Controls.Add(txtId);
            Controls.Add(txtEAN);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(btnPesquisar);
            Controls.Add(btnNovo);
            Controls.Add(btnExcluir);
            Controls.Add(btnExportar);
            Controls.Add(btnSalvar);
            Controls.Add(btnLimpar);
            Controls.Add(btnSair);
            Controls.Add(dgvLista);
            Name = "frmBaseCadastral";
            Text = "Base Cadastral";
            WindowState = FormWindowState.Maximized;
            Load += frmBaseCadastral_Load;
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
        private MaskedTextBox txtEAN;
        private Label label3;
        private Label label20;
        private ComboBox cboConvenio;
        private Label label17;
        private MaskedTextBox txtMatricula;
        private Label label4;
        private ComboBox cboStatus;
        private Label label1;
        private Label label2;
        private Label label6;
        private MaskedTextBox txtCPF;
        private ComboBox cboMedicamento;
        private ComboBox cboPaciente;
        private Label label5;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
       // private MaskedTextBox dTPRefil4;
       // private MaskedTextBox dTPRefil5;
       // private MaskedTextBox dTPRefil6;
       // private MaskedTextBox dTPRefilExtra;
        private MaskedTextBox txtId;
        private CheckBox chkMostrarIds;
        private MaskedTextBox txtMesAno;
        private Label label13;
        private ComboBox cboBairro;
        private Label label14;
        private ComboBox cboZona;
        private Label label15;
        private ComboBox cboStatusParaGravar;
        private Label label16;
        private ComboBox cboTipoReceita;
        private Button btnExportar;
        private CheckBox chkAumentaLarguraColunasGrid;
        private Label label18;
        private MaskedTextBox dTPRefil1;
        private MaskedTextBox dTPRefil2;
        private MaskedTextBox dTPRefil3;
        private MaskedTextBox dTPRefil4;
        private MaskedTextBox dTPRefil5;
        private MaskedTextBox dTPRefil6;
        private MaskedTextBox dTPRefilExtra;
        private Button btnSalvar2;
    }
}