using Microsoft.AspNetCore.Mvc;
using SenaiApi.DTos;
using SenaiApi.Entidades;
using SenaiApi.Servicos.Interface;

namespace SenaiApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EscolaController : ControllerBase
    {
        private readonly IEscolaService _escolaService;
        public EscolaController(IEscolaService escolaService) {
            _escolaService = escolaService;
        }
        [HttpPost]

        public IActionResult Adicionar(EscolaDTo escola)
        {
            _escolaService.Salvar(escola);
            return Ok();
        }

        [HttpGet("buscar-todos")]

        public IActionResult Buscar() 
        {
            var escolas = _escolaService.BuscarTodos();
            return Ok(escolas);
        }
        [HttpDelete]
        public async Task<IActionResult> Delete(long id)
        {
            await _escolaService.Delete(id);
            return Ok();
        }

        [HttpPost]
        [Route("Editar")]
        public IActionResult Editar([FromBody] EscolaEdicaoDTo escolaEdicao)
        {
            if (escolaEdicao == null)
            {
                return BadRequest("Escola não pode ser nula");
                _escolaService.Editar(escolaEdicao);
            }
            return Ok();
               
        }   
    }
}
