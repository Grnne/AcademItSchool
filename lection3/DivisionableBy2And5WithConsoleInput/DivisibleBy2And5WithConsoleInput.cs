namespace DivisibleBy2And5WithConsoleInput
{
    internal class DivisibleBy2And5WithConsoleInput
    {
        static void Main(string[] args)
        {
            Console.Write("Введите целое число: ");
            int number = int.Parse(Console.ReadLine()!);

            if (number % 2 == 0)
            {
                Console.WriteLine("Данное число четное");
            }
            else
            {
                Console.WriteLine("Данное число нечетное");
            }

            if (number % 5 == 0)
            {
                Console.WriteLine("Данное число кратно 5");
            }
            else
            {
                Console.WriteLine("Данное число не кратно 5");
            }
        }
    }
}