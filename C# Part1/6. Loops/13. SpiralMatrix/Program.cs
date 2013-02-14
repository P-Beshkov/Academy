//14. * Write a program that reads a positive integer number 
//N (N < 20) from console and outputs in the console the 
//numbers 1 ... N numbers arranged as a spiral.

using System;

class Program
{
    static void Main()
    {
        Console.Write("N = ");
        int n = int.Parse(Console.ReadLine());
        int[,] matrix = new int[n, n];
        int elementsToWrite, x, y, nextElement = 0, m;
        sbyte goingLeft = 0, goingDown = 1;
        
        for (x = 0; x < n; x++)
        {
            nextElement++;
            matrix[0, x] = x + 1;
        }
        x--;
        nextElement++;      
        for (elementsToWrite = n - 1, y = 0; elementsToWrite > 0; elementsToWrite--)
        {
            if (goingLeft == 0 && goingDown == 1)
            {
                for (m = 1; m <= elementsToWrite; m++, nextElement++)               
                    matrix[++y, x] = nextElement;                  
                goingLeft = 1;
                goingDown = 0;
            }
            if (goingLeft == 1 && goingDown == 0)
            { 
                for (m = 1; m <= elementsToWrite; m++, nextElement++)                
                    matrix[y, --x] = nextElement;          
                goingLeft = 0;
                goingDown = -1;
                continue;
            }
            if (goingLeft == 0 && goingDown == -1)
            {
                for (m = 1; m <= elementsToWrite; m++, nextElement++)                
                    matrix[--y, x] = nextElement;               
                goingLeft = -1;
                goingDown = 0;
            }
            if (goingLeft == -1 && goingDown == 0)
            { 
                for (m = 1; m <= elementsToWrite; m++, nextElement++)                
                    matrix[y, ++x] = nextElement;                  
                goingLeft = 0;
                goingDown = 1;
            }
        }
        for (y = 0; y < n; y++)
        {
            for (x = 0; x < n; x++)            
                Console.Write("{0,3}", matrix[y, x]);            
            Console.WriteLine();
        }
    }
}