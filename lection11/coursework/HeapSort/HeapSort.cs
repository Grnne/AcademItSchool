namespace HeapSort;

internal class HeapSort
{
    static void Main(string[] args)
    {
        int[] array = { 10, 2, 8, 1, 4, 7, 70, 63 };
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
        int length = array.Length;

        for (int i = length / 2 - 1; i >= 0; i--)
        {
            Sift(array, length, i);
        }

        for (int i = length - 1; i > 0; i--)
        {
            (array[0], array[i]) = (array[i], array[0]);
            Sift(array, i, 0);
        }
    }

    public static void Sift(int[] array, int length, int index)
    {
        while (true)
        {
            int maxIndex = index;
            int child1Index = index * 2 + 1;
            int child2Index = index * 2 + 2;

            if (child1Index < length && array[child1Index] > array[maxIndex])
            {
                maxIndex = child1Index;
            }

            if (child2Index < length && array[child2Index] > array[maxIndex])
            {
                maxIndex = child2Index;
            }

            if (maxIndex == index)
            {
                return;
            }

            (array[index], array[maxIndex]) = (array[maxIndex], array[index]);
            index = maxIndex;
        }
    }
}