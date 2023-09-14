using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjemploHerencia
{
    public class Administrador : Empleado
    {
        public Administrador(string nombre, bool TienePlaza, string Plaza) : base(nombre)
        {
            this.TienePlaza = TienePlaza;
            this.Plaza = Plaza;
        }

        public bool TienePlaza { get; set; }
        public string Plaza { get; set; }

        public string PlazaParking() { 
            //TODO: Conectar a BBDD
            throw new ErrorBaseDatosException("Error a conectar a BBDD",DateTime.Now);
            return TienePlaza ? Plaza : "No tiene plaza";
        
        }
        public override void CalculoVacaciones()
        {
            base.CalculoVacaciones();
            diasVacaciones += 20;
        }
        public override string ToString()
        {
            return $" Trabajador.Nombre: {Nombre} " +
                $" Dias Vacaciones: {diasVacaciones} ";
        }

    }
}