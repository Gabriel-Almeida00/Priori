using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using Priori_OBJ.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Priori_DADOS.Mapeamentos
{
    public class CarteiraInvestimentoMap : IEntityTypeConfiguration<tblCarteiraInvestimentos>
    {
        public void Configure(EntityTypeBuilder<tblCarteiraInvestimentos> builder)
        {
            builder.HasKey(c => c.id_carteira);

            builder.Property(c => c.data_efetuacao).IsRequired().HasMaxLength(50);
            builder.Property(c => c.valor_aplicado).HasColumnType("decimal(5,2)").IsRequired().IsRequired( );
            builder.Property(c => c.tempo_aplicacao).IsRequired().HasMaxLength(35);
            builder.Property(c => c.duracao).IsRequired().HasMaxLength(15);
            builder.Property(c => c.saldo).IsRequired().HasColumnType("decimal(5,2)").IsRequired().HasMaxLength(15);

            builder.HasOne(c => c.cliente).WithMany(c => c.CarteiraInvestimentos).HasForeignKey(c => c.id_cliente).IsRequired().OnDelete(DeleteBehavior.NoAction); 
            builder.HasMany(c => c.Investimentos).WithOne(c => c.carteira).OnDelete(DeleteBehavior.NoAction); 
           
            builder.ToTable("tblCarteiraInvestimento");
        }
    }
}
