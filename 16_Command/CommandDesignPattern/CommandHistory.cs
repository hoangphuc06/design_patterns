using CommandDesignPattern.ConcreteCommand;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandDesignPattern
{
    public class CommandHistory
    {
        List<ICommand> history = new ();
        public void Push(ICommand command)
        {
            history.Add(command);
        }

        public ICommand Pop()
        {
            if(history.Count > 0)
            {
                var lastCommand = history.Last();
                history.Remove(lastCommand);
                return lastCommand;
            }

            return null;
        }
    }
}
