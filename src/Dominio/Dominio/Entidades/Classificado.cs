using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio.Entidades
{
    public class Classificado
    {
        public Classificado(int clienteId, 
            int produtoId, 
            DateTime data, 
            string status)
        {
            ClienteId = clienteId;
            ProdutoId = produtoId;
            Data = data;
            Status = status;
        }

        public int Id { get; private set; }
        public int ClienteId { get; private set; }
        public int ProdutoId { get; private set; }
        public DateTime Data { get; private set; }
        public string Status { get; private set; }

        public Cliente Cliente { get; private set; }
        public Produto Produto { get; private set; }
    }
}
