using System;
using System.Collections.Generic;
using System.Text;

namespace SafariPark
{
    public class Hunted : Person
    {
        private int _health;

        public Hunted() { }

        public Hunted(string fName, string lName, int health) : base(fName, lName)
        {
            _health = health;
        }

        public string HasBeenShot(Hunter hunter)
        {
            _health -= 1;
            return $"{GetFullName()} has been shot by {hunter.GetFullName()}. Their health is now {_health}";
        }

        public override string ToString()
        {
            return $"{base.ToString()} Health: {_health}";
        }
    }
}
