using MobilePlanLib.Model;
using MobilePlanLib.Model.Enum;
using MobilePlanLib.Model.Interface;

namespace MobilePlanLib
{
    public class MobilePlanClient
    {
        private readonly IMobilePlanFactory _mobilePlanFactory;
        public MobilePlanClient(MobilePlan mobilePlan)
        {
            if (mobilePlan == MobilePlan.PrePaid)
            {
                _mobilePlanFactory = new PrePaidPlanFactory();
            }

            if (mobilePlan == MobilePlan.PosPaid)
            {
                _mobilePlanFactory = new PosPaidPlanFactory();
            }
        }

        public string ConnectionSpeed() => _mobilePlanFactory.CreateConnectionSpeed().Name;
        public string TextMessage() => _mobilePlanFactory.CreateTextMessage().Name;
        public string PlanName() => _mobilePlanFactory.PlanName;        
    }
}
