namespace QuickSort;

internal class QuickSort
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
        Sort(array, 0, array.Length - 1);
    }

    public static void Sort(int[] array, int left, int right)
    {
        if (right - left + 1 <= 1)
        {
            return;
        }

        if (right - left + 1 == 2)
        {
            if (array[left] > array[right])
            {
                (array[left], array[right]) = (array[right], array[left]);
            }

            return;
        }

        int pivot = array[left];
        int i = left;
        int j = right;

        while (i <= j)
        {
            while (array[i] < pivot)
            {
                i++;
            }

            while (array[j] > pivot)
            {
                j--;
            }

            if (i <= j)
            {
                (array[i], array[j]) = (array[j], array[i]);
                i++;
                j--;
            }
        }

        if (i < right)
        {
            Sort(array, i, right);
        }

        if (j > left)
        {
            Sort(array, left, j);
        }
    }
}