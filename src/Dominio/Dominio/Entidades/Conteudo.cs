using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio.Entidades
{
    public class Conteudo
    {
        public Conteudo(int tipoDeConteudoId,
            int autorId,
            DateTime dataDoCadastro,
            string titulo,
            string texto,
            string linkImagem)
        {
            TipoDeConteudoId = tipoDeConteudoId;
            AutorId = autorId;
            DataDoCadastro = dataDoCadastro;
            Titulo = titulo;
            Texto = texto;
            LinkImagem = linkImagem;
        }

        public int Id { get; private set; }
        public int TipoDeConteudoId { get; private set; }
        public int AutorId { get; private set; }
        public DateTime DataDoCadastro { get; private set; }
        public string Titulo { get; private set; }
        public string Texto { get; private set; }
        public string LinkImagem { get; private set; }

        public TipoDeConteudo TipoDeConteudo { get; private set; }
        public Autor Autor { get; private set; }
    }
}
