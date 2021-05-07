using Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Models;

namespace WebApp.Factories
{
    public static class AutorFactory
    {
        public static AutorViewModel MapearAutorViewModel(Autor autor)
        {
            var autorViewModel = new AutorViewModel
            {
                Id = autor.Id,
                Nome = autor.Nome,
                Linkdin = autor.Linkdin,
                Lattes = autor.Lattes
            };

            return autorViewModel;
        }

        public static Autor MapearAutor(AutorViewModel autorViewModel)
        {
            var autor = new Autor(
                autorViewModel.Nome,
                autorViewModel.Linkdin,
                autorViewModel.Lattes
                );

            return autor;
        }

        public static IEnumerable<AutorViewModel> MapearListaAutorViewModel(IEnumerable<Autor> autores)
        {
            var lista = new List<AutorViewModel>();
            foreach (var item in autores)
            {
                lista.Add(MapearAutorViewModel(item));
            }
            return lista;
        }
    }
}
