﻿namespace EPharmacy.Forms
{
    partial class frmReceita
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
            txtDescricao = new TextBox();
            txtId = new MaskedTextBox();
            cboPaciente = new ComboBox();
            dTPDataReceitaAnterior = new DateTimePicker();
            cboPeriodicidadeRefil = new ComboBox();
            cboClinica = new ComboBox();
            label10 = new Label();
            cboMedico = new ComboBox();
            label1 = new Label();
            panel1 = new Panel();
            label16 = new Label();
            dGVMedicamentosReceitasPac = new DataGridView();
            dTPReceita = new MaskedTextBox();
            chkAumentaLarguraColunasGrid = new CheckBox();
            chkMostrarIds = new CheckBox();
            label5 = new Label();
            label15 = new Label();
            label9 = new Label();
            txtCPF = new MaskedTextBox();
            label14 = new Label();
            label2 = new Label();
            panel2 = new Panel();
            dGVReceitaItens = new DataGridView();
            lblObs = new Label();
            txtObs = new TextBox();
            txtReceitaId = new TextBox();
            btnAdicionar = new Button();
            txtReceitaItemId = new MaskedTextBox();
            label12 = new Label();
            label7 = new Label();
            label6 = new Label();
            label8 = new Label();
            label17 = new Label();
            label4 = new Label();
            label13 = new Label();
            label11 = new Label();
            label3 = new Label();
            cboMedicamento = new ComboBox();
            cboStatus = new ComboBox();
            cboPeriodicidadeRefilAnterior = new ComboBox();
            txtQtddAnterior = new MaskedTextBox();
            txtQtdd = new MaskedTextBox();
            RECEITA = new Label();
            btnAtualizaListaMedicamentos = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvLista).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dGVMedicamentosReceitasPac).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dGVReceitaItens).BeginInit();
            SuspendLayout();
            // 
            // btnPesquisar
            // 
            btnPesquisar.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPesquisar.Location = new Point(673, 642);
            btnPesquisar.Margin = new Padding(4, 3, 4, 3);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(110, 27);
            btnPesquisar.TabIndex = 92;
            btnPesquisar.Text = "&Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = true;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // btnNovo
            // 
            btnNovo.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNovo.Location = new Point(552, 642);
            btnNovo.Margin = new Padding(4, 3, 4, 3);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(110, 27);
            btnNovo.TabIndex = 91;
            btnNovo.Text = "&Novo";
            btnNovo.UseVisualStyleBackColor = true;
            btnNovo.Click += btnNovo_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Enabled = false;
            btnExcluir.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExcluir.Location = new Point(915, 642);
            btnExcluir.Margin = new Padding(4, 3, 4, 3);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(110, 27);
            btnExcluir.TabIndex = 93;
            btnExcluir.Text = "&Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Enabled = false;
            btnSalvar.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalvar.Location = new Point(794, 642);
            btnSalvar.Margin = new Padding(4, 3, 4, 3);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(110, 27);
            btnSalvar.TabIndex = 94;
            btnSalvar.Text = "&Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpar.Location = new Point(1036, 642);
            btnLimpar.Margin = new Padding(4, 3, 4, 3);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(110, 27);
            btnLimpar.TabIndex = 95;
            btnLimpar.Text = "&Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // btnSair
            // 
            btnSair.BackColor = SystemColors.Control;
            btnSair.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSair.Location = new Point(1157, 642);
            btnSair.Margin = new Padding(4, 3, 4, 3);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(110, 27);
            btnSair.TabIndex = 96;
            btnSair.Text = "Sai&r";
            btnSair.UseVisualStyleBackColor = false;
            btnSair.Click += btnSair_Click;
            // 
            // dgvLista
            // 
            dgvLista.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLista.Location = new Point(22, 65);
            dgvLista.Margin = new Padding(4, 3, 4, 3);
            dgvLista.Name = "dgvLista";
            dgvLista.Size = new Size(1030, 192);
            dgvLista.TabIndex = 90;
            dgvLista.CellClick += dgvLista_CellClick;
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(85, 39);
            txtDescricao.Margin = new Padding(4, 3, 4, 3);
            txtDescricao.MaxLength = 255;
            txtDescricao.Multiline = true;
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(335, 23);
            txtDescricao.TabIndex = 84;
            // 
            // txtId
            // 
            txtId.Location = new Point(22, 39);
            txtId.Margin = new Padding(4, 3, 4, 3);
            txtId.Mask = "00000";
            txtId.Name = "txtId";
            txtId.Size = new Size(60, 23);
            txtId.TabIndex = 80;
            // 
            // cboPaciente
            // 
            cboPaciente.Enabled = false;
            cboPaciente.Location = new Point(422, 39);
            cboPaciente.Margin = new Padding(4, 3, 4, 3);
            cboPaciente.MaxLength = 255;
            cboPaciente.Name = "cboPaciente";
            cboPaciente.Size = new Size(428, 23);
            cboPaciente.TabIndex = 97;
            cboPaciente.SelectedIndexChanged += cboPaciente_SelectedIndexChanged;
            cboPaciente.Validating += cboSelecaoPadrao_Validating;
            // 
            // dTPDataReceitaAnterior
            // 
            dTPDataReceitaAnterior.Enabled = false;
            dTPDataReceitaAnterior.Font = new Font("Segoe UI", 7F);
            dTPDataReceitaAnterior.Location = new Point(454, 35);
            dTPDataReceitaAnterior.Margin = new Padding(4, 3, 4, 3);
            dTPDataReceitaAnterior.Name = "dTPDataReceitaAnterior";
            dTPDataReceitaAnterior.Size = new Size(104, 20);
            dTPDataReceitaAnterior.TabIndex = 99;
            // 
            // cboPeriodicidadeRefil
            // 
            cboPeriodicidadeRefil.Enabled = false;
            cboPeriodicidadeRefil.Location = new Point(697, 32);
            cboPeriodicidadeRefil.Margin = new Padding(4, 3, 4, 3);
            cboPeriodicidadeRefil.MaxLength = 255;
            cboPeriodicidadeRefil.Name = "cboPeriodicidadeRefil";
            cboPeriodicidadeRefil.Size = new Size(53, 23);
            cboPeriodicidadeRefil.TabIndex = 97;
            cboPeriodicidadeRefil.Validating += cboSelecaoPadrao_Validating;
            // 
            // cboClinica
            // 
            cboClinica.Enabled = false;
            cboClinica.Location = new Point(87, 47);
            cboClinica.Margin = new Padding(4, 3, 4, 3);
            cboClinica.MaxLength = 255;
            cboClinica.Name = "cboClinica";
            cboClinica.Size = new Size(433, 23);
            cboClinica.TabIndex = 97;
            cboClinica.Visible = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(32, 51);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(47, 13);
            label10.TabIndex = 98;
            label10.Text = "Clínica";
            label10.Visible = false;
            // 
            // cboMedico
            // 
            cboMedico.Enabled = false;
            cboMedico.Location = new Point(587, 47);
            cboMedico.Margin = new Padding(4, 3, 4, 3);
            cboMedico.MaxLength = 255;
            cboMedico.Name = "cboMedico";
            cboMedico.Size = new Size(477, 23);
            cboMedico.TabIndex = 97;
            cboMedico.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(534, 52);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(48, 13);
            label1.TabIndex = 98;
            label1.Text = "Médico";
            label1.Visible = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(192, 255, 255);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnAtualizaListaMedicamentos);
            panel1.Controls.Add(label16);
            panel1.Controls.Add(dGVMedicamentosReceitasPac);
            panel1.Controls.Add(dTPReceita);
            panel1.Controls.Add(chkAumentaLarguraColunasGrid);
            panel1.Controls.Add(chkMostrarIds);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label15);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(txtCPF);
            panel1.Controls.Add(label14);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(cboClinica);
            panel1.Controls.Add(cboMedico);
            panel1.Location = new Point(11, 15);
            panel1.Name = "panel1";
            panel1.Size = new Size(1335, 657);
            panel1.TabIndex = 101;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
            label16.Location = new Point(1046, 9);
            label16.Name = "label16";
            label16.Size = new Size(228, 13);
            label16.TabIndex = 151;
            label16.Text = "Medicamentos em Receita do Paciente";
            // 
            // dGVMedicamentosReceitasPac
            // 
            dGVMedicamentosReceitasPac.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dGVMedicamentosReceitasPac.Location = new Point(1047, 23);
            dGVMedicamentosReceitasPac.Name = "dGVMedicamentosReceitasPac";
            dGVMedicamentosReceitasPac.Size = new Size(280, 591);
            dGVMedicamentosReceitasPac.TabIndex = 150;
            dGVMedicamentosReceitasPac.CellClick += dGVMedicamentosReceitasPac_CellClick;
            // 
            // dTPReceita
            // 
            dTPReceita.Location = new Point(956, 23);
            dTPReceita.Mask = "00/00/0000";
            dTPReceita.Name = "dTPReceita";
            dTPReceita.Size = new Size(80, 23);
            dTPReceita.TabIndex = 149;
            dTPReceita.ValidatingType = typeof(DateTime);
            dTPReceita.Leave += dTPReceita_Leave;
            // 
            // chkAumentaLarguraColunasGrid
            // 
            chkAumentaLarguraColunasGrid.AutoSize = true;
            chkAumentaLarguraColunasGrid.Checked = true;
            chkAumentaLarguraColunasGrid.CheckState = CheckState.Checked;
            chkAumentaLarguraColunasGrid.Location = new Point(141, 629);
            chkAumentaLarguraColunasGrid.Name = "chkAumentaLarguraColunasGrid";
            chkAumentaLarguraColunasGrid.Size = new Size(184, 19);
            chkAumentaLarguraColunasGrid.TabIndex = 148;
            chkAumentaLarguraColunasGrid.Text = "Largura do Tamanho do Dado";
            chkAumentaLarguraColunasGrid.UseVisualStyleBackColor = true;
            chkAumentaLarguraColunasGrid.CheckedChanged += chkAumentaLarguraColunasGrid_CheckedChanged_1;
            // 
            // chkMostrarIds
            // 
            chkMostrarIds.AutoSize = true;
            chkMostrarIds.Location = new Point(10, 629);
            chkMostrarIds.Name = "chkMostrarIds";
            chkMostrarIds.Size = new Size(85, 19);
            chkMostrarIds.TabIndex = 147;
            chkMostrarIds.Text = "Mostrar Ids";
            chkMostrarIds.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(76, 9);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(121, 13);
            label5.TabIndex = 103;
            label5.Text = "Lembrete (Opcional)";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.Location = new Point(415, 9);
            label15.Margin = new Padding(4, 0, 4, 0);
            label15.Name = "label15";
            label15.Size = new Size(57, 13);
            label15.TabIndex = 103;
            label15.Text = "Paciente";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(13, 9);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(18, 13);
            label9.TabIndex = 103;
            label9.Text = "Id";
            // 
            // txtCPF
            // 
            txtCPF.Location = new Point(841, 23);
            txtCPF.Margin = new Padding(4, 3, 4, 3);
            txtCPF.Mask = "000.000.000-00";
            txtCPF.Name = "txtCPF";
            txtCPF.Size = new Size(112, 23);
            txtCPF.TabIndex = 102;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(955, 9);
            label14.Margin = new Padding(4, 0, 4, 0);
            label14.Name = "label14";
            label14.Size = new Size(82, 13);
            label14.TabIndex = 100;
            label14.Text = "Data Receita";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(14, 246);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(101, 13);
            label2.TabIndex = 89;
            label2.Text = "RECEITA ITENS";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Info;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(dGVReceitaItens);
            panel2.Controls.Add(lblObs);
            panel2.Controls.Add(dTPDataReceitaAnterior);
            panel2.Controls.Add(txtObs);
            panel2.Controls.Add(txtReceitaId);
            panel2.Controls.Add(btnAdicionar);
            panel2.Controls.Add(txtReceitaItemId);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label17);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label13);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(cboMedicamento);
            panel2.Controls.Add(cboStatus);
            panel2.Controls.Add(cboPeriodicidadeRefilAnterior);
            panel2.Controls.Add(cboPeriodicidadeRefil);
            panel2.Controls.Add(txtQtddAnterior);
            panel2.Controls.Add(txtQtdd);
            panel2.Location = new Point(11, 253);
            panel2.Name = "panel2";
            panel2.Size = new Size(1316, 369);
            panel2.TabIndex = 101;
            // 
            // dGVReceitaItens
            // 
            dGVReceitaItens.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dGVReceitaItens.Location = new Point(18, 60);
            dGVReceitaItens.Margin = new Padding(4, 3, 4, 3);
            dGVReceitaItens.Name = "dGVReceitaItens";
            dGVReceitaItens.Size = new Size(1010, 300);
            dGVReceitaItens.TabIndex = 90;
            dGVReceitaItens.CellContentClick += dGVReceitaItens_CellContentClick;
            // 
            // lblObs
            // 
            lblObs.AutoSize = true;
            lblObs.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblObs.Location = new Point(861, 16);
            lblObs.Margin = new Padding(4, 0, 4, 0);
            lblObs.Name = "lblObs";
            lblObs.Size = new Size(29, 13);
            lblObs.TabIndex = 98;
            lblObs.Text = "Obs";
            // 
            // txtObs
            // 
            txtObs.Enabled = false;
            txtObs.Location = new Point(857, 32);
            txtObs.Margin = new Padding(4, 3, 4, 3);
            txtObs.MaxLength = 255;
            txtObs.Multiline = true;
            txtObs.Name = "txtObs";
            txtObs.Size = new Size(129, 23);
            txtObs.TabIndex = 102;
            // 
            // txtReceitaId
            // 
            txtReceitaId.Enabled = false;
            txtReceitaId.Location = new Point(108, 150);
            txtReceitaId.Margin = new Padding(4, 3, 4, 3);
            txtReceitaId.MaxLength = 255;
            txtReceitaId.Multiline = true;
            txtReceitaId.Name = "txtReceitaId";
            txtReceitaId.Size = new Size(44, 23);
            txtReceitaId.TabIndex = 102;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAdicionar.Location = new Point(988, 18);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(42, 38);
            btnAdicionar.TabIndex = 99;
            btnAdicionar.Text = "+";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // txtReceitaItemId
            // 
            txtReceitaItemId.Location = new Point(45, 150);
            txtReceitaItemId.Margin = new Padding(4, 3, 4, 3);
            txtReceitaItemId.Mask = "00000";
            txtReceitaItemId.Name = "txtReceitaItemId";
            txtReceitaItemId.Size = new Size(38, 23);
            txtReceitaItemId.TabIndex = 80;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(23, 16);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(82, 13);
            label12.TabIndex = 98;
            label12.Text = "Medicamento";
            // 
            // label7
            // 
            label7.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(612, 4);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(41, 29);
            label7.TabIndex = 98;
            label7.Text = "Nova Qtdd";
            // 
            // label6
            // 
            label6.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(699, 2);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(55, 29);
            label6.TabIndex = 98;
            label6.Text = "Nova Period.";
            // 
            // label8
            // 
            label8.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(649, 2);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(88, 29);
            label8.TabIndex = 98;
            label8.Text = "Period. Anterior";
            // 
            // label17
            // 
            label17.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.Location = new Point(455, 4);
            label17.Margin = new Padding(4, 0, 4, 0);
            label17.Name = "label17";
            label17.Size = new Size(107, 29);
            label17.TabIndex = 98;
            label17.Text = "Data Receita Anterior";
            // 
            // label4
            // 
            label4.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(563, 4);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(53, 29);
            label4.TabIndex = 98;
            label4.Text = "Qtdd Anterior";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(755, 16);
            label13.Margin = new Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new Size(43, 13);
            label13.TabIndex = 98;
            label13.Text = "Status";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(101, 134);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(51, 13);
            label11.TabIndex = 98;
            label11.Text = "Receita";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(45, 114);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(18, 13);
            label3.TabIndex = 89;
            label3.Text = "Id";
            // 
            // cboMedicamento
            // 
            cboMedicamento.Enabled = false;
            cboMedicamento.Location = new Point(20, 32);
            cboMedicamento.Margin = new Padding(4, 3, 4, 3);
            cboMedicamento.MaxLength = 255;
            cboMedicamento.Name = "cboMedicamento";
            cboMedicamento.Size = new Size(432, 23);
            cboMedicamento.TabIndex = 97;
            cboMedicamento.SelectedIndexChanged += cboMedicamento_SelectedIndexChanged;
            cboMedicamento.Validating += cboSelecaoPadrao_Validating;
            // 
            // cboStatus
            // 
            cboStatus.Enabled = false;
            cboStatus.Location = new Point(753, 32);
            cboStatus.Margin = new Padding(4, 3, 4, 3);
            cboStatus.MaxLength = 255;
            cboStatus.Name = "cboStatus";
            cboStatus.Size = new Size(101, 23);
            cboStatus.TabIndex = 97;
            cboStatus.Validating += cboSelecaoPadrao_Validating;
            // 
            // cboPeriodicidadeRefilAnterior
            // 
            cboPeriodicidadeRefilAnterior.Enabled = false;
            cboPeriodicidadeRefilAnterior.Location = new Point(646, 32);
            cboPeriodicidadeRefilAnterior.Margin = new Padding(4, 3, 4, 3);
            cboPeriodicidadeRefilAnterior.MaxLength = 255;
            cboPeriodicidadeRefilAnterior.Name = "cboPeriodicidadeRefilAnterior";
            cboPeriodicidadeRefilAnterior.Size = new Size(49, 23);
            cboPeriodicidadeRefilAnterior.TabIndex = 97;
            // 
            // txtQtddAnterior
            // 
            txtQtddAnterior.Enabled = false;
            txtQtddAnterior.Location = new Point(560, 32);
            txtQtddAnterior.Margin = new Padding(4, 3, 4, 3);
            txtQtddAnterior.Mask = "000";
            txtQtddAnterior.Name = "txtQtddAnterior";
            txtQtddAnterior.Size = new Size(49, 23);
            txtQtddAnterior.TabIndex = 80;
            // 
            // txtQtdd
            // 
            txtQtdd.Location = new Point(610, 32);
            txtQtdd.Margin = new Padding(4, 3, 4, 3);
            txtQtdd.Mask = "000";
            txtQtdd.Name = "txtQtdd";
            txtQtdd.Size = new Size(34, 23);
            txtQtdd.TabIndex = 80;
            // 
            // RECEITA
            // 
            RECEITA.AutoSize = true;
            RECEITA.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RECEITA.Location = new Point(14, 7);
            RECEITA.Margin = new Padding(4, 0, 4, 0);
            RECEITA.Name = "RECEITA";
            RECEITA.Size = new Size(60, 13);
            RECEITA.TabIndex = 89;
            RECEITA.Text = "RECEITA";
            // 
            // btnAtualizaListaMedicamentos
            // 
            btnAtualizaListaMedicamentos.Location = new Point(1290, 0);
            btnAtualizaListaMedicamentos.Name = "btnAtualizaListaMedicamentos";
            btnAtualizaListaMedicamentos.Size = new Size(24, 23);
            btnAtualizaListaMedicamentos.TabIndex = 152;
            btnAtualizaListaMedicamentos.UseVisualStyleBackColor = true;
            btnAtualizaListaMedicamentos.Click += btnAtualizaListaMedicamentos_Click;
            // 
            // frmReceita
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1351, 674);
            Controls.Add(cboPaciente);
            Controls.Add(btnPesquisar);
            Controls.Add(btnNovo);
            Controls.Add(btnExcluir);
            Controls.Add(btnSalvar);
            Controls.Add(btnLimpar);
            Controls.Add(btnSair);
            Controls.Add(dgvLista);
            Controls.Add(RECEITA);
            Controls.Add(txtDescricao);
            Controls.Add(txtId);
            Controls.Add(panel1);
            Name = "frmReceita";
            Text = "Receita";
            WindowState = FormWindowState.Maximized;
            Load += frmReceita_Load;
            ((System.ComponentModel.ISupportInitialize)dgvLista).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dGVMedicamentosReceitasPac).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dGVReceitaItens).EndInit();
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
        private Label RECEITA;
        private TextBox txtEmail;
        private TextBox txtSenha;
        private TextBox txtLogin;
        private TextBox txtDescricao;
        private MaskedTextBox txtId;
        private ComboBox cboPaciente;
        private DateTimePicker dTPUltimaReceita;
        private ComboBox cboTipoEntrega;
        private ComboBox cboPeriodicidadeRefil;
        private Label label8;
        private ComboBox cboClinica;
        private Label label10;
        private ComboBox cboMedico;
        private Label label1;
        private Panel panel1;
        private Panel panel2;
        private Label label2;
        private DataGridView dGVReceitaItens;
        private MaskedTextBox txtReceitaItemId;
        private Label label12;
        private Label label11;
        private ComboBox cboMedicamento;
        private ComboBox cboReceita;
        private Button btnAdicionar;
        private TextBox txtReceitaId;
        private Label label13;
        private ComboBox cboStatus;
        private Label label14;
        private Button btnSubtrair;
        private TextBox txtObs;
        private Label lblObs;
        private MaskedTextBox txtQtdd;
        private DateTimePicker dTPDataReceitaAnterior;
        private Label label5;
        private Label label15;
        private Label label9;
        private MaskedTextBox txtCPF;
        private Label label4;
        private MaskedTextBox txtQtddAnterior;
        private Label label7;
        private CheckBox chkMostrarIds;
        private CheckBox chkAumentaLarguraColunasGrid;
        private MaskedTextBox dTPReceita;
        private Label label17;
        private Label label6;
        private ComboBox cboPeriodicidadeRefilAnterior;
        private DataGridView dGVMedicamentosReceitasPac;
        private Label label16;
        private Button btnAtualizaListaMedicamentos;
    }
}