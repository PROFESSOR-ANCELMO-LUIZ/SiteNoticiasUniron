using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio.Entidades
{
    public class Autor
    {
        public Autor(string nome, string linkdin)
        {
            Nome = nome;
            Linkdin = linkdin;
        }

        public int Id { get; private set; }
        public string Nome { get; private set; }
        public string Linkdin { get; private set; }
        public string Lattes { get; private set; }

        public IEnumerable<Conteudo> Conteudos { get; private set; }
    }
}
