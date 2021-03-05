using System;

using autos.entidades;
namespace autos
{
    class Program
    {
        static void Main(string[] args)
        {
            /* El objeto auto necesita los siguientes atributos:
            Linea del auto, Modelo, Cilindraje, tipo de vehiculo, tipo de transmicion. */
            /* Tipo de vehicuo, y tipo transmicion, son enumeraciones del sistema, no se puede agregar
            algo diferente a lo disponible. */
            Auto[] chevrolets = new Auto[3];
            chevrolets[0] = new Auto("Sonic",2020,1500,TipoAuto.HatchBack,Transmiciones.Automatico);
            chevrolets[1] = new Auto("Camaro",2019,6000,TipoAuto.Sport,Transmiciones.Manual);
            chevrolets[2] = new Auto("Spark",2015,1200,TipoAuto.Compact,Transmiciones.Manual);

            imprimirResumenAutos(chevrolets); 
        }

        private static void imprimirResumenAutos(Auto[] chevrolets)
        {
            foreach (var auto in chevrolets)
            {
                Console.WriteLine($"Nombre: {auto.Linea} {auto.Modelo}\nTipo: {auto.tipoAuto}\nCaja: {auto.TipoTransmicion}");
            }
           
        }
    }
}
