namespace EPharmacy
{
    partial class frmPrincipal
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
            menuStrip1 = new MenuStrip();
            cadastroToolStripMenuItem = new ToolStripMenuItem();
            medicamentosToolStripMenuItem = new ToolStripMenuItem();
            preçoMedicamentoToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            classeTerapeuticaToolStripMenuItem = new ToolStripMenuItem();
            fabricanteToolStripMenuItem = new ToolStripMenuItem();
            substânciaToolStripMenuItem = new ToolStripMenuItem();
            tipoReceitaToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            usuárioToolStripMenuItem = new ToolStripMenuItem();
            ajudaToolStripMenuItem = new ToolStripMenuItem();
            sobrceToolStripMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { cadastroToolStripMenuItem, ajudaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            cadastroToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { medicamentosToolStripMenuItem, preçoMedicamentoToolStripMenuItem, toolStripSeparator1, classeTerapeuticaToolStripMenuItem, fabricanteToolStripMenuItem, substânciaToolStripMenuItem, tipoReceitaToolStripMenuItem, toolStripSeparator2, usuárioToolStripMenuItem });
            cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            cadastroToolStripMenuItem.Size = new Size(66, 20);
            cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // medicamentosToolStripMenuItem
            // 
            medicamentosToolStripMenuItem.Name = "medicamentosToolStripMenuItem";
            medicamentosToolStripMenuItem.Size = new Size(181, 22);
            medicamentosToolStripMenuItem.Text = "Medicamento";
            medicamentosToolStripMenuItem.Click += medicamentosToolStripMenuItem_Click;
            // 
            // preçoMedicamentoToolStripMenuItem
            // 
            preçoMedicamentoToolStripMenuItem.Name = "preçoMedicamentoToolStripMenuItem";
            preçoMedicamentoToolStripMenuItem.Size = new Size(181, 22);
            preçoMedicamentoToolStripMenuItem.Text = "Preço Medicamento";
            preçoMedicamentoToolStripMenuItem.Click += preçoMedicamentoToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(178, 6);
            // 
            // classeTerapeuticaToolStripMenuItem
            // 
            classeTerapeuticaToolStripMenuItem.Name = "classeTerapeuticaToolStripMenuItem";
            classeTerapeuticaToolStripMenuItem.Size = new Size(181, 22);
            classeTerapeuticaToolStripMenuItem.Text = "Classe Terapeutica";
            classeTerapeuticaToolStripMenuItem.Click += classeTerapeuticaToolStripMenuItem_Click;
            // 
            // fabricanteToolStripMenuItem
            // 
            fabricanteToolStripMenuItem.Name = "fabricanteToolStripMenuItem";
            fabricanteToolStripMenuItem.Size = new Size(181, 22);
            fabricanteToolStripMenuItem.Text = "Fabricante";
            fabricanteToolStripMenuItem.Click += fabricanteToolStripMenuItem_Click;
            // 
            // substânciaToolStripMenuItem
            // 
            substânciaToolStripMenuItem.Name = "substânciaToolStripMenuItem";
            substânciaToolStripMenuItem.Size = new Size(181, 22);
            substânciaToolStripMenuItem.Text = "Substância";
            substânciaToolStripMenuItem.Click += substanciaToolStripMenuItem_Click;
            // 
            // tipoReceitaToolStripMenuItem
            // 
            tipoReceitaToolStripMenuItem.Name = "tipoReceitaToolStripMenuItem";
            tipoReceitaToolStripMenuItem.Size = new Size(181, 22);
            tipoReceitaToolStripMenuItem.Text = "Tipo Receita";
            tipoReceitaToolStripMenuItem.Click += tipoReceitaToolStripMenuItem_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(178, 6);
            // 
            // usuárioToolStripMenuItem
            // 
            usuárioToolStripMenuItem.Name = "usuárioToolStripMenuItem";
            usuárioToolStripMenuItem.Size = new Size(181, 22);
            usuárioToolStripMenuItem.Text = "Usuário";
            usuárioToolStripMenuItem.Click += usuárioToolStripMenuItem_Click;
            // 
            // ajudaToolStripMenuItem
            // 
            ajudaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { sobrceToolStripMenuItem, sairToolStripMenuItem });
            ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            ajudaToolStripMenuItem.Size = new Size(50, 20);
            ajudaToolStripMenuItem.Text = "Ajuda";
            // 
            // sobrceToolStripMenuItem
            // 
            sobrceToolStripMenuItem.Name = "sobrceToolStripMenuItem";
            sobrceToolStripMenuItem.Size = new Size(220, 22);
            sobrceToolStripMenuItem.Text = "Sobre Controle de Entregas ";
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(220, 22);
            sairToolStripMenuItem.Text = "Sai&r";
            sairToolStripMenuItem.Click += sairToolStripMenuItem_Click;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "frmPrincipal";
            Text = "Controle de Entregas";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem cadastroToolStripMenuItem;
        private ToolStripMenuItem medicamentosToolStripMenuItem;
        private ToolStripMenuItem preçoMedicamentoToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem usuárioToolStripMenuItem;
        private ToolStripMenuItem ajudaToolStripMenuItem;
        private ToolStripMenuItem fabricanteToolStripMenuItem;
        private ToolStripMenuItem substânciaToolStripMenuItem;
        private ToolStripMenuItem tipoReceitaToolStripMenuItem;
        private ToolStripMenuItem classeTerapeuticaToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem sairToolStripMenuItem;
        private ToolStripMenuItem sobrceToolStripMenuItem;
    }
}