using AbstractFactory.Aircrafts;
using AbstractFactory.LandVehicle;

namespace AbstractFactory.Factories
{
    interface ITransportFactory
    {
        IAirCraft CreateTransportAircraft();
        ILandVehicle CreateTransportLandVehicle();
    }
}
