using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjemploHerencia
{
    public class Externo : Empleado
    {
        public Externo(string nombre, Empresa empresa) : base(nombre)
        {
            Empresa = empresa;
        }

        public Empresa Empresa { get; set; }

        public override void CalculoVacaciones()
        {
            base.CalculoVacaciones();
            diasVacaciones += 5;
        }
        public override string ToString()
        {

            return $" Trabajador.Nombre: {Nombre} " +
                $" Dias Vacaciones: {diasVacaciones} ";
        }
    }
}