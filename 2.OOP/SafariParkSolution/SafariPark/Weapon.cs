using System;
using System.Collections.Generic;
using System.Text;

namespace SafariPark
{
    public abstract class Weapon : IShootable
    {
        private string _brand;
        public int Damage { get; set; }

        public string Brand
        {
            get { return _brand; }
        }


        public Weapon(string brand, int damage)
        {
            _brand = brand;
            Damage = damage;

        }
        public virtual string Shoot()
        {
            return $"Shooting a {ToString()}";
        }
        public override string ToString()
        {
            return $"{base.ToString()} - {_brand}";
        }
    }

    public class LaserGun : Weapon
    {
        public LaserGun(string brand, int damage) : base(brand, damage)
        {
        }

        public override string Shoot()
        {
            return $"Zap!! {base.Shoot()}";
        }
    }

    public class WaterPistol : Weapon
    {
        public WaterPistol(string brand, int damage) : base(brand, damage)
        {
        }

        public override string Shoot()
        {
            return $"Splash!! {base.Shoot()}";
        }
    }

    public class SpaceGun : Weapon
    {

        public SpaceGun(string brand, int damage) : base(brand, damage)
        {
        }

        public override string Shoot()
        {
            return $"Pew Pew!! {base.Shoot()}";
        }
    }

    public class Camera : Weapon
    {
        public Camera(string brand, int damage) : base(brand, damage)
        {

        }

        public override string Shoot()
        {
            return $"took a photo with their {base.ToString()} to commemorate the occasion";
        }

        public override string ToString()
        {
            return $"{base.ToString()} - {Brand}";
        }
    }
}
