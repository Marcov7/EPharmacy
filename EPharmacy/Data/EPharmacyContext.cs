using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EPharmacy.Models;
using Microsoft.EntityFrameworkCore;

namespace EPharmacy.Data
{
    // Não abra filme
    public class EPharmacyContext : DbContext
    {
        public DbSet<Medicamento> Medicamento { get; set; }
        public DbSet<MedicamentoPreco> MedicamentoPreco { get; set; }
        public DbSet<ClasseTerapeutica> ClasseTerapeutica { get; set; }
        public DbSet<TipoReceita> TipoReceita { get; set; }
        public DbSet<Fabricante> Fabricante { get; set; }
        public DbSet<Substancia> Substancia { get; set; }
        public DbSet<Receita> Receita { get; set; }
        public DbSet<ReceitaItens> ReceitaItens { get; set; }
        public DbSet<UsuarioSistema> UsuarioSistema { get; set; }
        public DbSet<Sexo> Sexo { get; set; }
        public DbSet<Paciente> Paciente { get; set; }
        public DbSet<Convenio> Convenio { get; set; }
        public DbSet<Modalidade> Modalidade { get; set; }
        public DbSet<TipoEntrega> TipoEntrega { get; set; }
        public DbSet<Medico> Medico { get; set; }
        public DbSet<Clinica> Clinica { get; set; }
        public DbSet<Especialidade> Especialidade { get; set; }
        public DbSet<PeriodicidadeRefil> PeriodicidadeRefil { get; set; }
        public DbSet<Status> Status { get; set; }




        public EPharmacyContext(DbContextOptions<EPharmacyContext> options) : base(options) { }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}




   