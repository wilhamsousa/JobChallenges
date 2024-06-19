using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePlanLib.Model.Interface
{
    public interface IMobilePlanFactory
    {
        public string PlanName { get; set; }
        public decimal Price { get; set; }
        ITextMessageFactory CreateTextMessage();
        IConnectionSpeedFactory CreateConnectionSpeed();
    }
}
