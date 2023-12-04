namespace SomeCalculations
{
    internal class SomeCalculations
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Программа возводит введенные числа в квадрат, после вычисляет квадратный корень их суммы и выводит остаток от целочисленного деления его на 2. Вводить можно только целые числа.");

            Console.Write("Введите первое число: ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите второе число: ");
            int y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Math.Sqrt(x * x + y * y) % 2);
        }
    }
}