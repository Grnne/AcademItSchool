namespace Calculations
{
    internal class Calculations
    {
        static void Main(string[] args)
        {
            double x = 3 - (56 - 12) / 44 * 4 / 2;
            Console.WriteLine("x = " + x);

            double y = 2 * x / (33 - x);
            Console.WriteLine("y = " + y);

            double z = -x / (2 * y);
            Console.WriteLine("z = " + z);
        }
    }
}