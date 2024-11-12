using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EPharmacy.Models;
using Microsoft.EntityFrameworkCore;

namespace EPharmacy.Data
{
    public class EPharmacyContext : DbContext
    {
        public DbSet<Medicamento> Medicamento { get; set; }
        public DbSet<MedicamentoPreco> MedicamentoPreco { get; set; }
        public DbSet<ClasseTerapeutica> ClasseTerapeutica { get; set; }
        public DbSet<TipoReceita> TipoReceita { get; set; }
        public DbSet<Fabricante> Fabricante { get; set; }
        public DbSet<Substancia> Substancia { get; set; }
        public DbSet<ReceitaItens> ReceitaItens { get; set; }

        public EPharmacyContext(DbContextOptions<EPharmacyContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}




   