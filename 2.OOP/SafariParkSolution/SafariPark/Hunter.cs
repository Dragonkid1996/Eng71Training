using System;
using System.Collections.Generic;
using System.Text;

namespace SafariPark
{
    public class Hunter : Person, IShootable
    {
        private int _health;


        public int Health
        {
            get { return _health; }
            set { _health = value; }
        }

        public Weapon Shooter { get; set; }

        public Hunter(string fName, string lName, Weapon shooter, int health) : base(fName, lName)
        {
            Shooter = shooter;
            Health = health;
        }

        public Hunter() { }

        public string Shoot()
        {
            return $"{GetFullName()}: {Shooter.Shoot()}";
        }

        Random rng = new Random();
        public string Shoot(Hunter hunted, Hunter hunter)
        {
            if (hunter.Shooter.Damage == 0)
                return Shoot();
            else
            {
                if (rng.Next(100) < 20)
                    return $"{Shoot()}\nBut they missed!!!";
                else
                    return $"{Shoot()} \n{hunted.HasBeenShot(hunter)}";
            }
            
        }

        public override string ToString()
        {
            return $"{base.ToString()} Weapon: {Shooter}"; 
        }

        public string HasBeenShot(Hunter hunter)
        {
            _health = hunter.Shooter.Damage >= _health ? 0 : _health - hunter.Shooter.Damage;
            if(_health == 0)
                return $"{GetFullName()} has been shot by {hunter.GetFullName()} and died.";
            else
                return $"{GetFullName()} has been shot by {hunter.GetFullName()}. Their health is now {_health}";
            
        }
    }
}
