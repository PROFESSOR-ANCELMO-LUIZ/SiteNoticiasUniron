using Dominio.Entidades;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Dominio.IRepositories
{
    public interface IAutorRepository
    {
        Task Criar(Autor autor);
        Task Alterar(Autor autor);
        Task Excluir(Autor autor);
        Task<Autor> BuscarPorId(int id);
        Task<IEnumerable<Autor>> ListarTodosAutores();
    }
}
