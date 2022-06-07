using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandDesignPattern.IoTDevice
{
    public class CeilingLight
    {
        public void On()
        {
            Console.WriteLine("The ceiling light is on");
        }

        public void Off()
        {
            Console.WriteLine("The ceiling light is off");
        }
    }
}
