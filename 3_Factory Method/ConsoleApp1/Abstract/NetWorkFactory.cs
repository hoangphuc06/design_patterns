using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern.Abstract
{
    public abstract class NetWorkFactory
    {
        public abstract INetWork Create();

        public string Hello()
        {
            // call factory method to create Product object
            var netWork = Create();
            var result = "Hello " + netWork.GetNetWorkName() + " network";

            return result;
        }
    }
}
