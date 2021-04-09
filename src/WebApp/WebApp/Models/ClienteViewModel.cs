using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class ClienteViewModel
    {
        [Required(ErrorMessage ="O campo Nome é obrigatório")]
        [StringLength(100, ErrorMessage = "O nome precisa ter no mínimo 5 letras",MinimumLength = 5)]
        public string Nome { get; set; }

        public string Sexo { get; set; }

        [DisplayName("Data de Nascimento")]
        [Required(ErrorMessage = "O campo Data de Nascimento é obrigatório")]
        public DateTime DataDeNascimento { get; set; }

        [DisplayName("e-Mail")]
        [Required(ErrorMessage = "O campo e-Mail é obrigatório")]
        [EmailAddress(ErrorMessage = "Email está em um formato incorreto!")]
        public string Email { get; set; }

        public string Telefone { get; set; }

        [DisplayName("Endereço")]
        public string Endereco { get; set; }

    }
}
