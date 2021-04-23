using Dominio.Entidades;
using Infra.Contexto.Maps;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.Contexto
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Autor> Autores { get; set; }
        public DbSet<Classificado> Classificados { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Conteudo> Conteudos { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<TipoDeConteudo> TipoDeConteudos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AutorMap());
        }

    }
}
