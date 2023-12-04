namespace LeapYear
{
    internal class LeapYear
    {
        static void Main(string[] args)
        {
            Console.Write("Введите год: ");
            int year = int.Parse(Console.ReadLine()!);

            if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
            {
                Console.WriteLine("Это високосный год");
            }
            else
            {
                Console.WriteLine("Это не високосный год");
            }
        }
    }
}