namespace Bridge.Platforms
{
    class Facebook : IPlatform
    {
        public Facebook()
        {
            ConfigureRMTP();
            Console.WriteLine("Facebook: Transmissão iniciada!");
        }
        public void AuthToken()
        {
            Console.WriteLine("Facebook: Autorizando transmissão!");
        }

        public void ConfigureRMTP()
        {
            AuthToken();
            Console.WriteLine("Facebook: Configurando servidor RMTP!");
        }
    }
}
