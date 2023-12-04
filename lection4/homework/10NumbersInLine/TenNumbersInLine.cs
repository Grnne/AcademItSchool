namespace TenNumbersInLine
{
    internal class TenNumbersInLine
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое и последнее число и количество чисел на строку");

            Console.Write("Введите первое число: ");
            int firstNumber = int.Parse(Console.ReadLine()!);

            Console.Write("Введите последнее число: ");
            int lastNumber = int.Parse(Console.ReadLine()!);

            Console.Write("Введите количество чисел в строке: ");
            int numbersInLineAmount = int.Parse(Console.ReadLine()!);

            int i = firstNumber;
            int currentNumbersInLineAmount = 1;

            while (i <= lastNumber)
            {
                Console.Write($"{i,3} ");

                if (currentNumbersInLineAmount < numbersInLineAmount)
                {
                    currentNumbersInLineAmount++;
                }
                else
                {
                    Console.WriteLine();
                    currentNumbersInLineAmount = 1;
                }

                i++;
            }
        }
    }
}