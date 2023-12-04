namespace MultiplicationTableArray;

internal class MultiplicationTableArray
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите числа, до которых нужно строить таблицу.");

        Console.Write("Введите количество строк: ");
        int arrayRowsAmount = int.Parse(Console.ReadLine()!);

        Console.Write("Введите количество столбцов: ");
        int arrayColumnsAmount = int.Parse(Console.ReadLine()!);

        int[,] multiplicationTableArray = GetMultiplicationTable(arrayRowsAmount, arrayColumnsAmount);

        for (int i = 0; i < multiplicationTableArray.GetLength(0); i++)
        {
            for (int j = 0; j < multiplicationTableArray.GetLength(1); j++)
            {
                Console.Write(multiplicationTableArray[i, j] + " ");
            }

            Console.WriteLine();
        }
    }

    public static int[,] GetMultiplicationTable(int arrayRowsAmount, int arrayColumnsAmount)
    {
        int[,] multiplicationTableArray = new int[arrayColumnsAmount, arrayRowsAmount];

        for (int i = 0; i < arrayColumnsAmount; i++)
        {
            for (int j = 0; j < arrayRowsAmount; j++)
            {
                multiplicationTableArray[i, j] = (i + 1) * (j + 1);
            }
        }

        return multiplicationTableArray;
    }
}