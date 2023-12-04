namespace PrintAndRead
{
    internal class PrintAndRead
    {
        static void Main(string[] args)
        {
            int number1 = WriteStringAndReadInt("Введите число 1: ");
            int number2 = WriteStringAndReadInt("Введите число 2: ");
        }

        public static int WriteStringAndReadInt(string inputPrompt)
        {
            Console.Write(inputPrompt);
            return int.Parse(Console.ReadLine()!);
        }
    }
}