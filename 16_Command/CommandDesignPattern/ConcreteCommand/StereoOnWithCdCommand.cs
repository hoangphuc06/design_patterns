using CommandDesignPattern.IoTDevice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandDesignPattern.ConcreteCommand
{
    public class StereoOnWithCdCommand : ICommand
    {
        private readonly Stereo _stereo;
        private readonly string _cd;
        private readonly int _volume;

        public StereoOnWithCdCommand(Stereo stereo, string cd, int volume)
        {
            _stereo = stereo;
            _cd = cd;
            _volume = volume;
        }

        public void Execute()
        {
            _stereo.On();
            _stereo.SetCd(_cd);
            _stereo.SetVolume(_volume);
        }

        public void Undo()
        {
            _stereo.Off();
        }
    }
}
