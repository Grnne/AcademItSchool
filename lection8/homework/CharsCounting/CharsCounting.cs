namespace CharsCounting
{
    internal class CharsCounting
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку:");
            string line = Console.ReadLine()!;

            int lettersAmount = 0;
            int digitsAmount = 0;
            int whiteSpacesAmount = 0;

            foreach (char c in line)
            {
                if (char.IsLetter(c))
                {
                    lettersAmount++;
                }
                else if (char.IsDigit(c))
                {
                    digitsAmount++;
                }
                else if (char.IsWhiteSpace(c))
                {
                    whiteSpacesAmount++;
                }
            }

            int otherCharsAmount = line.Length - lettersAmount - digitsAmount - whiteSpacesAmount;
            Console.WriteLine($"Количество букв: {lettersAmount} кол-во цифр: {digitsAmount}; кол-во пробелов: {whiteSpacesAmount}; кол-во остальных символов: {otherCharsAmount}");
        }
    }
}