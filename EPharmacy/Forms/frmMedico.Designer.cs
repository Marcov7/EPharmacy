namespace EPharmacy.Forms
{
    partial class frmMedico
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
            txtNome = new TextBox();
            txtId = new MaskedTextBox();
            txtCRM = new TextBox();
            label1 = new Label();
            label2 = new Label();
            cboEspecialidade = new ComboBox();
            chkMostrarIds = new CheckBox();
            chkAumentaLarguraColunasGrid = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)dgvLista).BeginInit();
            SuspendLayout();
            // 
            // btnPesquisar
            // 
            btnPesquisar.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPesquisar.Location = new Point(434, 460);
            btnPesquisar.Margin = new Padding(4, 3, 4, 3);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(110, 27);
            btnPesquisar.TabIndex = 102;
            btnPesquisar.Text = "&Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = true;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // btnNovo
            // 
            btnNovo.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNovo.Location = new Point(324, 460);
            btnNovo.Margin = new Padding(4, 3, 4, 3);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(110, 27);
            btnNovo.TabIndex = 101;
            btnNovo.Text = "&Novo";
            btnNovo.UseVisualStyleBackColor = true;
            btnNovo.Click += btnNovo_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Enabled = false;
            btnExcluir.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExcluir.Location = new Point(655, 460);
            btnExcluir.Margin = new Padding(4, 3, 4, 3);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(110, 27);
            btnExcluir.TabIndex = 103;
            btnExcluir.Text = "&Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Enabled = false;
            btnSalvar.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalvar.Location = new Point(544, 460);
            btnSalvar.Margin = new Padding(4, 3, 4, 3);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(110, 27);
            btnSalvar.TabIndex = 104;
            btnSalvar.Text = "&Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpar.Location = new Point(766, 460);
            btnLimpar.Margin = new Padding(4, 3, 4, 3);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(110, 27);
            btnLimpar.TabIndex = 105;
            btnLimpar.Text = "&Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // btnSair
            // 
            btnSair.BackColor = SystemColors.Control;
            btnSair.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSair.Location = new Point(876, 460);
            btnSair.Margin = new Padding(4, 3, 4, 3);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(110, 27);
            btnSair.TabIndex = 106;
            btnSair.Text = "Sai&r";
            btnSair.UseVisualStyleBackColor = false;
            btnSair.Click += btnSair_Click;
            // 
            // dgvLista
            // 
            dgvLista.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLista.Location = new Point(13, 112);
            dgvLista.Margin = new Padding(4, 3, 4, 3);
            dgvLista.Name = "dgvLista";
            dgvLista.Size = new Size(975, 339);
            dgvLista.TabIndex = 100;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(83, 15);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(39, 13);
            label4.TabIndex = 98;
            label4.Text = "Nome";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(15, 15);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(18, 13);
            label7.TabIndex = 99;
            label7.Text = "Id";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(83, 31);
            txtNome.Margin = new Padding(4, 3, 4, 3);
            txtNome.MaxLength = 255;
            txtNome.Multiline = true;
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(903, 23);
            txtNome.TabIndex = 97;
            // 
            // txtId
            // 
            txtId.Location = new Point(15, 31);
            txtId.Margin = new Padding(4, 3, 4, 3);
            txtId.Mask = "00000";
            txtId.Name = "txtId";
            txtId.Size = new Size(60, 23);
            txtId.TabIndex = 96;
            // 
            // txtCRM
            // 
            txtCRM.Location = new Point(15, 83);
            txtCRM.Margin = new Padding(4, 3, 4, 3);
            txtCRM.MaxLength = 255;
            txtCRM.Multiline = true;
            txtCRM.Name = "txtCRM";
            txtCRM.Size = new Size(192, 23);
            txtCRM.TabIndex = 97;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(15, 67);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(34, 13);
            label1.TabIndex = 98;
            label1.Text = "CRM";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(217, 67);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(86, 13);
            label2.TabIndex = 98;
            label2.Text = "Especialidade";
            // 
            // cboEspecialidade
            // 
            cboEspecialidade.FormattingEnabled = true;
            cboEspecialidade.Location = new Point(215, 83);
            cboEspecialidade.Margin = new Padding(4, 3, 4, 3);
            cboEspecialidade.Name = "cboEspecialidade";
            cboEspecialidade.Size = new Size(771, 23);
            cboEspecialidade.TabIndex = 107;
            // 
            // chkMostrarIds
            // 
            chkMostrarIds.AutoSize = true;
            chkMostrarIds.Location = new Point(13, 463);
            chkMostrarIds.Name = "chkMostrarIds";
            chkMostrarIds.Size = new Size(85, 19);
            chkMostrarIds.TabIndex = 148;
            chkMostrarIds.Text = "Mostrar Ids";
            chkMostrarIds.UseVisualStyleBackColor = true;
            // 
            // chkAumentaLarguraColunasGrid
            // 
            chkAumentaLarguraColunasGrid.AutoSize = true;
            chkAumentaLarguraColunasGrid.Checked = true;
            chkAumentaLarguraColunasGrid.CheckState = CheckState.Checked;
            chkAumentaLarguraColunasGrid.Location = new Point(116, 465);
            chkAumentaLarguraColunasGrid.Name = "chkAumentaLarguraColunasGrid";
            chkAumentaLarguraColunasGrid.Size = new Size(183, 19);
            chkAumentaLarguraColunasGrid.TabIndex = 152;
            chkAumentaLarguraColunasGrid.Text = "Largura do Tamanho do Dado";
            chkAumentaLarguraColunasGrid.UseVisualStyleBackColor = true;
            chkAumentaLarguraColunasGrid.CheckedChanged += chkAumentaLarguraColunasGrid_CheckedChanged;
            // 
            // frmMedico
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1001, 505);
            Controls.Add(chkAumentaLarguraColunasGrid);
            Controls.Add(chkMostrarIds);
            Controls.Add(cboEspecialidade);
            Controls.Add(btnPesquisar);
            Controls.Add(btnNovo);
            Controls.Add(btnExcluir);
            Controls.Add(btnSalvar);
            Controls.Add(btnLimpar);
            Controls.Add(btnSair);
            Controls.Add(dgvLista);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label4);
            Controls.Add(label7);
            Controls.Add(txtCRM);
            Controls.Add(txtNome);
            Controls.Add(txtId);
            Name = "frmMedico";
            Text = "Médico";
            Load += frmMedico_Load;
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
        private TextBox txtNome;
        private MaskedTextBox txtId;
        private TextBox txtCRM;
        private Label label1;
        private Label label2;
        private ComboBox cboEspecialidade;
        private CheckBox chkMostrarIds;
        private CheckBox chkAumentaLarguraColunasGrid;
    }
}