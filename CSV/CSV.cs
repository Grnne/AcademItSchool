namespace CSV;

internal class CSV
{
    static void Main(string[] args)
    {
        string path = "..\\..\\..\\";
        using StreamReader streamReader = new(path + "input.csv");

        string allLines = streamReader.ReadToEnd();
        
        string[] stringArray = allLines.Split(',');


    }
}
