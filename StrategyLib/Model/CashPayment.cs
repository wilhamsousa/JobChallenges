using StrategyLib.Model.Interface;

namespace StrategyLib.Model
{
    public class CashPayment : IPaymentStrategy
    {
        public void ExecutePayment(decimal value)
        {
            Console.WriteLine($"Cash payment of ${value}");
        }
    }
}
