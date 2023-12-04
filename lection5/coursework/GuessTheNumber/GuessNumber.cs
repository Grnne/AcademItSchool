namespace GuessNumber
{
    internal class GuessNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Угадайте число в пределах от 1 до 100 включительно");

            Random random = new();
            int randomNumber = random.Next(1, 101);

            int attemptsAmount = 0;

            while (true)
            {
                attemptsAmount++;

                Console.Write("Введите число: ");
                int number = int.Parse(Console.ReadLine()!);

                if (number == randomNumber)
                {
                    Console.WriteLine($"Бинго! Получилось с {attemptsAmount} попытки.");
                    break;
                }

                if (number > randomNumber)
                {
                    Console.WriteLine($"Число больше искомого. Количество попыток - {attemptsAmount}.");
                }
                else
                {
                    Console.WriteLine($"Число меньше искомого. Количество попыток - {attemptsAmount}.");
                }
            }
        }
    }
}