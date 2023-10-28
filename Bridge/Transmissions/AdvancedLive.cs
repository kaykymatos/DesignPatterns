using Bridge.Platforms;

namespace Bridge.Transmissions
{
    class AdvancedLive : Live
    {
        public AdvancedLive(IPlatform platform) : base(platform)
        {
        }

        public void Subtitle()
        {
            Console.WriteLine($"{base.platform}: Legendas ativadas na transmissão!");
        }
        public void Comments()
        {
            Console.WriteLine($"{base.platform}:Comentários liberados na transmissão!");
        }
        public void Record()
        {
            Console.WriteLine($"{base.platform}: Gravação iniciada!");
        }
    }
}
