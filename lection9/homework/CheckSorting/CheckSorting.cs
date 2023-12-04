namespace CheckSorting;

internal class CheckSorting
{
    static void Main(string[] args)
    {
        int[] array1 = { 10, 9, 8, 7, 2 };
        int[] array2 = { 1, 2, 3, 4, 5 };
        int[] array3 = { 1, 1, 1, 1, 1 };
        int[] array4 = { 1 };

        Console.WriteLine($"{IsArrayAscending(array1)} {IsArrayAscending(array2)}");
        Console.WriteLine($"{IsArrayDescending(array1)} {IsArrayDescending(array2)}");
        Console.WriteLine($"{IsArrayAscending(array3)} {IsArrayDescending(array3)}");
        Console.WriteLine($"{IsArrayAscending(array4)} {IsArrayDescending(array4)}");
    }

    public static bool IsArrayAscending(int[] array)
    {
        if (array.Length < 2)
        {
            return true;
        }

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i - 1] > array[i])
            {
                return false;
            }
        }

        return true;
    }

    public static bool IsArrayDescending(int[] array)
    {
        if (array.Length < 2)
        {
            return true;
        }

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i - 1] < array[i])
            {
                return false;
            }
        }

        return true;
    }
}