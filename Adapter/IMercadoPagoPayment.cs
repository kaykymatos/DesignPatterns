namespace Adapter
{
    interface IMercadoPagoPayment
    {
        Token AuthToken();
        void SendPaymentMercadoPago();
        void RecivePaymentMercadoPago();
    }
}
