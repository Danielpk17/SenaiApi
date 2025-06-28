using AutoMapper;
using SenaiApi.Controllers;
using SenaiApi.DTos;
using SenaiApi.Entidades;
using SenaiApi.Repositorios;
using SenaiApi.Repositorios.Interface;
using SenaiApi.Servicos.Interface;

namespace SenaiApi.Servicos
{
    public class EnderecoServico : IEndercoServico
    {
        private readonly IMapper _mapper;
        private readonly IEnderecoRepositorio _enderecoRepositorio;
        public EnderecoServico(IMapper mapper, IEnderecoRepositorio endercoRepositorio) 
        {
            _mapper = mapper;
            _enderecoRepositorio = endercoRepositorio;
        }
        public void Salvar(EnderecoDTo enderecoDTo)
        {
            var endereco = _mapper.Map<Endereco>(enderecoDTo);
            _enderecoRepositorio.Salvar(endereco);
        }

        public List<EnderecoDTo> BuscarTodos()
        {
            var enderecos = _enderecoRepositorio.PegarTodos();
            return _mapper.Map<List<EnderecoDTo>>(enderecos);
        }
        public async Task<bool> Delete(long id)
        {
            return await _enderecoRepositorio.Delete(id);
        }
        public void Editar(EnderecoDTo model)
        {
            var endereco = _enderecoRepositorio.ObterPorId(model.Id);
            _mapper.Map(model, endereco);

            _enderecoRepositorio.Salvar(endereco);
        }
    }
}
