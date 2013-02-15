//01. Write a method that asks the user for his name and prints “Hello, <name>” 
//(for example, “Hello, Peter!”). Write a program to test this method.

using System;

class HelloName
{
    static private void PrintName()
    {
        Console.Write("Your name: ");
        string name = Console.ReadLine();
        Console.WriteLine("Hello, {0}", name);
    }

    static void Main()
    {
        PrintName();
    }
}