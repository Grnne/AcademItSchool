namespace DigitsInNumber
{
    internal class DigitsInNumber
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            int number = int.Parse(Console.ReadLine()!);

            int maxDigit = 0;
            int allDigitsSum = 0;
            int oddDigitsSum = 0;

            while (number > 0)
            {
                int lastDigit = number % 10;
                maxDigit = Math.Max(maxDigit, lastDigit);
                allDigitsSum += lastDigit;

                if (lastDigit % 2 != 0)
                {
                    oddDigitsSum += lastDigit;
                }

                number /= 10;
            }

            Console.WriteLine($"Сумма цифр числа = {allDigitsSum}; сумма нечетных цифр числа = {oddDigitsSum}; максимальная цифра = {maxDigit}");
        }
    }
}