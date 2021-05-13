using Dominio.Entidades;
using Dominio.IRepositories;
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
