using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpreterDesignPattern.ConcreteExpression
{
    public class CheckExpression : IExpression
    {
        public void Evaluate(Context context)
        {
            //We assume tthe aircraft models only start with A or B and contains 4 or 5 chars.
            string ac_model = context.AircraftModel;
            if (ac_model.StartsWith("A") || ac_model.StartsWith("B"))
            {
                if (ac_model.Length == 4 || ac_model.Length == 5)
                {
                    context.IsAircraft = true;
                    Console.WriteLine(ac_model + " is an aircraft...");
                }
                else
                {
                    context.IsAircraft = false;
                    Console.WriteLine(ac_model + " is not aircraft...");
                }
            }
            else
            {
                context.IsAircraft = false;
                Console.WriteLine(ac_model + " is not aircraft...");
            }
        }
    }
}
