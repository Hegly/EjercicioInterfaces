using System;
namespace EjercicioInterfaces
{
    public interface IVehiculo
    {
        void Arrancar();
        void Conducir(int distancia);
        void Detener();
    }
}
