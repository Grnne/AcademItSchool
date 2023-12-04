namespace FindMax;

internal class FindMax
{
    static void Main(string[] args)
    {
        double[] doubles1 = { 2.1, 3.5, 1.2, 6, 9, 10, 0, 1, -5 };
        double[] doubles2 = { -5, -3, -15 };

        Console.WriteLine(GetMax(doubles1));
        Console.WriteLine(GetMax(doubles2));
    }

    public static double GetMax(double[] array)
    {
        double max = array[0];

        foreach (double item in array)
        {
            max = Math.Max(max, item);
        }

        return max;
    }
}