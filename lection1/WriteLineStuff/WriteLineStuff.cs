namespace WriteLineStuff
{
    internal class WriteLineStuff
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Первая строка {Environment.NewLine}Вторая строка {Environment.NewLine}Третья строка");
            Console.WriteLine();

            Console.WriteLine("\"30\" августа 1903г.");
            Console.WriteLine(@"C:\Windows\System32\Drivers\etc\hosts");
            Console.WriteLine();

            int x = (123 * 5 - 10) / 4;
            Console.WriteLine($"Результат = {x}");
        }
    }
}