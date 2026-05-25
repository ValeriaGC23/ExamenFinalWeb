using ExamenFinalWeb.Interface;
using ExamenFinalWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace ExamenFinalWeb.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RespuestasController : Controller
    {
        private readonly IRespuestasService _respuestaService;

        public RespuestasController(IRespuestasService respuestasService)
        {
            _respuestaService = respuestasService;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Respuestas>> GetById(int id)
        {
            var resp = await _respuestaService.GetByIdAsync(id);
            return resp is null ? NotFound() : Ok(resp);
        }

        [HttpPost]
        public async Task<ActionResult<Respuestas>> Create(Respuestas r)
        {
            var nuevo = await _respuestaService.CreateAsync(r);
            return CreatedAtAction(nameof(GetById), new { id = nuevo.idRespuesta }, nuevo);
        }

    }
}
