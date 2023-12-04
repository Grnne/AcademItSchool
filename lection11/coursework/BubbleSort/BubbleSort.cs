namespace BubbleSort;

internal class BubbleSort
{
    static void Main(string[] args)
    {
        int[] array = { 10, 2, 8, 1, 4, 7, 70, 0 };
        Sort(array);
        Console.WriteLine(string.Join(", ", array));

        array = new int[] { 6, 1, 10, 3, 3, 6, 2, 4, 2, 10, 10, 9, 3, 10, 2, 2, 5, 9, 10, 8, 3, 10, 9, 0, -int.MaxValue };
        Sort(array);
        Console.WriteLine(string.Join(", ", array));

        array = Array.Empty<int>();
        Sort(array);
        Console.WriteLine(string.Join(", ", array));

        array = new int[] { 0 };
        Sort(array);
        Console.WriteLine(string.Join(", ", array));

        array = new int[] { 1, 2, 3, 4, 6, 5 };
        Sort(array);
        Console.WriteLine(string.Join(", ", array));
    }

    public static void Sort(int[] array)
    {
        int length = array.Length;

        for (int i = 0; i < length - 1; i++)
        {
            bool isSorted = true;

            for (int j = 0; j < length - 1 - i; j++)
            {
                if (array[j] > array[j + 1])
                {
                    (array[j], array[j + 1]) = (array[j + 1], array[j]);
                    isSorted = false;
                }
            }

            if (isSorted)
            {
                return;
            }
        }
    }
}