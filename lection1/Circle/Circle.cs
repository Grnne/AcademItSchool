namespace Circle
{
    internal class Circle
    {
        static void Main(string[] args)
        {
            //  Площадь круга и длина окружности
            double radius = 5;
            double area = Math.PI * Math.Pow(radius, 2);
            double perimeter = 2 * Math.PI * radius;
            Console.WriteLine($"Площадь круга = {area}. Периметр = {perimeter}");
            Console.WriteLine();
            //TODO  Хочется округлить пи, но в условиях задачи ничего про это не говорится

            area = 100.5;
            radius = Math.Sqrt(area / Math.PI);
            Console.WriteLine($"Радиус круга = {radius}");
            Console.WriteLine();

            radius = 5;
            double angle = 360;
            area = Math.PI * Math.Pow(radius, 2) * (angle / 360);
            Console.WriteLine($"Площадь сектора = {area}");
        }
    }
}