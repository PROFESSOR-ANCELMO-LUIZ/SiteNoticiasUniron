using Dominio.Entidades;
using Dominio.IRepositories;
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
