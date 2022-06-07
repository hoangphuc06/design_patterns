using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDesignPattern
{
    public class EagerInitialization
    {
        private static readonly EagerInitialization instance = new();
        public static EagerInitialization GetInstance()
        {
            return instance;
        }

        private EagerInitialization()
        {
            Console.WriteLine("Eager Initialization");
        }

        public void DoSomeThing()
        {
            Console.WriteLine("Hello I'm Singleton with Eager Initialization!");
        }
    }
}
