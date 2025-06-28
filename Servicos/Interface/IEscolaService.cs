using Microsoft.AspNetCore.Mvc;
using SenaiApi.DTos;
using SenaiApi.Entidades;

namespace SenaiApi.Servicos.Interface
{
    public interface IEscolaService
    {
        List<EscolaDTo> BuscarTodos();
        Task<bool> Delete(long id);
<<<<<<< HEAD
        public EscolaDTo ObterPorId(long id);
=======
        Escola ObterPorId(long id);
>>>>>>> 4f301aef773ab96097617c0c9cfe844c815e4772
        Escola Salvar(EscolaDTo escola);
    }
}
