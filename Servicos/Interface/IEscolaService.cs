using Microsoft.AspNetCore.Mvc;
using SenaiApi.DTos;
using SenaiApi.Entidades;

namespace SenaiApi.Servicos.Interface
{
    public interface IEscolaService
    {
        List<EscolaDTo> BuscarTodos();
        Task<bool> Delete(long id);
        Escola ObterPorId(long id);
        Escola Salvar(EscolaDTo escola);
    }
}
