namespace EuclideanAlgorithm
{
    internal class EuclideanAlgorithm
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Поиск наибольшего общего делителя. Введите два числа.");

            Console.Write("Введите первое число: ");
            int number1 = Math.Abs(int.Parse(Console.ReadLine()!));

            Console.Write("Введите второе число: ");
            int number2 = Math.Abs(int.Parse(Console.ReadLine()!));

            if (number1 == 0 && number2 == 0)
            {
                Console.WriteLine("Оба числа равны нулю, НОДа нет");
            }
            else
            {
                while (number2 != 0)
                {
                    int temp = number2;
                    number2 = number1 % number2;
                    number1 = temp;
                }

                Console.WriteLine($"Общий делитель = {number1}");
            }
        }
    }
}