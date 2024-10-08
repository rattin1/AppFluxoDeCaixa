﻿using AppFluxoDeCaixa.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AppFluxoDeCaixa.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Clientes> Clientes { get; set; }
        public DbSet<Clientes> Fornecedores { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Clientes>().ToTable("1234Clientes");
            builder.Entity<Fornecedor>().ToTable("Fornecedor");
        }
        public DbSet<AppFluxoDeCaixa.Models.Fornecedor> Fornecedor { get; set; } = default!;

    }
}
