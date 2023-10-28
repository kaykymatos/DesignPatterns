
using AbstractFactory.App;
using AbstractFactory.Factories;

Application ConfigureApplication()
{
    Application app;
    ITransportFactory transport;

    string company = "Line";

    if (company == "Uber")
        transport = new UberTransport();
    else if (company == "NineNine")
        transport = new NineNineTransport();
    else if (company == "Line")
        transport = new LimeTransport();
    else
        transport = new NineNineTransport();

    app = new Application(transport);
    return app;
}

Application app = ConfigureApplication();
app.StartRoute();

Console.ReadLine();