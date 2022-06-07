using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpreterDesignPattern.ConcreteExpression
{
    public class TypeExpression : IExpression
    {
        public void Evaluate(Context context)
        {
            if (context.IsAircraft == true)
            {
                string ac_model = context.AircraftModel;
                if (context.GetLenght() == 5 && context.GetLastChar().Equals("F"))//F-> Freighter
                {
                    Console.WriteLine("Aircraft type is Cargo/Freighter");
                }
                else
                    Console.WriteLine("Aircraft type is Passenger Transportation");
            }
            else
                Console.WriteLine("Type could not be interpreted");
        }
    }
}
