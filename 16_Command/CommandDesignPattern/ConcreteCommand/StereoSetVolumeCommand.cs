using CommandDesignPattern.IoTDevice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandDesignPattern.ConcreteCommand
{
    public class StereoSetVolumeCommand : ICommand
    {
        private Stereo _stereo;
        private int _volume;
        public StereoSetVolumeCommand(Stereo stereo, int volume)
        {
            _stereo = stereo;
            _volume = volume;
        }

        public void Execute()
        {
            _stereo.SetVolume(_volume);
        }

        public void Undo()
        {
            _stereo.UndoVolume();
        }
    }
}
