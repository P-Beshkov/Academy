using System;
using System.Text.RegularExpressions;
class Program
{
    static void Main()
    {
        String text = "aaabacabababaccbacbcbccacbcbccbacccccc";
        string pattern = @"(\w*ab|\w*ac|\w*aa|\w*c)*cccccc";
        Match m = Regex.Match(text, pattern);
    }
}

