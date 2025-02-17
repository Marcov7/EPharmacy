namespace EPharmacy
{
    partial class frmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            btnSair = new Button();
            btnLogar = new Button();
            txtLogin = new TextBox();
            txtSenha = new TextBox();
            lblLogin = new Label();
            lblSenha = new Label();
            lblMsgInicial = new Label();
            lblVersao = new Label();
            SuspendLayout();
            // 
            // btnSair
            // 
            btnSair.BackColor = Color.Red;
            btnSair.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSair.ForeColor = Color.White;
            btnSair.Location = new Point(173, 191);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(140, 34);
            btnSair.TabIndex = 0;
            btnSair.Text = "Sai&r";
            btnSair.UseVisualStyleBackColor = false;
            btnSair.Click += btnSair_Click;
            // 
            // btnLogar
            // 
            btnLogar.BackColor = Color.Green;
            btnLogar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnLogar.ForeColor = Color.Transparent;
            btnLogar.Location = new Point(34, 191);
            btnLogar.Name = "btnLogar";
            btnLogar.Size = new Size(139, 34);
            btnLogar.TabIndex = 1;
            btnLogar.Text = "&Entrar";
            btnLogar.UseVisualStyleBackColor = false;
            btnLogar.Click += btnLogar_Click;
            // 
            // txtLogin
            // 
            txtLogin.Location = new Point(94, 76);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(152, 23);
            txtLogin.TabIndex = 2;
            txtLogin.Text = "Adm";
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(94, 131);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(152, 23);
            txtSenha.TabIndex = 3;
            txtSenha.Text = "123";
            txtSenha.UseSystemPasswordChar = true;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.BackColor = Color.White;
            lblLogin.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblLogin.Location = new Point(94, 58);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(49, 15);
            lblLogin.TabIndex = 4;
            lblLogin.Text = "Usuário";
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.BackColor = Color.White;
            lblSenha.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblSenha.Location = new Point(94, 113);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(41, 15);
            lblSenha.TabIndex = 4;
            lblSenha.Text = "Senha";
            // 
            // lblMsgInicial
            // 
            lblMsgInicial.AutoSize = true;
            lblMsgInicial.BackColor = Color.White;
            lblMsgInicial.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblMsgInicial.Location = new Point(80, 15);
            lblMsgInicial.Name = "lblMsgInicial";
            lblMsgInicial.Size = new Size(182, 19);
            lblMsgInicial.TabIndex = 4;
            lblMsgInicial.Text = "Acessa ao Sistema - Login";
            // 
            // lblVersao
            // 
            lblVersao.AutoSize = true;
            lblVersao.BackColor = Color.White;
            lblVersao.Font = new Font("Segoe UI", 7F, FontStyle.Bold);
            lblVersao.ForeColor = Color.Purple;
            lblVersao.Location = new Point(117, 237);
            lblVersao.Name = "lblVersao";
            lblVersao.Size = new Size(41, 12);
            lblVersao.TabIndex = 4;
            lblVersao.Text = "Versão: ";
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(349, 253);
            Controls.Add(lblVersao);
            Controls.Add(lblSenha);
            Controls.Add(lblMsgInicial);
            Controls.Add(lblLogin);
            Controls.Add(txtSenha);
            Controls.Add(txtLogin);
            Controls.Add(btnLogar);
            Controls.Add(btnSair);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EPharmacy - Login de Usuário.";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSair;
        private Button btnLogar;
        private TextBox txtLogin;
        private TextBox txtSenha;
        private Label lblLogin;
        private Label lblSenha;
        private Label lblMsgInicial;
        private Label lblVersao;
    }
}
