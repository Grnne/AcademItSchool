namespace CircleArea
{
    internal class CircleAreaAndMathStuff
    {
        static void Main(string[] args)
        {
            double radius = 10;
            double area = Math.PI * Math.Pow(radius, 2);
            Console.WriteLine($"Площадь круга с радиусом {radius}: {area}");
            Console.WriteLine();

            double x = 15;
            x = Math.Pow(x, 5);
            x = Math.Sqrt(x);
            x = Math.Log(x);
            x = Math.Sin(x);
            x = Math.Abs(x);
            x = Math.Round(x, MidpointRounding.AwayFromZero);
            Console.WriteLine($"Какое-то число: {x}");
        }
    }
}