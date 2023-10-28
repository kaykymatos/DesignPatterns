using FactoryMethod.Interfaces;
using FactoryMethod.Vehicle;

namespace FactoryMethod.Factory
{
    internal class CarTransport : Transport
    {
        protected override IVehicle CreateTransport()
        {
            return new Car();
        }
    }
}
