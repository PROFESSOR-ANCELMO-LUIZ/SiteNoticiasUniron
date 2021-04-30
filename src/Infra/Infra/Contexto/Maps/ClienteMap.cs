using Dominio.Entidades;
using Dominio.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.Contexto.Maps
{
    public class ClienteMap : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.ToTable("clientes");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Nome).IsRequired().HasMaxLength(100).HasColumnType("varchar(100)");
            builder.Property(x => x.DataDeNascimento).IsRequired().HasColumnType("DATE");
            builder.Property(x => x.Sexo).HasConversion(y => y.ToString(), y => (ESexo)Enum.Parse(typeof(ESexo), y)).HasMaxLength(10).IsRequired();
            builder.Property(x => x.Telefone).HasColumnType("varchar(15)");
            builder.Property(x => x.Endereco).HasColumnType("varchar(200)");

            builder.HasMany(x => x.Classificados).WithOne(x => x.Cliente);
        }
    }
}
