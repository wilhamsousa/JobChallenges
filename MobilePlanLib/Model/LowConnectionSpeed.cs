using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePlanLib.Model.Interface
{
    public class LowConnectionSpeed : IConnectionSpeedFactory
    {
        public string Name { get; set; } = "Low speed";
        public string Velocity { get; set; } = "100MB";
    }
}
