namespace Rectangle
{
    internal class Rectangle
    {
        static void Main(string[] args)
        {
            Console.Write("Введите ширину прямоугольника: ");
            double length = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите длину прямоугольника: ");
            double width = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();

            double area = length * width;
            double perimeter = 2 * (length + width);
            Console.WriteLine($"Длина = {width:F2} Ширина = {length:F2} Площадь = {area:F2} Периметр = {perimeter:F2}");
        }
    }
}