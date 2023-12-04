namespace Age
{
    internal class Age
    {
        static void Main(string[] args)
        {
            Console.Write("Введите возраст: ");
            int age = int.Parse(Console.ReadLine()!);

            if (age < 1)
            {
                Console.WriteLine("Вы слишком молоды");
            }
            else if (age > 112)
            {
                Console.WriteLine("Вы слишком стары");
            }
            else
            {
                int twoLastAgeDigits = age % 100;
                int lastAgeDigit = twoLastAgeDigits % 10;
                string ageString;

                if (twoLastAgeDigits >= 5 && twoLastAgeDigits <= 20)
                {
                    ageString = "лет";
                }
                else if (lastAgeDigit == 1)
                {
                    ageString = "год";
                }
                else if (lastAgeDigit >= 2 && lastAgeDigit <= 4)
                {
                    ageString = "года";
                }
                else
                {
                    ageString = "лет";
                }

                Console.WriteLine($"Вам {age} {ageString}");
            }
        }
    }
}