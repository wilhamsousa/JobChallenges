using MobilePlanLib.Model.Interface;

namespace MobilePlanLib.Model
{
    public class PrePaidPlanFactory : IMobilePlanFactory
    {
        public string PlanName { get; set; } = "Pre Paid";
        public decimal Price { get; set; } = 100;

        public IConnectionSpeedFactory CreateConnectionSpeed()
        {
            return new LowConnectionSpeed();
        }

        public ITextMessageFactory CreateTextMessage()
        {
            return new ThousandTextMessage();
        }
    }
}
