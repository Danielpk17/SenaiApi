using SenaiApi.Contexto;
using SenaiApi.Entidades;
using SenaiApi.Repositorios.Interface;

namespace SenaiApi.Repositorios
{
    public class EscolaRepositorio : IEscolaRepositorio
    {
        private readonly SenaiContext _context;

        public EscolaRepositorio(SenaiContext context)
        {
            _context = context;
        }
        public void Salvar(Escola escola)
        {
            if(escola.Id == 0)
                _context.Escola.Add(escola);
            else
                _context.Escola.Update(escola);

            _context.SaveChanges();
        }
        public List<Escola> PegarTodos() 
        {
            return _context.Escola.ToList();                       
        }
    }
}
