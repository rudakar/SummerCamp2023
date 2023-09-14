using Context;
using Entidades;
using EntidadesDto;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Repositorio;

namespace Examen2023.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonaController : ControllerBase
    {
        private readonly ContextoPersona _context;
        private readonly IRepositorioPersona repositorioPersona;
       

        public PersonaController(IRepositorioPersona repositorioPersona,
        ContextoPersona _context)
        {
            this.repositorioPersona = repositorioPersona;
          
            this._context = _context;
        }

        [HttpGet]
        public async Task<ActionResult<List<PersonaVerDto>>> GetPersona()
        {
            var usuarios = repositorioPersona.los10Primeros();

            if (usuarios == null) { return NotFound(); }

            return Ok(usuarios);
        }


        [HttpPost]
        [Route("AltaPersona")]
        public async Task<ActionResult> AltaPersona([FromBody] PersonaAltaDto usuarioCreacionDto)
        {
            var existe = await _context.personas.AnyAsync(x => x.Nombre == usuarioCreacionDto.nombre);
            if (existe)
                return BadRequest($"Ya existe un usuario con el nombre {usuarioCreacionDto.nombre}");
            Persona altaPersona = new()
            {
                id = Guid.NewGuid().ToString(),
                Nombre = usuarioCreacionDto.nombre,
                fechaNacimiento = usuarioCreacionDto.fechaNacimiento,
                Telefono = usuarioCreacionDto.Telefono

            };

            var persona = await repositorioPersona.CrearNuevaPersona(altaPersona);
            
            return Ok();
        }
    }
}
