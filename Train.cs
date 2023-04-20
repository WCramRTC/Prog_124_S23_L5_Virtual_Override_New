using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_124_S23_L5_Virtual_Override_New
{
    internal class Train : Land
    {
        int _numOfCars;

        public Train(ConsoleColor color, int capacity, int fuelCapacity, int maxSpeed, int numOfWheels, int numOfCars) : base(color, capacity, fuelCapacity, maxSpeed, numOfWheels)
        {
            _numOfCars = numOfCars;
            _backgroundColor = ConsoleColor.Yellow;
        }

        public override void Accelerate()
        {
            base.Accelerate();
            Console.WriteLine("And we are on tracks");
        }
    }
}
