using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio.Entidades
{
    public class Usuario
    {
        public Usuario(int id, string login, string senha)
        {
            Id = id;
            Login = login;
            Senha = senha;
        }

        public int Id { get; private set; }
        public string Login { get; private set; }
        public string Senha { get; private set; }
    }
}
