using Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.Contexto.Maps
{
    public class ConteudoMap : IEntityTypeConfiguration<Conteudo>
    {
        public void Configure(EntityTypeBuilder<Conteudo> builder)
        {
            builder.ToTable("conteudos");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Titulo).IsRequired().HasMaxLength(1000).HasColumnType("varchar(1000)");
            builder.Property(x => x.Texto).HasColumnType("text()");
            builder.Property(x => x.DataDoCadastro).IsRequired().HasColumnType("DATE");
            
        }
    }
}
