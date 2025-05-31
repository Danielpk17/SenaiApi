using Microsoft.AspNetCore.Mvc;
using SenaiApi.DTos;
using SenaiApi.Servicos;
using SenaiApi.Servicos.Interface;

namespace SenaiApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EnderecoController : ControllerBase
    {
        private readonly IEndercoServico _endercoServico;
        public EnderecoController(IEndercoServico endereco)
        {
            _endercoServico = endereco;
        }
        [HttpPost]
        public ActionResult Adicionar(EnderecoDTo endereco)
        {
            _endercoServico.Salvar(endereco);
            return Ok(); 
        }
        [HttpGet("buscar-todos")]

        public IActionResult Buscar()
        {
            var enderecos = _endercoServico.BuscarTodos();
            return Ok(enderecos);
        }
        [HttpDelete]
        public async Task<IActionResult> Delete(long id)
        {
            await _endercoServico.Delete(id);
            return Ok();
        }
        [HttpPost]
        [Route("Editar")]
        public IActionResult Editar([FromBody] EnderecoDTo endereco)
        {
            if (endereco == null)
            {
                BadRequest("Escola não pode ser nula");
                _endercoServico.Editar(endereco);
            }
            return Ok();

        }
    }
}
