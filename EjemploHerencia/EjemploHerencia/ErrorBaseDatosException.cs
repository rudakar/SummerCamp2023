using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploHerencia
{
    public class ErrorBaseDatosException:Exception
    {
        public string Mensaje { get; set; }
        public DateTime FechaHoraExcepcion { get; set; }
     
        public ErrorBaseDatosException(string mensaje,DateTime fechahoraexcepcion)
        :base(mensaje)
        {
            Mensaje = mensaje;
            FechaHoraExcepcion = fechahoraexcepcion;
        }
    }
}
