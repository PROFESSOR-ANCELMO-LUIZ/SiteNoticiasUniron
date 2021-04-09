using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class ConteudoViewModel
    {
        public string Titulo { get; set; }
        public DateTime DataDoCadastro { get; set; }
        public string Texto { get; set; }
        public string LinkImagem { get; set; }
    }
}
