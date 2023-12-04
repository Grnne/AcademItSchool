namespace RectangleAreaAndPerimeter
{
    internal class RectangleAreaAndPerimeter
    {
        static void Main(string[] args)
        {
            Console.Write("Введите ширину прямоугольника: ");
            double width = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите длину прямоугольника: ");
            double length = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();

            double area = width * length;
            double perimeter = 2 * (width + length);
            Console.WriteLine($"Площадь = {area:F2}. Периметр = {perimeter:F2}");
        }
    }
}