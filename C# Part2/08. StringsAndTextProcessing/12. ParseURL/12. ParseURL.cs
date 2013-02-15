/* 12. Write a program that parses an URL address given in the format:
 * [protocol]://[server]/[resource]
 * and extracts from it the [protocol], [server] and [resource] elements. 
 * For example from the URL http://www.devbg.org/forum/index.php the 
 * following information should be extracted:
 * [protocol] = "http"
 * [server] = "www.devbg.org"
 * [resource] = "/forum/index.php" */
using System;

class Program
{
    static void Main()
    {
        string url = "http://www.devbg.org/forum/index.php";
        int index=url.IndexOf("://");
        string protocol = url.Substring(0, index);
        int indexSlash = url.IndexOf("/", index + 3);
        string server = url.Substring(index + 3, indexSlash - index + 1-protocol.Length);
        string resource = url.Substring(indexSlash);
        Console.WriteLine("[protocol] = "+protocol);
        Console.WriteLine("[server] = "+server);
        Console.WriteLine("[resource] =" + resource);
    }
}