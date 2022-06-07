using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDesignPattern
{
    public class VietnameseClient
    {
        public void SayHelloToPutin()
        {
            RussianAdaptee russianAdaptee = new();
            IVietnameseClientInterface client = new TranslatorAdapter(russianAdaptee);
            client.SendMessage("Xin chào ông Putin");
        }

    }
}
