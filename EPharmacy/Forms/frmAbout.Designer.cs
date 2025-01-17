namespace EPharmacy.Forms
{
    partial class frmAbout
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
            lblMsgInicial = new Label();
            lblVersao = new Label();
            SuspendLayout();
            // 
            // lblMsgInicial
            // 
            lblMsgInicial.AutoSize = true;
            lblMsgInicial.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblMsgInicial.Location = new Point(12, 18);
            lblMsgInicial.Name = "lblMsgInicial";
            lblMsgInicial.Size = new Size(298, 19);
            lblMsgInicial.TabIndex = 5;
            lblMsgInicial.Text = "SiContEn - Sistema de Controle de Entregas";
            // 
            // lblVersao
            // 
            lblVersao.AutoSize = true;
            lblVersao.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblVersao.Location = new Point(12, 48);
            lblVersao.Name = "lblVersao";
            lblVersao.Size = new Size(58, 19);
            lblVersao.TabIndex = 6;
            lblVersao.Text = "Versão ";
            // 
            // frmAbout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblVersao);
            Controls.Add(lblMsgInicial);
            Name = "frmAbout";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Sobre";
            Load += frmAbout_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMsgInicial;
        private Label lblVersao;
    }
}