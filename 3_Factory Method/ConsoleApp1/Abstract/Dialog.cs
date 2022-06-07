using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern.Abstract
{
    public abstract class Dialog
    {
        public abstract IButton CreateButton();

        public string Render()
        {
            // call factory method to create Product object
            var button = CreateButton();
            Console.WriteLine(button.OnClick());
            var result = "Dialog has " + button.Render();

            return result;
        }
    }
}
