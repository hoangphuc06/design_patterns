using CommandDesignPattern.IoTDevice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandDesignPattern.ConcreteCommand
{
    public class LightOffCommand : ICommand
    {
        private readonly CeilingLight _ceilingLight;

        public LightOffCommand(CeilingLight ceilingLight)
        {
            _ceilingLight = ceilingLight;
        }

        public void Execute()
        {
            _ceilingLight.Off();
        }

        public void Undo()
        {
            _ceilingLight.On();

        }
    }
}
