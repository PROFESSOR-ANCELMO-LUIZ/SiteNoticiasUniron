using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class ClienteController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Novo()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Novo(ClienteViewModel model)
        {
            if(ModelState.IsValid)
            {
                var cliente = model;
                return RedirectToAction("Index");
            }

            return View(model);
;        }
    }
}
