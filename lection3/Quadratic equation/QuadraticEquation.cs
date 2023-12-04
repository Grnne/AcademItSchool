namespace QuadraticEquation;

public class QuadraticEquation
{
    public const double Epsilon = 1.0e-10;

    static void Main(string[] args)
    {
        Console.WriteLine("Введите коэффициенты квадратного уравнения a,b,c.");

        Console.Write("Введите a: ");
        double a = double.Parse(Console.ReadLine()!);

        Console.Write("Введите b: ");
        double b = double.Parse(Console.ReadLine()!);

        Console.Write("Введите c: ");
        double c = double.Parse(Console.ReadLine()!);

        if (Math.Abs(a) <= Epsilon && Math.Abs(b) <= Epsilon)
        {
            if (Math.Abs(c) <= Epsilon)
            {
                Console.WriteLine("Корень может быть каким угодно");
            }
            else
            {
                Console.WriteLine("Корней нет");
            }
        }
        else if (Math.Abs(a) <= Epsilon)
        {
            CalculateLinearEquation(b, c);
        }
        else
        {
            CalculateQuadraticEquation(a, b, c);
        }
    }

    public static void CalculateQuadraticEquation(double a, double b, double c)
    {
        double discriminant = b * b - 4 * a * c;

        if (discriminant < -Epsilon)
        {
            Console.WriteLine("Дискриминант меньше 0, корней нет.");
        }
        else if (Math.Abs(discriminant) <= Epsilon)
        {
            double root = -b / (2 * a);
            Console.WriteLine($"Корень равен: {root}");
        }
        else
        {
            double root1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
            double root2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
            Console.WriteLine($"В результате получаются корни {root1} и {root2}");
        }
    }

    public static void CalculateLinearEquation(double b, double c)
    {
        double result = -c / b;
        Console.WriteLine($"Корень равен: {result}");
    }
}