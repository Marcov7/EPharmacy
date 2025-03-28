using OfficeOpenXml.Style;
using System.Text.RegularExpressions;
using static System.Windows.Forms.LinkLabel;

namespace BLL
{
    public static class UtilitariosBLL
    {
        public static string limpaString(string s)
        {
            s = s.Replace("-", "");
            s = s.Replace(".", "");
            s = s.Replace(",", "");
            s = s.Replace(";", "");
            s = s.Replace(":", "");
            s = s.Replace(")", "");
            s = s.Replace("(", "");
            return s;
        }

        public static string limpaString2(string s)
        {
            s = s.Replace("-", "");
            s = s.Replace(".", "");
            s = s.Replace(",", "");
            s = s.Replace(";", "");
            s = s.Replace(":", "");
            s = s.Replace(")", "");
            s = s.Replace("(", "");
            s = s.Replace("/", "");
            s = s.Replace("\\", "");
            s = s.Replace("|", "");
            s = s.Replace(" ", "");
            return s;
        }


        public static bool Validar(string cpf)
        {
            // Remove qualquer caracter não numérico
            cpf = cpf.Replace(".", "").Replace("-", "");

            // Verifica se o CPF tem 11 dígitos numéricos
            if (cpf.Length != 11 || !cpf.All(char.IsDigit))
            {
                return false;
            }

            // CPF não pode ser uma sequência de números iguais
            if (cpf.All(c => c == cpf[0]))
            {
                return false;
            }

            // Verificar os dois últimos dígitos verificadores
            int[] multiplicadores1 = new int[] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicadores2 = new int[] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };

            string cpfBase = cpf.Substring(0, 9); // Pega apenas os 9 primeiros números

            // Calcula o primeiro dígito verificador
            int soma1 = 0;
            for (int i = 0; i < 9; i++)
            {
                soma1 += (cpfBase[i] - '0') * multiplicadores1[i];
            }
            int resto1 = soma1 % 11;
            int digito1 = (resto1 < 2) ? 0 : 11 - resto1;

            // Calcula o segundo dígito verificador
            int soma2 = 0;
            for (int i = 0; i < 9; i++)
            {
                soma2 += (cpfBase[i] - '0') * multiplicadores2[i];
            }
            soma2 += digito1 * multiplicadores2[9];
            int resto2 = soma2 % 11;
            int digito2 = (resto2 < 2) ? 0 : 11 - resto2;

            // Verifica se os dois dígitos verificadores estão corretos
            return cpf.EndsWith(digito1.ToString() + digito2.ToString());
        }


        public static bool IsValidEmail(string email)
        {
            // Expressão regular para validar um e-mail básico
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            // Valida se a string corresponde à expressão regular
            return Regex.IsMatch(email, pattern);
        }


        public static bool ContemNumeroLetraCaractereEspecialRegex(string input)
        {
            return Regex.IsMatch(input, @"\d") &&
                   Regex.IsMatch(input, @"[a-zA-Z]") &&
                   Regex.IsMatch(input, @"[^a-zA-Z0-9]");
        }


        public static bool Contem6Caracteres(string input)
        {   Boolean retorna = false;
            if(input.Length == 6 ) 
                retorna = true;
            return retorna;
        }


        public static bool Contem4Caracteres(string input)
        {
            Boolean retorna = false;
            if (input.Length == 4)
                retorna = true;
            return retorna;
        }

        public static string CarregarStrConn()
        {
            string caminhoArquivo = "C:\\Projetos\\ProjetoControleEntrega\\Publish\\arquivoSCB.ini"; 

            if (File.Exists(caminhoArquivo))
            {
                try
                { 
                    string linha = "";
                    StreamReader reader = new StreamReader(caminhoArquivo);
                    linha = reader.ReadLine();           
                    return linha;
                }
                catch (Exception ex)
                {
                    return $"Erro - ao ler o arquivo: {ex.Message}";
                }
            }
            return $"Erro - ao ler o arquivo.";
        }


        public static DateTime? ConverterParaData(string data)
        {
            DateTime? dataConvertida = null;
            string userInput = data;
            if (DateTime.TryParse(userInput, out DateTime parsedDate))
            {
                dataConvertida = parsedDate;
            }

            return dataConvertida;
        }


    }
}
