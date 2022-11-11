using Priori_OBJ.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Priori_DADOS.Mapeamentos;
using System;
using System.Collections.Generic;
using System.Text;
using Priori_OBJ.Models;

namespace Priori_DADOS
{
    public class Contexto : IdentityDbContext<tblClientes, Funcao, string>
    {
        public DbSet<tbltipoInvestidor> tipoInvestdor { get; set; }
        public DbSet<tblInvestimentos> investimentos { get; set; }
        public DbSet<tblClientes> cliente { get; set; }
        public DbSet<Funcao> Funcoes { get; set; }
        public DbSet<tblCarteiraInvestimentos> CarteiraInvestimentos { get; set; }
        public DbSet<tblAgentes> Agente { get; set; }
  

        public Contexto(DbContextOptions<Contexto> opcoes) : base(opcoes) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new TipoInvestidorMap());
            builder.ApplyConfiguration(new InvestimentoMap());
            builder.ApplyConfiguration(new ClienteMap());
            builder.ApplyConfiguration(new FuncaoMap());
            builder.ApplyConfiguration(new CarteiraInvestimentoMap());
            builder.ApplyConfiguration(new AgenteMap());
        
        }
    }
}