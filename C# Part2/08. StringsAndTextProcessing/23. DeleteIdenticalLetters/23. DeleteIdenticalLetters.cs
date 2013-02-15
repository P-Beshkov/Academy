/* 23. Write a program that reads a string from the console and replaces
 * all series of consecutive identical letters with a single one. 
 * Example: "aaaaabbbbbcdddeeeedssaa"  "abcdedsa". */
using System;
using System.Text;
class DeleteIdenticalLetters
{
    static void Main()
    {
        StringBuilder buffer = new StringBuilder();
        string workText = "aaaaabbbbbcdddeeeedssaa";
        string editedText;
        buffer.Append(workText[0]);
        for (int i = 1; i < workText.Length; i++)
        {
            if (workText[i] != workText[i - 1])
            {
                buffer.Append(workText[i]);
            }
        }
        editedText = buffer.ToString();
        Console.WriteLine(editedText);
    }
}