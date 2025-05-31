namespace SenaiApi.Repositorios.Interface
{
    public interface IBaseRepository<T> where T : class
    {
        List<T> ObterTodos();
        void Salvar(T entidade);
        IQueryable<T> PegarTodos();
        Task<bool> Delete(long id);
    }
}
