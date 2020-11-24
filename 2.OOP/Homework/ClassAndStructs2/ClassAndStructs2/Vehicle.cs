using System;
using System.Collections.Generic;
using System.Text;

namespace ClassAndStructs2
{
    public class Vehicle
    {
        private int _capacity;
        private int _numPassengers;
        private int _speed = 10;

        public int NumPassengers
        {
            get { return _numPassengers; }
            set { if (value > 0 && value <= _capacity) _numPassengers = value; }
        }

        public int Position { get; private set; }

        public Vehicle() { }

        public Vehicle(int capacity, int speed)
        {
            _capacity = capacity;
            _speed = speed;
        }

        public string Move()
        {
            Position += _speed;
            return "Moving along";
        }

        public string Move(int times)
        {
            Position += times * _speed;
            return $"Moving along {times} times";
        }
    }
}
