using AccountProject.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace AccountProject.Data
{
    public class SqlDbContext:DbContext
    {
        public SqlDbContext()
        {
        }

        public SqlDbContext(DbContextOptions<SqlDbContext> options):base(options)
        {

        }
        public DbSet<Subscriber> Subscribers { get; set; }
        public DbSet<Account> Accounts { get; set; }
        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            modelbuilder.ApplyConfigurationsFromAssembly(typeof(SqlDbContext).Assembly);

            modelbuilder.Entity<Subscriber>().ToTable("Subscribers");

            modelbuilder.Entity<Account>()
            .Property(o => o.SonEndeks).HasColumnType("decimal(5,3)");
            modelbuilder.Entity<Account>()
            .Property(o => o.İlkEndeks).HasColumnType("decimal(5,3)");
            modelbuilder.Entity<Account>()
            .Property(o => o.TarifeToplamFiyat).HasColumnType("decimal(5,3)");
            modelbuilder.Entity<Account>()
            .Property(o => o.TarifeKdvFiyat).HasColumnType("decimal(5,3)");
            modelbuilder.Entity<Account>()
            .Property(o => o.TarifeBirimFiyat).HasColumnType("decimal(5,3)");
        }
       
       
    }
}
