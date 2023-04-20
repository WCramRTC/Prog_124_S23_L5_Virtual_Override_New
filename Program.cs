namespace Prog_124_S23_L5_Virtual_Override_New
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            BankAccount ba = new BankAccount("Will", rand.Next().ToString(), 500);
            SavingsAccount sa = new SavingsAccount("Ronda", rand.Next().ToString(), 10000);
            CheckingAccount ca = new CheckingAccount("Jonathan", rand.Next().ToString(), 10000);

            Console.WriteLine(ca);
            ca.Deposit(10000);
            Console.WriteLine(ca);



        } // Main

        public static void Example()
        {
            Vehicle vehicle = new Vehicle(ConsoleColor.Green, 4, 12, 95);
            Land car = new Land(ConsoleColor.DarkMagenta, 8, 18, 85, 4);
            Sea sea = new Sea(ConsoleColor.DarkGray, 16, 30, 60, 40);
            Train train = new Train(ConsoleColor.Cyan, 100, 8, 55, 16, 100);

            Forklift forklift = new Forklift(ConsoleColor.DarkCyan, 2, 10, 15, 3);

            vehicle.Accelerate();
            car.Accelerate();
            sea.Accelerate();
            train.Accelerate();
            forklift.Accelerate();
            forklift.RaiseForkLift();

        }

    } // class

} // namespace