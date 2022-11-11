using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Priori_OBJ.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Priori_DADOS.Mapeamentos
{
    public class ClienteMap : IEntityTypeConfiguration<tblClientes>
    {
        public void Configure(EntityTypeBuilder<tblClientes> builder)
        {
            builder.Property(u => u.Id).ValueGeneratedOnAdd();

            builder.Property(c => c.nome).IsRequired().HasMaxLength(50);
            builder.Property(c => c.email).IsRequired().HasMaxLength(30);
            builder.Property(c => c.estado).IsRequired().HasMaxLength(35);
            builder.Property(c => c.cpf).IsRequired().HasColumnType("decimal(5,2").IsRequired().HasMaxLength(15);
            builder.Property(c => c.senha).IsRequired().HasMaxLength(15);
            builder.Property(c => c.telefone).IsRequired().HasMaxLength(15);
            builder.Property(c => c.data_adesao).IsRequired().HasMaxLength(15);
           

            builder.HasOne(c => c.agente).WithMany(c => c.cliente).HasForeignKey(c => c.id_agente).IsRequired().OnDelete(DeleteBehavior.NoAction); 
            builder.HasMany(c => c.CarteiraInvestimentos).WithOne(c => c.cliente).OnDelete(DeleteBehavior.NoAction); 

            builder.ToTable("tblClientes");
        }
    }
}
