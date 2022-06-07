using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDesignPattern
{
    public class TranslatorAdapter : IVietnameseClientInterface
    {
        private readonly RussianAdaptee _adaptee;
        public TranslatorAdapter(RussianAdaptee adaptee)
        {
            _adaptee = adaptee;
        }

        public void SendMessage(string words)
        {
            Console.Write("Reading words: ");
            Console.WriteLine(words);
            string russianWords = Translate(words);
            Console.WriteLine("Sending words...");
            _adaptee.Receive(russianWords);
        }

        private static string Translate(string vietnameseWords)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Translated");
            return "Здравствуйте г-н Путин";
        }
    }
}
