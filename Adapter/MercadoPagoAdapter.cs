namespace Adapter
{
    class MercadoPagoAdapter : IPayPalPayment
    {
        private MercadoPago mercadoPago;
        public MercadoPagoAdapter(MercadoPago mercadoPago)
        {
            this.mercadoPago = mercadoPago;
        }
        public Token AuthToken()
        {
            return this.mercadoPago.AuthToken();
        }

        public void PayPalPayment()
        {
            this.mercadoPago.SendPaymentMercadoPago();
        }

        public void PayPalRecive()
        {
            this.mercadoPago.RecivePaymentMercadoPago();
        }
    }
}
