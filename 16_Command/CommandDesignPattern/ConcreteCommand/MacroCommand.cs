using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandDesignPattern.ConcreteCommand
{
    public class MacroCommand : ICommand
    {
        private List<ICommand> _commands;

        public MacroCommand(List<ICommand> commands)
        {
            _commands = commands;
        }
        public void Execute()
        {
            foreach(var command in _commands)
            {
                command.Execute();
            }    
        }

        public void Undo()
        {
            foreach (var command in _commands)
            {
                command.Undo();
            }    
        }
    }
}
