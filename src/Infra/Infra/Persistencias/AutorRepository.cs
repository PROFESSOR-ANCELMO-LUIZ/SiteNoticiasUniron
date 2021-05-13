using Dominio.Entidades;
using Dominio.IRepositories;
using Infra.Contexto;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Persistencias
{
    public class AutorRepository : IAutorRepository
    {
        private readonly DataContext _dataContext;

        public AutorRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task Criar(Autor autor)
        {
            _dataContext.Autores.Add(autor);
            await _dataContext.SaveChangesAsync();
        }

        public async Task Alterar(Autor autor)
        {
            _dataContext.Update(autor);
            await _dataContext.SaveChangesAsync();
        }

        public async Task Excluir(Autor autor)
        {
            _dataContext.Remove(autor);
            await _dataContext.SaveChangesAsync();
        }

        public async Task<Autor> BuscarPorId(int id)
        {
            var autor = await _dataContext.Autores.FirstOrDefaultAsync(x => x.Id == id);
            return autor;
        }

        public async Task<IEnumerable<Autor>> ListarTodosAutores()
        {
            return await _dataContext.Autores.AsNoTracking().ToListAsync();
        }
    }
}
