using System;

using autos.entidades;
namespace autos
{
    class Program
    {
        static void Main(string[] args)
        {
            /* El objeto auto necesita de Linea del auto, Modelo, Cilindraje, tipo de vehiculo, tipo de transmicion. */
            Auto chevrolet = new Auto("Sonic",2020,1500,TipoAuto.Sport,Transmiciones.Manual);
            Console.WriteLine($"Linea: {chevrolet.Linea}\nModelo: {chevrolet.Modelo}\nCC: {chevrolet.Cilindraje}\nTipo: {chevrolet.tipoAuto}\nCaja: {chevrolet.TipoTransmicion}");
            bool esRapido = chevrolet.esRapido(chevrolet.Cilindraje);
            if(esRapido){
                Console.WriteLine("El vehiculo es rapido");
            }else{
                Console.WriteLine("El vehiculo es lento");
            } 
        }
    }
}
