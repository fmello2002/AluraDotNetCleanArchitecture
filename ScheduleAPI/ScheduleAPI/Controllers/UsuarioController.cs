using Microsoft.AspNetCore.Mvc;
using ScheduleAPI.Application.DTOs.Requests;
using ScheduleAPI.Application.UseCases;

namespace ScheduleAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsuarioController(CadastrarUsuario cadastrarUsuario, BuscarUsuarios buscarUsuarios) : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> PostAsync([FromBody] CadastrarUsuarioInput cadastrarUsuarioInput)
        {
            await cadastrarUsuario.Execute(cadastrarUsuarioInput);

            return Created();
        }

        [HttpGet]
        public async Task<IActionResult> GetAsync([FromQuery] Guid? id)
        {
            var usuarios = await buscarUsuarios.Execute(id);
            return Ok(usuarios);
        }
    }
}