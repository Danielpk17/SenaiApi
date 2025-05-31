using SenaiApi.DTos;
using SenaiApi.Entidades;

namespace SenaiApi.Repositorios.Interface
{
    public interface IEnderecoRepositorio
    {
        void Salvar(Endereco endereco);

        IQueryable<Endereco> PegarTodos();

        Task<bool> Delete(long id);

        Endereco ObterPorId(long id);

    }
}
