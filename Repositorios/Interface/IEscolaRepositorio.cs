using SenaiApi.Entidades;

namespace SenaiApi.Repositorios.Interface
{
    public interface IEscolaRepositorio
    {
        List<Escola> PegarTodos();
        void Salvar(Escola escola);
    }
}
