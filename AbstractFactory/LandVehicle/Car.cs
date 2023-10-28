namespace AbstractFactory.LandVehicle
{
    class Car : ILandVehicle
    {
        public void GetCargo()
        {
            Console.WriteLine("Pegando passageiros, estamos prontos");
        }

        public void StartRoute()
        {
            GetCargo();
            Console.WriteLine("Iniciando trajeto!");
        }
    }
}
