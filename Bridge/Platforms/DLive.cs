namespace Bridge.Platforms
{
    class DLive : IPlatform
    {
        public DLive()
        {
            ConfigureRMTP();
            Console.WriteLine("TheLive: Transmissão iniciada!");
        }
        public void AuthToken()
        {
            Console.WriteLine("TheLive: Autorizando transmissão!");
        }

        public void ConfigureRMTP()
        {
            AuthToken();
            Console.WriteLine("TheLive: Configurando servidor RMTP!");
        }
    }
}
