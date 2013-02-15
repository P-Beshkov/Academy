/* 13. Write a program that reverses the words in given sentence. 	
 * Example: "C# is not C++, not PHP and not Delphi!" 
 * ->"Delphi not and PHP, not C++ not is C#!". */
using System;
using System.Collections.Generic;
using System.Text;

class Program
{
    static void Main()
    {
        string sentence = "C# is not C++, not PHP and not Delphi!";
        string[] words = sentence.Split(new char[] {' ',',','!',':' }, StringSplitOptions.RemoveEmptyEntries);
        Stack<string> wordStack = new Stack<string>();
        foreach (string word in words)
        {
            wordStack.Push(word);
        }
        StringBuilder buffer = new StringBuilder();
        while (wordStack.Count!=0)
        {
            buffer.Append(wordStack.Pop()+" ");
            
        }
        Console.WriteLine(buffer.ToString());
    }
}