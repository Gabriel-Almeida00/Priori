using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Priori_OBJ.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Priori_DADOS.Mapeamentos
{
    public class TipoInvestidorMap : IEntityTypeConfiguration<tbltipoInvestidor>
    {
        public void Configure(EntityTypeBuilder<tbltipoInvestidor> builder)
        {
            builder.HasKey(c => c.id_tipoinvestidor);
            

            builder.Property(u => u.nome_categoria).IsRequired().HasMaxLength(50);
            builder.HasIndex(u => u.nome_categoria).IsUnique();

            builder.Property(u => u.descricao_categoria).IsRequired().HasMaxLength(100);

            builder.ToTable("tblTipoInvestidor");
        }
    }
}
