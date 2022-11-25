﻿using MasterServicesFZ.Domain;
using Microsoft.EntityFrameworkCore;

namespace MasterServicesFZ.Infrastructure.Persistence
{
    public class SqlDbContext : DbContext
    {
        private const string DboSchema = "dbo";

        public SqlDbContext(DbContextOptions<SqlDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>()
                .ToTable("Scr_Departamento", DboSchema)
                .HasKey(d => d.CodigoLP);

            modelBuilder.Entity<Municipality>()
                .ToTable("Scr_Municipio", DboSchema)
                .HasKey(m => m.CodigoLP);

            modelBuilder.Entity<Occupation>()
                .ToTable("Scr_Ocupacion", DboSchema)
                .HasKey(o => o.CodigoLP);

            modelBuilder.Entity<ContractType>()
                .ToTable("Scr_TipoContrato", DboSchema)
                .HasKey(m => m.CodigoLP);

            modelBuilder.Entity<MaritalStatus>()
                .ToTable("Scr_EstadoCivil", DboSchema)
                .HasKey(m => m.CodigoLP);

            modelBuilder.Entity<ResidenceType>()
                .ToTable("Scr_TipoVivienda", DboSchema)
                .HasKey(m => m.CodigoLP);

            modelBuilder.Entity<InitialPaymentOrigin>()
                .ToTable("Scr_OrigenCuotaInicial", DboSchema)
                .HasKey(o => o.Id);
        }

        public DbSet<Department>? Scr_Departamento { get; set; }
        public DbSet<Municipality>? Scr_Municipio { get; set; }
        public DbSet<Occupation>? Scr_Ocupacion { get; set; }
        public DbSet<ContractType>? Scr_TipoContrato { get; set; }
        public DbSet<MaritalStatus>? Scr_EstadoCivil { get; set; }
        public DbSet<ResidenceType>? Scr_TipoVivienda { get; set; }
        public DbSet<InitialPaymentOrigin>? Scr_OrigenCuotaInicial { get; set; }
    }
}
