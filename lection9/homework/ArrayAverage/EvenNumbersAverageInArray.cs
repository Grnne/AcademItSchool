namespace EvenNumbersAverageInArray;

internal class EvenNumbersAverageInArray
{
    static void Main(string[] args)
    {
        int[] array = { 1, 2, 3, 4, 0, 6 };
        Console.WriteLine(GetEvenNumbersAverageInArray(array));
    }

    public static double GetEvenNumbersAverageInArray(int[] array)
    {
        int sum = 0;
        int count = 0;

        foreach (int number in array)
        {
            if (number % 2 == 0)
            {
                sum += number;
                count++;
            }
        }

        return (double)sum / count;
    }
}