using Dominio.IRepositories;
using Historias.Autores;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Factories;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class AutorController : Controller
    {
        private readonly CriarAutor _criarAutor;
        private readonly AlterarAutor _alterarAutor;
        private readonly ExcluirAutor _excluirAutor;
        private readonly ConsultasAutor _consultasAutor;

        public AutorController(IAutorRepository autorRepository)
        {
            _criarAutor = new CriarAutor(autorRepository);
            _alterarAutor = new AlterarAutor(autorRepository);
            _excluirAutor = new ExcluirAutor(autorRepository);
            _consultasAutor = new ConsultasAutor(autorRepository);
        }

        public async Task<IActionResult> Index()
        {
            var listaAutores = await _consultasAutor.ListarTodosAutores();
            var listaAutoresViewModel = AutorFactory.MapearListaAutorViewModel(listaAutores);

            return View(listaAutoresViewModel);
        }

        public IActionResult Criar()
        {

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Criar(AutorViewModel autorViewModel)
        {
            if (ModelState.IsValid)
            {
                var autor = AutorFactory.MapearAutor(autorViewModel);

                await _criarAutor.Executar(autor);

                return RedirectToAction("Index");
            }

            return View(autorViewModel);
        }
    }
}
