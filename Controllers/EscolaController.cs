using System.Security.Cryptography.X509Certificates;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
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
        public IActionResult Salvar([FromBody] EscolaDTo escola)
        {
            if (escola == null)
                return BadRequest("Escola não pode ser nula");
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

        [HttpGet("ObterPorId")]
        public IActionResult ObterPorId(long id)
        {
            var escolas = _escolaService.ObterPorId(id);
            return Ok(escolas);
        }
    }
}
