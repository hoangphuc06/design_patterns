using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandDesignPattern.IoTDevice
{
    public class Stereo
    {
        private string? _cd;
        private string? _dvd;
        private int _volume;
        private int _preVolume;
        public void On()
        {
            Console.WriteLine("Stereo is on");
        }

        public void Off()
        {
            Console.WriteLine("Stereo is off");
        }

        public void SetCd(string cd)
        {
            _cd = cd;
            Console.WriteLine("Current cd of stereo is {0}", _cd);
        }

        public void SetDvd(string dvd)
        {
            _dvd = dvd;
        }

        public void SetVolume(int volume)
        {
            _preVolume = _volume;
            _volume = volume;
            Console.WriteLine("Current volumn of stereo is {0}", _volume);
        }

        public void UndoVolume()
        {
            _volume = _preVolume;
        }

        public void Play()
        {
            if (_cd != null)
            {
                Console.WriteLine("Stereo is playing {0} with {1} volume", _cd, _volume.ToString());
            }
            else if (_dvd != null)
            {
                Console.WriteLine("Stereo is playing {0} with {1} volume", _dvd, _volume.ToString());
            }
        }
    }
}
