﻿namespace ControleEntregada.Forms
{
    partial class frmMedicamento
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
            cboClasseTerapeutica = new ComboBox();
            cboTipoReceita = new ComboBox();
            txtEAN = new MaskedTextBox();
            txtProduto = new TextBox();
            cboSubstancia = new ComboBox();
            cboFabricante = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            dgvMedicamentos = new DataGridView();
            btnSair = new Button();
            btnLimpar = new Button();
            btnSalvar = new Button();
            btnNovo = new Button();
            btnPesquisar = new Button();
            txtId = new MaskedTextBox();
            label7 = new Label();
            btnExcluir = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvMedicamentos).BeginInit();
            SuspendLayout();
            // 
            // cboClasseTerapeutica
            // 
            cboClasseTerapeutica.FormattingEnabled = true;
            cboClasseTerapeutica.Location = new Point(24, 112);
            cboClasseTerapeutica.Margin = new Padding(4, 3, 4, 3);
            cboClasseTerapeutica.Name = "cboClasseTerapeutica";
            cboClasseTerapeutica.Size = new Size(854, 23);
            cboClasseTerapeutica.TabIndex = 3;
            // 
            // cboTipoReceita
            // 
            cboTipoReceita.FormattingEnabled = true;
            cboTipoReceita.Location = new Point(886, 113);
            cboTipoReceita.Margin = new Padding(4, 3, 4, 3);
            cboTipoReceita.Name = "cboTipoReceita";
            cboTipoReceita.Size = new Size(393, 23);
            cboTipoReceita.TabIndex = 4;
            // 
            // txtEAN
            // 
            txtEAN.Location = new Point(92, 39);
            txtEAN.Margin = new Padding(4, 3, 4, 3);
            txtEAN.Mask = "0000000000000";
            txtEAN.Name = "txtEAN";
            txtEAN.Size = new Size(134, 23);
            txtEAN.TabIndex = 1;
            // 
            // txtProduto
            // 
            txtProduto.Location = new Point(235, 38);
            txtProduto.Margin = new Padding(4, 3, 4, 3);
            txtProduto.MaxLength = 280;
            txtProduto.Multiline = true;
            txtProduto.Name = "txtProduto";
            txtProduto.Size = new Size(1044, 47);
            txtProduto.TabIndex = 2;
            // 
            // cboSubstancia
            // 
            cboSubstancia.FormattingEnabled = true;
            cboSubstancia.Location = new Point(24, 163);
            cboSubstancia.Margin = new Padding(4, 3, 4, 3);
            cboSubstancia.Name = "cboSubstancia";
            cboSubstancia.Size = new Size(854, 23);
            cboSubstancia.TabIndex = 5;
            // 
            // cboFabricante
            // 
            cboFabricante.FormattingEnabled = true;
            cboFabricante.Location = new Point(886, 163);
            cboFabricante.Margin = new Padding(4, 3, 4, 3);
            cboFabricante.Name = "cboFabricante";
            cboFabricante.Size = new Size(393, 23);
            cboFabricante.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(24, 93);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(116, 13);
            label1.TabIndex = 3;
            label1.Text = "Classe Terapeutica";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(887, 96);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(98, 13);
            label2.TabIndex = 3;
            label2.Text = "Tipo de Receita";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(92, 23);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(32, 13);
            label3.TabIndex = 3;
            label3.Text = "EAN";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(233, 21);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(51, 13);
            label4.TabIndex = 3;
            label4.Text = "Produto";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(24, 145);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(70, 13);
            label5.TabIndex = 3;
            label5.Text = "Substância";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(886, 145);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(67, 13);
            label6.TabIndex = 3;
            label6.Text = "Fabricante";
            // 
            // dgvMedicamentos
            // 
            dgvMedicamentos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMedicamentos.Location = new Point(24, 205);
            dgvMedicamentos.Margin = new Padding(4, 3, 4, 3);
            dgvMedicamentos.Name = "dgvMedicamentos";
            dgvMedicamentos.Size = new Size(1255, 393);
            dgvMedicamentos.TabIndex = 7;
            dgvMedicamentos.CellClick += dgvMedicamentos_CellClick;
            // 
            // btnSair
            // 
            btnSair.BackColor = SystemColors.Control;
            btnSair.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSair.Location = new Point(1170, 604);
            btnSair.Margin = new Padding(4, 3, 4, 3);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(110, 27);
            btnSair.TabIndex = 12;
            btnSair.Text = "Sai&r";
            btnSair.UseVisualStyleBackColor = false;
            btnSair.Click += btnSair_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpar.Location = new Point(1049, 604);
            btnLimpar.Margin = new Padding(4, 3, 4, 3);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(110, 27);
            btnLimpar.TabIndex = 11;
            btnLimpar.Text = "&Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalvar.Location = new Point(806, 604);
            btnSalvar.Margin = new Padding(4, 3, 4, 3);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(110, 27);
            btnSalvar.TabIndex = 10;
            btnSalvar.Text = "&Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnNovo
            // 
            btnNovo.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNovo.Location = new Point(562, 604);
            btnNovo.Margin = new Padding(4, 3, 4, 3);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(110, 27);
            btnNovo.TabIndex = 8;
            btnNovo.Text = "&Novo";
            btnNovo.UseVisualStyleBackColor = true;
            btnNovo.Click += btnNovo_Click;
            // 
            // btnPesquisar
            // 
            btnPesquisar.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPesquisar.Location = new Point(684, 604);
            btnPesquisar.Margin = new Padding(4, 3, 4, 3);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(110, 27);
            btnPesquisar.TabIndex = 9;
            btnPesquisar.Text = "&Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = true;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // txtId
            // 
            txtId.Location = new Point(24, 39);
            txtId.Margin = new Padding(4, 3, 4, 3);
            txtId.Mask = "00000";
            txtId.Name = "txtId";
            txtId.Size = new Size(60, 23);
            txtId.TabIndex = 0;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(24, 23);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(18, 13);
            label7.TabIndex = 3;
            label7.Text = "Id";
            // 
            // btnExcluir
            // 
            btnExcluir.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExcluir.Location = new Point(927, 604);
            btnExcluir.Margin = new Padding(4, 3, 4, 3);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(110, 27);
            btnExcluir.TabIndex = 10;
            btnExcluir.Text = "&Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // frmMedicamento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(1309, 635);
            Controls.Add(btnPesquisar);
            Controls.Add(btnNovo);
            Controls.Add(btnExcluir);
            Controls.Add(btnSalvar);
            Controls.Add(btnLimpar);
            Controls.Add(btnSair);
            Controls.Add(dgvMedicamentos);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label7);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtProduto);
            Controls.Add(txtId);
            Controls.Add(txtEAN);
            Controls.Add(cboFabricante);
            Controls.Add(cboSubstancia);
            Controls.Add(cboTipoReceita);
            Controls.Add(cboClasseTerapeutica);
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmMedicamento";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Medicamento";
            Load += Medicamento_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMedicamentos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ComboBox cboClasseTerapeutica;
        private System.Windows.Forms.ComboBox cboTipoReceita;
        //private System.Windows.Forms.TextBox txtEAN;
        private System.Windows.Forms.MaskedTextBox txtEAN;
        private System.Windows.Forms.TextBox txtProduto;
        private System.Windows.Forms.ComboBox cboSubstancia;
        private System.Windows.Forms.ComboBox cboFabricante;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvMedicamentos;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnNovo;
        private Button btnPesquisar;
        // private TextBox txtId;
        private MaskedTextBox txtId;
        private Label label7;
        private Button btnExcluir;
    }
}