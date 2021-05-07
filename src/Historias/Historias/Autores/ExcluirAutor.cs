using Dominio.Entidades;
using Infra.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Historias.Autores
{
    public class ExcluirAutor
    {
        private readonly IAutorRepository _autorRepository;

        public ExcluirAutor(IAutorRepository autorRepository)
        {
            _autorRepository = autorRepository;
        }

        public async Task Executar(Autor autor)
        {
            await _autorRepository.Excluir(autor);
        }
    }
}
