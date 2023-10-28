namespace Adapter
{
    class Payonner : IPayonnerPayment
    {
        private Token token;
        public Token AuthToken()
        {
            return new Token();
        }

        public void RecivePayment()
        {
            token = AuthToken();
            Console.WriteLine("Recebendo pagamentos com payonner");
        }

        public void SendPayment()
        {
            token = AuthToken();
            Console.WriteLine("Enviando pagamentos com payonner");
        }
    }
}
