using Dominio.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio.Entidades
{
    public class Produto
    {
        public Produto(string descricao, 
            decimal valor, 
            ETipoProduto tipoDoProduto)
        {
            Descricao = descricao;
            Valor = valor;
            TipoDoProduto = tipoDoProduto;
        }

        public int Id { get; private set; }
        public string Descricao { get; private set; }
        public decimal Valor { get; private set; }
        public ETipoProduto TipoDoProduto { get; private set; }
    }
}
