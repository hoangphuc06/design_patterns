using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpreterDesignPattern.ConcreteExpression
{
    public class ModelExpression : IExpression
    {
        public void Evaluate(Context context)
        {
            if (context.IsAircraft == true)
            {
                Console.WriteLine("Model is : " + context.AircraftModel.Substring(1, 3));
            }
            else
                Console.WriteLine("Model could not be interpreted");
        }
    }
}
