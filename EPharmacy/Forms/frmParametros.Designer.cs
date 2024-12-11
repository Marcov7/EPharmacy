namespace EPharmacy.Forms
{
    partial class frmParametros
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
            txtValorParametro = new NumericUpDown();
            txtDirecaoMaisMenos = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnCalcularNovoPreco = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvLista).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtValorParametro).BeginInit();
            SuspendLayout();
            // 
            // btnPesquisar
            // 
            btnPesquisar.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPesquisar.Location = new Point(296, 413);
            btnPesquisar.Margin = new Padding(4, 3, 4, 3);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(111, 27);
            btnPesquisar.TabIndex = 58;
            btnPesquisar.Text = "&Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = true;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // btnNovo
            // 
            btnNovo.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNovo.Location = new Point(182, 413);
            btnNovo.Margin = new Padding(4, 3, 4, 3);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(111, 27);
            btnNovo.TabIndex = 57;
            btnNovo.Text = "&Novo";
            btnNovo.UseVisualStyleBackColor = true;
            btnNovo.Click += btnNovo_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Enabled = false;
            btnExcluir.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExcluir.Location = new Point(524, 413);
            btnExcluir.Margin = new Padding(4, 3, 4, 3);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(111, 27);
            btnExcluir.TabIndex = 59;
            btnExcluir.Text = "&Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Enabled = false;
            btnSalvar.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalvar.Location = new Point(410, 413);
            btnSalvar.Margin = new Padding(4, 3, 4, 3);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(111, 27);
            btnSalvar.TabIndex = 60;
            btnSalvar.Text = "&Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpar.Location = new Point(639, 413);
            btnLimpar.Margin = new Padding(4, 3, 4, 3);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(111, 27);
            btnLimpar.TabIndex = 61;
            btnLimpar.Text = "&Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // btnSair
            // 
            btnSair.BackColor = SystemColors.Control;
            btnSair.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSair.Location = new Point(755, 413);
            btnSair.Margin = new Padding(4, 3, 4, 3);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(111, 27);
            btnSair.TabIndex = 62;
            btnSair.Text = "Sai&r";
            btnSair.UseVisualStyleBackColor = false;
            btnSair.Click += btnSair_Click;
            // 
            // dgvLista
            // 
            dgvLista.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLista.Location = new Point(22, 61);
            dgvLista.Margin = new Padding(4, 3, 4, 3);
            dgvLista.Name = "dgvLista";
            dgvLista.Size = new Size(843, 339);
            dgvLista.TabIndex = 56;
            dgvLista.CellClick += dgvLista_CellClick;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(70, 15);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(143, 13);
            label4.TabIndex = 54;
            label4.Text = "Descrição do Parâmetro";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(22, 15);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(18, 13);
            label7.TabIndex = 55;
            label7.Text = "Id";
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(70, 31);
            txtDescricao.Margin = new Padding(4, 3, 4, 3);
            txtDescricao.MaxLength = 30;
            txtDescricao.Multiline = true;
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(354, 23);
            txtDescricao.TabIndex = 53;
            // 
            // txtId
            // 
            txtId.Location = new Point(22, 31);
            txtId.Margin = new Padding(4, 3, 4, 3);
            txtId.Mask = "00000";
            txtId.Name = "txtId";
            txtId.Size = new Size(44, 23);
            txtId.TabIndex = 52;
            // 
            // txtValorParametro
            // 
            txtValorParametro.DecimalPlaces = 2;
            txtValorParametro.Location = new Point(426, 32);
            txtValorParametro.Name = "txtValorParametro";
            txtValorParametro.Size = new Size(138, 23);
            txtValorParametro.TabIndex = 63;
            // 
            // txtDirecaoMaisMenos
            // 
            txtDirecaoMaisMenos.Location = new Point(567, 32);
            txtDirecaoMaisMenos.Margin = new Padding(4, 3, 4, 3);
            txtDirecaoMaisMenos.MaxLength = 20;
            txtDirecaoMaisMenos.Multiline = true;
            txtDirecaoMaisMenos.Name = "txtDirecaoMaisMenos";
            txtDirecaoMaisMenos.Size = new Size(294, 23);
            txtDirecaoMaisMenos.TabIndex = 53;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(567, 16);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(140, 13);
            label1.TabIndex = 54;
            label1.Text = "Direção Mais ou Menos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(426, 16);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(36, 13);
            label2.TabIndex = 54;
            label2.Text = "Valor";
            // 
            // btnCalcularNovoPreco
            // 
            btnCalcularNovoPreco.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalcularNovoPreco.ForeColor = Color.Red;
            btnCalcularNovoPreco.Location = new Point(20, 413);
            btnCalcularNovoPreco.Margin = new Padding(4, 3, 4, 3);
            btnCalcularNovoPreco.Name = "btnCalcularNovoPreco";
            btnCalcularNovoPreco.Size = new Size(154, 27);
            btnCalcularNovoPreco.TabIndex = 57;
            btnCalcularNovoPreco.Text = "&Calcular Novo Preco";
            btnCalcularNovoPreco.UseVisualStyleBackColor = true;
            btnCalcularNovoPreco.Click += btnCalcularNovoPreco_Click;
            // 
            // frmParametros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(885, 448);
            Controls.Add(txtValorParametro);
            Controls.Add(btnPesquisar);
            Controls.Add(btnCalcularNovoPreco);
            Controls.Add(btnNovo);
            Controls.Add(btnExcluir);
            Controls.Add(btnSalvar);
            Controls.Add(btnLimpar);
            Controls.Add(btnSair);
            Controls.Add(dgvLista);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(label7);
            Controls.Add(txtDirecaoMaisMenos);
            Controls.Add(txtDescricao);
            Controls.Add(txtId);
            Name = "frmParametros";
            Text = "Parâmetros";
            ((System.ComponentModel.ISupportInitialize)dgvLista).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtValorParametro).EndInit();
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
        private Label label4;
        private Label label7;
        private TextBox txtDescricao;
        private MaskedTextBox txtId;
        private NumericUpDown txtPrecoFabrica;
        private TextBox txtDirecaoMaisMenos;
        private Label label1;
        private Label label2;
        private NumericUpDown txtValorParametro;
        private Button btnCalcularNovoPreco;
    }
}