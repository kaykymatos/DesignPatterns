namespace Adapter
{
    class PayPal : IPayPalPayment
    {
        private Token token;
        public Token AuthToken()
        {
            return new Token();
        }

        public void PayPalPayment()
        {
            token = AuthToken();
            Console.WriteLine("Enviando pagamentos com PayPal");
        }

        public void PayPalRecive()
        {
            token = AuthToken();
            Console.WriteLine("Recebendo pagamentos com PayPal");
        }
    }
}
