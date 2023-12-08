namespace MultiplicationTableArray;

internal class MultiplicationTableArray
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите числа, до которых нужно строить таблицу.");

        Console.Write("Введите количество строк: ");
        int rowsAmount = int.Parse(Console.ReadLine()!);

        Console.Write("Введите количество столбцов: ");
        int columnsAmount = int.Parse(Console.ReadLine()!);

        int[,] multiplicationTable = GetMultiplicationTable(rowsAmount, columnsAmount);

        for (int i = 0; i < multiplicationTable.GetLength(0); i++)
        {
            for (int j = 0; j < multiplicationTable.GetLength(1); j++)
            {
                Console.Write(multiplicationTable[i, j] + " ");
            }

            Console.WriteLine();
        }
    }

    public static int[,] GetMultiplicationTable(int rowsAmount, int columnsAmount)
    {
        int[,] multiplicationTable = new int[rowsAmount, columnsAmount];

        for (int i = 0; i < rowsAmount; i++)
        {
            for (int j = 0; j < columnsAmount; j++)
            {
                multiplicationTable[i, j] = (i + 1) * (j + 1);
            }
        }

        return multiplicationTable;
    }
}