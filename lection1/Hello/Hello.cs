namespace Hello
{
    internal class Hello
    {
        static void Main(string[] args)
        {
            Console.Write("Введите ваше имя: ");
            string name = Console.ReadLine()!; // Чего он предупреждает, инпут же не будет нулл, даже если просто энтер нажать.

            Console.WriteLine($"Привет, {name}!");
        }
    }
}