namespace FileToUpper;

internal class FileToUpper
{
    static void Main(string[] args)
    {
        string path = "..\\..\\..\\";

        using StreamReader streamReader = new(path + "input.txt");
        using StreamWriter streamWriter = new(path + "output.txt");
        string currentLine;

        while ((currentLine = streamReader.ReadLine()!) != null)
        {
            streamWriter.WriteLine(currentLine.ToUpper());
        }
    }
}