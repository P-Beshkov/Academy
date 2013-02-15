//03. We are given a matrix of strings of size N x M. Sequences in the matrix we define 
//as sets of several neighbor elements located on the same line, column or diagonal. 
//Write a program that finds the longest sequence of equal strings in the matrix. Example:

using System;

class LongestSequence
{
    enum Direction
    {
        down = 1,
        right,
        diagonal
    };
    static string[,] matrix = 
    {
        { "ha", "fifi", "ho", "hi" },
        { "fo", "ha", "hi", "xx" },
        { "xxx", "ho", "ha", "xx" },
    };



    static void Main()
    {
        int column = 0,
        maxLenght = 0,
        maxLenghtRow = 0,
        maxLenghtColumn = 0,
        currentLenght = 0;
        Direction way = Direction.down;
        for (int x = 0; x < matrix.GetLength(0); x++)
        {
            for (int y = 0; y < matrix.GetLength(1); y++)
            {
                for (int row = x; row < matrix.GetLength(0) - 1; row++)
                {
                    if ((matrix[row, y].CompareTo(matrix[row + 1, y])) == 0)
                    {
                        if ((row - x) > maxLenght)
                        {
                            maxLenght = row - x;
                            way = Direction.down;
                            maxLenghtRow = x;
                            maxLenghtColumn = y;
                        }
                    }
                }
                for (column = y; column < matrix.GetLength(1) - 1; column++)
                {
                    if ((matrix[x, column].CompareTo(matrix[x, column + 1])) == 0)
                    {
                        if ((column - y) > maxLenght)
                        {
                            maxLenght = column - y;
                            way = Direction.right;
                            maxLenghtRow = x;
                            maxLenghtColumn = y;
                        }
                    }
                }
                column = y;
                for (int row = x; row < (matrix.GetLength(0) - 1) && column < (matrix.GetLength(1) - 1); row++, column++)
                {
                    if ((matrix[row, column].CompareTo(matrix[row + 1, column + 1])) == 0)
                    {
                        currentLenght++;                        
                    }
                    if ((matrix[row, column].CompareTo(matrix[row + 1, column + 1])) != 0)
                    {
                        
                        if (currentLenght > maxLenght)
                        {
                            maxLenght = currentLenght;
                            way = Direction.diagonal;
                            maxLenghtRow = x;
                            maxLenghtColumn = y;
                        }
                        currentLenght = 0;
                    }
                    if (row == 2 && (row - x) > maxLenght)
                    {
                        maxLenght = row - x;
                        way = Direction.diagonal;
                        maxLenghtRow = x;
                        maxLenghtColumn = y;
                    }
                }
            }
        }
        int i = maxLenghtRow,
        j = maxLenghtColumn;
        for (int m = 0; m < maxLenght; m++)
        {
            Console.Write("{0} ", matrix[i, j]);
            switch (way)
            {
                case Direction.down:
                    i++;
                    break;
                case Direction.right:
                    j++;
                    break;
                case Direction.diagonal:
                    i++;
                    j++;
                    break;
            }
        }
    }
}