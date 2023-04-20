using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_124_S23_L5_Virtual_Override_New
{
    internal class Forklift : Land
    {
        int _weightCapacity;

        public Forklift(ConsoleColor color, int capacity, int fuelCapacity, int maxSpeed, int numOfWheels) : base(color, capacity, fuelCapacity, maxSpeed, numOfWheels)
        {
            _weightCapacity = 3000;
        }

        public override void Accelerate()
        {
            base.Accelerate();
            Console.WriteLine("We are on the construction site.");
        }

        public void RaiseForkLift()
        {
            Console.WriteLine("The forklift is raised");
        }

    }
}
