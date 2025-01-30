using StrategyLib.Model.Interface;

namespace StrategyLib.Model
{
    public class PaymentContext
    {
        public PaymentContext(IPaymentStrategy paymentStrategy) 
        {
            PaymentStrategy = paymentStrategy;
        }

        public IPaymentStrategy PaymentStrategy { get; protected set; }

        public void ExecutePayment(decimal value) =>
            PaymentStrategy.ExecutePayment(value);
    }
}
