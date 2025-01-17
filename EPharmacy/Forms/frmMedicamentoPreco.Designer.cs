namespace ControleEntregada.Forms
{
    partial class frmMedicamentoPreco
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
            btnNovo = new Button();
            btnSalvar = new Button();
            btnLimpar = new Button();
            btnSair = new Button();
            dgvMedicamentos = new DataGridView();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            label5 = new Label();
            btnPesquisar = new Button();
            label7 = new Label();
            txtProduto = new TextBox();
            txtId = new MaskedTextBox();
            txtEAN = new MaskedTextBox();
            btnExcluir = new Button();
            txtMedicamentoId = new MaskedTextBox();
            label6 = new Label();
            txtPrecoFabrica = new NumericUpDown();
            txtPMCBrasindice = new NumericUpDown();
            txtPrecoAcordo = new NumericUpDown();
            btnCalcular = new Button();
            txtUnidadesCaixa = new MaskedTextBox();
            label8 = new Label();
            txtPrecoUnitario = new NumericUpDown();
            label9 = new Label();
            numericUpDown2 = new NumericUpDown();
            btnCalcularPrecounitario = new Button();
            maskedTextBox1 = new MaskedTextBox();
            label10 = new Label();
            chkAumentaLarguraColunasGrid = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)dgvMedicamentos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtPrecoFabrica).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtPMCBrasindice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtPrecoAcordo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtPrecoUnitario).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            SuspendLayout();
            // 
            // btnNovo
            // 
            btnNovo.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNovo.Location = new Point(457, 566);
            btnNovo.Margin = new Padding(4, 3, 4, 3);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(110, 27);
            btnNovo.TabIndex = 23;
            btnNovo.Text = "&Novo";
            btnNovo.UseVisualStyleBackColor = true;
            btnNovo.Click += btnNovo_Click_1;
            // 
            // btnSalvar
            // 
            btnSalvar.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalvar.Location = new Point(711, 567);
            btnSalvar.Margin = new Padding(4, 3, 4, 3);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(110, 27);
            btnSalvar.TabIndex = 22;
            btnSalvar.Text = "&Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpar.Location = new Point(960, 566);
            btnLimpar.Margin = new Padding(4, 3, 4, 3);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(110, 27);
            btnLimpar.TabIndex = 21;
            btnLimpar.Text = "&Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // btnSair
            // 
            btnSair.BackColor = SystemColors.Control;
            btnSair.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSair.Location = new Point(1084, 566);
            btnSair.Margin = new Padding(4, 3, 4, 3);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(110, 27);
            btnSair.TabIndex = 20;
            btnSair.Text = "Sai&r";
            btnSair.UseVisualStyleBackColor = false;
            btnSair.Click += btnSair_Click_1;
            // 
            // dgvMedicamentos
            // 
            dgvMedicamentos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMedicamentos.Location = new Point(26, 142);
            dgvMedicamentos.Margin = new Padding(4, 3, 4, 3);
            dgvMedicamentos.Name = "dgvMedicamentos";
            dgvMedicamentos.Size = new Size(1168, 410);
            dgvMedicamentos.TabIndex = 19;
            dgvMedicamentos.CellClick += dgvMedicamentos_CellClick;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(311, 21);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(51, 13);
            label4.TabIndex = 18;
            label4.Text = "Produto";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(183, 22);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(32, 13);
            label3.TabIndex = 15;
            label3.Text = "EAN";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(30, 100);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(86, 13);
            label1.TabIndex = 15;
            label1.Text = "Preço Fábrica";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(216, 100);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(96, 13);
            label2.TabIndex = 15;
            label2.Text = "PMC Brasindice";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(402, 100);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(119, 13);
            label5.TabIndex = 15;
            label5.Text = "Preço Acordo (15%)";
            // 
            // btnPesquisar
            // 
            btnPesquisar.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPesquisar.Location = new Point(584, 567);
            btnPesquisar.Margin = new Padding(4, 3, 4, 3);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(110, 27);
            btnPesquisar.TabIndex = 24;
            btnPesquisar.Text = "&Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = true;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(35, 23);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(18, 13);
            label7.TabIndex = 28;
            label7.Text = "Id";
            // 
            // txtProduto
            // 
            txtProduto.Location = new Point(306, 37);
            txtProduto.Margin = new Padding(4, 3, 4, 3);
            txtProduto.MaxLength = 280;
            txtProduto.Multiline = true;
            txtProduto.Name = "txtProduto";
            txtProduto.Size = new Size(888, 47);
            txtProduto.TabIndex = 27;
            // 
            // txtId
            // 
            txtId.Location = new Point(31, 38);
            txtId.Margin = new Padding(4, 3, 4, 3);
            txtId.Mask = "000000";
            txtId.Name = "txtId";
            txtId.Size = new Size(67, 23);
            txtId.TabIndex = 25;
            // 
            // txtEAN
            // 
            txtEAN.Location = new Point(181, 38);
            txtEAN.Margin = new Padding(4, 3, 4, 3);
            txtEAN.Mask = "0000000000000";
            txtEAN.Name = "txtEAN";
            txtEAN.Size = new Size(123, 23);
            txtEAN.TabIndex = 26;
            // 
            // btnExcluir
            // 
            btnExcluir.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExcluir.Location = new Point(834, 566);
            btnExcluir.Margin = new Padding(4, 3, 4, 3);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(110, 27);
            btnExcluir.TabIndex = 29;
            btnExcluir.Text = "&Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // txtMedicamentoId
            // 
            txtMedicamentoId.Location = new Point(100, 38);
            txtMedicamentoId.Margin = new Padding(4, 3, 4, 3);
            txtMedicamentoId.Mask = "00000";
            txtMedicamentoId.Name = "txtMedicamentoId";
            txtMedicamentoId.Size = new Size(79, 23);
            txtMedicamentoId.TabIndex = 25;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(98, 23);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(76, 13);
            label6.TabIndex = 28;
            label6.Text = "Id Medicam.";
            // 
            // txtPrecoFabrica
            // 
            txtPrecoFabrica.Location = new Point(26, 115);
            txtPrecoFabrica.Name = "txtPrecoFabrica";
            txtPrecoFabrica.Size = new Size(182, 23);
            txtPrecoFabrica.TabIndex = 30;
            // 
            // txtPMCBrasindice
            // 
            txtPMCBrasindice.Location = new Point(212, 115);
            txtPMCBrasindice.Name = "txtPMCBrasindice";
            txtPMCBrasindice.Size = new Size(182, 23);
            txtPMCBrasindice.TabIndex = 30;
            // 
            // txtPrecoAcordo
            // 
            txtPrecoAcordo.DecimalPlaces = 2;
            txtPrecoAcordo.Enabled = false;
            txtPrecoAcordo.Location = new Point(398, 115);
            txtPrecoAcordo.Name = "txtPrecoAcordo";
            txtPrecoAcordo.Size = new Size(182, 23);
            txtPrecoAcordo.TabIndex = 30;
            // 
            // btnCalcular
            // 
            btnCalcular.Font = new Font("Segoe UI", 7F, FontStyle.Bold);
            btnCalcular.ForeColor = Color.DarkGreen;
            btnCalcular.Location = new Point(588, 115);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(128, 23);
            btnCalcular.TabIndex = 100;
            btnCalcular.Text = "Calcular Preço Acordado";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // txtUnidadesCaixa
            // 
            txtUnidadesCaixa.Location = new Point(790, 115);
            txtUnidadesCaixa.Margin = new Padding(4, 3, 4, 3);
            txtUnidadesCaixa.Mask = "000";
            txtUnidadesCaixa.Name = "txtUnidadesCaixa";
            txtUnidadesCaixa.Size = new Size(52, 23);
            txtUnidadesCaixa.TabIndex = 101;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(849, 101);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(88, 13);
            label8.TabIndex = 15;
            label8.Text = "Preço Unitário";
            // 
            // txtPrecoUnitario
            // 
            txtPrecoUnitario.DecimalPlaces = 2;
            txtPrecoUnitario.Enabled = false;
            txtPrecoUnitario.Location = new Point(846, 116);
            txtPrecoUnitario.Name = "txtPrecoUnitario";
            txtPrecoUnitario.Size = new Size(217, 23);
            txtPrecoUnitario.TabIndex = 30;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(1315, 100);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(82, 13);
            label9.TabIndex = 15;
            label9.Text = "Acordo (15%)";
            // 
            // numericUpDown2
            // 
            numericUpDown2.DecimalPlaces = 2;
            numericUpDown2.Enabled = false;
            numericUpDown2.Location = new Point(1312, 115);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(217, 23);
            numericUpDown2.TabIndex = 30;
            // 
            // btnCalcularPrecounitario
            // 
            btnCalcularPrecounitario.Font = new Font("Segoe UI", 7F, FontStyle.Bold);
            btnCalcularPrecounitario.ForeColor = Color.DarkGreen;
            btnCalcularPrecounitario.Location = new Point(1066, 114);
            btnCalcularPrecounitario.Name = "btnCalcularPrecounitario";
            btnCalcularPrecounitario.Size = new Size(128, 23);
            btnCalcularPrecounitario.TabIndex = 100;
            btnCalcularPrecounitario.Text = "Calcular Preço Unitário";
            btnCalcularPrecounitario.UseVisualStyleBackColor = true;
            btnCalcularPrecounitario.Click += bntCalcularPrecounitario_Click;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(1267, 114);
            maskedTextBox1.Margin = new Padding(4, 3, 4, 3);
            maskedTextBox1.Mask = "000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(41, 23);
            maskedTextBox1.TabIndex = 101;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(790, 101);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(52, 13);
            label10.TabIndex = 15;
            label10.Text = "Qtdd Cx";
            // 
            // chkAumentaLarguraColunasGrid
            // 
            chkAumentaLarguraColunasGrid.AutoSize = true;
            chkAumentaLarguraColunasGrid.Checked = true;
            chkAumentaLarguraColunasGrid.CheckState = CheckState.Checked;
            chkAumentaLarguraColunasGrid.Location = new Point(25, 574);
            chkAumentaLarguraColunasGrid.Name = "chkAumentaLarguraColunasGrid";
            chkAumentaLarguraColunasGrid.Size = new Size(183, 19);
            chkAumentaLarguraColunasGrid.TabIndex = 154;
            chkAumentaLarguraColunasGrid.Text = "Largura do Tamanho do Dado";
            chkAumentaLarguraColunasGrid.UseVisualStyleBackColor = true;
            chkAumentaLarguraColunasGrid.CheckedChanged += chkAumentaLarguraColunasGrid_CheckedChanged;
            // 
            // frmMedicamentoPreco
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1217, 600);
            Controls.Add(chkAumentaLarguraColunasGrid);
            Controls.Add(maskedTextBox1);
            Controls.Add(btnCalcularPrecounitario);
            Controls.Add(txtUnidadesCaixa);
            Controls.Add(numericUpDown2);
            Controls.Add(btnCalcular);
            Controls.Add(txtPrecoUnitario);
            Controls.Add(txtPrecoAcordo);
            Controls.Add(txtPMCBrasindice);
            Controls.Add(txtPrecoFabrica);
            Controls.Add(btnExcluir);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(txtProduto);
            Controls.Add(txtMedicamentoId);
            Controls.Add(txtId);
            Controls.Add(txtEAN);
            Controls.Add(btnPesquisar);
            Controls.Add(btnNovo);
            Controls.Add(btnSalvar);
            Controls.Add(btnLimpar);
            Controls.Add(btnSair);
            Controls.Add(label9);
            Controls.Add(dgvMedicamentos);
            Controls.Add(label10);
            Controls.Add(label8);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label3);
            Location = new Point(1, 1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmMedicamentoPreco";
            Text = "Preco de Medicamento";
            ((System.ComponentModel.ISupportInitialize)dgvMedicamentos).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtPrecoFabrica).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtPMCBrasindice).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtPrecoAcordo).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtPrecoUnitario).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.DataGridView dgvMedicamentos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        //private System.Windows.Forms.TextBox txtPMCBrasindice;
        private System.Windows.Forms.Label label2;
        //private System.Windows.Forms.TextBox txtAcordo;
        private System.Windows.Forms.Label label5;
        private Button btnPesquisar;
        private Label label7;
        private TextBox txtProduto;
        private MaskedTextBox txtId;
        private MaskedTextBox txtEAN;
        private Button btnExcluir;
        /*private MaskedTextBox txtPMCBrasindice;
        private MaskedTextBox txtPrecoAcordo;
        private MaskedTextBox maskedTextBox1;*/
        private Label label6;
        private MaskedTextBox txtMedicamentoId;
        private NumericUpDown txtPrecoFabrica;
        private MaskedTextBox maskedTextBox2;
        private NumericUpDown txtPMCBrasindice;
        private NumericUpDown txtPrecoAcordo;
        private Button btnCalcular;
        private MaskedTextBox txtUnidadesCaixa;
        private Label label8;
        private NumericUpDown txtPrecoUnitario;
        private Label label9;
        private NumericUpDown numericUpDown2;
        private Button btnCalcularPrecounitario;
        private MaskedTextBox maskedTextBox1;
        private Label label10;
        private CheckBox chkAumentaLarguraColunasGrid;
    }
}