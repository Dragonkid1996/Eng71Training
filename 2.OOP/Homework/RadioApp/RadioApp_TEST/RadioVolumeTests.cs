using NUnit.Framework;
using RadioApp;
namespace RadioTests
{
    public class RadioVolumeTests
    {
        private Radio _radio;
        [SetUp]
        public void Setup()
        {
            _radio = new Radio();
            _radio.TurnOn();
        }

        [Test]
        public void VolumeUpTest()
        {
            _radio.VolumeUp();
            Assert.AreEqual(0.6f, _radio.Volume);
        }

        [Test]
        public void VolumeDownTest()
        {
            _radio.VolumeDown();
            Assert.AreEqual(0.4f, _radio.Volume);
        }

        [Test]
        public void VolumeUpCannotGoAboveOneTest()
        {
            _radio.Volume = 1.0f;
            _radio.VolumeUp();
            Assert.AreEqual(1.0, _radio.Volume);
        }

        [Test]
        public void VolumeUpCannotGoBelowZeroTest()
        {
            _radio.Volume = 0.0f;
            _radio.VolumeDown();
            Assert.AreEqual(0.0, _radio.Volume);
        }
    }
}