using AutoMapper;
using SenaiApi.DTos;
using SenaiApi.Entidades;
using SenaiApi.Repositorios;
using SenaiApi.Repositorios.Interface;
using SenaiApi.Servicos.Interface;

namespace SenaiApi.Servicos
{
    public class ProfessoresServico : IProfessoresServico
    {
        private readonly IMapper _mapper;
        private readonly IProfessoresRepositorio _professoresRepositorio;
        public ProfessoresServico(IMapper mapper, IProfessoresRepositorio professoresRepositorio)
        {
            _mapper = mapper;
            _professoresRepositorio = professoresRepositorio;
        }

        public void Salvar(ProfessorDTO professorDTO)
        {
            var professor = _mapper.Map<Professor>(professorDTO);
            _professoresRepositorio.Salvar(professor);
        }
        public List<ProfessorDTO> BuscarTodos()
        {
            var professor = _professoresRepositorio.PegarTodos();
            return _mapper.Map<List<ProfessorDTO>>(professor);
        }
        public async Task<bool> Delete(long id)
        {
            return await _professoresRepositorio.Delete(id);
        }
        public void Editar(ProfessorDTO model)
        {
            var professor = _professoresRepositorio.ObterPorId(model.id);
            _mapper.Map(model, professor);

            _professoresRepositorio.Salvar(professor);
        }
    }

}
