using Microsoft.EntityFrameworkCore;
using SenaiApi.Contexto;
using SenaiApi.Entidades;
using SenaiApi.Repositorios.Interface;

namespace SenaiApi.Repositorios
{
    public class EscolaRepositorio : BaseRepository<Escola>, IEscolaRepositorio
    {
        private readonly SenaiContext _context;

        public EscolaRepositorio(SenaiContext context) : base(context)
        {
            _context = context;
        }
        public void Salvar(Escola escola)
        {
            base.Salvar(escola);
        }
        public List<Escola> PegarTodos() 
        {
            return base.PegarTodos()
                .Include(c => c.Endereco)
                .Include(c => c.Professor)
                .ToList();
        }

        public async Task<bool> Delete(long id)
        {
            return await base.Delete(id);
        }

        public Escola ObterPorId(long id)
        {
            return _context.Escola.Include(c => c.Endereco).FirstOrDefault(c => c.Id == id);
        }
    }
}
