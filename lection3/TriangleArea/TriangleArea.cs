namespace TriangleArea
{
    internal class TriangleArea
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите координаты ваших точек.");

            double x1 = ReadDouble("x1");
            double y1 = ReadDouble("y1");
            double x2 = ReadDouble("x2");
            double y2 = ReadDouble("y2");
            double x3 = ReadDouble("x3");
            double y3 = ReadDouble("y3");

            if (IsPointsOnLine(x1, y1, x2, y2, x3, y3))
            {
                Console.WriteLine("Это не треугольник, все точки лежат на одной прямой или в одном месте");
            }
            else
            {
                double sideLength1 = CalculateSideLength(x1, y1, x2, y2);
                double sideLength2 = CalculateSideLength(x2, y2, x3, y3);
                double sideLength3 = CalculateSideLength(x3, y3, x1, y1);

                double semiperimeter = (sideLength1 + sideLength2 + sideLength3) / 2;
                double triangleArea = Math.Sqrt(semiperimeter * (semiperimeter - sideLength1) * (semiperimeter - sideLength2) * (semiperimeter - sideLength3));
                Console.WriteLine($"Площадь треугольника = {triangleArea}");
            }
        }

        public static double ReadDouble(string name)
        {
            Console.Write($"Введите {name}: ");
            return double.Parse(Console.ReadLine()!);
        }

        public static double CalculateSideLength(double x1, double y1, double x2, double y2) => Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

        public static bool IsPointsOnLine(double x1, double y1, double x2, double y2, double x3, double y3)
        {
            const double epsilon = 1.0e-10;
            return Math.Abs(x3 * (y2 - y1) - y3 * (x2 - x1) - (x1 * y2 - x2 * y1)) <= epsilon;
        }
    }
}