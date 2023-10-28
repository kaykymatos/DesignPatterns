using FactoryMethod.Interfaces;
using FactoryMethod.Vehicle;

namespace FactoryMethod.Factory
{
    class BicycleTransport : Transport
    {
        protected override IVehicle CreateTransport()
        {
            return new Bicycle();
        }
    }
}
