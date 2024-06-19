using MobilePlanLib;
using MobilePlanLib.Model.Enum;

namespace MobilePlanTest
{
    public class MobilePlanTest
    {
        [Fact]
        public void HighSpeedTest()
        {
            var mobilePlanClient = new MobilePlanClient(MobilePlan.PosPaid);
            Assert.Equal("High speed", mobilePlanClient.ConnectionSpeed());
        }

        [Fact]
        public void LowSpeedTest()
        {
            var mobilePlanClient = new MobilePlanClient(MobilePlan.PrePaid);
            Assert.Equal("Low speed", mobilePlanClient.ConnectionSpeed());
        }
        
        [Fact]
        public void PrePaidName()
        {
            var mobilePlanClient = new MobilePlanClient(MobilePlan.PrePaid);
            Assert.Equal("Pre Paid", mobilePlanClient.PlanName());
        }
    }
}