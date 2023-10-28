using AbstractFactory.Aircrafts;
using AbstractFactory.AirCrafts;
using AbstractFactory.LandVehicle;

namespace AbstractFactory.Factories
{
    class LimeTransport : ITransportFactory
    {
        public IAirCraft CreateTransportAircraft()
        {
            return new Drone();
        }

        public ILandVehicle CreateTransportLandVehicle()
        {
            return new Scooter();
        }
    }
}
