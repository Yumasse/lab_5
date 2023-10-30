using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    public class Bus : Vehicle
    {
        public Bus(int speed) : base(speed, 30)
        {
        }

        public override void Move()
        {
            Console.WriteLine($"Bus is driving at a speed of {Speed} km/h");
        }
    }
}
