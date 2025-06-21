using AutoMapper;
using SenaiApi.DTos;
using SenaiApi.Entidades;
using SenaiApi.Repositorios;
using SenaiApi.Repositorios.Interface;
using SenaiApi.Servicos.Interface;

namespace SenaiApi.Servicos
{
    public class EscolaService : IEscolaService
    {
        private readonly IMapper _mapper;
        private readonly IEscolaRepositorio _escolaRepositorio;

        public EscolaService(IMapper mapper, IEscolaRepositorio escolaRepositorio)
        {
            _mapper = mapper;
            _escolaRepositorio = escolaRepositorio;
        }
        public Escola Salvar(EscolaDTo escolaDTo)
        {
            var escola = _mapper.Map<Escola>(escolaDTo);
            _escolaRepositorio.Salvar(escola);
            return escola;
        }

        public List<EscolaDTo> BuscarTodos()
        {
            var escolas = _escolaRepositorio.PegarTodos();
            return _mapper.Map<List<EscolaDTo>>(escolas);
        }

        public async Task<bool> Delete(long id)
        {
            return await _escolaRepositorio.Delete(id);
        }

        public void Editar (EscolaEdicaoDTo model)
        {
            var escola = _escolaRepositorio.ObterPorId(model.id);
            _mapper.Map(model, escola);

            _escolaRepositorio.Salvar(escola);
        }
        public Escola ObterPorId(long id)
        {
            return _escolaRepositorio.ObterPorId(id);
        }
    }
}
