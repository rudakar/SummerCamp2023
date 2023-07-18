namespace Practica_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var lista =new List<Vehiculo>();
             var coche_1 = new Vehiculo(1990,1000,Vehiculo.Etiqueta.sin);
             var coche_2 = new Vehiculo(2010,1000,Vehiculo.Etiqueta.B);
             var coche_3 = new Vehiculo(2000,1000,Vehiculo.Etiqueta.C);
             var coche_4 = new Vehiculo(2021,1000,Vehiculo.Etiqueta.ECO);
             var coche_5 = new Vehiculo(1970,1000,Vehiculo.Etiqueta.CERO);
             
            lista.Add(coche_1);
            lista.Add(coche_2); 
            lista.Add(coche_3);
            lista.Add(coche_4);
            lista.Add(coche_5);

            foreach(Vehiculo coche in lista) {

                double precio_final=Vehiculo.SacarPrecio(coche);
                Console.WriteLine(precio_final);
            
            
            }

        }
    }
}
