namespace Overload
{
    internal class Overload
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Размер byte: " + GetTypeSize((byte)1));
            Console.WriteLine("Размер short: " + GetTypeSize((short)1));
            Console.WriteLine("Размер int: " + GetTypeSize(1));
            Console.WriteLine("Размер long: " + GetTypeSize((long)1));
            Console.WriteLine("Размер float: " + GetTypeSize((float)1));
            Console.WriteLine("Размер double: " + GetTypeSize((double)1));
        }

        public static int GetTypeSize(byte number) => 1;

        public static int GetTypeSize(short number) => 2;

        public static int GetTypeSize(int number) => 4;

        public static int GetTypeSize(long number) => 8;

        public static int GetTypeSize(float number) => 4;

        public static int GetTypeSize(double number) => 8;
    }
}