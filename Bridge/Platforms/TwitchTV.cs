namespace Bridge.Platforms
{
    class TwitchTV : IPlatform
    {
        public TwitchTV()
        {
            ConfigureRMTP();
            Console.WriteLine("TwitchTV: Transmissão iniciada!");
        }
        public void AuthToken()
        {
            Console.WriteLine("TwitchTV: Autorizando transmissão!");
        }

        public void ConfigureRMTP()
        {
            AuthToken();
            Console.WriteLine("TwitchTV: Configurando servidor RMTP!");
        }
    }
}
