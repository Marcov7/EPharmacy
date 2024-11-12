using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPharmacy.Models
{
    public class Medicamento
    {
        public int Id { get; set; }
        public string EAN { get; set; }
        public string Produto { get; set; }
        public int ClasseTerapeuticaId { get; set; }
        public int TipoReceitaId { get; set; }
        public int FabricanteId { get; set; }
        public int SubstanciaId { get; set; }
        public DateTime DataCadastro { get; set; }
        public int Usuario { get; set; }
    }
}
