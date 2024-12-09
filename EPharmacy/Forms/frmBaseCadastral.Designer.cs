﻿namespace EPharmacy.Forms
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
            dTPRefil1 = new DateTimePicker();
            dTPRefil2 = new DateTimePicker();
            dTPRefil3 = new DateTimePicker();
            dTPRefil4 = new DateTimePicker();
            dTPRefil5 = new DateTimePicker();
            dTPRefil6 = new DateTimePicker();
            dTPRefilExtra = new DateTimePicker();
            txtId = new MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)dgvLista).BeginInit();
            SuspendLayout();
            // 
            // btnPesquisar
            // 
            btnPesquisar.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPesquisar.Location = new Point(838, 597);
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
            btnNovo.Location = new Point(588, 597);
            btnNovo.Margin = new Padding(4, 3, 4, 3);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(110, 27);
            btnNovo.TabIndex = 79;
            btnNovo.Text = "&Novo";
            btnNovo.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            btnExcluir.Enabled = false;
            btnExcluir.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExcluir.Location = new Point(713, 597);
            btnExcluir.Margin = new Padding(4, 3, 4, 3);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(110, 27);
            btnExcluir.TabIndex = 81;
            btnExcluir.Text = "&Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            btnSalvar.Enabled = false;
            btnSalvar.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalvar.Location = new Point(963, 597);
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
            btnLimpar.Location = new Point(1087, 597);
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
            btnSair.Location = new Point(1212, 597);
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
            dgvLista.Size = new Size(1333, 496);
            dgvLista.TabIndex = 78;
            dgvLista.CellClick += dgvLista_CellClick;
            // 
            // txtEAN
            // 
            txtEAN.Location = new Point(14, 23);
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
            label3.Location = new Point(16, 9);
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
            label20.Location = new Point(405, 9);
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
            cboConvenio.Location = new Point(405, 23);
            cboConvenio.Margin = new Padding(4, 3, 4, 3);
            cboConvenio.Name = "cboConvenio";
            cboConvenio.Size = new Size(96, 23);
            cboConvenio.TabIndex = 94;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.Location = new Point(503, 9);
            label17.Margin = new Padding(4, 0, 4, 0);
            label17.Name = "label17";
            label17.Size = new Size(59, 13);
            label17.TabIndex = 92;
            label17.Text = "Matricula";
            // 
            // txtMatricula
            // 
            txtMatricula.Enabled = false;
            txtMatricula.Location = new Point(502, 23);
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
            label4.Location = new Point(577, 9);
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
            cboStatus.Location = new Point(885, 23);
            cboStatus.Margin = new Padding(4, 3, 4, 3);
            cboStatus.Name = "cboStatus";
            cboStatus.Size = new Size(90, 23);
            cboStatus.TabIndex = 94;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(886, 9);
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
            label2.Location = new Point(90, 9);
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
            label6.Location = new Point(808, 9);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(30, 13);
            label6.TabIndex = 98;
            label6.Text = "CPF";
            // 
            // txtCPF
            // 
            txtCPF.Location = new Point(807, 23);
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
            cboMedicamento.Location = new Point(91, 23);
            cboMedicamento.Margin = new Padding(4, 3, 4, 3);
            cboMedicamento.Name = "cboMedicamento";
            cboMedicamento.Size = new Size(312, 23);
            cboMedicamento.TabIndex = 94;
            // 
            // cboPaciente
            // 
            cboPaciente.Enabled = false;
            cboPaciente.FormattingEnabled = true;
            cboPaciente.Location = new Point(576, 23);
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
            label7.Location = new Point(204, 56);
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
            label8.Location = new Point(394, 56);
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
            label9.Location = new Point(584, 56);
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
            label10.Location = new Point(774, 56);
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
            label11.Location = new Point(968, 56);
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
            label12.Location = new Point(1162, 56);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(66, 13);
            label12.TabIndex = 85;
            label12.Text = "Refil Extra";
            // 
            // dTPRefil1
            // 
            dTPRefil1.Enabled = false;
            dTPRefil1.Font = new Font("Segoe UI", 8F);
            dTPRefil1.Location = new Point(13, 69);
            dTPRefil1.Margin = new Padding(4, 3, 4, 3);
            dTPRefil1.Name = "dTPRefil1";
            dTPRefil1.Size = new Size(187, 22);
            dTPRefil1.TabIndex = 99;
            dTPRefil1.ValueChanged += dTPRefil1_ValueChanged;
            // 
            // dTPRefil2
            // 
            dTPRefil2.Enabled = false;
            dTPRefil2.Font = new Font("Segoe UI", 8F);
            dTPRefil2.Location = new Point(204, 69);
            dTPRefil2.Margin = new Padding(4, 3, 4, 3);
            dTPRefil2.Name = "dTPRefil2";
            dTPRefil2.Size = new Size(187, 22);
            dTPRefil2.TabIndex = 99;
            // 
            // dTPRefil3
            // 
            dTPRefil3.Enabled = false;
            dTPRefil3.Font = new Font("Segoe UI", 8F);
            dTPRefil3.Location = new Point(395, 69);
            dTPRefil3.Margin = new Padding(4, 3, 4, 3);
            dTPRefil3.Name = "dTPRefil3";
            dTPRefil3.Size = new Size(187, 22);
            dTPRefil3.TabIndex = 99;
            // 
            // dTPRefil4
            // 
            dTPRefil4.Enabled = false;
            dTPRefil4.Font = new Font("Segoe UI", 8F);
            dTPRefil4.Location = new Point(586, 69);
            dTPRefil4.Margin = new Padding(4, 3, 4, 3);
            dTPRefil4.Name = "dTPRefil4";
            dTPRefil4.Size = new Size(187, 22);
            dTPRefil4.TabIndex = 99;
            // 
            // dTPRefil5
            // 
            dTPRefil5.Enabled = false;
            dTPRefil5.Font = new Font("Segoe UI", 8F);
            dTPRefil5.Location = new Point(777, 69);
            dTPRefil5.Margin = new Padding(4, 3, 4, 3);
            dTPRefil5.Name = "dTPRefil5";
            dTPRefil5.Size = new Size(187, 22);
            dTPRefil5.TabIndex = 99;
            // 
            // dTPRefil6
            // 
            dTPRefil6.Enabled = false;
            dTPRefil6.Font = new Font("Segoe UI", 8F);
            dTPRefil6.Location = new Point(968, 69);
            dTPRefil6.Margin = new Padding(4, 3, 4, 3);
            dTPRefil6.Name = "dTPRefil6";
            dTPRefil6.Size = new Size(187, 22);
            dTPRefil6.TabIndex = 99;
            // 
            // dTPRefilExtra
            // 
            dTPRefilExtra.Enabled = false;
            dTPRefilExtra.Font = new Font("Segoe UI", 8F);
            dTPRefilExtra.Location = new Point(1159, 69);
            dTPRefilExtra.Margin = new Padding(4, 3, 4, 3);
            dTPRefilExtra.Name = "dTPRefilExtra";
            dTPRefilExtra.Size = new Size(187, 22);
            dTPRefilExtra.TabIndex = 99;
            // 
            // txtId
            // 
            txtId.Location = new Point(937, -6);
            txtId.Margin = new Padding(4, 3, 4, 3);
            txtId.Mask = "00000";
            txtId.Name = "txtId";
            txtId.Size = new Size(38, 23);
            txtId.TabIndex = 87;
            // 
            // frmBaseCadastral
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1355, 630);
            Controls.Add(dTPRefilExtra);
            Controls.Add(dTPRefil6);
            Controls.Add(dTPRefil5);
            Controls.Add(dTPRefil4);
            Controls.Add(dTPRefil3);
            Controls.Add(dTPRefil2);
            Controls.Add(dTPRefil1);
            Controls.Add(label6);
            Controls.Add(txtCPF);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(label20);
            Controls.Add(cboPaciente);
            Controls.Add(cboStatus);
            Controls.Add(cboMedicamento);
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
            Controls.Add(btnSalvar);
            Controls.Add(btnLimpar);
            Controls.Add(btnSair);
            Controls.Add(dgvLista);
            Name = "frmBaseCadastral";
            Text = "Base Cadastral";
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
        private DateTimePicker dTPRefil1;
        private DateTimePicker dTPRefil2;
        private DateTimePicker dTPRefil3;
        private DateTimePicker dTPRefil4;
        private DateTimePicker dTPRefil5;
        private DateTimePicker dTPRefil6;
        private DateTimePicker dTPRefilExtra;
        private MaskedTextBox txtId;
    }
}