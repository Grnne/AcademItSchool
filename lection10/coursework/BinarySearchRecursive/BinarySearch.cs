namespace BinarySearch;

internal class BinarySearch
{
    static void Main(string[] args)
    {
        int[] array = { -1, 0, 3, 5, 9, 12 };

        Console.WriteLine(BinarySearchRecursive(array, 3));
        Console.WriteLine(BinarySearchRecursive(array, 9));
        Console.WriteLine(BinarySearchRecursive(array, 2));

        Console.WriteLine(BinarySearchNonRecursive(array, 6));
        Console.WriteLine(BinarySearchNonRecursive(array, 11));
    }

    public static int BinarySearchRecursive(int[] array, int targetNumber) => BinarySearchRecursive(array, targetNumber, 0, array.Length - 1);

    private static int BinarySearchRecursive(int[] array, int targetNumber, int left, int right)
    {
        if (left > right)
        {
            return -1;
        }

        int middle = left + (right - left) / 2;

        if (array[middle] == targetNumber)
        {
            return middle;
        }

        if (targetNumber < array[middle])
        {
            return BinarySearchRecursive(array, targetNumber, left, middle - 1);
        }

        return BinarySearchRecursive(array, targetNumber, middle + 1, right);
    }

    public static int BinarySearchNonRecursive(int[] array, int targetNumber)
    {
        int left = 0;
        int right = array.Length - 1;

        while (left <= right)
        {
            int middle = left + (right - left) / 2;

            if (array[middle] == targetNumber)
            {
                return middle;
            }

            if (targetNumber > array[middle])
            {
                left = middle + 1;
            }
            else
            {
                right = middle - 1;
            }
        }

        return -1;
    }
}
