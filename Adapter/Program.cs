
using Adapter;

IPayPalPayment payment = new PayPal();
payment.PayPalPayment();
payment.PayPalRecive();

payment = new PayonnerAdapter(new Payonner());
payment.PayPalPayment();
payment.PayPalRecive();

payment = new MercadoPagoAdapter(new MercadoPago());
payment.PayPalPayment();
payment.PayPalRecive();

Console.ReadLine();