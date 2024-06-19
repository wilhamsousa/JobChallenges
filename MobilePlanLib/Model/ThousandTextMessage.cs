using MobilePlanLib.Model.Interface;

namespace MobilePlanLib.Model
{
    public class ThousandTextMessage : ITextMessageFactory
    {
        public string Name { get; set; } = "A thousand text message";
        public string QuantityPerMonth { get; set; } = "1000";
    }
}
