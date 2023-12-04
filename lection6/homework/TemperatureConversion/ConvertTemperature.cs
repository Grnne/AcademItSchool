namespace ConvertTemperature
{
    internal class ConvertTemperature
    {
        static void Main(string[] args)
        {
            Console.Write("Введите значение температуры в градусах Цельсия: ");
            double celsiusTemperature = double.Parse(Console.ReadLine()!);

            Console.WriteLine("Температура в градусах Фаренгейта: " + ConvertToFahrenheitTemperature(celsiusTemperature));
            Console.WriteLine("Температура в градусах Кельвина: " + ConvertToKelvinTemperature(celsiusTemperature));
        }

        public static double ConvertToFahrenheitTemperature(double celsiusTemperature) => celsiusTemperature * 1.8 + 32;

        public static double ConvertToKelvinTemperature(double celsiusTemperature) => celsiusTemperature + 273.15;
    }
}