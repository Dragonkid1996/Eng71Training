using System;
using System.Collections.Generic;

namespace SafariPark
{
    class Program
    {
        static void Main(string[] args)
        {
            //Person cathy = new Person("Cathy", "French");
            //cathy.Age = 20;

            //Console.WriteLine(cathy.GetFullName());

            //Person nish;
            //nish = new Person("Nish", "Mandal") { Age = 30 };       //Age is an object initialiser
            //Console.WriteLine(nish.GetFullName());

            //Person Jino = new Person("Jino", "Bimpa") { Age = 20 };
            //Point3D pt3D = new Point3D(5, 8, 2);

            //DemoMethod(pt3D, Jino);

            //Hunter lauren = new Hunter("Lauren", "Pang", "Leica") { Age = 20 };
            //Console.WriteLine(lauren.Age);
            //Console.WriteLine(lauren.Shoot());
            //Console.WriteLine(lauren.GetFullName());

            //Hunter h = new Hunter();
            //Console.WriteLine(h.Shoot());

            //var kam = new Hunter("Kam", "Sohal", "Nikon") { Age = 25 };
            //Console.WriteLine($"Kam Equals Lauren? {kam.Equals(lauren)}");
            //Console.WriteLine($"Kam HashCode: {kam.GetHashCode()}");
            //Console.WriteLine($"Kam Type: {kam.GetType()}");
            //Console.WriteLine($"Kam ToString: {kam.ToString()}");

            //Airplane a = new Airplane(200, 100, "JetsRUs") { NumPassengers = 150 };
            //a.Ascend(500);
            //Console.WriteLine(a.Move(3));
            //Console.WriteLine(a);
            //a.Descend(200);
            //Console.WriteLine(a.Move());
            //a.Move();
            //Console.WriteLine(a);

            //var dom = new Hunter("Dom", "Newell", "Kodak");
            //var geoff = new Hunted("Geoff", "Jefferson", 3);

            //Console.WriteLine(dom.Shoot(geoff));

            //var nish = new Hunter("Nish", "Mandal") { Age = 30 };

            //SpartaWrite(nish, geoff);

            //List<object> gameObjects = new List<object>()
            //{
            //    new Person ("Cathy", "French"),
            //    new Airplane(400, 100, "Vorgon"),
            //    nish,
            //    new Vehicle(12, 40)
            //};

            //foreach(var gameObj in gameObjects)
            //{
            //    Console.WriteLine(gameObj.ToString());
            //}

            //var movingObj = new List<IMovable>() 
            //{
            //    new Vehicle(),
            //    new Person(),
            //    new Airplane(),
            //    new Hunter(),
            //    new Hunted(),
            //    new Person(),
            //    new Airplane(),
            //    new Hunter()
            //};

            //foreach (var item in movingObj)
            //{
            //    Console.WriteLine(item.Move());
            //}

            //var shooties = new List<IShootable>()
            //{
            //    new WaterPistol("Nerf"),
            //    new LaserGun("ACME"),
            //    new WaterPistol("Super Soaker"),
            //    new LaserGun("DeathLazerz"),
            //    new Hunter(),
            //    new Hunter(),
            //    new Camera("Pentax")
            //};

            //foreach (var item in shooties)
            //{
            //    Console.WriteLine(item.Shoot());
            //}

            Console.WriteLine("Polymorphic Shootout\n\n");

            Camera pentax = new Camera("Pentax", 0);
            WaterPistol pistol = new WaterPistol("SuperSoaker", 1);
            LaserGun laserGun = new LaserGun("Acme", 2);
            SpaceGun space = new SpaceGun("Martian", 3);
            Hunter dom = new Hunter("Dom", "Newell", pistol, 10);
            Hunter geoff = new Hunter("Geoff", "Jefferson", pistol, 10);

            var nextTurn = new Random();
            var weaponChange = new Random();
            
            
            while (dom.Health > 0 && geoff.Health > 0)
            {
                if(nextTurn.Next(2) == 1)
                {
                    switch (weaponChange.Next(4))
                    {
                        case 0:
                            dom.Shooter = laserGun;
                            break;
                        case 1:
                            dom.Shooter = pistol;
                            break;
                        case 2:
                            dom.Shooter = space;
                            break;
                        default:
                            dom.Shooter = pentax;
                            break;
                    }
                    Console.WriteLine(dom.Shoot(geoff, dom) + "\n");
                }
                else
                {
                    switch (weaponChange.Next(4))
                    {
                        case 0:
                            geoff.Shooter = laserGun;
                            break;
                        case 1:
                            geoff.Shooter = pistol;
                            break;
                        case 2:
                            geoff.Shooter = space;
                            break;
                        default:
                            geoff.Shooter = pentax;
                            break;
                    }
                    Console.WriteLine(geoff.Shoot(dom, geoff) + "\n");
                }
                    
            }
            
        }

        //static void DemoMethod(Point3D pt, Person p)
        //{
        //    pt.y = 1000;
        //    p.Age = 92;
        //}

        //static void SpartaWrite(object obj, Hunted hunted)
        //{
        //    Console.WriteLine(obj.ToString());
        //    if (obj is Hunter)
        //    {
        //        var hunter = (Hunter)obj;
        //        Console.WriteLine(hunter.Shoot(hunted));
        //    }
        //}
    }
}
