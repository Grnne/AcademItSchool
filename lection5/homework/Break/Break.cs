namespace Break
{
    internal class Break
    {
        static void Main(string[] args)
        {
            string guessedWord = "сорока";

            while (true)
            {
                Console.Write("Напишите слово, в котором сорок гласных (с маленькой буквы): ");
                string guess = Console.ReadLine()!;

                if (guess == guessedWord)
                {
                    Console.WriteLine("Верно");
                    break;
                }

                Console.WriteLine("Неверно");
            }
        }
    }
}