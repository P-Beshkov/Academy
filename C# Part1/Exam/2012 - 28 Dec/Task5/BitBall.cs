﻿using System;

class Task5
{
    static char[,] field = new char[8, 8];
    static char[,] fillTopTeam(int[] numbers)
    {
        char[,] matrix = new char[8, 8];
        for (int x = 0; x <= 7; x++)
        {
            int y = 0;
            do
            {
                int juniorBit = 1 & numbers[x];
                if (juniorBit == 1)
                {
                    matrix[x, y] = 'T';
                }
                numbers[x] >>= 1;
                y++;
            }
            while (numbers[x] != 0);
        }
        return matrix;
    }
    static char[,] fillBottomTeam(int[] numbers)
    {
        char[,] matrix = new char[8, 8];
        for (int x = 0; x <= 7; x++)
        {
            int y = 0;
            do
            {
                int juniorBit = 1 & numbers[x];
                if (juniorBit == 1)
                {
                    matrix[x, y] = 'B';
                }
                numbers[x] >>= 1;
                y++;
            }
            while (numbers[x] != 0);
        }
        return matrix;
    }
    static void fillField(char[,] teamTop, char[,] teamBot)
    {

        for (int row = 0; row < field.GetLength(0); row++)
        {
            for (int column = 0; column < field.GetLength(1); column++)
            {
                if (teamTop[row, column] == 'T' && teamBot[row, column] != 'B')
                {
                    field[row, column] = 'T';
                }
                if (teamTop[row, column] != 'T' && teamBot[row, column] == 'B')
                {
                    field[row, column] = 'B';
                }
            }
        }
    }
    static bool DownWards(int row, int column)
    {
        bool scored = true;

        for (int i = (row + 1); i < 8; i++)
        {
            if (field[i, column] != '\0')
            {
                scored = false;
                break;
            }
        }
        return scored;
    }
    static bool UpWards(int row, int column)
    {
        bool scored = true;

        for (int i = (row - 1); i >= 0; i--)
        {
            if (field[i, column] != '\0')
            {
                scored = false;
                break;
            }
        }
        return scored;
    }
    static void attack()
    {
        int scoreTop = 0,
            scoreBot = 0;
        for (int row = 0; row < field.GetLength(0); row++)
        {
            for (int column = 0; column < field.GetLength(1); column++)
            {
                if (field[row, column] == 'T' && DownWards(row, column))
                {
                    scoreTop++;
                }
                if (field[row, column] == 'B' && UpWards(row, column))
                {
                    scoreBot++;
                }
            }
        }
        Console.WriteLine(scoreTop + ":" + scoreBot);
    }
    static void Main()
    {
        int[] numbers = new int[8];
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }
        char[,] topTeam = fillTopTeam(numbers);

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }
        char[,] bottomTeam = fillBottomTeam(numbers);

        fillField(topTeam, bottomTeam);
        attack();
    }
}

