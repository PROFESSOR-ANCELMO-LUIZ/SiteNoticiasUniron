using Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.Contexto.Maps
{
    public class TipoDeConteudoMap : IEntityTypeConfiguration<TipoDeConteudo>
    {
        public void Configure(EntityTypeBuilder<TipoDeConteudo> builder)
        {
            builder.ToTable("tipoDeConteudos");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Descricao).IsRequired().HasMaxLength(100).HasColumnType("varchar(100)");
        }
    }
}
