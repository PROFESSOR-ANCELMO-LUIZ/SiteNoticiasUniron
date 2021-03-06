using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio.Entidades
{
    public class Autor
    {
        public Autor(string nome, string linkdin, string lattes)
        {
            Nome = nome;
            Linkdin = linkdin;
            Lattes = lattes;
        }

        public int Id { get; private set; }
        public string Nome { get; private set; }
        public string Linkdin { get; private set; }
        public string Lattes { get; private set; }

        public IEnumerable<Conteudo> Conteudos { get; private set; }

        public void AtualizarAutor(string nome, string linkedin, string lattes)
        {
            this.Nome = nome;
            this.Linkdin = linkedin;
            this.Lattes = lattes;
        }
    }
}
