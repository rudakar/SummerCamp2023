using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntidadesDto
{
    public class PersonaVerDto
    {
        public string nombre { get; set; }
        public DateTime? fechanacimiento { get; set; }
        public string telefono { get; set;}
    }
}
