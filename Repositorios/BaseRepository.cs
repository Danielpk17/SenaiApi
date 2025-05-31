using Microsoft.EntityFrameworkCore;
using SenaiApi.Contexto;
using SenaiApi.Entidades;
using SenaiApi.Repositorios.Interface;

namespace SenaiApi.Repositorios
{
    public class BaseRepository <T> : IBaseRepository<T> where T : BaseEntity
    {
        protected readonly SenaiContext _context;
        protected readonly DbSet<T> _dbSet;

        public BaseRepository(SenaiContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }

        public List<T> ObterTodos()
        {
            return _dbSet.ToList();
        }
        public void Salvar(T entidade)
        {
            if (entidade.Id == 0)
                _dbSet.Add(entidade);
            else
                _dbSet.Update(entidade);
            _context.SaveChanges();
        }
        public IQueryable<T> PegarTodos()
        {
            return _dbSet;
        }

        public async Task<bool> Delete(long id)
        {
            try
            {
                await _dbSet.Where(c => c.Id == id).ExecuteDeleteAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public T ObterPorId(long id)
        {
            return _dbSet.FirstOrDefault(e => e.Id == id);
        }
    }
}
