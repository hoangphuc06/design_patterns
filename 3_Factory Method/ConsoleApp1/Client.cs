using FactoryMethodPattern.Abstract;
using FactoryMethodPattern.ConcreteCreator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    public class Client
    {
        public void Main()
        {
            Console.WriteLine("App: Launched with the Windows Dialog.");
            ClientCode(new WindowsDialog());

            Console.WriteLine("");

            Console.WriteLine("App: Launched with the HTML Dialog.");
            ClientCode(new HTMLDialog());
        }

        // The client code works with an instance of a concrete creator, albeit
        // through its base interface. As long as the client keeps working with
        // the creator via the base interface, you can pass it any creator's
        // subclass.
        public static void ClientCode(Dialog creator)
        {
            // ...
            Console.WriteLine("Client: I'm not aware of the creator's class," +
                "but it still works.\n" + creator.Render());
            // ...
        }
    }
}
