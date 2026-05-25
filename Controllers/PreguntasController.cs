using ExamenFinalWeb.Interface;
using ExamenFinalWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace ExamenFinalWeb.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PreguntasController : Controller
    {
        private readonly IPreguntasService _preguntasService;

        public PreguntasController(IPreguntasService preguntasService)
        {
            _preguntasService = preguntasService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Preguntas>>> GetResueltas()
        {
            return Ok(await _preguntasService.GetResueltasAsync());
        }

        [HttpGet]
        public async Task<ActionResult<List<Preguntas>>> GetNoResueltas()
        {
            return Ok(await _preguntasService.GetNoResueltasAsync());
        }


        [HttpGet("{id}")]
        public async Task<ActionResult<Preguntas>> GetById(int id)
        {
            var pregunta = await _preguntasService.GetByIdAsync(id);
            return pregunta is null ? NotFound() : Ok(pregunta);
        }

        [HttpPost]
        public async Task<ActionResult<Preguntas>> Create(Preguntas p)
        {
            var nuevo = await _preguntasService.CreateAsync(p);
            return CreatedAtAction(nameof(GetById), new { id = nuevo.idPregunta }, nuevo);
        }
    }
}
