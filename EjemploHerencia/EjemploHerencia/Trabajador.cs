using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjemploHerencia
{
    public class Trabajador : Empleado
    {
        public Trabajador(string nombre) : base(nombre)
        {
        }

        public Trabajador(string nombre,string turno) : base(nombre)
        {
            Turno = turno;
        }
        public override void CalculoVacaciones()
        {
            base.CalculoVacaciones();
            diasVacaciones += 15;
        }
        public override string ToString()
        {
            return $" Trabajador.Nombre: {Nombre} " +
                $" Dias Vacaciones: {diasVacaciones} ";
        }
        public string Turno { get; set; }
    }
}