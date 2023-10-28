using Bridge.Platforms;

namespace Bridge.Transmissions
{
    class Live : ITransmission
    {
        protected IPlatform platform;
        public Live(IPlatform platform)
        {
            this.platform = platform;
        }
        public void Broadcasting()
        {
            Console.WriteLine($"Iniciand transmissão na plataforma {platform}");
        }

        public void Result()
        {
            Console.WriteLine("****** ON AIR ******");
        }
    }
}
