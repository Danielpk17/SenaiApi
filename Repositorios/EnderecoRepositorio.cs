using Microsoft.EntityFrameworkCore;
using SenaiApi.Contexto;
using SenaiApi.DTos;
using SenaiApi.Entidades;
using SenaiApi.Repositorios.Interface;

namespace SenaiApi.Repositorios
{
    public class EnderecoRepositorio : BaseRepository<Endereco>, IEnderecoRepositorio
    {
        private readonly SenaiContext _context;

        public EnderecoRepositorio(SenaiContext context) : base(context)
        {
            _context = context;
        }
        public void Salvar(Endereco endereco)
        {
            base.Salvar(endereco);
        }
        public IQueryable<Endereco> PegarTodos()
        {
            return base.PegarTodos();
        }
        public async Task<bool> Delete(long id)
        {
            return await base.Delete(id);
        }
        public Endereco ObterPorId(long id)
        {
            return base.ObterPorId(id);
        }
    }
}
