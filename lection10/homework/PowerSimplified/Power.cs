namespace Power;

internal class Power
{
    static void Main(string[] args)
    {
        Console.WriteLine(GetPowerRecursive(0, 0));
        Console.WriteLine(GetPower(0, 0));
    }

    public static int GetPowerRecursive(int number, int power)
    {
        if (power == 0)
        {
            return 1;
        }

        return GetPowerRecursive(number, power - 1) * number;
    }

    public static int GetPower(int number, int power)
    {
        int result = 1;

        for (int i = 0; i < power; i++)
        {
            result *= number;
        }

        return result;
    }
}
