using SenaiApi.DTos;

namespace SenaiApi.Servicos.Interface
{
    public interface IProfessoresServico
    {
        void Salvar(ProfessorDTO professorDTO);
        List<ProfessorDTO> BuscarTodos();
        Task<bool> Delete(long id);
        void Editar(ProfessorDTO model);
    }
}
