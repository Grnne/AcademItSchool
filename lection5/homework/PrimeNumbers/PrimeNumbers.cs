namespace PrimeNumbers
{
    internal class PrimeNumbers
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            int limitNumber = int.Parse(Console.ReadLine()!);

            if (limitNumber < 2)
            {
                Console.WriteLine("На этом промежутке нет простых чисел");
            }
            else
            {
                Console.WriteLine("Список простых чисел до введенного числа:");

                for (int i = 2; i <= limitNumber; i++)
                {
                    if (IsPrime(i))
                    {
                        Console.WriteLine(i);
                    }
                }
            }
        }

        public static bool IsPrime(int number)
        {
            int limitNumber = (int)Math.Sqrt(number);

            for (int i = 2; i <= limitNumber; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}