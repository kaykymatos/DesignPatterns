using AbstractFactory.Aircrafts;
using AbstractFactory.Factories;
using AbstractFactory.LandVehicle;

namespace AbstractFactory.App
{
    class Application
    {
        private readonly IAirCraft aircraft;
        private readonly ILandVehicle vehicle;
        public Application(ITransportFactory factory)
        {

            vehicle = factory.CreateTransportLandVehicle();
            aircraft = factory.CreateTransportAircraft();

        }

        public void StartRoute()
        {
            vehicle.StartRoute();
            aircraft.StartRoute();
        }
    }
}
