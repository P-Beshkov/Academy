/* 18. Write a program for extracting all email addresses from given text. 
 * All substrings that match the format <identifier>@<host>…<domain> should 
 * be recognized as emails. */
using System;
using System.Text.RegularExpressions;

class ExtractEmails
{
    static void Main()
    {
        string text = "zuzi@kaval.bg;; ciki@duduk.net, " +
    "bob@mail.bg\n\nfn12345@fmi.uni-sofia.bg\n" +
    "    mente@eu.int | , , ;;; gero@dir.bg";
        string pattern = @"\w+@\w+\.\w+";
        MatchCollection matches = Regex.Matches(text, pattern);
        foreach (Match match in matches)
        {
            Console.WriteLine(match);
        }

    }
}