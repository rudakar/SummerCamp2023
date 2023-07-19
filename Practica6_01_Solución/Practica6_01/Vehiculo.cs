
namespace Practica6_01
{
    internal class Vehiculo
    {
        public int Año { get; set; }
        public string? Color  { get; set; }
        public string? Marca { get; set; }
        public string? Modelo { get; set; } 

        public Vehiculo() { }
        public Vehiculo(int año,string color,string marca,string modelo)
        {
            Año = año;
            Color = color;
            Marca = marca;
            Modelo = modelo;
            
        }
        public Vehiculo(int año, string color) {
            Año = año;
            Color = color;
            Marca = "_";
            Modelo = "_";
        }
        public Vehiculo(string marca,string modelo)
        {
            Año = 00;
            Color = "_";
            Marca = marca;
            Modelo = modelo;
        }
        public void MostrarDatos(Vehiculo v,int pos) { 
        
            Console.WriteLine("Coche numero:"+pos +
                "\n Año: "+v.Año +"Color: "+ v.Color+"Marca: "+v.Marca +"Modelo: "+ v.Modelo);
        
        }
        

    }
}
