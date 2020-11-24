using System;
using System.Collections.Generic;
using System.Text;

namespace SafariPark
{
    public class Vehicle : IMovable
    {
        private int _capacity;
        private int _numPassengers;
        private int _speed = 10;

        public int NumPassengers
        {
            get { return _numPassengers; }
            set { if (value >= _capacity)
                    _numPassengers = _capacity;
                else if (value < 0)
                    _numPassengers = 0;
                else
                    _numPassengers = value;
            }
        }

        public int Position { get; private set; }

        public Vehicle() { }

        public Vehicle(int capacity, int speed)
        {
            _capacity = capacity;
            _speed = speed;
        }

        public virtual string Move()
        {
            Position += _speed;
            return "Moving along";
        }

        public virtual string Move(int times)
        {
            Position += times * _speed;
            return $"Moving along {times} times";
        }

        public override string ToString()
        {
            return $"{base.ToString()} capacity: {_capacity} passengers: {_numPassengers} speed: {_speed} position: {Position}";
        }
    }
}
