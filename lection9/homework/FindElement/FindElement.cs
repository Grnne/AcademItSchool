namespace FindElement;

internal class FindElement
{
    static void Main(string[] args)
    {
        int[] array = { 1, 2, 3, 4, 0, 6 };

        Console.WriteLine(GetElementIndex(0, array));
    }

    public static int GetElementIndex(int number, int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == number)
            {
                return i;
            }
        }

        return -1;
    }
}