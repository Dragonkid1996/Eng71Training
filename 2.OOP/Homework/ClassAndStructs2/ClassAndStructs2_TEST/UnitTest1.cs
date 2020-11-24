using NUnit.Framework;
using ClassAndStructs2;
using System;

namespace ClassAndStructs2_TEST
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void WhenADefaultVehicleMovesTwiceItsPositionIs20()
        {
            Vehicle v = new Vehicle();
            var result = v.Move(2);
            Assert.AreEqual(20, v.Position);
            Assert.AreEqual("Moving along 2 times", result);
        }

        [Test]
        public void WhenAVehicleWithSpeed40IsMovedOnceItsPositionIs40()
        {
            Vehicle v = new Vehicle(5, 40);
            var result = v.Move();
            Assert.AreEqual(40, v.Position);
            Assert.AreEqual("Moving along", result);
        }

        [Test]
        public void AVehicleCanHaveNegativeSpeedAndIsMovedThreeTimes()
        {
            Vehicle v = new Vehicle(5, -20);
            var result = v.Move(3);
            Assert.AreEqual(-60, v.Position);
            Assert.AreEqual("Moving along 3 times", result);
        }

        [Test]
        public void CrammedCar()
        {
            Vehicle v = new Vehicle(5, 10);
            v.NumPassengers = 7;
            Assert.AreEqual(0, v.NumPassengers);
        }

        [Test]
        public void NegativePassengersInCar()
        {
            Vehicle v = new Vehicle(5, 10);
            v.NumPassengers = -13;
            Assert.AreEqual(0, v.NumPassengers);
        }

        [Test]
        public void GoodNumberOfPassengersInCar()
        {
            Vehicle v = new Vehicle(5, 10);
            v.NumPassengers = 3;
            Assert.AreEqual(3, v.NumPassengers);
        }
    }
}