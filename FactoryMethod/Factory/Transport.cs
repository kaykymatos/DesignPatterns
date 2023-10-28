using FactoryMethod.Interfaces;

namespace FactoryMethod.Factory
{
    abstract class Transport
    {
        public void StartTransport()
        {
            IVehicle vehicle = CreateTransport();
            vehicle.StartToute();
        }
        protected abstract IVehicle CreateTransport();
    }
}
