namespace AbstractFactory.LandVehicle
{
    class Scooter : ILandVehicle
    {
        public void GetCargo()
        {
            Console.WriteLine("Pegando encomenda!");
        }

        public void StartRoute()
        {
            GetCargo();
            Console.WriteLine("Iniciando a entrega!");
        }
    }
}
