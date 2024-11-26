using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EPharmacy.Models
{
    public class Medico
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string? CRM { get; set; }
        public int? EspecialidadeId { get; set; }
        public DateTime DataCadastro { get; set; }
        public int Usuario { get; set; }
    }
}
