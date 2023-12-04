namespace IfElseChainWithConsoleInput
{
    internal class IfElseChainWithConsoleInput
    {
        static void Main(string[] args)
        {
            Console.Write("Введите целое число: ");
            int number = int.Parse(Console.ReadLine()!);

            if (number > 0)
            {
                Console.WriteLine("Данное число - положительное");
            }
            else if (number == 0)
            {
                Console.WriteLine("Данное число равно нулю");
            }
            else
            {
                Console.WriteLine("Данное число меньше нуля");
            }
        }
    }
}