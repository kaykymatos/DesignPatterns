namespace Adapter
{
    class MercadoPago : IMercadoPagoPayment
    {
        private Token token;
        public Token AuthToken()
        {
            return new Token();
        }

        public void RecivePaymentMercadoPago()
        {
            token = AuthToken();
            Console.WriteLine("Recebendo pagamento com Mercaro Pago!");
        }

        public void SendPaymentMercadoPago()
        {
            token = AuthToken();
            Console.WriteLine("Enviando pagamento com Mercaro Pago!");
        }
    }
}
