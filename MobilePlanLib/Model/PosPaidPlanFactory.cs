using MobilePlanLib.Model.Interface;

namespace MobilePlanLib.Model
{
    public class PosPaidPlanFactory : IMobilePlanFactory
    {
        public string PlanName { get; set; } = "Pos Paid";
        public decimal Price { get; set; } = 150;

        public IConnectionSpeedFactory CreateConnectionSpeed()
        {
            return new HighConnectionSpeed();
        }

        public ITextMessageFactory CreateTextMessage()
        {
            return new UnlimitedTextMessage();
        }
    }
}
