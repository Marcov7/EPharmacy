namespace EPharmacy.Forms
{
    partial class frmPedido
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
            chkMostrarIds = new CheckBox();
            label13 = new Label();
            label6 = new Label();
            txtMesAno = new MaskedTextBox();
            txtCPF = new MaskedTextBox();
            label2 = new Label();
            label4 = new Label();
            label1 = new Label();
            label16 = new Label();
            label15 = new Label();
            label14 = new Label();
            label20 = new Label();
            cboPaciente = new ComboBox();
            cboStatus = new ComboBox();
            cboMedicamento = new ComboBox();
            cboTipoReceita = new ComboBox();
            cboZona = new ComboBox();
            cboBairro = new ComboBox();
            cboConvenio = new ComboBox();
            label17 = new Label();
            txtMatricula = new MaskedTextBox();
            txtId = new MaskedTextBox();
            txtEAN = new MaskedTextBox();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label3 = new Label();
            btnPesquisar = new Button();
            btnNovo = new Button();
            btnExcluir = new Button();
            btnExportar = new Button();
            btnSalvar = new Button();
            btnLimpar = new Button();
            btnSair = new Button();
            dgvLista = new DataGridView();
            txtLote = new MaskedTextBox();
            txtNotaFiscal = new MaskedTextBox();
            txtReal = new NumericUpDown();
            cboRefil = new ComboBox();
            cboStatusEntrega = new ComboBox();
            dTPRefil = new DateTimePicker();
            label5 = new Label();
            txtReceitaItensEntregaId = new MaskedTextBox();
            panel2 = new Panel();
            btnAdicionar = new Button();
            dGVReceitaItensEntrega = new DataGridView();
            label18 = new Label();
            txtReceitaItensId = new MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)dgvLista).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtReal).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dGVReceitaItensEntrega).BeginInit();
            SuspendLayout();
            // 
            // chkMostrarIds
            // 
            chkMostrarIds.AutoSize = true;
            chkMostrarIds.Location = new Point(11, 646);
            chkMostrarIds.Name = "chkMostrarIds";
            chkMostrarIds.Size = new Size(85, 19);
            chkMostrarIds.TabIndex = 146;
            chkMostrarIds.Text = "Mostrar Ids";
            chkMostrarIds.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.Green;
            label13.Location = new Point(13, 9);
            label13.Margin = new Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new Size(58, 13);
            label13.TabIndex = 138;
            label13.Text = "Mês/Ano";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(638, 9);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(30, 13);
            label6.TabIndex = 137;
            label6.Text = "CPF";
            // 
            // txtMesAno
            // 
            txtMesAno.BackColor = Color.FromArgb(192, 255, 192);
            txtMesAno.Location = new Point(12, 23);
            txtMesAno.Margin = new Padding(4, 3, 4, 3);
            txtMesAno.Mask = "00/0000";
            txtMesAno.Name = "txtMesAno";
            txtMesAno.Size = new Size(59, 23);
            txtMesAno.TabIndex = 136;
            // 
            // txtCPF
            // 
            txtCPF.Location = new Point(635, 23);
            txtCPF.Margin = new Padding(4, 3, 4, 3);
            txtCPF.Mask = "000.000.000-00";
            txtCPF.Name = "txtCPF";
            txtCPF.Size = new Size(77, 23);
            txtCPF.TabIndex = 135;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(151, 9);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(82, 13);
            label2.TabIndex = 134;
            label2.Text = "Medicamento";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(715, 9);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(57, 13);
            label4.TabIndex = 133;
            label4.Text = "Paciente";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(947, 9);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(43, 13);
            label1.TabIndex = 121;
            label1.Text = "Status";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.Location = new Point(1246, 9);
            label16.Margin = new Padding(4, 0, 4, 0);
            label16.Name = "label16";
            label16.Size = new Size(80, 13);
            label16.TabIndex = 122;
            label16.Text = "Tipo Receita";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.Location = new Point(1150, 9);
            label15.Margin = new Padding(4, 0, 4, 0);
            label15.Name = "label15";
            label15.Size = new Size(36, 13);
            label15.TabIndex = 123;
            label15.Text = "Zona";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(1039, 9);
            label14.Margin = new Padding(4, 0, 4, 0);
            label14.Name = "label14";
            label14.Size = new Size(40, 13);
            label14.TabIndex = 124;
            label14.Text = "Bairro";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label20.Location = new Point(466, 9);
            label20.Margin = new Padding(4, 0, 4, 0);
            label20.Name = "label20";
            label20.Size = new Size(60, 13);
            label20.TabIndex = 125;
            label20.Text = "Convenio";
            // 
            // cboPaciente
            // 
            cboPaciente.Enabled = false;
            cboPaciente.FormattingEnabled = true;
            cboPaciente.Location = new Point(713, 23);
            cboPaciente.Margin = new Padding(4, 3, 4, 3);
            cboPaciente.Name = "cboPaciente";
            cboPaciente.Size = new Size(230, 23);
            cboPaciente.TabIndex = 131;
            // 
            // cboStatus
            // 
            cboStatus.Enabled = false;
            cboStatus.FormattingEnabled = true;
            cboStatus.Location = new Point(945, 23);
            cboStatus.Margin = new Padding(4, 3, 4, 3);
            cboStatus.Name = "cboStatus";
            cboStatus.Size = new Size(90, 23);
            cboStatus.TabIndex = 130;
            // 
            // cboMedicamento
            // 
            cboMedicamento.Enabled = false;
            cboMedicamento.FormattingEnabled = true;
            cboMedicamento.Location = new Point(152, 23);
            cboMedicamento.Margin = new Padding(4, 3, 4, 3);
            cboMedicamento.Name = "cboMedicamento";
            cboMedicamento.Size = new Size(312, 23);
            cboMedicamento.TabIndex = 129;
            // 
            // cboTipoReceita
            // 
            cboTipoReceita.Enabled = false;
            cboTipoReceita.FormattingEnabled = true;
            cboTipoReceita.Location = new Point(1249, 23);
            cboTipoReceita.Margin = new Padding(4, 3, 4, 3);
            cboTipoReceita.Name = "cboTipoReceita";
            cboTipoReceita.Size = new Size(96, 23);
            cboTipoReceita.TabIndex = 126;
            // 
            // cboZona
            // 
            cboZona.Enabled = false;
            cboZona.FormattingEnabled = true;
            cboZona.Location = new Point(1152, 23);
            cboZona.Margin = new Padding(4, 3, 4, 3);
            cboZona.Name = "cboZona";
            cboZona.Size = new Size(96, 23);
            cboZona.TabIndex = 128;
            // 
            // cboBairro
            // 
            cboBairro.Enabled = false;
            cboBairro.FormattingEnabled = true;
            cboBairro.Location = new Point(1036, 23);
            cboBairro.Margin = new Padding(4, 3, 4, 3);
            cboBairro.Name = "cboBairro";
            cboBairro.Size = new Size(115, 23);
            cboBairro.TabIndex = 127;
            // 
            // cboConvenio
            // 
            cboConvenio.Enabled = false;
            cboConvenio.FormattingEnabled = true;
            cboConvenio.Location = new Point(465, 23);
            cboConvenio.Margin = new Padding(4, 3, 4, 3);
            cboConvenio.Name = "cboConvenio";
            cboConvenio.Size = new Size(96, 23);
            cboConvenio.TabIndex = 132;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.Location = new Point(564, 9);
            label17.Margin = new Padding(4, 0, 4, 0);
            label17.Name = "label17";
            label17.Size = new Size(59, 13);
            label17.TabIndex = 120;
            label17.Text = "Matricula";
            // 
            // txtMatricula
            // 
            txtMatricula.Enabled = false;
            txtMatricula.Location = new Point(562, 23);
            txtMatricula.Margin = new Padding(4, 3, 4, 3);
            txtMatricula.Mask = "0000000000";
            txtMatricula.Name = "txtMatricula";
            txtMatricula.Size = new Size(73, 23);
            txtMatricula.TabIndex = 119;
            // 
            // txtId
            // 
            txtId.Location = new Point(998, -6);
            txtId.Margin = new Padding(4, 3, 4, 3);
            txtId.Mask = "00000";
            txtId.Name = "txtId";
            txtId.Size = new Size(38, 23);
            txtId.TabIndex = 118;
            // 
            // txtEAN
            // 
            txtEAN.Location = new Point(75, 23);
            txtEAN.Margin = new Padding(4, 3, 4, 3);
            txtEAN.Mask = "0000000000000";
            txtEAN.Name = "txtEAN";
            txtEAN.Size = new Size(76, 23);
            txtEAN.TabIndex = 117;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.Purple;
            label12.Location = new Point(286, 8);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(32, 13);
            label12.TabIndex = 109;
            label12.Text = "Lote";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.Navy;
            label11.Location = new Point(365, 8);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(71, 13);
            label11.TabIndex = 110;
            label11.Text = "Nota Fiscal";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Red;
            label10.Location = new Point(528, 8);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(64, 13);
            label10.TabIndex = 112;
            label10.Text = "Qtdd Real";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Green;
            label9.Location = new Point(747, 8);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(33, 13);
            label9.TabIndex = 111;
            label9.Text = "Refil";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Olive;
            label8.Location = new Point(900, 8);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(107, 13);
            label8.TabIndex = 116;
            label8.Text = "Data Consolidade";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(128, 64, 0);
            label7.Location = new Point(1140, 8);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(91, 13);
            label7.TabIndex = 113;
            label7.Text = "Status Entrega";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(77, 9);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(32, 13);
            label3.TabIndex = 115;
            label3.Text = "EAN";
            // 
            // btnPesquisar
            // 
            btnPesquisar.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPesquisar.Location = new Point(839, 642);
            btnPesquisar.Margin = new Padding(4, 3, 4, 3);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(110, 27);
            btnPesquisar.TabIndex = 103;
            btnPesquisar.Text = "&Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = true;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // btnNovo
            // 
            btnNovo.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNovo.Location = new Point(464, 642);
            btnNovo.Margin = new Padding(4, 3, 4, 3);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(110, 27);
            btnNovo.TabIndex = 102;
            btnNovo.Text = "&Novo";
            btnNovo.UseVisualStyleBackColor = true;
            btnNovo.Visible = false;
            // 
            // btnExcluir
            // 
            btnExcluir.Enabled = false;
            btnExcluir.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExcluir.Location = new Point(589, 642);
            btnExcluir.Margin = new Padding(4, 3, 4, 3);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(110, 27);
            btnExcluir.TabIndex = 104;
            btnExcluir.Text = "&Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Visible = false;
            // 
            // btnExportar
            // 
            btnExportar.Enabled = false;
            btnExportar.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExportar.Location = new Point(714, 642);
            btnExportar.Margin = new Padding(4, 3, 4, 3);
            btnExportar.Name = "btnExportar";
            btnExportar.Size = new Size(110, 27);
            btnExportar.TabIndex = 106;
            btnExportar.Text = "&Exportar XLS";
            btnExportar.UseVisualStyleBackColor = true;
            btnExportar.Click += btnExportar_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Enabled = false;
            btnSalvar.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalvar.Location = new Point(962, 642);
            btnSalvar.Margin = new Padding(4, 3, 4, 3);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(110, 27);
            btnSalvar.TabIndex = 105;
            btnSalvar.Text = "&Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpar.Location = new Point(1086, 642);
            btnLimpar.Margin = new Padding(4, 3, 4, 3);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(110, 27);
            btnLimpar.TabIndex = 107;
            btnLimpar.Text = "&Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // btnSair
            // 
            btnSair.BackColor = SystemColors.Control;
            btnSair.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSair.Location = new Point(1211, 642);
            btnSair.Margin = new Padding(4, 3, 4, 3);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(110, 27);
            btnSair.TabIndex = 108;
            btnSair.Text = "Sai&r";
            btnSair.UseVisualStyleBackColor = false;
            btnSair.Click += btnSair_Click;
            // 
            // dgvLista
            // 
            dgvLista.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLista.Location = new Point(4, 49);
            dgvLista.Margin = new Padding(4, 3, 4, 3);
            dgvLista.Name = "dgvLista";
            dgvLista.Size = new Size(1341, 349);
            dgvLista.TabIndex = 101;
            dgvLista.CellClick += dgvLista_CellClick;
            dgvLista.CellFormatting += dgvLista_CellFormatting;
            // 
            // txtLote
            // 
            txtLote.Location = new Point(283, 21);
            txtLote.Margin = new Padding(4, 3, 4, 3);
            txtLote.Mask = "0000000000000";
            txtLote.Name = "txtLote";
            txtLote.Size = new Size(76, 23);
            txtLote.TabIndex = 117;
            // 
            // txtNotaFiscal
            // 
            txtNotaFiscal.Location = new Point(362, 21);
            txtNotaFiscal.Margin = new Padding(4, 3, 4, 3);
            txtNotaFiscal.Mask = "0000000000000";
            txtNotaFiscal.Name = "txtNotaFiscal";
            txtNotaFiscal.Size = new Size(159, 23);
            txtNotaFiscal.TabIndex = 117;
            // 
            // txtReal
            // 
            txtReal.Location = new Point(524, 21);
            txtReal.Name = "txtReal";
            txtReal.Size = new Size(217, 23);
            txtReal.TabIndex = 147;
            // 
            // cboRefil
            // 
            cboRefil.Enabled = false;
            cboRefil.FormattingEnabled = true;
            cboRefil.Location = new Point(744, 21);
            cboRefil.Margin = new Padding(4, 3, 4, 3);
            cboRefil.Name = "cboRefil";
            cboRefil.Size = new Size(150, 23);
            cboRefil.TabIndex = 130;
            // 
            // cboStatusEntrega
            // 
            cboStatusEntrega.Enabled = false;
            cboStatusEntrega.FormattingEnabled = true;
            cboStatusEntrega.Location = new Point(1137, 21);
            cboStatusEntrega.Margin = new Padding(4, 3, 4, 3);
            cboStatusEntrega.Name = "cboStatusEntrega";
            cboStatusEntrega.Size = new Size(138, 23);
            cboStatusEntrega.TabIndex = 130;
            // 
            // dTPRefil
            // 
            dTPRefil.Enabled = false;
            dTPRefil.Location = new Point(897, 21);
            dTPRefil.Margin = new Padding(4, 3, 4, 3);
            dTPRefil.Name = "dTPRefil";
            dTPRefil.Size = new Size(237, 23);
            dTPRefil.TabIndex = 148;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.SeaGreen;
            label5.Location = new Point(15, 8);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(131, 13);
            label5.TabIndex = 109;
            label5.Text = "Receita Itens Entrega";
            // 
            // txtReceitaItensEntregaId
            // 
            txtReceitaItensEntregaId.BackColor = Color.WhiteSmoke;
            txtReceitaItensEntregaId.Enabled = false;
            txtReceitaItensEntregaId.Location = new Point(17, 21);
            txtReceitaItensEntregaId.Margin = new Padding(4, 3, 4, 3);
            txtReceitaItensEntregaId.Mask = "00000000";
            txtReceitaItensEntregaId.Name = "txtReceitaItensEntregaId";
            txtReceitaItensEntregaId.Size = new Size(129, 23);
            txtReceitaItensEntregaId.TabIndex = 117;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Info;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(btnAdicionar);
            panel2.Controls.Add(dGVReceitaItensEntrega);
            panel2.Controls.Add(dTPRefil);
            panel2.Controls.Add(txtReal);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(label18);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(txtLote);
            panel2.Controls.Add(txtReceitaItensId);
            panel2.Controls.Add(txtReceitaItensEntregaId);
            panel2.Controls.Add(txtNotaFiscal);
            panel2.Controls.Add(cboRefil);
            panel2.Controls.Add(cboStatusEntrega);
            panel2.Location = new Point(4, 404);
            panel2.Name = "panel2";
            panel2.Size = new Size(1341, 236);
            panel2.TabIndex = 149;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAdicionar.Location = new Point(1282, 21);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(39, 23);
            btnAdicionar.TabIndex = 150;
            btnAdicionar.Text = "+";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // dGVReceitaItensEntrega
            // 
            dGVReceitaItensEntrega.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dGVReceitaItensEntrega.Location = new Point(14, 50);
            dGVReceitaItensEntrega.Margin = new Padding(4, 3, 4, 3);
            dGVReceitaItensEntrega.Name = "dGVReceitaItensEntrega";
            dGVReceitaItensEntrega.Size = new Size(1307, 180);
            dGVReceitaItensEntrega.TabIndex = 90;
            dGVReceitaItensEntrega.CellContentClick += dGVReceitaItensEntrega_CellContentClick;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label18.ForeColor = Color.SeaGreen;
            label18.Location = new Point(150, 8);
            label18.Margin = new Padding(4, 0, 4, 0);
            label18.Name = "label18";
            label18.Size = new Size(83, 13);
            label18.TabIndex = 109;
            label18.Text = "Receita Itens";
            // 
            // txtReceitaItensId
            // 
            txtReceitaItensId.BackColor = Color.WhiteSmoke;
            txtReceitaItensId.Enabled = false;
            txtReceitaItensId.Location = new Point(151, 21);
            txtReceitaItensId.Margin = new Padding(4, 3, 4, 3);
            txtReceitaItensId.Mask = "00000000";
            txtReceitaItensId.Name = "txtReceitaItensId";
            txtReceitaItensId.Size = new Size(95, 23);
            txtReceitaItensId.TabIndex = 117;
            // 
            // frmPedido
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1360, 669);
            Controls.Add(panel2);
            Controls.Add(chkMostrarIds);
            Controls.Add(label13);
            Controls.Add(label6);
            Controls.Add(txtMesAno);
            Controls.Add(txtCPF);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(label16);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(label20);
            Controls.Add(cboPaciente);
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
            Controls.Add(label3);
            Controls.Add(btnPesquisar);
            Controls.Add(btnNovo);
            Controls.Add(btnExcluir);
            Controls.Add(btnExportar);
            Controls.Add(btnSalvar);
            Controls.Add(btnLimpar);
            Controls.Add(btnSair);
            Controls.Add(dgvLista);
            Name = "frmPedido";
            Text = "Pedido";
            Load += frmPedido_Load;
            ((System.ComponentModel.ISupportInitialize)dgvLista).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtReal).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dGVReceitaItensEntrega).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox chkMostrarIds;
        private Label label13;
        private Label label6;
        private MaskedTextBox txtMesAno;
        private MaskedTextBox txtCPF;
        private Label label2;
        private Label label4;
        private Label label1;
        private Label label16;
        private Label label15;
        private Label label14;
        private Label label20;
        private ComboBox cboPaciente;
        private ComboBox cboStatus;
        private ComboBox cboMedicamento;
        private ComboBox cboTipoReceita;
        private ComboBox cboZona;
        private ComboBox cboBairro;
        private ComboBox cboConvenio;
        private Label label17;
        private MaskedTextBox txtMatricula;
        private MaskedTextBox txtId;
        private MaskedTextBox txtEAN;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label3;
        private Button btnPesquisar;
        private Button btnNovo;
        private Button btnExcluir;
        private Button btnExportar;
        private Button btnSalvar;
        private Button btnLimpar;
        private Button btnSair;
        private DataGridView dgvLista;
        private MaskedTextBox txtLote;
        private MaskedTextBox txtNotaFiscal;
        private NumericUpDown txtReal;
        private ComboBox cboRefil;
        private ComboBox cboStatusEntrega;
        private DateTimePicker dTPRefil;
        private Label label5;
        private MaskedTextBox txtReceitaItensEntregaId;
        private Panel panel2;
        private DataGridView dGVReceitaItensEntrega;
        private Label label18;
        private MaskedTextBox txtReceitaItensId;
        private Button btnAdicionar;
    }
}