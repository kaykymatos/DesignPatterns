using ChainOfResponsibility.Middlewares;

namespace ChainOfResponsibility.Servers
{
    class Server
    {
        private Dictionary<string, string> users = new Dictionary<string, string>();
        private Middleware middleware;

        public void SetMiddleware(Middleware middleware)
        {
            this.middleware = middleware;
        }
        public Boolean LogIn(string email, string password)
        {
            if (middleware.Check(email, password))
            {

                Console.WriteLine("Usuário autorizado com sucesso!");
                Console.WriteLine("Bem vindo(a)!");
                return true;
            }
            return false;
        }
        public void RegisterUser(string email, string password)
        {
            users[email] = password;
        }
        public Boolean HasEmail(string email)
        {
            return users.ContainsKey(email);
        }
        public Boolean IsValidPassword(string email, string password)
        {
            users.TryGetValue(email, out string value);
            return password == value;
        }
    }
}
