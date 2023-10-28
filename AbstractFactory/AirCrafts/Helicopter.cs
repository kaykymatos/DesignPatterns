using AbstractFactory.Aircrafts;

namespace AbstractFactory.AirCrafts
{
    class Helicopter : IAirCraft
    {
        public void CheckWind()
        {
            Console.WriteLine("Verificando os ventos, vento sudeste, ventos ok");
        }

        public void GetCargo()
        {
            Console.WriteLine("Passageiros ok, ligando as helices.");
        }

        public void StartRoute()
        {
            CheckWind();
            GetCargo();
            Console.WriteLine("Inciando decolagem");
        }
    }
}
