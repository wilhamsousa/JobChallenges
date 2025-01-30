using StrategyLib.Model;

namespace StrategyTest
{
    public class PaymentTest
    {
        [Fact]
        public void CashPaymentOk()
        {
            var cashPayment = new PaymentContext(new CashPayment());
            cashPayment.ExecutePayment(10);
        }

        [Fact]
        public void CreditCardPaymentOk()
        {
            var creditCard = new PaymentContext(new CreditCardPayment());
            creditCard.ExecutePayment(5);
        }
    }
}