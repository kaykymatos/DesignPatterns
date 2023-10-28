using ChainOfResponsibility.Servers;

namespace ChainOfResponsibility.Middlewares
{
    class CheckUserMiddleware : Middleware
    {
        private Server server;
        public CheckUserMiddleware(Server server)
        {
            this.server = server;
        }
        public override bool Check(string email, string password)
        {
            if (!server.HasEmail(email))
            {
                Console.WriteLine("Email ou senha inválidos!");
                return false;
            }

            if (!server.IsValidPassword(email, password))
            {
                Console.WriteLine("Email ou senha inválidos!");
                return false;
            }

            return CheckNext(email, password);

        }

    }
}
