using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjemploHerencia
{
    public class Empresa
    {
        public Empresa(string nombre, string tlf)
        {
            Nombre = nombre;
            Tlf = tlf;
        }

        public string Nombre { get; set; }
        public string Tlf { get; set; }
    }
}