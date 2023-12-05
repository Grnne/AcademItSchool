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

        int[,] multiplicationTableMatrix = GetMultiplicationTable(rowsAmount, columnsAmount);

        for (int i = 0; i < multiplicationTableMatrix.GetLength(0); i++)
        {
            for (int j = 0; j < multiplicationTableMatrix.GetLength(1); j++)
            {
                Console.Write(multiplicationTableMatrix[i, j] + " ");
            }

            Console.WriteLine();
        }
    }

    public static int[,] GetMultiplicationTable(int rowsAmount, int columnsAmount)
    {
        int[,] multiplicationTableMatrix = new int[columnsAmount, rowsAmount];

        for (int i = 0; i < columnsAmount; i++)
        {
            for (int j = 0; j < rowsAmount; j++)
            {
                multiplicationTableMatrix[i, j] = (i + 1) * (j + 1);
            }
        }

        return multiplicationTableMatrix;
    }
}