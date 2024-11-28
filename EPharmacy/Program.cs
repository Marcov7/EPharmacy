using Microsoft.EntityFrameworkCore;
using EPharmacy.Data;
using System.Runtime.ConstrainedExecution;

namespace EPharmacy
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var optionsBuilder = new DbContextOptionsBuilder<EPharmacyContext>();
            //optionsBuilder.UseSqlServer(@"Server=LAPTOP-5CRV3IV2\SQLEXPRESS;Database=CONTROLE_ENTREGA;Trusted_Connection=True;Encrypt=False;");
            optionsBuilder.UseSqlServer(StrConn());
            using (var context = new EPharmacyContext(optionsBuilder.Options))
            {
                context.Database.Migrate(); 
            }

            ApplicationConfiguration.Initialize();
            Application.Run(new frmLogin());
           // Application.Run(new frmMedicamento());
        }


        public static string StrConn()
        {
            return @"Server=LAPTOP-5CRV3IV2\SQLEXPRESS;Database=CONTROLE_ENTREGA;Trusted_Connection=True;Encrypt=False;";
        }


        public static string StrLinkEndereco(string cep)
        {
            string url = $"https://viacep.com.br/ws/{cep}/json/";
            return url;
        }
    }
}