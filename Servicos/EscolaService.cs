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
        public void Salvar(EscolaDTo escolaDTo)
        {
            var escola = _mapper.Map<Escola>(escolaDTo);
            _escolaRepositorio.Salvar(escola);
        }

        public List<EscolaDTo> BuscarTodos()
        {
            var escolas = _escolaRepositorio.PegarTodos();
            return _mapper.Map<List<EscolaDTo>>(escolas);
        }
    }
}
