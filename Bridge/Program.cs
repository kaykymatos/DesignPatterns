
using Bridge.Platforms;
using Bridge.Transmissions;

static void StartLive(IPlatform platform)
{
    Console.WriteLine("Aguarde...");

    Live live = new Live(platform);

    live.Broadcasting();
    live.Result();
}
static void StartLiveAdvanced(IPlatform platform)
{
    Console.WriteLine("Aguarde...");

    AdvancedLive live = new AdvancedLive(platform);

    live.Broadcasting();
    live.Subtitle();
    live.Comments();
    live.Record();
    live.Result();
}

StartLiveAdvanced(new YouTube());
StartLive(new Facebook());
StartLive(new TwitchTV());