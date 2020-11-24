using System;
using System.Collections.Generic;

namespace RadioApp
{
    public class Radio
    {
        private int _channel = 1;
        private float _volume = 0.5f;
        public Dictionary<string,string> channels = new Dictionary<string, string>() 
        { 
            { "Classic Rock Radio", "http://us5.internet-radio.com:8267/" },
            { "Radio Bloodstream", "http://uk1.internet-radio.com:8294/live" },
            { "90's Radio", "http://uk1.internet-radio.com:8150/live" },
            { "NoLife Radio", "http://listen.nolife-radio.com:8000" }
        };
        
        public float Volume
        {
            get { return _volume; }
            set { _volume = value; }
        }

        public int Channel
        {
            get { return _channel; }
            set { if (value > 0 && value <= channels.Count && On) _channel = value; }
        }

        public bool On { get; set; }

        public string Play()
        {
            if (!On)
            {
                Channel = 1;
                return "Radio is off";
            }
            return $"Playing channel {Channel}";
        }

        public void TurnOff()
        {
            On = false;            
        }

        public void TurnOn()
        {
            On = true;
            Play();
        }

        public float VolumeUp()
        {
            if (_volume < 1.0)
                _volume += 0.1f;
            return _volume;
        }

        public float VolumeDown()
        {
            if (_volume > 0.0)
                _volume -= 0.1f;
            return _volume;
        }
    }
    // implement a class Radio that corresponds to the Class diagram 
    //   and specification in the Radio_Mini_Project document
}