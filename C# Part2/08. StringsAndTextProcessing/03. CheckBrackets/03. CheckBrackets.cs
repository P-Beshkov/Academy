//03. Write a program to check if in a given expression the 
//brackets are put correctly.
//Example of correct expression: ((a+b)/5-d).
//Example of incorrect expression: )(a+b)).

using System;
using System.Collections.Generic;

class Program
{
    static private bool AreBracketsCorrect(string expression)
    {
        Stack<char> brackets = new Stack<char>();
        foreach (char item in expression)
        {
            if (item == '(')
            {
                brackets.Push(item);
            }
            if (item == ')')
            {
                if (brackets.Count == 0)
                {
                    return false;
                }
                brackets.Pop();
            }
        }
        return brackets.Count == 0;
    }
    static void Main()
    {
        //Test 1
        string expression = "((a+b)/5-d)";
        Console.WriteLine("Expression: {0}",expression);
        Console.WriteLine("Has correct brackets: {0}",AreBracketsCorrect(expression));
        //Test 2
        expression = ")(a+b))";
        Console.WriteLine("Expression: {0}", expression);
        Console.WriteLine("Has correct brackets: {0}", AreBracketsCorrect(expression));
    }
}