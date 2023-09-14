using Context;
using Entidades;
using EntidadesDto;
using Microsoft.EntityFrameworkCore;


namespace Repositorio
{
    public class RepositorioPersona : IRepositorioPersona
    {

        private readonly ContextoPersona _context;

        public RepositorioPersona(ContextoPersona context)
        {
            _context = context;
        }

        public IEnumerable<PersonaVerDto> los10Primeros()
        {
            var actualDate = DateTime.Now;
            var consulta = _context.personas
                        .Where(p => p.fechaNacimiento < actualDate.AddYears(-21)) // Personas mayores de 21 años
                        .OrderBy(p => p.Nombre) // Ordenar por fecha de nacimiento en orden descendente
                        .Take(10) // Tomar los primeros 10 (los últimos en orden descendente)
                        .Select(p => new PersonaVerDto
                        {
                            nombre = p.Nombre,
                            fechanacimiento = p.fechaNacimiento,
                            telefono = p.Telefono,
                        })
                        .ToList(); // Ejecutar la consulta y convertirla en una lista

            return consulta;
        }

        public async Task<Persona> obtenerPersona(string nombrePersona)
        {

            return _context.personas.Include(n => n.Nombre).FirstOrDefault(m => m.Nombre == nombrePersona);

        }

        public async Task<Persona> CrearNuevaPersona(Persona usuario)
        {
            Persona existeUsuario = _context.personas.FirstOrDefault(m => m.id == usuario.id);
            Persona listaPersonas = new Persona();
            if (existeUsuario == null)
            {
                // Si la persona existe, actualiza sus propiedades
                listaPersonas.id = Guid.NewGuid().ToString();
                listaPersonas.Nombre = usuario.Nombre;
                listaPersonas.fechaNacimiento = usuario.fechaNacimiento;
                listaPersonas.Telefono = usuario.Telefono;



                //si la persona no exite, se agrega una nueva
                _context.Add(listaPersonas);
                // Guarda los cambios en la base de datos
                await _context.SaveChangesAsync();

            }




            // Devuelve la persona agregada o actualizada
            return usuario;
        }

    }
}

