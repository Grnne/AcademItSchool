namespace MaxMin
{
    internal class MaxMin
    {
        static void Main(string[] args)
        {
            Console.Write("Введите первое число: ");
            int number1 = int.Parse(Console.ReadLine()!);

            Console.Write("Введите второе число: ");
            int number2 = int.Parse(Console.ReadLine()!);

            if (number1 > number2)
            {
                Console.WriteLine($"Наибольшее число = {number1}, наименьшее = {number2}");
            }
            else if (number2 > number1)
            {
                Console.WriteLine($"Наибольшее число = {number2}, наименьшее = {number1}");
            }
            else
            {
                Console.WriteLine("Числа равны");
            }

            Console.WriteLine("Решение через тернарные операторы.");
            int max = (number1 > number2) ? number1 : number2;
            int min = (number2 < number1) ? number2 : number1;
            Console.WriteLine($"Наибольшее число = {max}, наименьшее = {min}");
        }
    }
}