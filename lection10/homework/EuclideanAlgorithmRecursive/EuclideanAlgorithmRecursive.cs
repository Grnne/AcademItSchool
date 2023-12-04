namespace EuclideanAlgorithmRecursive;

internal class EuclideanAlgorithmRecursive
{
    static void Main(string[] args)
    {
        Console.WriteLine("Поиск наибольшего общего делителя. Введите два числа.");

        Console.Write("Введите первое число: ");
        int number1 = Math.Abs(int.Parse(Console.ReadLine()!));

        Console.Write("Введите второе число: ");
        int number2 = Math.Abs(int.Parse(Console.ReadLine()!));

        int? greatestCommonDivisor = GetGreatestCommonDivisor(number1, number2);

        if (greatestCommonDivisor is null)
        {
            Console.WriteLine("Наибольший общий делитель отсутствует");
        }
        else
        {
            Console.WriteLine($"Наибольший общий делитель: {greatestCommonDivisor}");
        }
    }

    public static int? GetGreatestCommonDivisor(int number1, int number2)
    {
        if (number1 == 0 && number2 == 0)
        {
            return null;
        }

        if (number2 == 0)
        {
            return number1;
        }

        return GetGreatestCommonDivisor(number2, number1 % number2);
    }
}
