using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Priori_OBJ.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Priori_DADOS.Mapeamentos
{
    public class InvestimentoMap : IEntityTypeConfiguration<tblInvestimentos>
    {
        public void Configure(EntityTypeBuilder<tblInvestimentos> builder)
        {
            builder.HasKey(c => c.id_investimento);

            builder.Property(c => c.nome).IsRequired().HasMaxLength(50);
            builder.Property(c => c.rentabilidade).IsRequired().HasMaxLength(15);
            builder.Property(c => c.descricao).IsRequired().HasMaxLength(35);
            builder.Property(c => c.tempo_minimo).IsRequired().HasMaxLength(15);
            builder.Property(c => c.valor_minimo).HasColumnType("decimal(5,2").IsRequired().HasMaxLength(15);
            builder.Property(c => c.tipo_investimento).IsRequired().HasMaxLength(15);

            builder.HasOne(c => c.tbltipoInvestidor).WithMany(c => c.investimento).HasForeignKey(c => c.id_tipoInvestidor).IsRequired().OnDelete(DeleteBehavior.NoAction); 
            builder.HasOne(c => c.carteira).WithMany(c => c.Investimentos).HasForeignKey(c => c.id_carteira).IsRequired().OnDelete(DeleteBehavior.NoAction); 

            builder.ToTable("tblInvestimento");
        }
    }
}
