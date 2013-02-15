using System;

class Task2
{
    static char GetNextElement(char first, char second)
    {        
        int resultCode = first + second;
        resultCode -= 2*'@';
        
        if (resultCode > 26)
        {
            resultCode = resultCode % 26;
        }
        resultCode += '@';
        
        return (char)resultCode;
    }
    static void Main()
    {
        char firstElement = char.Parse(Console.ReadLine());
        char secondElement = char.Parse(Console.ReadLine());
        char nextElement,
            lastElement,
            lastButOne;
        int linesCount = int.Parse(Console.ReadLine());

        if (linesCount == 1)
        {
            Console.WriteLine(firstElement);
            return;
        }
        if (linesCount == 2)
        {
            Console.WriteLine(firstElement);
            nextElement=GetNextElement(firstElement,secondElement);
            Console.Write(secondElement);
            Console.WriteLine(nextElement);
            return;
        }

        Console.WriteLine(firstElement);
        Console.Write(secondElement);
        Console.WriteLine(GetNextElement(firstElement, secondElement));
        lastButOne = secondElement;
        lastElement = GetNextElement(firstElement, secondElement);
        for (int lineNumber = 3; lineNumber <= linesCount; lineNumber++)
        {
            nextElement = GetNextElement(lastButOne, lastElement);
            Console.Write(nextElement);
            Console.Write(new String(' ', lineNumber - 2));
            lastButOne = lastElement;
            lastElement = nextElement;
            nextElement = GetNextElement(lastButOne, lastElement);
            Console.WriteLine(nextElement);
            lastButOne = lastElement;
            lastElement = nextElement;
        }

    }
}

