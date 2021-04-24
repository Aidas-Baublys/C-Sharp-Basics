using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld2
{
    class TV : ElectricalDevice
    {
        public TV(bool isOn, string brand) : base(isOn, brand) { }
    }
}
