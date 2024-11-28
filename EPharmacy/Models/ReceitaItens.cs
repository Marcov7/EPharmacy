namespace EPharmacy.Models
{
    public class ReceitaItens
    {
        public int Id { get; set; }
        public int ReceitaId { get; set; }
        public int MedicamentoId { get; set; }
        public int PeriodicidadeRefilId { get; set; }
        public int StatusId { get; set; }
        public DateTime DataCadastro { get; set; }
        public int Usuario { get; set; }
    }
}
