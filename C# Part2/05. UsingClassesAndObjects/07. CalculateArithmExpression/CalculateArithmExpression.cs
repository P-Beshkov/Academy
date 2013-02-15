//07. * Write a program that calculates the value of given arithmetical expression. 
//The expression can contain the following elements only:
//Real numbers, e.g. 5, 18.33, 3.14159, 12.6
//Arithmetic operators: +, -, *, / (standard priorities)
//Mathematical functions: ln(x), sqrt(x), pow(x,y)
//Brackets (for changing the default priorities)
//    Examples:
//    (3+5.3) * 2.7 - ln(22) / pow(2.2, -1.7) -> ~ 10.6
//    pow(2, 3.14) * (3 - (3 * sqrt(2) - 3.2) + 1.5*0.3) -> ~ 21.22
//    Hint: Use the classical "shunting yard" algorithm and "reverse Polish notation".

using System;
using System.Collections.Generic;

class CalculateArithmExpression
{
    
    static private bool HigherPriority(char top, char item)
    {
        if (top == '*' || top == '/' && (item == '-' || item == '+'))
        {
            return true;
        }
        if (top == '*' || top == '/' && (item == '*' || item == '/'))
        {
            return true;
        }
        if (top == '+' || top == '-' && (item == '-' || item == '+'))
        {
            return true;
        }
        return false;
    }
    static private string ConvertToPostfix(string expression)
    {
        Stack<char> data = new Stack<char>();
        string output = string.Empty;
        foreach (char item in expression)
        {
            if (char.IsDigit(item))
            {
                output += item;
                continue;
            }
            if (IsOperator(item))
            {
                char top='a';
                if (data.Count > 0)
                {
                    top = data.Peek();
                }
                while (HigherPriority(top, item) && data.Count != 0)
                {
                    output += data.Pop();
                    if (data.Count > 0)
                    {
                        top = data.Peek();
                    }
                }
                data.Push(item);
            }
            if (item == '(')
            {
                data.Push(item);
            }
            if (item == ')')
            {
                char top = data.Peek();
                while (top != '(')
                {
                    output += data.Pop();
                    top = data.Peek();
                }
                data.Pop();
            }
        }
        while (data.Count != 0)
        {
            char top = data.Pop();
            output += top;
        }
        return output;
    }

    private static bool IsOperator(char item)
    {
        if (item == '+' || item == '-' || item == '*' || item == '/')
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    static void Main()
    {
        string data = "(3+5.3) * 2.7";
        Console.WriteLine(ConvertToPostfix(data));
        Console.ReadKey();
    }    
}