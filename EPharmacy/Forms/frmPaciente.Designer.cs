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
            txtTelefone = new MaskedTextBox();
            dTPDataPrimeiroAtendimento = new DateTimePicker();
            label16 = new Label();
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
            dgvLista.Location = new Point(22, 179);
            dgvLista.Margin = new Padding(4, 3, 4, 3);
            dgvLista.Name = "dgvLista";
            dgvLista.Size = new Size(935, 343);
            dgvLista.TabIndex = 79;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(181, 74);
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
            label2.Location = new Point(25, 74);
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
            label6.Location = new Point(527, 22);
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
            label5.Location = new Point(300, 22);
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
            label8.Location = new Point(624, 22);
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
            label1.Location = new Point(866, 22);
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
            txtLogradouro.Location = new Point(179, 90);
            txtLogradouro.Margin = new Padding(4, 3, 4, 3);
            txtLogradouro.MaxLength = 255;
            txtLogradouro.Multiline = true;
            txtLogradouro.Name = "txtLogradouro";
            txtLogradouro.Size = new Size(322, 23);
            txtLogradouro.TabIndex = 69;
            // 
            // txtNomeSocial
            // 
            txtNomeSocial.Location = new Point(295, 38);
            txtNomeSocial.Margin = new Padding(4, 3, 4, 3);
            txtNomeSocial.MaxLength = 255;
            txtNomeSocial.Multiline = true;
            txtNomeSocial.Name = "txtNomeSocial";
            txtNomeSocial.Size = new Size(219, 23);
            txtNomeSocial.TabIndex = 66;
            // 
            // dTPNascimento
            // 
            dTPNascimento.Location = new Point(620, 38);
            dTPNascimento.Margin = new Padding(4, 3, 4, 3);
            dTPNascimento.Name = "dTPNascimento";
            dTPNascimento.Size = new Size(237, 23);
            dTPNascimento.TabIndex = 65;
            // 
            // cboSexo
            // 
            cboSexo.Enabled = false;
            cboSexo.Location = new Point(862, 38);
            cboSexo.Margin = new Padding(4, 3, 4, 3);
            cboSexo.MaxLength = 255;
            cboSexo.Name = "cboSexo";
            cboSexo.Size = new Size(95, 23);
            cboSexo.TabIndex = 64;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(64, 38);
            txtNome.Margin = new Padding(4, 3, 4, 3);
            txtNome.MaxLength = 255;
            txtNome.Multiline = true;
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(227, 23);
            txtNome.TabIndex = 70;
            // 
            // txtId
            // 
            txtId.Location = new Point(22, 38);
            txtId.Margin = new Padding(4, 3, 4, 3);
            txtId.Mask = "00000";
            txtId.Name = "txtId";
            txtId.Size = new Size(40, 23);
            txtId.TabIndex = 63;
            // 
            // txtComplemento
            // 
            txtComplemento.Enabled = false;
            txtComplemento.Location = new Point(22, 138);
            txtComplemento.Margin = new Padding(4, 3, 4, 3);
            txtComplemento.MaxLength = 255;
            txtComplemento.Multiline = true;
            txtComplemento.Name = "txtComplemento";
            txtComplemento.Size = new Size(249, 23);
            txtComplemento.TabIndex = 64;
            // 
            // txtUF
            // 
            txtUF.Enabled = false;
            txtUF.Location = new Point(275, 138);
            txtUF.Margin = new Padding(4, 3, 4, 3);
            txtUF.MaxLength = 255;
            txtUF.Multiline = true;
            txtUF.Name = "txtUF";
            txtUF.Size = new Size(165, 23);
            txtUF.TabIndex = 68;
            // 
            // txtEmail
            // 
            txtEmail.Enabled = false;
            txtEmail.Location = new Point(535, 138);
            txtEmail.Margin = new Padding(4, 3, 4, 3);
            txtEmail.MaxLength = 255;
            txtEmail.Multiline = true;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(180, 23);
            txtEmail.TabIndex = 69;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(22, 122);
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
            label10.Location = new Point(279, 122);
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
            label11.Location = new Point(539, 122);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(37, 13);
            label11.TabIndex = 76;
            label11.Text = "Email";
            // 
            // txtNumero
            // 
            txtNumero.Enabled = false;
            txtNumero.Location = new Point(505, 90);
            txtNumero.Margin = new Padding(4, 3, 4, 3);
            txtNumero.MaxLength = 255;
            txtNumero.Multiline = true;
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(83, 23);
            txtNumero.TabIndex = 69;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(509, 74);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(50, 13);
            label12.TabIndex = 76;
            label12.Text = "Número";
            // 
            // txtBairro
            // 
            txtBairro.Enabled = false;
            txtBairro.Location = new Point(592, 90);
            txtBairro.Margin = new Padding(4, 3, 4, 3);
            txtBairro.MaxLength = 255;
            txtBairro.Multiline = true;
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(190, 23);
            txtBairro.TabIndex = 69;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(595, 74);
            label13.Margin = new Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new Size(40, 13);
            label13.TabIndex = 76;
            label13.Text = "Bairro";
            // 
            // txtMunicipio
            // 
            txtMunicipio.Enabled = false;
            txtMunicipio.Location = new Point(786, 90);
            txtMunicipio.Margin = new Padding(4, 3, 4, 3);
            txtMunicipio.MaxLength = 255;
            txtMunicipio.Multiline = true;
            txtMunicipio.Name = "txtMunicipio";
            txtMunicipio.Size = new Size(170, 23);
            txtMunicipio.TabIndex = 68;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(788, 74);
            label14.Margin = new Padding(4, 0, 4, 0);
            label14.Name = "label14";
            label14.Size = new Size(61, 13);
            label14.TabIndex = 75;
            label14.Text = "Municipio";
            // 
            // txtCPF
            // 
            txtCPF.Location = new Point(519, 38);
            txtCPF.Margin = new Padding(4, 3, 4, 3);
            txtCPF.Mask = "000.000.000-00";
            txtCPF.Name = "txtCPF";
            txtCPF.Size = new Size(96, 23);
            txtCPF.TabIndex = 63;
            // 
            // txtCEP
            // 
            txtCEP.Enabled = false;
            txtCEP.Location = new Point(22, 90);
            txtCEP.Margin = new Padding(4, 3, 4, 3);
            txtCEP.Mask = "00.000-000";
            txtCEP.Name = "txtCEP";
            txtCEP.Size = new Size(64, 23);
            txtCEP.TabIndex = 63;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.Location = new Point(444, 122);
            label15.Margin = new Padding(4, 0, 4, 0);
            label15.Name = "label15";
            label15.Size = new Size(57, 13);
            label15.TabIndex = 76;
            label15.Text = "Telefone";
            // 
            // txtTelefone
            // 
            txtTelefone.Enabled = false;
            txtTelefone.Location = new Point(443, 138);
            txtTelefone.Margin = new Padding(4, 3, 4, 3);
            txtTelefone.Mask = "(00) 00000-0000";
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(89, 23);
            txtTelefone.TabIndex = 63;
            // 
            // dTPDataPrimeiroAtendimento
            // 
            dTPDataPrimeiroAtendimento.Location = new Point(719, 138);
            dTPDataPrimeiroAtendimento.Margin = new Padding(4, 3, 4, 3);
            dTPDataPrimeiroAtendimento.Name = "dTPDataPrimeiroAtendimento";
            dTPDataPrimeiroAtendimento.Size = new Size(237, 23);
            dTPDataPrimeiroAtendimento.TabIndex = 65;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.Location = new Point(722, 122);
            label16.Margin = new Padding(4, 0, 4, 0);
            label16.Name = "label16";
            label16.Size = new Size(157, 13);
            label16.TabIndex = 73;
            label16.Text = "Data Primeiro Atendimento";
            // 
            // frmPaciente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(981, 573);
            Controls.Add(btnPesquisar);
            Controls.Add(btnNovo);
            Controls.Add(btnExcluir);
            Controls.Add(btnSalvar);
            Controls.Add(btnLimpar);
            Controls.Add(btnSair);
            Controls.Add(dgvLista);
            Controls.Add(label15);
            Controls.Add(label11);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label3);
            Controls.Add(label10);
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
            Controls.Add(txtUF);
            Controls.Add(txtMunicipio);
            Controls.Add(txtNomeSocial);
            Controls.Add(dTPDataPrimeiroAtendimento);
            Controls.Add(dTPNascimento);
            Controls.Add(txtComplemento);
            Controls.Add(cboSexo);
            Controls.Add(txtTelefone);
            Controls.Add(txtCPF);
            Controls.Add(txtNome);
            Controls.Add(txtCEP);
            Controls.Add(txtId);
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
        private MaskedTextBox txtTelefone;
        private DateTimePicker dTPDataPrimeiroAtendimento;
        private Label label16;
    }
}