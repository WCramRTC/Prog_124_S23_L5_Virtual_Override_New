using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_124_S23_L5_Virtual_Override_New
{
    internal class Land : Vehicle
    {
        int _numOfWheels;
        

        public Land(ConsoleColor color, int capacity, int fuelCapacity, int maxSpeed, int numOfWheels) : base(color, capacity, fuelCapacity, maxSpeed)
        {
            _numOfWheels = numOfWheels;
            _backgroundColor = ConsoleColor.DarkRed;
        }

        public override void Accelerate()
        {
            base.Accelerate();
            Console.WriteLine("And we are driving");
        } // Accelerate


        //public Land(ConsoleColor color, int capacity, int fuelCapacity, int maxSpeed, int numOfWheels) : base(color, capacity, fuelCapacity, maxSpeed)
        //{
        //    _numOfWheels = numOfWheels;
        //}
    }
}
