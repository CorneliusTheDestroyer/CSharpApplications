namespace PracticeApp31
{
    public interface IPayment
    {
        // TODO: Declare a method ProcessPayment
        void ProcessPayment();
    }

    public class CreditCardPayment : IPayment
    {
        // TODO: Implement the ProcessPayment method
        public void ProcessPayment()
        {
            Console.WriteLine("Processing credit card payment");
        }
    }

    public class PayPalPayment : IPayment
    {
        // TODO: Implement the ProcessPayment method
        public void ProcessPayment()
        {
            Console.WriteLine("Processing PayPal payment");
        }
    }

    internal class Program
    {
        static void Main()
        {
            // TODO: Create instances of CreditCardPayment and PayPalPayment, and call the ProcessPayment method on each
            IPayment creditCardPayment = new CreditCardPayment();
            creditCardPayment.ProcessPayment();

            IPayment payPalPayment = new PayPalPayment();
            payPalPayment.ProcessPayment();
        }
    }
}
