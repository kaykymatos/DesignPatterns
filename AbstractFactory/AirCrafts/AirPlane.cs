using AbstractFactory.Aircrafts;

namespace AbstractFactory.AirCrafts
{
    class AirPlane : IAirCraft
    {
        public void CheckWind()
        {
            Console.WriteLine("Verificando os ventos, ventos a 25 Km, ventos ok");
        }

        public void GetCargo()
        {
            Console.WriteLine("Passageiros à bordo, voô autorizado");
        }

        public void StartRoute()
        {
            CheckWind();
            GetCargo();
            Console.WriteLine("Iniciando decolagem...");
        }
    }
}
