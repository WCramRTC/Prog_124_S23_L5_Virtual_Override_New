using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_124_S23_L5_Virtual_Override_New
{
    internal class Vehicle
    {
        protected ConsoleColor _color;
        int _capacity;
        int _fuelCapacity;
        int _maxSpeed;
        protected ConsoleColor _backgroundColor;

        public Vehicle(ConsoleColor color, int capacity, int fuelCapacity, int maxSpeed)
        {
            _color = color;
            _capacity = capacity;
            _fuelCapacity = fuelCapacity;
            _maxSpeed = maxSpeed;
            _backgroundColor = ConsoleColor.Black;
        } // Vehicle

        // Virtual - This gives permission for a child class to change the fuctionality of a method
        public virtual void Accelerate()
        {
            ConsoleColor og = Console.ForegroundColor; // This saves the original color of the font before we switch it to a vehicle color
            ConsoleColor backOg = Console.BackgroundColor;

            Console.ForegroundColor = _color; // Changed Color
            Console.BackgroundColor = _backgroundColor;
            // Prog124 blah blah .Vehicle
            // GetType().Name 
            Console.WriteLine($"This is a {GetType().Name}"); // Printed out in that 
            Console.ForegroundColor = og; // Changes back to the original color       
            Console.BackgroundColor = backOg;
        }

    } // class

} // namespace
