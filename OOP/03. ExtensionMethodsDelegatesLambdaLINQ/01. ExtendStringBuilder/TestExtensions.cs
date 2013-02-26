/*01. Implement an extension method Substring(int index, int length) for the 
 * class StringBuilder that returns new StringBuilder and has the same functionality
 * as Substring in the class String. */

using System;
using System.Text;

class TestExtensions

{    
    static void Main()
    {
        StringBuilder temp = new StringBuilder("Test string for this method");
        string subTemp = temp.Substring(5, 10);
        Console.WriteLine(subTemp);
    }
}