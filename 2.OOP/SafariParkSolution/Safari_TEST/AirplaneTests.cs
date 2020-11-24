using NUnit.Framework;

namespace SafariPark
{
    class AirplaneTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CantHaveANegativeAltitude()
        {
            Airplane a = new Airplane(200, 100, "JetsRUs");
            a.Ascend(200);
            a.Descend(800);
            Assert.AreEqual(0, a.Altitude);
        }

        [TestCase(400)]
        [TestCase(8000)]
        public void AirplaneAscendsProperly(int alt)
        {
            Airplane a = new Airplane();
            a.Ascend(alt);
            Assert.AreEqual(alt, a.Altitude);
        }

        [TestCase(400)]
        [TestCase(8000)]
        public void AirplaneDescendsProperly(int alt)
        {
            Airplane a = new Airplane();
            a.Ascend(alt);
            a.Descend(alt / 2);
            Assert.AreEqual(alt/2, a.Altitude);
        }

        [Test]
        public void DefaultAirplaneMovesOnce()
        {
            Airplane a = new Airplane();
            a.Ascend(100);
            a.Move();
            Assert.AreEqual(10, a.Position);
        }

        [Test]
        public void DefaultAirplaneMovesMoreThanOnce()
        {
            Airplane a = new Airplane();
            a.Ascend(100);
            a.Move(20);
            Assert.AreEqual(200, a.Position);
        }

        [TestCase(200, 100, "JetsRUs", "Thank you for flying JetsRUs: SafariPark.Airplane capacity: 200 passengers: 150 speed: 100 position: 100 altitude: 100")]
        [TestCase(500, 300, "Vorgon", "Thank you for flying Vorgon: SafariPark.Airplane capacity: 500 passengers: 150 speed: 300 position: 300 altitude: 100")]
        [TestCase(2000, 1000, "Vorgon Galactoc", "Thank you for flying Vorgon Galactoc: SafariPark.Airplane capacity: 2000 passengers: 150 speed: 1000 position: 1000 altitude: 100")]
        public void CorrectMessageShownWhenToStringIsCalled(int cap, int speed, string airline, string expected)
        {
            Airplane a = new Airplane(cap, speed, airline);
            a.NumPassengers = 150;
            a.Ascend(100);
            a.Move();
            Assert.AreEqual(expected,a.ToString());
        }
    }
}
