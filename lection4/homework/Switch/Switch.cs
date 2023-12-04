namespace Switch
{
    internal class Switch
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите два операнда и код команды. Коды: 1 - деление, 2 - вычитание, 3 - умножение, 4 - деление.");

            Console.Write("Введите первый операнд: ");
            double operand1 = double.Parse(Console.ReadLine()!);

            Console.Write("Введите второй операнд: ");
            double operand2 = double.Parse(Console.ReadLine()!);

            Console.Write("Введите код команды: ");
            int commandCode = int.Parse(Console.ReadLine()!);

            switch (commandCode)
            {
                case 1:
                    Console.WriteLine($"Сумма операндов = {operand1 + operand2}");
                    break;
                case 2:
                    Console.WriteLine($"Разность операндов = {operand1 - operand2}");
                    break;
                case 3:
                    Console.WriteLine($"Произведение операндов = {operand1 * operand2}");
                    break;
                case 4:
                    Console.WriteLine($"Частное операндов = {operand1 / operand2}");
                    break;
                default:
                    Console.WriteLine("Командный код неверен");
                    break;
            }
        }
    }
}