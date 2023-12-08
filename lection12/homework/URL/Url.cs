namespace Url;

internal class Url
{
    static void Main(string[] args)
    {
        string url1 = "http://SomeServerName/abcd/dfdf.htm?dfdf=dfdf";
        string url2 = "ftp://SomeServerName";
        string url3 = "https://";

        Console.WriteLine("Имя сервера: " + GetServerName(url1));
        Console.WriteLine("Имя сервера: " + GetServerName(url2));
        Console.WriteLine("Имя сервера: " + GetServerName(url3));
    }

    public static string GetServerName(string url)
    {
        int serverNameFirstIndex = url.IndexOf("://") + 3;
        int serverNameLastIndex = url.IndexOf('/', serverNameFirstIndex);
        int serverNameLength = serverNameLastIndex != -1 ? serverNameLastIndex - serverNameFirstIndex : url.Length - serverNameFirstIndex;

        return url.Substring(serverNameFirstIndex, serverNameLength);
    }

    // этот метод выглядит лучше :D
    //public static string GetServerNameNaive(string url)
    //{
    //    string[] array = url.Split('/');
    //    return array[2];
    //}
}
