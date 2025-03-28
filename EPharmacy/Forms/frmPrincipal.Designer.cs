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
            toolStripSeparator1 = new ToolStripSeparator();
            bairroZonaToolStripMenuItem = new ToolStripMenuItem();
            classeTerapeuticaToolStripMenuItem = new ToolStripMenuItem();
            clinicaToolStripMenuItem = new ToolStripMenuItem();
            convenioToolStripMenuItem = new ToolStripMenuItem();
            especialidadeToolStripMenuItem = new ToolStripMenuItem();
            fabricanteToolStripMenuItem = new ToolStripMenuItem();
            medicoToolStripMenuItem = new ToolStripMenuItem();
            modalidadeToolStripMenuItem = new ToolStripMenuItem();
            parâmetrosToolStripMenuItem = new ToolStripMenuItem();
            periodicidadeRefilToolStripMenuItem = new ToolStripMenuItem();
            substânciaToolStripMenuItem = new ToolStripMenuItem();
            tipoEntregaToolStripMenuItem = new ToolStripMenuItem();
            tipoReceitaToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            usuárioToolStripMenuItem = new ToolStripMenuItem();
            mmedicamentoToolStripMenuItem = new ToolStripMenuItem();
            medicamentoToolStripMenuItem = new ToolStripMenuItem();
            preçoDeMedicamentoToolStripMenuItem = new ToolStripMenuItem();
            pacienteToolStripMenuItem = new ToolStripMenuItem();
            cadastroDePacienteToolStripMenuItem = new ToolStripMenuItem();
            receitaToolStripMenuItem2 = new ToolStripMenuItem();
            receitaToolStripMenuItem1 = new ToolStripMenuItem();
            receitaToolStripMenuItem = new ToolStripMenuItem();
            BaseCadastralToolStripMenuItem = new ToolStripMenuItem();
            pedidoToolStripMenuItem2 = new ToolStripMenuItem();
            pedidoToolStripMenuItem = new ToolStripMenuItem();
            pedidoToolStripMenuItem1 = new ToolStripMenuItem();
            ajudaToolStripMenuItem = new ToolStripMenuItem();
            sobrceToolStripMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            saírToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { cadastroToolStripMenuItem, mmedicamentoToolStripMenuItem, pacienteToolStripMenuItem, receitaToolStripMenuItem2, receitaToolStripMenuItem, pedidoToolStripMenuItem, ajudaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            cadastroToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripSeparator1, bairroZonaToolStripMenuItem, classeTerapeuticaToolStripMenuItem, clinicaToolStripMenuItem, convenioToolStripMenuItem, especialidadeToolStripMenuItem, fabricanteToolStripMenuItem, medicoToolStripMenuItem, modalidadeToolStripMenuItem, parâmetrosToolStripMenuItem, periodicidadeRefilToolStripMenuItem, substânciaToolStripMenuItem, tipoEntregaToolStripMenuItem, tipoReceitaToolStripMenuItem, toolStripSeparator2, usuárioToolStripMenuItem, toolStripSeparator3, saírToolStripMenuItem });
            cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            cadastroToolStripMenuItem.Size = new Size(66, 20);
            cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(177, 6);
            // 
            // bairroZonaToolStripMenuItem
            // 
            bairroZonaToolStripMenuItem.Name = "bairroZonaToolStripMenuItem";
            bairroZonaToolStripMenuItem.Size = new Size(180, 22);
            bairroZonaToolStripMenuItem.Text = "Bairro Zona";
            bairroZonaToolStripMenuItem.Click += bairroZonaToolStripMenuItem_Click;
            bairroZonaToolStripMenuItem.Enabled = "124".Contains(GlobalVariables.PerfilId.ToString()) ? true : false;
            // 
            // classeTerapeuticaToolStripMenuItem
            // 
            classeTerapeuticaToolStripMenuItem.Name = "classeTerapeuticaToolStripMenuItem";
            classeTerapeuticaToolStripMenuItem.Size = new Size(180, 22);
            classeTerapeuticaToolStripMenuItem.Text = "Classe Terapeutica";
            classeTerapeuticaToolStripMenuItem.Click += classeTerapeuticaToolStripMenuItem_Click;
            classeTerapeuticaToolStripMenuItem.Enabled = "124".Contains(GlobalVariables.PerfilId.ToString()) ? true : false;
            // 
            // clinicaToolStripMenuItem
            // 
            clinicaToolStripMenuItem.Name = "clinicaToolStripMenuItem";
            clinicaToolStripMenuItem.Size = new Size(180, 22);
            clinicaToolStripMenuItem.Text = "Clinica";
            clinicaToolStripMenuItem.Click += clinicaToolStripMenuItem_Click;
            clinicaToolStripMenuItem.Enabled = "124".Contains(GlobalVariables.PerfilId.ToString()) ? true : false;
            // 
            // convenioToolStripMenuItem
            // 
            convenioToolStripMenuItem.Name = "convenioToolStripMenuItem";
            convenioToolStripMenuItem.Size = new Size(180, 22);
            convenioToolStripMenuItem.Text = "Convênio";
            convenioToolStripMenuItem.Click += convenioToolStripMenuItem_Click;
            convenioToolStripMenuItem.Enabled = "124".Contains(GlobalVariables.PerfilId.ToString()) ? true : false;
            // 
            // especialidadeToolStripMenuItem
            // 
            especialidadeToolStripMenuItem.Name = "especialidadeToolStripMenuItem";
            especialidadeToolStripMenuItem.Size = new Size(180, 22);
            especialidadeToolStripMenuItem.Text = "Especialidade";
            especialidadeToolStripMenuItem.Click += especialidadeToolStripMenuItem_Click;
            especialidadeToolStripMenuItem.Enabled = "124".Contains(GlobalVariables.PerfilId.ToString()) ? true : false;
            // 
            // fabricanteToolStripMenuItem
            // 
            fabricanteToolStripMenuItem.Name = "fabricanteToolStripMenuItem";
            fabricanteToolStripMenuItem.Size = new Size(180, 22);
            fabricanteToolStripMenuItem.Text = "Fabricante";
            fabricanteToolStripMenuItem.Click += fabricanteToolStripMenuItem_Click;
            fabricanteToolStripMenuItem.Enabled = "124".Contains(GlobalVariables.PerfilId.ToString()) ? true : false;
            // 
            // medicoToolStripMenuItem
            // 
            medicoToolStripMenuItem.Name = "medicoToolStripMenuItem";
            medicoToolStripMenuItem.Size = new Size(180, 22);
            medicoToolStripMenuItem.Text = "Medico";
            medicoToolStripMenuItem.Click += medicoToolStripMenuItem_Click;
            medicoToolStripMenuItem.Enabled = "124".Contains(GlobalVariables.PerfilId.ToString()) ? true : false;
            // 
            // modalidadeToolStripMenuItem
            // 
            modalidadeToolStripMenuItem.Name = "modalidadeToolStripMenuItem";
            modalidadeToolStripMenuItem.Size = new Size(180, 22);
            modalidadeToolStripMenuItem.Text = "Modalidade";
            modalidadeToolStripMenuItem.Click += modalidadeToolStripMenuItem_Click;
            modalidadeToolStripMenuItem.Enabled = "124".Contains(GlobalVariables.PerfilId.ToString()) ? true : false;
            // 
            // parâmetrosToolStripMenuItem
            // 
            parâmetrosToolStripMenuItem.Name = "parâmetrosToolStripMenuItem";
            parâmetrosToolStripMenuItem.Size = new Size(180, 22);
            parâmetrosToolStripMenuItem.Text = "Parâmetros";
            parâmetrosToolStripMenuItem.Click += parâmetrosToolStripMenuItem_Click;
            parâmetrosToolStripMenuItem.Enabled = "124".Contains(GlobalVariables.PerfilId.ToString()) ? true : false;
            // 
            // periodicidadeRefilToolStripMenuItem
            // 
            periodicidadeRefilToolStripMenuItem.Name = "periodicidadeRefilToolStripMenuItem";
            periodicidadeRefilToolStripMenuItem.Size = new Size(180, 22);
            periodicidadeRefilToolStripMenuItem.Text = "Periodicidade Refil";
            periodicidadeRefilToolStripMenuItem.Click += periodicidadeRefilToolStripMenuItem_Click;
            periodicidadeRefilToolStripMenuItem.Enabled = "124".Contains(GlobalVariables.PerfilId.ToString()) ? true : false;
            // 
            // substânciaToolStripMenuItem
            // 
            substânciaToolStripMenuItem.Name = "substânciaToolStripMenuItem";
            substânciaToolStripMenuItem.Size = new Size(180, 22);
            substânciaToolStripMenuItem.Text = "Substância";
            substânciaToolStripMenuItem.Click += substanciaToolStripMenuItem_Click;
            substânciaToolStripMenuItem.Enabled = "124".Contains(GlobalVariables.PerfilId.ToString()) ? true : false;
            // 
            // tipoEntregaToolStripMenuItem
            // 
            tipoEntregaToolStripMenuItem.Name = "tipoEntregaToolStripMenuItem";
            tipoEntregaToolStripMenuItem.Size = new Size(180, 22);
            tipoEntregaToolStripMenuItem.Text = "Tipo Entrega";
            tipoEntregaToolStripMenuItem.Click += tipoEntregaToolStripMenuItem_Click;
            tipoEntregaToolStripMenuItem.Enabled = "124".Contains(GlobalVariables.PerfilId.ToString()) ? true : false;
            // 
            // tipoReceitaToolStripMenuItem
            // 
            tipoReceitaToolStripMenuItem.Name = "tipoReceitaToolStripMenuItem";
            tipoReceitaToolStripMenuItem.Size = new Size(180, 22);
            tipoReceitaToolStripMenuItem.Text = "Tipo Receita";
            tipoReceitaToolStripMenuItem.Click += tipoReceitaToolStripMenuItem_Click;
            tipoReceitaToolStripMenuItem.Enabled = "124".Contains(GlobalVariables.PerfilId.ToString()) ? true : false;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(177, 6);
            // 
            // usuárioToolStripMenuItem
            // 
            usuárioToolStripMenuItem.Name = "usuárioToolStripMenuItem";
            usuárioToolStripMenuItem.Size = new Size(180, 22);
            usuárioToolStripMenuItem.Text = "Usuário";
            usuárioToolStripMenuItem.Click += usuárioToolStripMenuItem_Click;
            usuárioToolStripMenuItem.Enabled = GlobalVariables.PerfilId == 1 ? true : false;

            // 
            // mmedicamentoToolStripMenuItem
            // 
            mmedicamentoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { medicamentoToolStripMenuItem, preçoDeMedicamentoToolStripMenuItem });
            mmedicamentoToolStripMenuItem.Name = "mmedicamentoToolStripMenuItem";
            mmedicamentoToolStripMenuItem.Size = new Size(93, 20);
            mmedicamentoToolStripMenuItem.Text = "Medicamento";
            mmedicamentoToolStripMenuItem.Enabled = "1234".Contains(GlobalVariables.PerfilId.ToString()) ? true : false;
            // 
            // medicamentoToolStripMenuItem
            // 
            medicamentoToolStripMenuItem.Name = "medicamentoToolStripMenuItem";
            medicamentoToolStripMenuItem.Size = new Size(197, 22);
            medicamentoToolStripMenuItem.Text = "Medicamento";
            medicamentoToolStripMenuItem.Click += medicamentoToolStripMenuItem_Click;
            medicamentoToolStripMenuItem.Enabled = "124".Contains(GlobalVariables.PerfilId.ToString()) ? true : false;
            // 
            // preçoDeMedicamentoToolStripMenuItem
            // 
            preçoDeMedicamentoToolStripMenuItem.Name = "preçoDeMedicamentoToolStripMenuItem";
            preçoDeMedicamentoToolStripMenuItem.Size = new Size(197, 22);
            preçoDeMedicamentoToolStripMenuItem.Text = "Preço de Medicamento";
            preçoDeMedicamentoToolStripMenuItem.Click += preçoDeMedicamentoToolStripMenuItem_Click;
            preçoDeMedicamentoToolStripMenuItem.Enabled = "124".Contains(GlobalVariables.PerfilId.ToString()) ? true : false;
            // 
            // pacienteToolStripMenuItem
            // 
            pacienteToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cadastroDePacienteToolStripMenuItem });
            pacienteToolStripMenuItem.Name = "pacienteToolStripMenuItem";
            pacienteToolStripMenuItem.Size = new Size(64, 20);
            pacienteToolStripMenuItem.Text = "Paciente";
            pacienteToolStripMenuItem.Enabled = "1234".Contains(GlobalVariables.PerfilId.ToString()) ? true : false;
            // 
            // cadastroDePacienteToolStripMenuItem
            // 
            cadastroDePacienteToolStripMenuItem.Name = "cadastroDePacienteToolStripMenuItem";
            cadastroDePacienteToolStripMenuItem.Size = new Size(185, 22);
            cadastroDePacienteToolStripMenuItem.Text = "Cadastro de Paciente";
            cadastroDePacienteToolStripMenuItem.Click += cadastroDePacienteToolStripMenuItem_Click;
            cadastroDePacienteToolStripMenuItem.Enabled = "124".Contains(GlobalVariables.PerfilId.ToString()) ? true : false;
            // 
            // receitaToolStripMenuItem2
            // 
            receitaToolStripMenuItem2.DropDownItems.AddRange(new ToolStripItem[] { receitaToolStripMenuItem1 });
            receitaToolStripMenuItem2.Name = "receitaToolStripMenuItem2";
            receitaToolStripMenuItem2.Size = new Size(57, 20);
            receitaToolStripMenuItem2.Text = "Receita";
            receitaToolStripMenuItem2.Enabled = "1234".Contains(GlobalVariables.PerfilId.ToString()) ? true : false;
            // 
            // receitaToolStripMenuItem1
            // 
            receitaToolStripMenuItem1.Name = "receitaToolStripMenuItem1";
            receitaToolStripMenuItem1.Size = new Size(178, 22);
            receitaToolStripMenuItem1.Text = "Cadastro de Receita";
            receitaToolStripMenuItem1.Click += receitaToolStripMenuItem1_Click;
            receitaToolStripMenuItem1.Enabled = "124".Contains(GlobalVariables.PerfilId.ToString()) ? true : false;
            // 
            // receitaToolStripMenuItem
            // 
            receitaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { BaseCadastralToolStripMenuItem, pedidoToolStripMenuItem2 });
            receitaToolStripMenuItem.Name = "receitaToolStripMenuItem";
            receitaToolStripMenuItem.Size = new Size(59, 20);
            receitaToolStripMenuItem.Text = "Entrega";
            receitaToolStripMenuItem.Enabled = "1234".Contains(GlobalVariables.PerfilId.ToString()) ? true : false;
            // 
            // BaseCadastralToolStripMenuItem
            // 
            BaseCadastralToolStripMenuItem.Name = "BaseCadastralToolStripMenuItem";
            BaseCadastralToolStripMenuItem.Size = new Size(150, 22);
            BaseCadastralToolStripMenuItem.Text = "Base Cadastral";
            BaseCadastralToolStripMenuItem.Click += baseCadastralToolStripMenuItem_Click;
            BaseCadastralToolStripMenuItem.Enabled = "124".Contains(GlobalVariables.PerfilId.ToString()) ? true : false;

            // 
            // pedidoToolStripMenuItem2
            // 
            pedidoToolStripMenuItem2.Name = "pedidoToolStripMenuItem2";
            pedidoToolStripMenuItem2.Size = new Size(150, 22);
            pedidoToolStripMenuItem2.Text = "Pedido";
            pedidoToolStripMenuItem2.Click += pedidoToolStripMenuItem2_Click_1;
            pedidoToolStripMenuItem2.Enabled = "1234".Contains(GlobalVariables.PerfilId.ToString()) ? true : false;
            // 
            // pedidoToolStripMenuItem
            // 
            pedidoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { pedidoToolStripMenuItem1 });
            pedidoToolStripMenuItem.Name = "pedidoToolStripMenuItem";
            pedidoToolStripMenuItem.Size = new Size(56, 20);
            pedidoToolStripMenuItem.Text = "Pedido";
            pedidoToolStripMenuItem.Visible = false;
            pedidoToolStripMenuItem.Enabled = "1234".Contains(GlobalVariables.PerfilId.ToString()) ? true : false;
            // 
            // pedidoToolStripMenuItem1
            // 
            pedidoToolStripMenuItem1.Name = "pedidoToolStripMenuItem1";
            pedidoToolStripMenuItem1.Size = new Size(111, 22);
            pedidoToolStripMenuItem1.Text = "Pedido";
            pedidoToolStripMenuItem1.Click += pedidoToolStripMenuItem1_Click;
            pedidoToolStripMenuItem1.Enabled = "1234".Contains(GlobalVariables.PerfilId.ToString()) ? true : false;
            // 
            // ajudaToolStripMenuItem
            // 
            ajudaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { sobrceToolStripMenuItem, sairToolStripMenuItem });
            ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            ajudaToolStripMenuItem.Size = new Size(50, 20);
            ajudaToolStripMenuItem.Text = "Ajuda";
            ajudaToolStripMenuItem.Enabled = "1234".Contains(GlobalVariables.PerfilId.ToString()) ? true : false;
            // 
            // sobrceToolStripMenuItem
            // 
            sobrceToolStripMenuItem.Name = "sobrceToolStripMenuItem";
            sobrceToolStripMenuItem.Size = new Size(220, 22);
            sobrceToolStripMenuItem.Text = "Sobre Controle de Entregas ";
            sobrceToolStripMenuItem.Click += sobrceToolStripMenuItem_Click;
            sobrceToolStripMenuItem.Enabled = "1234".Contains(GlobalVariables.PerfilId.ToString()) ? true : false;
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(220, 12);
            sairToolStripMenuItem.Text = "Sai&r";
            sairToolStripMenuItem.Click += sairToolStripMenuItem_Click;
            sairToolStripMenuItem.Enabled = "1234".Contains(GlobalVariables.PerfilId.ToString()) ? true : false;
            // 
            // saírToolStripMenuItem
            // 
            saírToolStripMenuItem.Name = "saírToolStripMenuItem";
            saírToolStripMenuItem.Size = new Size(180, 12);
            saírToolStripMenuItem.Text = "Saí&r";
            saírToolStripMenuItem.Click += saírToolStripMenuItem_Click;
            saírToolStripMenuItem.Enabled = "1234".Contains(GlobalVariables.PerfilId.ToString()) ? true : false;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(177, 6);
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            MaximizeBox = true;
            Name = "frmPrincipal";
            Text = "EPharmacy - Sistema de  Controle de Entregas";
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
        private ToolStripMenuItem mmedicamentoToolStripMenuItem;
        private ToolStripMenuItem pacienteToolStripMenuItem;
        private ToolStripMenuItem cadastroDeMedicaentoToolStripMenuItem1;
       // private ToolStripMenuItem preçoMedicamentoToolStripMenuItem;
        private ToolStripMenuItem cadastroDePacienteToolStripMenuItem;
        private ToolStripMenuItem medicamentoToolStripMenuItem;
        private ToolStripMenuItem preçoDeMedicamentoToolStripMenuItem;
        private ToolStripMenuItem modalidadeToolStripMenuItem;
        private ToolStripMenuItem tipoEntregaToolStripMenuItem;
        private ToolStripMenuItem clinicaToolStripMenuItem;
        private ToolStripMenuItem convenioToolStripMenuItem;
        private ToolStripMenuItem receitaToolStripMenuItem;
        private ToolStripMenuItem periodicidadeRefilToolStripMenuItem;
        private ToolStripMenuItem medicoToolStripMenuItem;
        private ToolStripMenuItem BaseCadastralToolStripMenuItem;
        private ToolStripMenuItem parâmetrosToolStripMenuItem;
        private ToolStripMenuItem pedidoToolStripMenuItem;
        private ToolStripMenuItem pedidoToolStripMenuItem1;
        private ToolStripMenuItem pedidoToolStripMenuItem2;
        private ToolStripMenuItem receitaToolStripMenuItem2;
        private ToolStripMenuItem receitaToolStripMenuItem1;
        private ToolStripMenuItem bairroZonaToolStripMenuItem;
        private ToolStripMenuItem especialidadeToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem saírToolStripMenuItem;
    }
}