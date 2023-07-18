using System;

namespace Practica_5
{
    internal class Vehiculo
    {
        
        public Vehiculo() { }
        public Vehiculo(int año, int valor, Etiqueta etiqueta) {
            Año = año;
            ValorBase = valor;
            Etiqueta1 = etiqueta;
        }
        public int  ValorBase { get; set; }
        public int Año { get; set; }
        public int Valor { get; set; }
        public Etiqueta Etiqueta1  { get; set; }

       

        public enum Etiqueta { 
        sin,
        B,
        C,
        ECO,
        CERO

        }
        internal static double SacarPrecio(Vehiculo coche)
        {
            var año_Actual = DateTime.Now.Year;
            var difAños = año_Actual - coche.Año;
            double porcentaje=0;
            switch (coche.Etiqueta1) {
                case Etiqueta.sin:
                    porcentaje = 25;
                    break;
                case Etiqueta.B:
                    porcentaje = 15;
                    break;
                case Etiqueta.C:
                    porcentaje = 10;
                    break;
                case Etiqueta.ECO:
                    porcentaje = 5;
                    break;
                case Etiqueta.CERO:
                    porcentaje = 0;
                    break;
            }
            //porcentaje = porcentaje + difAños;
            double preciofinal = coche.ValorBase * ((porcentaje+difAños)/ 100 ) + coche.ValorBase;
            return preciofinal;
            
        }

    }

}
 