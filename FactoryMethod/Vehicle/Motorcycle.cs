using FactoryMethod.Interfaces;

namespace FactoryMethod.Vehicle
{
    public class Motorcycle : IVehicle
    {
        public void GetCargo()
        {
            Console.WriteLine("Pegando a encomenda");
        }

        public void StartToute()
        {
            GetCargo();
            Console.WriteLine("Iniciando entrega");
        }
    }
}
