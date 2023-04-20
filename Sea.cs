using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_124_S23_L5_Virtual_Override_New
{
    internal class Sea : Vehicle
    {
        double _displacment;


        public Sea(ConsoleColor color, int capacity, int fuelCapacity, int maxSpeed, double displacment) : base(color, capacity, fuelCapacity, maxSpeed)
        {
            _displacment = displacment;
            _backgroundColor = ConsoleColor.Blue;
        }

        public override void Accelerate()
        {
            base.Accelerate();
            Console.WriteLine("We are floating");
        }
    }
}
