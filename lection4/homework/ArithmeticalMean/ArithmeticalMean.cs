namespace ArithmeticalMean
{
    internal class ArithmeticalMean
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое и последнее число диапазона чисел.");

            Console.Write("Введите первое число: ");
            int firstNumber = int.Parse(Console.ReadLine()!);

            Console.Write("Введите последнее число: ");
            int lastNumber = int.Parse(Console.ReadLine()!);

            int allNumbersSum = 0;
            int allNumbersCount = 0;
            int evenNumbersSum = 0;
            int evenNumbersCount = 0;
            int i = firstNumber;

            while (i <= lastNumber)
            {
                if (i % 2 == 0)
                {
                    evenNumbersSum += i;
                    evenNumbersCount++;
                }

                allNumbersSum += i;
                allNumbersCount++;
                i++;
            }

            double allNumbersArithmeticalMean = (double)allNumbersSum / allNumbersCount;
            double evenNumbersArithmeticalMean = (double)evenNumbersSum / evenNumbersCount;
            Console.WriteLine($"Среднее арифметическое = {allNumbersArithmeticalMean}; количество чисел = {allNumbersCount}");
            Console.WriteLine($"среднее арифметическое четных чисел = {evenNumbersArithmeticalMean}; количество четных чисел = {evenNumbersCount}");
        }
    }
}