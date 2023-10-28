using FactoryMethod.Interfaces;
using FactoryMethod.Vehicle;

namespace FactoryMethod.Factory
{
    class MotorcycleTransport : Transport
    {
        protected override IVehicle CreateTransport()
        {
            return new Motorcycle();
        }
    }
}
