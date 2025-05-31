using Microsoft.AspNetCore.Mvc;
using SenaiApi.DTos;
using SenaiApi.Entidades;
using SenaiApi.Servicos.Interface;

namespace SenaiApi.Controllers
{
        [ApiController]
        [Route("[controller]")]
        public class ProfessorController : ControllerBase
        {
            private readonly IProfessoresServico _professorServico;
            public ProfessorController(IProfessoresServico professores)
            {
                _professorServico = professores;
            }
            [HttpPost]
            public IActionResult Adicionar(ProfessorDTO professores)
            {
                _professorServico.Salvar(professores);
                return Ok();
            }
            [HttpGet("buscar-todos")]

            public IActionResult Buscar()
            {
                var professors = _professorServico.BuscarTodos();
                return Ok();
            }
            [HttpDelete]
            public async Task<IActionResult> Delete(long id)
            {
                await _professorServico.Delete(id);
                return Ok();
            }
            [HttpPost]
            [Route("Editar")]
            public IActionResult Editar([FromBody] ProfessorDTO professor)
            {
                if (professor == null)
                {
                    BadRequest("Professor não pode ser nulo");
                    _professorServico.Editar(professor);
                }
                return Ok();

            }
        }
    }

