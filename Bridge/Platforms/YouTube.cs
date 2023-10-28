namespace Bridge.Platforms
{
    class YouTube : IPlatform
    {
        public YouTube()
        {
            ConfigureRMTP();
            Console.WriteLine("Youtube: Transmissão iniciada!");
        }
        public void AuthToken()
        {
            Console.WriteLine("YouTube: Autorizando transmissão!");
        }

        public void ConfigureRMTP()
        {
            AuthToken();
            Console.WriteLine("Youtube: Configurando servidor RMTP!");
        }
    }
}
