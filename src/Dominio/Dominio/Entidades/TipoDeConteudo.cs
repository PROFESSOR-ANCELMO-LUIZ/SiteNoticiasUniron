using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio.Entidades
{
    public class TipoDeConteudo
    {
        public TipoDeConteudo(string descricao)
        {
            Descricao = descricao;
        }

        public int Id { get; private set; }
        public string Descricao { get; private set; }
        public IEnumerable<Conteudo> Conteudos { get; private set; }
    }
}
