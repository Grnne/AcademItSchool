namespace ArrayReverse;

internal class ArrayReverse
{
    public static void Main(string[] args)
    {
        int[] array = { 1, 2, 3, 4, 0, 6 };

        ReverseArray(array);
        Console.WriteLine(string.Join(' ', array));
    }

    public static void ReverseArray(int[] array)
    {
        int halfLength = array.Length / 2;

        for (int i = 0,  j = 0 ; i < halfLength; i++)
        {
            int temp = array[i];
            array[i] = array[^(1 + i)];
            array[^(1 + i)] = temp;
        }
    }
}