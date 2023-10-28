using ChainOfResponsibility.Middlewares;
using ChainOfResponsibility.Servers;

class Program
{
    static Server server;
    static void Init()
    {
        server = new Server();
        server.RegisterUser("master@hotmail.com", "ohd87o7h8129eo7h127dh");
        server.RegisterUser("teste@hotmail.com", "123456");

        Middleware middleware = new CheckUserMiddleware(server);
        middleware.LinkWith(new CheckPermissionMiddleware());
        middleware.LinkWith(new CheckWeakPassword());

        server.SetMiddleware(middleware);
    }
    private static void Main(string[] args)
    {
        Init();
        Boolean done = false;
        do
        {
            Console.WriteLine("Digite seu email:");
            string email = Console.ReadLine();

            Console.WriteLine("Digite sua senha:");
            string password = Console.ReadLine();

            done = server.LogIn(email, password);

        } while (!done);

        Console.ReadLine();

    }
}