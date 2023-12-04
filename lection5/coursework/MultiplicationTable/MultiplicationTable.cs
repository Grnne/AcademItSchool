namespace MultiplicationTable
{
    internal class MultiplicationTable
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число, до которого нужно строить таблицу: ");
            int lastNumber = int.Parse(Console.ReadLine()!);

            Console.WriteLine();
            int longestCellLength = (lastNumber * lastNumber).ToString().Length;
            string horizontalBorder = "_";
            horizontalBorder = horizontalBorder.PadLeft(longestCellLength + 1, '_');

            // Шапка
            string emptySpaces = new(' ', longestCellLength);
            Console.Write(emptySpaces + "|");

            for (int i = 1; i <= lastNumber; i++)
            {
                Console.Write(GetPaddedNumber(i, longestCellLength + 1));
            }

            Console.WriteLine();

            for (int i = 0; i <= lastNumber; i++)
            {
                Console.Write(horizontalBorder);
            }

            Console.WriteLine();

            // Тело
            for (int i = 1; i <= lastNumber; i++)
            {
                Console.Write($"{GetPaddedNumber(i, longestCellLength)}|");

                for (int j = 1; j <= lastNumber; j++)
                {
                    Console.Write(GetPaddedNumber(i * j, longestCellLength + 1));
                }

                Console.WriteLine();
            }
        }

        public static string GetPaddedNumber(int number, int cellLength)
        {
            string paddedNumber = number.ToString();
            return paddedNumber.PadLeft(cellLength, ' ');
        }
    }
}