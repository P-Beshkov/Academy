/*10. Write a program that converts a string to a sequence of C# Unicode
 * character literals. Use format strings. Sample input: Hi!
 * Expected output: \u0048\u0069\u0021 */
using System;

class Program
{
    static void Main()
    {
        string testString = "Hi!";
        foreach (char symbol in testString)
        {
            Console.Write("\\u{0:X4}",(int)symbol);
        }
    }
}