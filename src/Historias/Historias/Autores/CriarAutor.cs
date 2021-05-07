using Dominio.Entidades;
using Infra.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Historias.Autores
{
    public class CriarAutor
    {
        private readonly IAutorRepository _autorRepository;

        public CriarAutor(IAutorRepository autorRepository)
        {
            _autorRepository = autorRepository;
        }

        public async Task Executar(Autor autor)
        {
            await _autorRepository.Criar(autor);
        }
    }
}
