using EPharmacy.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPharmacy.BLL
{
    public class MedicamentoBLL
    {

        private readonly EPharmacyContext _context;

        public MedicamentoBLL()
        {
            var optionsBuilder = new DbContextOptionsBuilder<EPharmacyContext>();
            optionsBuilder.UseSqlServer(Program.StrConn());
            _context = new EPharmacyContext(optionsBuilder.Options);
        }

        public string CalcularNovoPreco()
        {

            try
            {
                // Buscar o parâmetro com a descrição específica
                var parametro = _context.Parametros.FirstOrDefault(p => p.Descricao == "PercentePrecoAcordo");

                if (parametro == null)
                {
                    return "Parâmetro com Descrição 'PercentePraCalculo' não encontrado.";
                }

                // Atualizar todos os registros de MedicamentoPreco
                var medicamentos = _context.MedicamentoPreco.ToList();

                bool sucesso = decimal.TryParse(parametro.Valor, out decimal Valor);
                if (!sucesso)
                {
                    return " Erro no valor. Verifique a tabela de Parâmentro e tente novamente";
                }

                string retorno = "";
                foreach (var medicamento in medicamentos)
                { 
                    medicamento.PrecoAcordado = Math.Round(medicamento.PrecoPmcBrasindice * (1 - Valor/100), 2);
                    retorno = "Alterado e";
                }

                // Salvar as alterações no banco de dados
                _context.SaveChanges();

                return retorno + " Atualizado com sucesso.";
            }
            catch (Exception ex)
            {
                return $"Erro: {ex.Message}";
            }
        }
    }
}
