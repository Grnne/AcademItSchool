namespace SelectionSort;

internal class SelectionSort
{
    static void Main(string[] args)
    {
        int[] array = { 1, 2, 3, 4, 0, 6 };

        Sort(array);
        Console.WriteLine(string.Join(' ', array));
    }

    public static void Sort(int[] array)
    {
        for (int i = 0; i < array.Length - 1; i++)
        {
            int minIndex = i;

            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[j] < array[minIndex])
                {
                    minIndex = j;
                }
            }

            (array[i], array[minIndex]) = (array[minIndex], array[i]);
        }
    }
}