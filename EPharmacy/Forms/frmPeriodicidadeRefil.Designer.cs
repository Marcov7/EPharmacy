namespace EPharmacy.Forms
{
    partial class frmPeriodicidadeRefil
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
            ((System.ComponentModel.ISupportInitialize)dgvLista).BeginInit();
            SuspendLayout();
            // 
            // btnPesquisar
            // 
            btnPesquisar.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPesquisar.Location = new Point(259, 437);
            btnPesquisar.Margin = new Padding(4, 3, 4, 3);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(110, 27);
            btnPesquisar.TabIndex = 58;
            btnPesquisar.Text = "&Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = true;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // btnNovo
            // 
            btnNovo.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNovo.Location = new Point(134, 437);
            btnNovo.Margin = new Padding(4, 3, 4, 3);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(110, 27);
            btnNovo.TabIndex = 57;
            btnNovo.Text = "&Novo";
            btnNovo.UseVisualStyleBackColor = true;
            btnNovo.Click += btnNovo_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Enabled = false;
            btnExcluir.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExcluir.Location = new Point(509, 437);
            btnExcluir.Margin = new Padding(4, 3, 4, 3);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(110, 27);
            btnExcluir.TabIndex = 59;
            btnExcluir.Text = "&Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Enabled = false;
            btnSalvar.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalvar.Location = new Point(384, 437);
            btnSalvar.Margin = new Padding(4, 3, 4, 3);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(110, 27);
            btnSalvar.TabIndex = 60;
            btnSalvar.Text = "&Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpar.Location = new Point(634, 437);
            btnLimpar.Margin = new Padding(4, 3, 4, 3);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(110, 27);
            btnLimpar.TabIndex = 61;
            btnLimpar.Text = "&Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // btnSair
            // 
            btnSair.BackColor = SystemColors.Control;
            btnSair.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSair.Location = new Point(759, 437);
            btnSair.Margin = new Padding(4, 3, 4, 3);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(110, 27);
            btnSair.TabIndex = 62;
            btnSair.Text = "Sai&r";
            btnSair.UseVisualStyleBackColor = false;
            btnSair.Click += btnSair_Click;
            // 
            // dgvLista
            // 
            dgvLista.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLista.Location = new Point(26, 71);
            dgvLista.Margin = new Padding(4, 3, 4, 3);
            dgvLista.Name = "dgvLista";
            dgvLista.Size = new Size(842, 339);
            dgvLista.TabIndex = 56;
            dgvLista.CellClick += dgvLista_CellClick;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(94, 12);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(64, 13);
            label4.TabIndex = 54;
            label4.Text = "Descrição";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(26, 12);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(18, 13);
            label7.TabIndex = 55;
            label7.Text = "Id";
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(94, 28);
            txtDescricao.Margin = new Padding(4, 3, 4, 3);
            txtDescricao.MaxLength = 255;
            txtDescricao.Multiline = true;
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(774, 23);
            txtDescricao.TabIndex = 53;
            // 
            // txtId
            // 
            txtId.Location = new Point(26, 28);
            txtId.Margin = new Padding(4, 3, 4, 3);
            txtId.Mask = "00000";
            txtId.Name = "txtId";
            txtId.Size = new Size(60, 23);
            txtId.TabIndex = 52;
            // 
            // frmPeriodicidadeRefil
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(905, 481);
            Controls.Add(btnPesquisar);
            Controls.Add(btnNovo);
            Controls.Add(btnExcluir);
            Controls.Add(btnSalvar);
            Controls.Add(btnLimpar);
            Controls.Add(btnSair);
            Controls.Add(dgvLista);
            Controls.Add(label4);
            Controls.Add(label7);
            Controls.Add(txtDescricao);
            Controls.Add(txtId);
            Name = "frmPeriodicidadeRefil";
            Text = "Periodicidade Refil";
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
        private Label label4;
        private Label label7;
        private TextBox txtDescricao;
        private MaskedTextBox txtId;
    }
}