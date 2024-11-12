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
            btnSair = new Button();
            btnLogar = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            lblLogin = new Label();
            lblSenha = new Label();
            lblMsgInicial = new Label();
            SuspendLayout();
            // 
            // btnSair
            // 
            btnSair.Location = new Point(171, 196);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(75, 23);
            btnSair.TabIndex = 0;
            btnSair.Text = "Sai&r";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // btnLogar
            // 
            btnLogar.Location = new Point(90, 196);
            btnLogar.Name = "btnLogar";
            btnLogar.Size = new Size(75, 23);
            btnLogar.TabIndex = 1;
            btnLogar.Text = "&Entrar";
            btnLogar.UseVisualStyleBackColor = true;
            btnLogar.Click += btnLogar_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(94, 76);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(152, 23);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(94, 131);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(152, 23);
            textBox2.TabIndex = 3;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
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
            lblMsgInicial.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblMsgInicial.Location = new Point(12, 20);
            lblMsgInicial.Name = "lblMsgInicial";
            lblMsgInicial.Size = new Size(316, 15);
            lblMsgInicial.TabIndex = 4;
            lblMsgInicial.Text = "Para acessaro Sistema enter com o seu Usuário e Senha.";
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(349, 249);
            Controls.Add(lblSenha);
            Controls.Add(lblMsgInicial);
            Controls.Add(lblLogin);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(btnLogar);
            Controls.Add(btnSair);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Controle de Entregas - Login de Usuário.";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSair;
        private Button btnLogar;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label lblLogin;
        private Label lblSenha;
        private Label lblMsgInicial;
    }
}
