using System.Xml.Serialization;

namespace PracticeApp30
{

    public interface IPaymentProcessor
    {
        void ProcessPayment(decimal amount);
    }

    public class CreditCardProcessor: IPaymentProcessor
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Processing credit card payment: {amount}");
        }
    }

    public class PayPalProcessor: IPaymentProcessor
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Processing PayPal payment: {amount}");
        }
    }

    public class PaymentService
    {
        private readonly IPaymentProcessor _processor;

        public PaymentService(IPaymentProcessor processor)
        {
            _processor = processor;
        }

        public void ProcessOrderPayment(decimal amount)
        {
            _processor.ProcessPayment(amount);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            IPaymentProcessor creditcardProcessor = new CreditCardProcessor();
            PaymentService paymentService = new PaymentService(creditcardProcessor);
            paymentService.ProcessOrderPayment(100.00m);

            IPaymentProcessor paypalProcessor = new PayPalProcessor();
            paymentService = new PaymentService(paypalProcessor);
            paymentService.ProcessOrderPayment(200.00m);

        }
    }
}
