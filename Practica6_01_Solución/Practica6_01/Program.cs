using System.Security.Cryptography.X509Certificates;

namespace Practica6_01
{
    internal class Program
    {
        static void Main(string[] args)
        {   var lista =new List<Vehiculo>();
            while (true) { 

                Console.WriteLine("Elige entre 1) para introducir año y color 2) para marca y modelo." +
                    "\n Y 3) para año color marca y modelo!");
                var input=Console.ReadLine();
                switch (input)
                {
                    case "1":
                        Console.WriteLine("Introduce Año: ");
                        var año=Console.ReadLine();
                        int año_int = Int32.Parse(año);
                        Console.WriteLine("Introduce Color: ");
                        var color=Console.ReadLine();
                        var coche = new Vehiculo(año_int, color);
                        lista.Add(coche);
                        break;
                    case "2":
                        Console.WriteLine("Introduce Marca: ");
                        var marca=Console.ReadLine();
                        Console.WriteLine("Introduce Modelo: ");
                        var modelo=Console.ReadLine();
                        var coche_1 = new Vehiculo(marca,modelo);
                        lista.Add(coche_1);
                        break;
                    case "3":
                        Console.WriteLine("Introduce Año: ");
                        var año_1 = Console.ReadLine();
                        int año_int_1 = Int32.Parse(año_1);
                        Console.WriteLine("Introduce Color: ");
                        var color_1 = Console.ReadLine();
                        Console.WriteLine("Introduce Marca: ");
                        var marca_1 = Console.ReadLine();
                        Console.WriteLine("Introduce Modelo: ");
                        var modelo_1 = Console.ReadLine();
                        var coche_3 = new Vehiculo(año_int_1,color_1,marca_1,modelo_1);
                        lista.Add(coche_3);
                        break;
                    default: Console.WriteLine("Número introducido erroneo");
                        break;




                }
                Console.WriteLine("Lista de coches registrados" +
                    "\n===========================================");
                int i = 1;
                foreach (var coche in lista) {
                    coche.MostrarDatos(coche, i);
                    i++;
                
                }
            }
        }
    }
}