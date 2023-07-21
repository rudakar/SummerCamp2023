
namespace EjemploHerencia

{
    internal class Program
    {
        static void Main(string[] args)
        {

            Empleado juan = new Empleado("Juan");
            //Console.WriteLine(juan.ToString());

            Administrador maria  = new Administrador("Maria",true,"x-d");

            //juan.Jefe = maria;

            Empleado jose = new Trabajador("Jose");
            Empresa empresa = new Empresa("Xdenterprise", "1234567");
            Empleado pepe = new Externo("pepe", empresa);
            //Console.WriteLine(jose.ToString());

            int numero = 10;
            //Console.WriteLine(numero.ToString());
            var lista = new List<Empleado>() {
                juan,
                
                pepe,jose,
                new Trabajador("luis","Mañana")




            };
           
            //SELECT *FROM empleados where empleados.NombreStartsWith("J")
            var listaEmpleadosJ = from empleado in lista
                                  where empleado.Nombre.StartsWith("J")
                                  orderby empleado.Nombre //ordenado por nombre
                                  select empleado;
            foreach (var empleado in listaEmpleadosJ)
            {
                if (empleado.Nombre.StartsWith("J"))
                {
                    empleado.CalculoVacaciones();
                    
                }
                try {
                    if (maria.TienePlaza) {
                        maria.PlazaParking();
                           Console.Write(maria.Plaza);
                    
                    
                    }
                
                }catch (ErrorBaseDatosException ex)
                {
                    Console.WriteLine(ex.Mensaje+" ___ "+ex.FechaHoraExcepcion);

                }

            }
        }
    }
}