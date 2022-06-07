using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandDesignPattern.IoTDevice
{
    public class GarageDoor
    {
        public void Up()
        {
            Console.WriteLine("The garage door is up");
        }

        public void Down()
        {
            Console.WriteLine("The garage door is down");
        }
    }
}
