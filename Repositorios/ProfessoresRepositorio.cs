using Microsoft.EntityFrameworkCore;
using SenaiApi.Contexto;
using SenaiApi.Entidades;
using SenaiApi.Repositorios.Interface;

namespace SenaiApi.Repositorios
{
    public class ProfessoresRepositorio : BaseRepository<Professor>, IProfessoresRepositorio
    {
        private readonly SenaiContext _context;

        public ProfessoresRepositorio(SenaiContext context) : base(context) 
        {
            _context = context;
        }
        public void Salvar(Professor professor)
        {
            base.Salvar(professor);
        }

        public IQueryable<Professor> PegarTodos()
        {
            return base.PegarTodos();
        }

        public async Task<bool> Delete(long id)
        {
            return await base.Delete(id);
        }
        public Professor ObterPorId(long id)
        {
            return base.ObterPorId(id);
        }
    }
}
