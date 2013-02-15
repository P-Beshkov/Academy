//01. Write a program that fills and prints a matrix of size (n, n) as shown below: (examples for n = 4)
//a)row, row+1, ... , col b)
using System;
class Program
{
    static void FillFirtsType(int[,] matrix)
    {
        int value = 1;
        for (int column = 0; column < matrix.GetLength(1); column++)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                matrix[row, column] = value;
                value++;
            }
        }
    }
    static void FillSecondType(int[,] matrix)
    {
        int value = 1;
        for (int column = 0; column < matrix.GetLength(1); column++)
        {
            if (column % 2 == 0)
            {
                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    matrix[row, column] = value;
                    value++;
                }
            }
            else
            {
                for (int row = matrix.GetLength(1) - 1; row >= 0; row--)
                {
                    matrix[row, column] = value;
                    value++;
                }
            }
        }
    }
    
    static void FillThirdType(int[,] matrix)
    {
        int value = 1;              

        for (int startRow = matrix.GetLength(0) - 1; startRow >= 0; startRow--)
        {            
            matrix[startRow, 0] = value++;
            int row = startRow + 1,
                column=1;
            while (row < matrix.GetLength(0) && column < matrix.GetLength(1))
            {
                matrix[row++, column++] = value++;                
            }            
        }
        
        for (int startColumn = 1; startColumn < matrix.GetLength(1); startColumn++)
        {            
            matrix[0, startColumn] = value++;
            int row=1,
                column = startColumn + 1;
            while (row < matrix.GetLength(0) && column < matrix.GetLength(1))
            {
                matrix[row++, column++] = value++;                
            }
        }
    }
    static void FillFourthType(int[,] matrix)
    {   
        int value=1;
        int row, column;
        for (row = 0; row < matrix.GetLength(0); row++)
        {            
            matrix[row, 0] = value++;
        }
        int elementsToWrite;
        sbyte goingLeft = -1, goingDown = 0;
        row = matrix.GetLength(0) - 1;
        column = 1;
        for (elementsToWrite = matrix.GetLength(0) - 1; elementsToWrite > 0; elementsToWrite--)
        {
            if (goingLeft == -1 && goingDown == 0)
            {
                for (int m = 1; m <= elementsToWrite; m++)
                {
                    matrix[row, column++] = value++;
                }
                goingLeft = 0;
                goingDown = -1;
                column--;
                row--;
            }
            if (goingLeft == 0 && goingDown == -1)
            {
                for (int m = 1; m <= elementsToWrite; m++)
                {
                    matrix[row--, column] = value++;
                }
                goingLeft = 1;
                goingDown = 0;
                row++;
                column--;
                elementsToWrite--;
                
            }
            if (goingLeft == 1 && goingDown == 0)
            {
                for (int m = 1; m <= elementsToWrite; m++)
                {
                    matrix[row, column--] = value++;
                }
                goingLeft = 0;
                goingDown = 1;
                column++;
                row++;
            }
            if (goingLeft == 0 && goingDown == 1)
            {
                for (int m = 1; m <= elementsToWrite; m++)
                {
                    matrix[row++, column] = value++;
                }
                goingLeft = -1;
                goingDown = 0;
                row--;
                column++;
            }           
        }
    }
    static void PrintMatrix(int[,] matrix)
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int column = 0; column < matrix.GetLength(1); column++)
            {
                Console.Write("{0,2} ", matrix[row, column]);
            }
            Console.WriteLine();
        }
    }
    static void Main(string[] args)
    {
        int n = 4;
        int[,] matrix = new int[n, n];
        FillFirtsType(matrix);
        PrintMatrix(matrix);
        Console.WriteLine();

        FillSecondType(matrix);
        PrintMatrix(matrix);
        Console.WriteLine();

        FillThirdType(matrix);
        PrintMatrix(matrix);
        Console.WriteLine();

        FillFourthType(matrix);
        PrintMatrix(matrix);
        Console.WriteLine();

    }
}

