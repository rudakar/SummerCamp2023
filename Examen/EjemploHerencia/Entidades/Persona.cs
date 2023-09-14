
using System.ComponentModel.DataAnnotations;


namespace Entidades
{
    public class Persona
    {
        [Key]
        public string? id { get; set; }

        [Required]
        [StringLength(100)]
        public string Nombre { get; set; }
        [Required]
        public DateTime? fechaNacimiento { get; set; }

        [StringLength(25)]
        public string Telefono { get; set; }

    }
}

