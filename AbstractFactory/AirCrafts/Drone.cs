using AbstractFactory.Aircrafts;

namespace AbstractFactory.AirCrafts
{
    class Drone : IAirCraft
    {
        public void CheckWind()
        {
            Console.WriteLine("Checando força do vendo, ventos ok!");
        }

        public void GetCargo()
        {
            Console.WriteLine("Entrega acoplada ao drone!");
        }

        public void StartRoute()
        {
            CheckWind();
            GetCargo();
            Console.WriteLine("Entrega iniciada, drone indo ao destino!");
        }
    }
}
