using MobilePlanLib;
using MobilePlanLib.Model.Enum;

namespace MobilePlanTest
{
    /// <summary>
    /// Factory with sub factories, where the factory build a implementation based with parameter
    /// </summary>
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