namespace StringSplit;

internal class StringSplit
{
    static void Main(string[] args)
    {
        string numbersString1 = "1,2,3,4,5,6";
        Console.WriteLine($"Сумма цифр в строке: {GetNumbersSumFromString(numbersString1)}");

        string numbersString2 = "10,20,30,40,50,60";
        Console.WriteLine($"Сумма цифр в строке: {GetNumbersSumFromString(numbersString2)}");
    }

    public static int GetNumbersSumFromString(string str)
    {
        int[] array = Array.ConvertAll(str.Split(','), Convert.ToInt32);
        return array.Sum();
    }
}