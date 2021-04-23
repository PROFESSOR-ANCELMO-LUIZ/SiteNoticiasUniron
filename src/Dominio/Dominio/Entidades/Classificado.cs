using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio.Entidades
{
    public class Classificado
    {
        public Classificado(DateTime data, string status)
        {
            Data = data;
            Status = status;
        }

        public int Id { get; private set; }
        public DateTime Data { get; private set; }
        public string Status { get; private set; }
    }
}
