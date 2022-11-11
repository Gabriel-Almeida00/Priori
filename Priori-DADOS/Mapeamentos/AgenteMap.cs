using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Priori_OBJ.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Priori_DADOS.Mapeamentos 
{
    public class AgenteMap : IEntityTypeConfiguration<tblAgentes>
    {
       
    public void Configure(EntityTypeBuilder<tblAgentes> builder)
        {
            builder.HasKey(c => c.id_agente);

            builder.Property(c => c.nome).IsRequired().HasMaxLength(50);
            builder.Property(c => c.estado).IsRequired().HasMaxLength(15);
            builder.Property(c => c.email).IsRequired().HasMaxLength(35);
            builder.Property(c => c.cpf).HasColumnType("decimal(5,2").IsRequired();
            builder.Property(c => c.telefone).IsRequired().HasMaxLength(15);
            builder.Property(c => c.salario).HasColumnType("decimal(5,2").IsRequired();
            builder.Property(c => c.data_demissao).IsRequired().HasMaxLength(15);
            builder.Property(c => c.data_contratacao).IsRequired().HasMaxLength(15);

            builder.HasMany(c => c.cliente).WithOne(c => c.agente).OnDelete(DeleteBehavior.NoAction);


            builder.ToTable("tblAgente");
        }
    }
}
