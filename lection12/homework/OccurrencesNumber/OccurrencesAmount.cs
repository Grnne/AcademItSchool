namespace OccurrencesAmount;

internal class OccurrencesAmount
{
    static void Main(string[] args)
    {
        string path = "..\\..\\..\\Content\\txt\\";
        using StreamReader streamReader = new(path + "input.txt");

        string currentLine;
        int occurrencesAmount = 0;
        string desiredSubstring = "SHALL";

        while ((currentLine = streamReader.ReadLine()!) != null)
        {
            int currentLineOccurrencesAmount = GetOccurrencesAmount(currentLine, desiredSubstring);
            occurrencesAmount += currentLineOccurrencesAmount;
        }

        Console.WriteLine($"Количество вхождений подстроки {desiredSubstring} в данный текст: {occurrencesAmount}");
    }

    public static int GetOccurrencesAmount(string line, string substring)
    {
        int occurrencesAmount = 0;
        int index = 0;

        while (true)
        {
            index = line.IndexOf(substring, index, StringComparison.OrdinalIgnoreCase);

            if (index == -1)
            {
                break;
            }

            index += substring.Length;
            occurrencesAmount++;
        }

        return occurrencesAmount;
    }
}