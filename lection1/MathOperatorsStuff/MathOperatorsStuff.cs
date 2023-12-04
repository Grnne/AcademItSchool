namespace MathOperatorsStuff
{
    internal class MathOperatorsStuff
    {
        static void Main(string[] args)
        {
            int x = 0;
            x = x + 50;
            x = x - 5;
            x = x * 3;
            x = x / 2;
            x = x % 10;
            Console.WriteLine($"Результат действий с целыми: {x}");

            double y = 0;
            y = y + 10.5;
            y = y - 3;
            y = y * 3;
            y = y / 4;
            y = y % 3;
            Console.WriteLine($"Результат действий с вещественными: {y}");
            Console.WriteLine();

            Console.WriteLine($"Проверка целочисленного деления : {x / 2}");
            Console.WriteLine($"Проверка вещественного деления : {y / 2}");
        }
    }
}