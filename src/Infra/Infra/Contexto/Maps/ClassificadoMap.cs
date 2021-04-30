using Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Infra.Contexto.Maps
{
    public class ClassificadoMap : IEntityTypeConfiguration<Classificado>
    {
        public void Configure(EntityTypeBuilder<Classificado> builder)
        {
            builder.ToTable("classificados");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Data).IsRequired();
            builder.Property(x => x.Status).IsRequired();

            builder.HasOne(x => x.Produto).WithOne(x => x.Classificado);
        }
    }
}
