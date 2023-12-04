namespace Range;

internal class MarkedRangesCalculator
{
    static void Main(string[] args)
    {
        Console.WriteLine("Программа суммирует длины введенных пользователем отрезков, если указанная пользователем точка лежит на этих отрезках.");
        Console.WriteLine("Все координаты находится на одной линии.");
        Console.WriteLine();

        double point = 0;
        int selector = 0;
        List<Range> ranges = new();

        while (selector < 4)
        {
            Console.WriteLine("Введите 1 для ввода координат отрезка, 2 для точки, 3 если хотите вычислить сумму, другое число для выхода.");

            Console.Write("Введите число: ");
            selector = int.Parse(Console.ReadLine()!);

            switch (selector)
            {
                case 1:
                    ranges.Add(CreateRange());
                    break;
                case 2:
                    Console.Write("Введите координату точки: ");
                    point = double.Parse(Console.ReadLine()!);
                    break;
                case 3:
                    Console.WriteLine($"Сумма длин отрезков, которым принадлежит точка = {GetMarkedRangesLengthSum(ranges, point)}");
                    selector = 4;
                    break;
                default:
                    selector = 4;
                    break;
            }
        }
    }

    public static Range CreateRange()
    {
        Range range = new(0, 0);

        Console.Write("Введите первую координату отрезка: ");
        range.From = double.Parse(Console.ReadLine()!);

        Console.Write("Введите вторую координату отрезка: ");
        range.To = double.Parse(Console.ReadLine()!);

        return range;
    }

    public static double GetMarkedRangesLengthSum(List<Range> ranges, double point)
    {
        double result = 0;

        foreach (Range range in ranges)
        {
            if (range.IsInside(point))
            {
                result += range.GetLength();
            }
        }

        return result;
    }
}