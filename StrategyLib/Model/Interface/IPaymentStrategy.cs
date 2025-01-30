namespace StrategyLib.Model.Interface
{
    public interface IPaymentStrategy
    {
        void ExecutePayment(decimal value);
    }
}
