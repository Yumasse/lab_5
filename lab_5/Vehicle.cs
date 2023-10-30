using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    public abstract class Vehicle
    {
        //властивості
        public int Speed { get; }
        public int Capacity { get; }

        public Vehicle(int speed, int capacity)
        {
            Speed = speed;
            Capacity = capacity;
        }
        //метод
        public abstract void Move();
    }
}
