using CommandDesignPattern.IoTDevice;

namespace CommandDesignPattern.ConcreteCommand
{
    public class LightOnCommand : ICommand
    {
        private readonly CeilingLight _ceilingLight;

        public LightOnCommand(CeilingLight ceilingLight)
        {
            _ceilingLight = ceilingLight;
        }

        public void Execute()
        {
            _ceilingLight.On();
        }

        public void Undo()
        {
            _ceilingLight.Off();
        }
    }
}
