using SenaiApi.DTos;
using SenaiApi.Entidades;

namespace SenaiApi.Servicos.Interface
{
    public interface IEscolaService
    {
        List<EscolaDTo> BuscarTodos();
        void Salvar(EscolaDTo escola);
    }
}
