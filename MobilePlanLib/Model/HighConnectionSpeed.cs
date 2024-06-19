using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobilePlanLib.Model.Interface;

namespace MobilePlanLib.Model
{
    public class HighConnectionSpeed : IConnectionSpeedFactory
    {
        public string Name { get; set; } = "High speed";
        public string Velocity { get; set; } = "700MB";
    }
}
