namespace FibonacciNumbers
{
    internal class FibonacciNumbers
    {
        static void Main(string[] args)
        {
            Console.Write("Введите номер нужного вам числа в ряду Фибоначчи: ");
            int fibonacciNumberIndex = int.Parse(Console.ReadLine()!);

            if (fibonacciNumberIndex == 0)
            {
                Console.WriteLine("Число под индексом 0 = 0");
            }
            else if (fibonacciNumberIndex == 1)
            {
                Console.WriteLine("Число под индексом 1 = 1");
            }
            else
            {
                int previousFibonacciNumber = 0;
                int currentFibonacciNumber = 1;
                int i = 0;

                while (i <= fibonacciNumberIndex - 2) // Оффсет по количеству уже введенных членов
                {
                    int nextFibonacciNumber = previousFibonacciNumber + currentFibonacciNumber;
                    previousFibonacciNumber = currentFibonacciNumber;
                    currentFibonacciNumber = nextFibonacciNumber;

                    i++;
                }

                Console.WriteLine($"Число под номером {fibonacciNumberIndex} = {currentFibonacciNumber}");
            }
        }
    }
}