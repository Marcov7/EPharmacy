namespace EPharmacy.Forms
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
            label4 = new Label();
            label7 = new Label();
            txtDescricao = new TextBox();
            txtId = new MaskedTextBox();
            label5 = new Label();
            cboPaciente = new ComboBox();
            label16 = new Label();
            dTPUltimaReceita = new DateTimePicker();
            cboTipoEntrega = new ComboBox();
            label6 = new Label();
            cboPeriodicidadeRefil = new ComboBox();
            label8 = new Label();
            cboConvenio = new ComboBox();
            label9 = new Label();
            cboClinica = new ComboBox();
            label10 = new Label();
            cboMedico = new ComboBox();
            label1 = new Label();
            panel1 = new Panel();
            label14 = new Label();
            label2 = new Label();
            dTPReceita = new DateTimePicker();
            panel2 = new Panel();
            txtReceitaId = new TextBox();
            btnAdicionar = new Button();
            dGVReceitaItens = new DataGridView();
            txtReceitaItemId = new MaskedTextBox();
            label12 = new Label();
            label13 = new Label();
            label11 = new Label();
            label3 = new Label();
            cboMedicamento = new ComboBox();
            cboStatus = new ComboBox();
            RECEITA = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvLista).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dGVReceitaItens).BeginInit();
            SuspendLayout();
            // 
            // btnPesquisar
            // 
            btnPesquisar.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPesquisar.Location = new Point(673, 585);
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
            btnNovo.Location = new Point(552, 585);
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
            btnExcluir.Location = new Point(915, 585);
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
            btnSalvar.Location = new Point(794, 585);
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
            btnLimpar.Location = new Point(1036, 585);
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
            btnSair.Location = new Point(1157, 585);
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
            dgvLista.Location = new Point(22, 170);
            dgvLista.Margin = new Padding(4, 3, 4, 3);
            dgvLista.Name = "dgvLista";
            dgvLista.Size = new Size(1245, 127);
            dgvLista.TabIndex = 90;
            dgvLista.CellClick += dgvLista_CellClick;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(86, 29);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(64, 13);
            label4.TabIndex = 85;
            label4.Text = "Descrição";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(22, 29);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(18, 13);
            label7.TabIndex = 89;
            label7.Text = "Id";
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(86, 45);
            txtDescricao.Margin = new Padding(4, 3, 4, 3);
            txtDescricao.MaxLength = 255;
            txtDescricao.Multiline = true;
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(458, 23);
            txtDescricao.TabIndex = 84;
            // 
            // txtId
            // 
            txtId.Location = new Point(22, 45);
            txtId.Margin = new Padding(4, 3, 4, 3);
            txtId.Mask = "00000";
            txtId.Name = "txtId";
            txtId.Size = new Size(60, 23);
            txtId.TabIndex = 80;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(552, 29);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(57, 13);
            label5.TabIndex = 98;
            label5.Text = "Paciente";
            // 
            // cboPaciente
            // 
            cboPaciente.Enabled = false;
            cboPaciente.Location = new Point(548, 45);
            cboPaciente.Margin = new Padding(4, 3, 4, 3);
            cboPaciente.MaxLength = 255;
            cboPaciente.Name = "cboPaciente";
            cboPaciente.Size = new Size(476, 23);
            cboPaciente.TabIndex = 97;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.Location = new Point(1033, 29);
            label16.Margin = new Padding(4, 0, 4, 0);
            label16.Name = "label16";
            label16.Size = new Size(121, 13);
            label16.TabIndex = 100;
            label16.Text = "Data Última Receita";
            // 
            // dTPUltimaReceita
            // 
            dTPUltimaReceita.Enabled = false;
            dTPUltimaReceita.Location = new Point(1030, 45);
            dTPUltimaReceita.Margin = new Padding(4, 3, 4, 3);
            dTPUltimaReceita.Name = "dTPUltimaReceita";
            dTPUltimaReceita.Size = new Size(237, 23);
            dTPUltimaReceita.TabIndex = 99;
            // 
            // cboTipoEntrega
            // 
            cboTipoEntrega.Enabled = false;
            cboTipoEntrega.Location = new Point(266, 90);
            cboTipoEntrega.Margin = new Padding(4, 3, 4, 3);
            cboTipoEntrega.MaxLength = 255;
            cboTipoEntrega.Name = "cboTipoEntrega";
            cboTipoEntrega.Size = new Size(458, 23);
            cboTipoEntrega.TabIndex = 97;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(856, 16);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(114, 13);
            label6.TabIndex = 98;
            label6.Text = "Periodicidade Refil";
            // 
            // cboPeriodicidadeRefil
            // 
            cboPeriodicidadeRefil.Enabled = false;
            cboPeriodicidadeRefil.Location = new Point(856, 32);
            cboPeriodicidadeRefil.Margin = new Padding(4, 3, 4, 3);
            cboPeriodicidadeRefil.MaxLength = 255;
            cboPeriodicidadeRefil.Name = "cboPeriodicidadeRefil";
            cboPeriodicidadeRefil.Size = new Size(134, 23);
            cboPeriodicidadeRefil.TabIndex = 97;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(254, 52);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(80, 13);
            label8.TabIndex = 98;
            label8.Text = "Tipo Entrega";
            // 
            // cboConvenio
            // 
            cboConvenio.Enabled = false;
            cboConvenio.Location = new Point(732, 90);
            cboConvenio.Margin = new Padding(4, 3, 4, 3);
            cboConvenio.MaxLength = 255;
            cboConvenio.Name = "cboConvenio";
            cboConvenio.Size = new Size(535, 23);
            cboConvenio.TabIndex = 97;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(720, 52);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(60, 13);
            label9.TabIndex = 98;
            label9.Text = "Convênio";
            // 
            // cboClinica
            // 
            cboClinica.Enabled = false;
            cboClinica.Location = new Point(22, 134);
            cboClinica.Margin = new Padding(4, 3, 4, 3);
            cboClinica.MaxLength = 255;
            cboClinica.Name = "cboClinica";
            cboClinica.Size = new Size(616, 23);
            cboClinica.TabIndex = 97;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(25, 118);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(47, 13);
            label10.TabIndex = 98;
            label10.Text = "Clínica";
            // 
            // cboMedico
            // 
            cboMedico.Enabled = false;
            cboMedico.Location = new Point(646, 134);
            cboMedico.Margin = new Padding(4, 3, 4, 3);
            cboMedico.MaxLength = 255;
            cboMedico.Name = "cboMedico";
            cboMedico.Size = new Size(621, 23);
            cboMedico.TabIndex = 97;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(649, 118);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(48, 13);
            label1.TabIndex = 98;
            label1.Text = "Médico";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label14);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(dTPReceita);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(11, 21);
            panel1.Name = "panel1";
            panel1.Size = new Size(1268, 558);
            panel1.TabIndex = 101;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(14, 52);
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
            label2.Location = new Point(14, 285);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(101, 13);
            label2.TabIndex = 89;
            label2.Text = "RECEITA ITENS";
            // 
            // dTPReceita
            // 
            dTPReceita.Enabled = false;
            dTPReceita.Location = new Point(11, 68);
            dTPReceita.Margin = new Padding(4, 3, 4, 3);
            dTPReceita.Name = "dTPReceita";
            dTPReceita.Size = new Size(237, 23);
            dTPReceita.TabIndex = 99;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Window;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(txtReceitaId);
            panel2.Controls.Add(btnAdicionar);
            panel2.Controls.Add(dGVReceitaItens);
            panel2.Controls.Add(txtReceitaItemId);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(label13);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(cboMedicamento);
            panel2.Controls.Add(cboStatus);
            panel2.Controls.Add(cboPeriodicidadeRefil);
            panel2.Location = new Point(11, 294);
            panel2.Name = "panel2";
            panel2.Size = new Size(1245, 259);
            panel2.TabIndex = 101;
            // 
            // txtReceitaId
            // 
            txtReceitaId.Enabled = false;
            txtReceitaId.Location = new Point(88, 32);
            txtReceitaId.Margin = new Padding(4, 3, 4, 3);
            txtReceitaId.MaxLength = 255;
            txtReceitaId.Multiline = true;
            txtReceitaId.Name = "txtReceitaId";
            txtReceitaId.Size = new Size(68, 23);
            txtReceitaId.TabIndex = 102;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAdicionar.Location = new Point(1149, 31);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(38, 23);
            btnAdicionar.TabIndex = 99;
            btnAdicionar.Text = "+";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // dGVReceitaItens
            // 
            dGVReceitaItens.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dGVReceitaItens.Location = new Point(18, 60);
            dGVReceitaItens.Margin = new Padding(4, 3, 4, 3);
            dGVReceitaItens.Name = "dGVReceitaItens";
            dGVReceitaItens.Size = new Size(1210, 193);
            dGVReceitaItens.TabIndex = 90;
            dGVReceitaItens.CellContentClick += dGVReceitaItens_CellContentClick;
            // 
            // txtReceitaItemId
            // 
            txtReceitaItemId.Location = new Point(20, 32);
            txtReceitaItemId.Margin = new Padding(4, 3, 4, 3);
            txtReceitaItemId.Mask = "00000";
            txtReceitaItemId.Name = "txtReceitaItemId";
            txtReceitaItemId.Size = new Size(60, 23);
            txtReceitaItemId.TabIndex = 80;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(167, 16);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(82, 13);
            label12.TabIndex = 98;
            label12.Text = "Medicamento";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(997, 15);
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
            label11.Location = new Point(87, 16);
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
            label3.Location = new Point(20, 16);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(18, 13);
            label3.TabIndex = 89;
            label3.Text = "Id";
            // 
            // cboMedicamento
            // 
            cboMedicamento.Enabled = false;
            cboMedicamento.Location = new Point(164, 32);
            cboMedicamento.Margin = new Padding(4, 3, 4, 3);
            cboMedicamento.MaxLength = 255;
            cboMedicamento.Name = "cboMedicamento";
            cboMedicamento.Size = new Size(684, 23);
            cboMedicamento.TabIndex = 97;
            // 
            // cboStatus
            // 
            cboStatus.Enabled = false;
            cboStatus.Location = new Point(997, 31);
            cboStatus.Margin = new Padding(4, 3, 4, 3);
            cboStatus.MaxLength = 255;
            cboStatus.Name = "cboStatus";
            cboStatus.Size = new Size(146, 23);
            cboStatus.TabIndex = 97;
            // 
            // RECEITA
            // 
            RECEITA.AutoSize = true;
            RECEITA.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RECEITA.Location = new Point(14, 11);
            RECEITA.Margin = new Padding(4, 0, 4, 0);
            RECEITA.Name = "RECEITA";
            RECEITA.Size = new Size(60, 13);
            RECEITA.TabIndex = 89;
            RECEITA.Text = "RECEITA";
            // 
            // frmReceita
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1291, 618);
            Controls.Add(label16);
            Controls.Add(dTPUltimaReceita);
            Controls.Add(label1);
            Controls.Add(label10);
            Controls.Add(label5);
            Controls.Add(cboMedico);
            Controls.Add(cboClinica);
            Controls.Add(cboConvenio);
            Controls.Add(cboTipoEntrega);
            Controls.Add(cboPaciente);
            Controls.Add(btnPesquisar);
            Controls.Add(btnNovo);
            Controls.Add(btnExcluir);
            Controls.Add(btnSalvar);
            Controls.Add(btnLimpar);
            Controls.Add(btnSair);
            Controls.Add(dgvLista);
            Controls.Add(label4);
            Controls.Add(RECEITA);
            Controls.Add(label7);
            Controls.Add(txtDescricao);
            Controls.Add(txtId);
            Controls.Add(panel1);
            Name = "frmReceita";
            Text = "Receita";
            Load += frmReceita_Load;
            ((System.ComponentModel.ISupportInitialize)dgvLista).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
        private Label label4;
        private Label label7;
        private TextBox txtEmail;
        private TextBox txtSenha;
        private TextBox txtLogin;
        private TextBox txtDescricao;
        private MaskedTextBox txtId;
        private Label label5;
        private ComboBox cboPaciente;
        private Label label16;
        private DateTimePicker dTPUltimaReceita;
        private ComboBox cboTipoEntrega;
        private Label label6;
        private ComboBox cboPeriodicidadeRefil;
        private Label label8;
        private ComboBox cboConvenio;
        private Label label9;
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
        private DateTimePicker dTPReceita;
        private Button btnSubtrair;
    }
}