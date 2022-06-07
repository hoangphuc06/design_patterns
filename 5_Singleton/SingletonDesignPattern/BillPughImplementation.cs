using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDesignPattern
{
    public class BillPughImplementation
    {
        private static class SingletonHelper
        {
            public static BillPughImplementation instance = new BillPughImplementation();
        }

        public static BillPughImplementation GetInstance()
        {
            return SingletonHelper.instance;
        }

        private BillPughImplementation()
        {
            Console.WriteLine("Bill Pugh Implementation");
        }

        public void DoSomeThing()
        {
            Console.WriteLine("Hello I'm Singleton with Bill Pugh Implementation!");
        }
    }
}
