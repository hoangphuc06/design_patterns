using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandDesignPattern
{
    public class Invoker
    {
        private ICommand _command;
        private CommandHistory _history = new();
        public Invoker()
        {
            /*_command = command;*/
        }

        public void SetCommand(ICommand command)
        {
            _command = command;
        }

        public void ExecutionCommand ()
        {
            _command.Execute();
            _history.Push(_command);
        }

        public void UndoCommand ()
        {
            _history.Pop().Undo();
        }

        public void UndoCommands()
        {
            ICommand lastCommand = _history.Pop();
            while (lastCommand != null) 
            {
                lastCommand.Undo();
                lastCommand = _history.Pop();
            }
            
        }
    }
}
