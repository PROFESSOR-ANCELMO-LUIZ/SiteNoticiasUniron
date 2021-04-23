using Dominio.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio.Entidades
{
    public class Cliente
    {
        public Cliente(string nome, 
            DateTime dataDeNascimento, 
            ESexo sexo, 
            string telefone, 
            string endereco)
        {
            Nome = nome;
            DataDeNascimento = dataDeNascimento;
            Sexo = sexo;
            Telefone = telefone;
            Endereco = endereco;
        }

        public int Id { get; private set; }
        public string Nome { get; private set; }
        public DateTime DataDeNascimento { get; private set; }
        public ESexo Sexo { get; private set; }
        public string Telefone { get; private set; }
        public string Endereco { get; private set; }
    }
}
