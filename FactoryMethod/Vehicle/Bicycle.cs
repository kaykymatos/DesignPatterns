using FactoryMethod.Interfaces;

namespace FactoryMethod.Vehicle
{
    public class Bicycle : IVehicle
    {
        public void GetCargo()
        {
            Console.WriteLine("Pegando entrega(comida)!");
        }

        public void StartToute()
        {
            GetCargo();
            Console.WriteLine("Inicnando trajeto!");
        }
    }
}
