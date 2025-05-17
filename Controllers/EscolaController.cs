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

        [HttpGet]
        public IActionResult Index()
        {
            return Ok();
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
    }
}
