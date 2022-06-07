using FactoryMethodPattern.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern.ConcreteProduct
{
    public class WindowsButton : IButton
    {
        public string OnClick()
        {
            return "WindowsButton is clicked";
        }

        public string Render()
        {
            return "Windows Button";
        }
    }
}
