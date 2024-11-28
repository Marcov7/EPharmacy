using System.Text.RegularExpressions;

namespace BLL
{
    public static class Utilitarios
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
    
    
    
    }
}
