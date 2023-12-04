namespace Palindrome;
internal class Palindrome
{
    static void Main(string[] args)
    {
        Console.WriteLine(IsPalindrome("роза азо1р"));
        Console.WriteLine(IsPalindrome("Ten1e1t"));
        Console.WriteLine(IsPalindrome("aadjj11"));
        Console.WriteLine(IsPalindrome("121312"));
        Console.WriteLine(IsPalindrome("1"));
        Console.WriteLine(IsPalindrome(""));
    }

    public static bool IsPalindrome(string line)
    {
        line = line.ToLower();

        int startIndex = 0;
        int endIndex = line.Length - 1;

        while (startIndex < endIndex)
        {
            while (!char.IsLetter(line[startIndex]) && startIndex != endIndex)
            {
                startIndex++;
            }

            while (!char.IsLetter(line[endIndex]) && startIndex != endIndex)
            {
                endIndex--;
            }

            if (line[startIndex] != line[endIndex])
            {
                return false;
            }

            startIndex++;
            endIndex--;
        }

        return true;
    }
}