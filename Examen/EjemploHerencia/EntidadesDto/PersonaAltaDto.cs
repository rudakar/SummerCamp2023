using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace EntidadesDto
{
    public class PersonaAltaDto
    {
        [Required(ErrorMessage ="El nombre obligatorio")]
        public string? nombre { get; set; }
        [Required(ErrorMessage ="Fecha nacimiento obligatorio")]
        public DateTime? fechaNacimiento { get; set; }
        public string Telefono { get; set; }

    }
}