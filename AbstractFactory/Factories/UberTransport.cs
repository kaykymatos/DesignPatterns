using AbstractFactory.Aircrafts;
using AbstractFactory.AirCrafts;
using AbstractFactory.LandVehicle;

namespace AbstractFactory.Factories
{
    class UberTransport : ITransportFactory
    {
        public IAirCraft CreateTransportAircraft()
        {
            return new AirPlane();
        }

        public ILandVehicle CreateTransportLandVehicle()
        {
            return new Car();
        }

    }
}
