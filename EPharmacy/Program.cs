using Microsoft.EntityFrameworkCore;
using EPharmacy.Data;
using System.Runtime.ConstrainedExecution;
using BLL;
using System.Globalization;

namespace EPharmacy
{
    internal static class Program
    {
        public static string stringConn = "";
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            stringConn = UtilitariosBLL.CarregarStrConn();
            var optionsBuilder = new DbContextOptionsBuilder<EPharmacyContext>();
            //optionsBuilder.UseSqlServer(@"Server=LAPTOP-5CRV3IV2\SQLEXPRESS;Database=CONTROLE_ENTREGA;Trusted_Connection=True;Encrypt=False;");
            optionsBuilder.UseSqlServer(StrConn());
            using (var context = new EPharmacyContext(optionsBuilder.Options))
            {
                context.Database.Migrate(); 
            }

            // Define a cultura para o Brasil (pt-BR)
            Thread.CurrentThread.CurrentCulture = new CultureInfo("pt-BR");
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("pt-BR");

            ApplicationConfiguration.Initialize();
            Application.Run(new frmLogin());
           // Application.Run(new frmMedicamento());
        }


        public static string StrConn()
        {
            // return @"Server=LAPTOP-5CRV3IV2\SQLEXPRESS;Database=CONTROLE_ENTREGA;Trusted_Connection=True;Encrypt=False;";
            return @stringConn;
            //return @"Server=NB-VME-JPA-0002; Database=CONTROLE_ENTREGA; User Id=sa; Password=Deusmeajude102031+-;";

        }


        public static string StrLinkEndereco(string cep)
        {
            string url = $"https://viacep.com.br/ws/{cep}/json/";
            return url;
        }
    }
}