//01. Write a program that reads an integer number and calculates and prints its 
//square root. If the number is invalid or negative, print "Invalid number". 
//In all cases finally print "Good bye". Use try-catch-finally.

using System;

class CalculateRoot
{
    static void Main()
    {        
        Console.Write("Enter an integer: ");
        string number = Console.ReadLine();
        double root;
        try
        {
            root = MyRoot(number);
            Console.WriteLine("root = " + root);
        }
        catch (InvalidCastException ice)
        {
            Console.WriteLine(ice.Message);
        }
        catch (ArgumentNullException ane)
        {
            Console.WriteLine(ane.ParamName);
        }
        finally
        {
            Console.WriteLine("Goodbye");
        }      
    }

    private static double MyRoot(string number)
    {
        int value=0;
        if (!int.TryParse(number, out value))
        {
            throw new InvalidCastException("Invalid number");
        }
        if (value <= 0)
        {
            throw new ArgumentNullException("Value must be positive");
        }
        return Math.Sqrt(value);
    }
}