namespace ChainOfResponsibility.Middlewares
{
    class CheckWeakPassword : Middleware
    {
        public override bool Check(string email, string password)
        {
            if (password == "123456")
                Console.WriteLine("Sua senha é muito fraca, recomendamos que você mude ela para uma mais forte!");

            return CheckNext(email, password);

        }
    }
}
