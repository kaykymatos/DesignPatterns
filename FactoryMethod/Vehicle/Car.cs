using FactoryMethod.Interfaces;

namespace FactoryMethod.Vehicle
{
    public class Car : IVehicle
    {
        public void GetCargo()
        {
            Console.WriteLine("Pegamos so passageiros");
        }

        public void StartToute()
        {
            GetCargo();
            Console.WriteLine("Iniciamos o trajeto");
        }
    }
}
