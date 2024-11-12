using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPharmacy.Models
{
    public class ReceitaItens
    {
        public int Id { get; set; }
        public int ReceitaId { get; set; }
        public int MedicamentoId { get; set; }
        public int PacienteId { get; set; }
        public DateTime DataCadastro { get; set; }
        public int Usuario { get; set; }
    }
}
