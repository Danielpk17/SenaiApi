using SenaiApi.Controllers;
using SenaiApi.DTos;

namespace SenaiApi.Servicos.Interface
{
    public interface IEndercoServico
    {
        void Salvar(EnderecoDTo enderecoDTo);
        List<EnderecoDTo> BuscarTodos();
        Task<bool> Delete(long id);
        void Editar(EnderecoDTo model);
    }
}
