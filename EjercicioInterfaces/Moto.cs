using System;
namespace EjercicioInterfaces
{
    public class Moto : IVehiculo
    {
        public string? Marca { get; set; }
        public bool EstaEncendida { get; private set; }
        public string? Tipo { get; set; }

        public void Arrancar()
        {
            EstaEncendida = true;
            Console.WriteLine($"En la moto {Marca}, {Tipo}, se arrancó el motor.");
        }

        public void Conducir(int distancia)
        {
            Console.WriteLine($"La moto {Marca}, {Tipo}, se está conduciendo en un recorrido de {distancia} Km.");
        }

        public void Detener()
        {
            EstaEncendida = false;
            Console.WriteLine($"En la moto {Marca}, {Tipo}, se apagó el motor.");
            Console.WriteLine( );
        }
    }
}

