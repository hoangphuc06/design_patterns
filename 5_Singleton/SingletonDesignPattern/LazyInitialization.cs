using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDesignPattern
{
    public class LazyInitialization
    {
        private static LazyInitialization? instance = null;
        public static LazyInitialization GetInstance()
        {
            if (instance is null)
                instance = new LazyInitialization();
            return instance;
        }

        private LazyInitialization()
        {
            Console.WriteLine("Lazy Initialization");
        }

        public void DoSomeThing()
        {
            Console.WriteLine("Hello I'm Singleton with Lazy Initialization!");
        }
    }
}
