using Dominio.Entidades;
using Infra.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Historias.Autores
{
    public class ConsultasAutor
    {
        private readonly IAutorRepository _autorRepository;

        public ConsultasAutor(IAutorRepository autorRepository)
        {
            _autorRepository = autorRepository;
        }

        public async Task<Autor> BuscarPeloId(int id)
        {
            return await _autorRepository.BuscarPorId(id);
        }

        public async Task<IEnumerable<Autor>> ListarTodosAutores()
        {
            return await _autorRepository.ListarTodosAutores();
        }
    }
}
