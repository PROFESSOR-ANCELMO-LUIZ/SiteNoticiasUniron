using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WebApp.Models
{
    public class AutorViewModel
    {
        [HiddenInput]
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo Nome é obrigatório")]
        public string Nome { get; set; }

        [DisplayName("LinkedIn")]
        public string Linkdin { get; set; }

        [DisplayName("Currículo Lattes")]
        public string Lattes { get; set; }
    }
}
