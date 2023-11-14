using System;
namespace EjercicioInterfaces
{
    public class Carro : IVehiculo
    {
        public string? Modelo { get; set; }
        public int Velocidad { get; private set; }
        public string? Color { get; set; }

        public void Arrancar()
        {
            Console.WriteLine($"En el carro {Modelo}, {Color}, se arrancó el motor.");
        }

        public void Conducir(int distancia)
        {
            Velocidad = 60;
            Console.WriteLine($"El carro {Modelo}, {Color}, se está conduciendo a {Velocidad} Km/h recorriendo {distancia} Km.");
        }

        public void Detener()
        {
            Console.WriteLine($"En el carro {Modelo}, {Color}, se detuvo el motor.");
            Console.WriteLine( );
        }

        
    }
}

