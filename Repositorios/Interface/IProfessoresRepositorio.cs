using SenaiApi.Entidades;

namespace SenaiApi.Repositorios.Interface
{
    public interface IProfessoresRepositorio
    {
        void Salvar(Professor professor);

        IQueryable<Professor> PegarTodos();

        Task<bool> Delete(long id);

        Professor ObterPorId(long id);

    }
}
