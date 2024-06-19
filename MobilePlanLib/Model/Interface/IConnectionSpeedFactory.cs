using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePlanLib.Model.Interface
{
    public interface IConnectionSpeedFactory
    {
        string Name { get; set; }
        string Velocity { get; set; }
    }
}
