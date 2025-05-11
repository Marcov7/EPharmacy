using EPharmacy.Data;
using Microsoft.EntityFrameworkCore;

namespace EPharmacy
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();

            var optionsBuilder = new DbContextOptionsBuilder<EPharmacyContext>();
            optionsBuilder.UseSqlServer(Program.StrConn());
            _context = new EPharmacyContext(optionsBuilder.Options);

            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            GlobalVariables.Versao = "1.00b - 05/05/2025";

            lblVersao.Text += GlobalVariables.Versao;
        }


        private readonly EPharmacyContext _context;
        //private int Id;


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
            string Login = txtLogin.Text;
            string Senha = txtSenha.Text;

            var entidade = _context.UsuarioSistema.AsQueryable();

            if (!string.IsNullOrEmpty(Login) && !string.IsNullOrEmpty(Senha))
            {
                entidade = entidade.Where(p => p.Login == Login && p.Senha == Senha);

            }
            else
            {
                MessageBox.Show("Preencha os campos Login e Senha e Tente novamente.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            var entidadex = entidade.ToList();

            if (entidadex.Count <= 0) {
               MessageBox.Show("Falha na tentativa login no sistema. Tente novamente.","", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
               return;
            }

            GlobalVariables.LoginId = entidadex[0].Id;
            GlobalVariables.PerfilId = entidadex[0].PerfilId;

            GlobalVariables.Login = entidadex[0].Id.ToString() + "-" + entidadex[0].Login + " - " + entidadex[0].Nome + " - Perfil:" + entidadex[0].PerfilId.ToString();

            frmPrincipal frm = new frmPrincipal();
            frm.ShowDialog(); 
            this.Close();
        }


    }
}
