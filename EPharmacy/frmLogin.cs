namespace EPharmacy
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
             "Você tem certeza que deseja Sair?",
             "Confirmação",
             MessageBoxButtons.YesNo,
             MessageBoxIcon.Question
         );

            if (resultado == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            frmPrincipal frm = new frmPrincipal();
            frm.ShowDialog(); 
            this.Close();
        }
    }
}
