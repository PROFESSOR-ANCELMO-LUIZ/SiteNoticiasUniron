using Dominio.Entidades;
using Infra.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Historias.Autores
{
    public class AlterarAutor
    {
        private readonly IAutorRepository _autorRepository;

        public AlterarAutor(IAutorRepository autorRepository)
        {
            _autorRepository = autorRepository;
        }

        public async Task Executar(int id, Autor autor)
        {
            var dadosDoAutor = await _autorRepository.BuscarPorId(id);

            dadosDoAutor.AtualizarAutor(autor.Nome, autor.Linkdin, autor.Linkdin);

            await _autorRepository.Alterar(dadosDoAutor);

        }
    }
}
