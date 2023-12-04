namespace RowSum
{
    internal class RowSum
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество чисел ряда: ");
            int numbersAmount = int.Parse(Console.ReadLine()!);

            int i = 1;
            int sum = 0;
            int sign = -1;

            while (i <= numbersAmount)
            {
                sign *= -1;
                sum += i * i * sign;
                i++;
            }

            Console.WriteLine($"Сумма чисел ряда = {sum}");
        }
    }
}