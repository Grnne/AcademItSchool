using System.Text;

namespace OccurrencesAmount;

internal class OccurrencesAmount
{
    static void Main(string[] args)
    {
        string path = "..\\..\\..\\Content\\txt\\";
        using StreamReader streamReader = new(path + "input.txt");
        
        string currentLine;
        int count = 0;
        string desiredSubstring = "SHALL";

        while ((currentLine = streamReader.ReadLine()!) != null)
        {
            int currentLineOccurrencesAmount = CountSubstringsInString(currentLine, desiredSubstring);

            if (currentLineOccurrencesAmount != -1)
            {
                count += currentLineOccurrencesAmount;
            }
        }

        Console.WriteLine($"Количество вхождений подстроки {desiredSubstring} в данный текст: {count}");
    }

    public static int CountSubstringsInString(string stringLine, string substring)
    {
        int count = 0;
        int index = -1;

        do
        {
            index = stringLine.IndexOf(substring, index + 1, StringComparison.OrdinalIgnoreCase);

            if (index == -1)
            {
                break;
            }

            count++;
        }
        while (index != -1);

        return count;
    }
}