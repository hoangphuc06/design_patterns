using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDesignPattern
{
    public class ThreadSafeSingleton
    {
        private static ThreadSafeSingleton? instance = null;
        public static ThreadSafeSingleton GetInstance()
        {
            return GetInstanceAsync().Result;
        }
        private static async Task<ThreadSafeSingleton> GetInstanceAsync()
        {
            await Task.Run(() =>
            {
                if (instance is null)
                    instance = new ThreadSafeSingleton();
            });

            return instance;
        }

        private ThreadSafeSingleton()
        {
            Console.WriteLine("Thread Safe Singleton");
        }

        public void DoSomeThing()
        {
            Console.WriteLine("Hello I'm Singleton with Thread Safe Singleton!");
        }
    }
}
