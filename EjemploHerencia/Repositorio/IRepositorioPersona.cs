using Entidades;
using EntidadesDto;


namespace Repositorio
{
    public interface IRepositorioPersona
    {
        //Task<Persona> obtenerPersona(string id);
        IEnumerable<PersonaVerDto> los10Primeros();

        Task<Persona> CrearNuevaPersona(Persona usuario);

    }
}
