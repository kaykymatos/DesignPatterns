namespace AbstractFactory.LandVehicle
{
    class Motorcycle : ILandVehicle
    {
        public void GetCargo()
        {
            Console.WriteLine("Pegando a encomenda");
        }

        public void StartRoute()
        {
            GetCargo();
            Console.WriteLine("Iniciando a entrega!");
        }
    }
}
