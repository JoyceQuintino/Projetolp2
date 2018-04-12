using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using laiscegonha.Models;

namespace laiscegonha.Context
{
    public class LaisContext : DbContext
    {
        public DbSet<Crianca> Criancas { get; set; }
        public DbSet<Mae> Maes { get; set; }
        public DbSet<ConsultaPreNatal> Consultas { get; set; }
        public DbSet<Parto> Partos { get; set; }
        public DbSet<MaeConsultaPreNatal> MaeConsultaPreNatal { get; set; }

        public LaisContext(DbContextOptions<LaisContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MaeConsultaPreNatal>()
                .HasKey(mc => new { mc.IdMae, mc.IdConsultaPreNatal });
        }
    }
}
