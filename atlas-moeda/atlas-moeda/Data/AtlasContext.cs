using atlas_moeda.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace atlas_moeda.Data
{
    public class AtlasContext : DbContext
    {
        public AtlasContext(DbContextOptions<AtlasContext> options) : base(options) { }
        public DbSet<Moeda> Moedas { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Moeda>(moeda => {
                moeda.HasKey(m => m.Id);
                moeda.ToTable("Tb_Moedas");
                moeda.Property(m => m.Nome).HasMaxLength(50).IsRequired();
                moeda.Property(m => m.Sigla).HasMaxLength(5).IsRequired();
            });
        }
    }
}
