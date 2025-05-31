using SenaiApi.DTos;
using SenaiApi.Entidades;

namespace SenaiApi.Repositorios.Interface
{
    public interface IEscolaRepositorio
    {
        void Salvar(Escola escola);

        IQueryable<Escola> PegarTodos();

        Task<bool> Delete(long id);

        Escola ObterPorId(long id);
    }
}
