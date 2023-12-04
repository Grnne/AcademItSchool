namespace InsertionSort;

internal class InsertionSort
{
    static void Main(string[] args)
    {
        int[] array = { 10, 2, 8, 1, 4, 7, 14, 63 };
        Sort(array);
        Console.WriteLine(string.Join(", ", array));

        array = new int[] { 6, 1, 10, 3, 3, 6, 2, 4, 2, 10, 10, 9, 3, 10, 2, 2, 5, 9, 10, 8, 3, 10, 9, -int.MaxValue, int.MaxValue };
        Sort(array);
        Console.WriteLine(string.Join(", ", array));

        array = Array.Empty<int>();
        Sort(array);
        Console.WriteLine(string.Join(", ", array));

        array = new int[] { 0 };
        Sort(array);
        Console.WriteLine(string.Join(", ", array));

        array = new int[] { 0, 0, 0, 0, 0, 0 };
        Sort(array);
        Console.WriteLine(string.Join(", ", array));
    }

    public static void Sort(int[] array)
    {
        for (int i = 1; i < array.Length; i++)
        {
            int temp = array[i];
            int j = i - 1;

            while (j >= 0 && array[j] > temp)
            {
                array[j + 1] = array[j];
                j--;
            }

            array[j + 1] = temp;
        }
    }
}