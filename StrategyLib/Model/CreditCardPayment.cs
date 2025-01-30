using StrategyLib.Model.Interface;

namespace StrategyLib.Model
{
    public class CreditCardPayment : IPaymentStrategy
    {
        public void ExecutePayment(decimal value)
        {
            Console.WriteLine($"Creditcard payment of ${value}");
        }
    }
}
