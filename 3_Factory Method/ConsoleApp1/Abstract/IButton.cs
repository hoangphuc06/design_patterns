using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern.Abstract
{
    public interface IButton
    {
        string Render();
        string OnClick();
    }
}
