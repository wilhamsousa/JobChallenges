using MobilePlanLib.Model.Interface;

namespace MobilePlanLib.Model
{
    public class UnlimitedTextMessage : ITextMessageFactory
    {
        public string Name { get; set; } = "Unlimited text message";
        public string QuantityPerMonth { get; set; } = "***";
    }
}
