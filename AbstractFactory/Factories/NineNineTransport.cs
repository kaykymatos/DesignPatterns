using AbstractFactory.Aircrafts;
using AbstractFactory.AirCrafts;
using AbstractFactory.LandVehicle;

namespace AbstractFactory.Factories
{
    class NineNineTransport : ITransportFactory
    {
        public IAirCraft CreateTransportAircraft()
        {
            return new Helicopter();
        }

        public ILandVehicle CreateTransportLandVehicle()
        {
            return new Motorcycle();
        }
    }
}
