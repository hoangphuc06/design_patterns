using FactoryMethodPattern.Abstract;
using FactoryMethodPattern.ConcreteProduct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern.ConcreteCreator
{
    class FPTConcreteCreator : NetWorkFactory
    {
        public override INetWork Create()
        {
            return new FPT();
        }
    }
}
