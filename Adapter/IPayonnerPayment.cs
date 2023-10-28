namespace Adapter
{
    interface IPayonnerPayment
    {
        Token AuthToken();
        void SendPayment();
        void RecivePayment();
    }
}
