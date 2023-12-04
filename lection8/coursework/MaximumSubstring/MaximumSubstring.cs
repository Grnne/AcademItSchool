namespace MaximumSubstring;

internal class MaximumSubstring
{
    static void Main(string[] args)
    {
        Console.WriteLine(GetMaxSubstringLength("abcdeEefg"));
        Console.WriteLine(GetMaxSubstringLength(""));
    }

    public static int GetMaxSubstringLength(string line)
    {
        if (string.IsNullOrEmpty(line))
        {
            return 0;
        }

        if (line.Length == 1)
        {
            return 1;
        }

        int maxSubstringLength = 1;
        int substringLength = 1;
        line = line.ToLower();

        for (int i = 0; i < line.Length - 1; i++)
        {
            if (line[i] == line[i + 1])
            {
                substringLength++;
                maxSubstringLength = Math.Max(maxSubstringLength, substringLength);
            }
            else
            {
                substringLength = 1;
            }
        }

        return maxSubstringLength;
    }
}