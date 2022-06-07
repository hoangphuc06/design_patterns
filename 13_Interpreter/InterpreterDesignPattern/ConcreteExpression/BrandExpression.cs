using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpreterDesignPattern.ConcreteExpression
{
    public class BrandExpression : IExpression
    {
        public void Evaluate(Context context)
        {
            if (context.IsAircraft == true)
            {
                if (context.GetFirstChar().Equals("A"))
                    Console.WriteLine("Brand is Airbus");
                else if (context.GetFirstChar().Equals("B"))
                    Console.WriteLine("Brand is Boeing");
            }
            else
                Console.WriteLine("Brand could not be interpreted");
        }
    }
}
