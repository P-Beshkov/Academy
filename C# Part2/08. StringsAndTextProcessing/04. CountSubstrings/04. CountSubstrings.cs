//04. Write a program that finds how many times a substring is 
//contained in a given text (perform case insensitive search).

using System;

class Program
{
    static void Main()
    {
        string text = "We are living in an yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
        string substring = "iN";
        int count = CountSubstringInText(substring,text);
        Console.WriteLine("Count = {0}",count);
    }

    private static int CountSubstringInText(string substring, string text)
    {
        string lowText = text.ToLower();
        string lowSubstring = substring.ToLower();
        int count = 0;

        int startIndex = lowText.IndexOf(lowSubstring);

        while (startIndex!=-1)
        {
            count++;
            startIndex = lowText.IndexOf(lowSubstring,startIndex+substring.Length);
        }
        return count;        
    }
}