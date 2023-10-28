using FactoryMethod.Factory;

var argsParam = Environment.GetCommandLineArgs();

Transport transport = null;
if (argsParam.Length > 0 && argsParam[1] == "--uber")
    transport = new CarTransport();
else if (argsParam.Length > 0 && argsParam[1] == "--log")
    transport = new MotorcycleTransport();
else if (argsParam.Length > 0 && argsParam[1] == "--bicycle")
    transport = new BicycleTransport();
else
    Console.WriteLine("Selecione o tipo de serviço!");

if (transport != null)
    transport.StartTransport();

Console.ReadLine();