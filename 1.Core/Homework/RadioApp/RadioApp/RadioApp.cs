using System;

namespace RadioApp
{
    public class Radio
    {
        private int _channel = 1;
        private bool _on = false;

        public int Channel { 
            get { return _channel; } 
            set { if(value > 0 && value <= 4 && _on) _channel = value; } 
        }

        public string Play()
        {
            if (!_on)
            {
                Channel = 1;
                return "Radio is off";                
            }
            return $"Playing channel {Channel}";
        }

        public void TurnOff()
        {
            _on = false;
        }

        public void TurnOn()
        {
            _on = true;            
        }
    }
    // implement a class Radio that corresponds to the Class diagram 
    //   and specification in the Radio_Mini_Project document
}