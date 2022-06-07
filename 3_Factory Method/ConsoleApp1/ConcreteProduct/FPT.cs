using FactoryMethodPattern.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern.ConcreteProduct
{
    public class FPT : INetWork
    {
        public string GetNetWorkName()
        {
            return "FPT";
        }
    }
}
