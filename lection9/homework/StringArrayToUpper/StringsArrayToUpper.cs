namespace StringsArrayToUpper;

internal class StringsArrayToUpper
{
    static void Main(string[] args)
    {
        string[] array = { "aaa", "bbb", "ccc", "dDd" };

        ConvertStringsArrayToUpper(array);
        Console.WriteLine(string.Join(' ', array));
    }

    public static void ConvertStringsArrayToUpper(string[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = array[i].ToUpper();
        }
    }
}