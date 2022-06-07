using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDesignPattern
{
    public class RussianAdaptee
    {
        public void Receive(string words)
        {
            Console.Write("Retreving words from Adapter: ");
            Console.Write(words);

        }
    }
}
