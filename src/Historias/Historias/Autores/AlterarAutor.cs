using Dominio.Entidades;
using Dominio.IRepositories;
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

            dadosDoAutor.AtualizarAutor(autor.Nome, autor.Linkdin, autor.Lattes);

            await _autorRepository.Alterar(dadosDoAutor);
        }
    }
}
