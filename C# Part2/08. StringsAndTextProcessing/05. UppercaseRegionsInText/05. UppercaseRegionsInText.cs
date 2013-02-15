/*05. You are given a text. Write a program that changes the text in all
* regions surrounded by the tags <upcase> and </upcase> to uppercase. 
* The tags cannot be nested. Example:
* We are living in a <upcase>yellow submarine</upcase>. We don't have
* <upcase>anything</upcase> else.
* The expected result:
* We are living in a YELLOW SUBMARINE. We don't have ANYTHING else.*/

using System;
using System.Text;

class Program
{
    static private string ExecuteUpcaseTags(string text)
    {
        StringBuilder buffer = new StringBuilder();
        int startIndex,
            endIndex;
        startIndex = text.IndexOf("<upcase>");
        if (startIndex==-1)
        {
            throw new ArgumentException("Argument doesn't have upcase tags");
        }
        endIndex = text.IndexOf("</upcase>", startIndex + 7);
        if (endIndex==-1)
        {
            throw new ArgumentException("Invalid text");
        }
        buffer.Append(text.Substring(0, startIndex));
        while (startIndex!=-1)
        {
            int forUpperLenght = endIndex - startIndex - 8;
            string forUpper = text.Substring(startIndex + 8, forUpperLenght);
            buffer.Append(forUpper.ToUpper());
            startIndex = text.IndexOf("<upcase>",endIndex);
            if (startIndex==-1)
            {
                buffer.Append(text.Substring(endIndex + 9));
                return buffer.ToString();
            }
            buffer.Append(text.Substring(endIndex + 9, startIndex - endIndex - 9));
            endIndex = text.IndexOf("</upcase>", startIndex + 8);
        }
        return buffer.ToString();
    }
    static void Main()
    {
        string text = "We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.";
        Console.WriteLine(ExecuteUpcaseTags(text));
    }
}