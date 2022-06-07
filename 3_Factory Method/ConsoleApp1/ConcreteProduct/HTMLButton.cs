using FactoryMethodPattern.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern.ConcreteProduct
{
    public class HTMLButton : IButton
    {
        public string OnClick()
        {
            return "HTMLButton is clicked";
        }

        public string Render()
        {
            return "HTML Button";
        }
    }
}
