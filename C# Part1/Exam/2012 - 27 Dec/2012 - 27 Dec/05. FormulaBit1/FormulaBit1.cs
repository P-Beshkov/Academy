﻿using System;

class FormulaBit1
{
    static int[,] track = new int[8, 8];
    static bool downBlock = false,
            upBlock = false,
            leftBlock = false;
    struct Position
    {
        public int row;
        public int column;
    }
    static Position position = new Position();

    static int MoveDown()
    {
        int distance = 0;
        do
        {
            if (position.row + 1 > 7 || track[position.row + 1, position.column] == 1)
            {
                break;
            }
            else
            {
                position.row++;
                distance++;
            }
        }
        while (true);
        return distance;
    }

    static int MoveLeft()
    {
        int distance = 0;
        do
        {
            if (position.column + 1 > 7 || track[position.row, position.column + 1] == 1)
            {
                break;
            }
            else
            {
                position.column++;
                distance++;
            }
        }
        while (true);
        return distance;
    }

    static int MoveUp()
    {
        int distance = 0;
        do
        {
            if ((position.row - 1) <= -1 || track[position.row - 1, position.column] == 1)
            {
                break;
            }
            else
            {
                position.row--;
                distance++;
            }
        }
        while (true);
        return distance;
    }

    static void CreateTrack(int[] numbers)
    { 
        for (int x = 0; x <= 7; x++)
        {
            int y = 0;
            do
            {
                int juniorBit = 1 & numbers[x];
                if (juniorBit == 1)
                {
                    track[x, y] = 1;
                }
                numbers[x] >>= 1;
                y++;
            }
            while (numbers[x] != 0);
        }
    }

    static void Main()
    {
        int[] numbers = new int[8];
        for (int i = 0; i < 8; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }
        CreateTrack(numbers);
        position.row = 0;
        position.column = 0;
        int turns = -1;
        int lenght = 1;
        
        do
        {
            int distance,
                cycleState = 0;
            distance = MoveDown();
            if (distance == 0)
            {
                downBlock = true;
            }
            else
            {
                cycleState = 1;
                lenght += distance;                
                turns++;
                downBlock = upBlock = leftBlock = false;
            }

            distance = MoveLeft();
            if (distance == 0)
            {
                leftBlock = true;
            }
            else
            {
                cycleState = 2;
                lenght += distance;                
                turns++;
                downBlock = upBlock = leftBlock = false;
            }
            
            if (cycleState==2 || cycleState==0)
            {
                distance = MoveUp();
                if (distance == 0)
                {
                    upBlock = true;
                }
                else
                {
                    lenght += distance;
                    turns++;
                    downBlock = upBlock = leftBlock = false;
                }
            }

            distance = MoveLeft();  
            if (distance == 0)
            {
                leftBlock = true;
            }
            else
            {
                lenght += distance;                
                turns++;
                downBlock = upBlock = leftBlock = false;
            }
            if (upBlock && leftBlock && downBlock)
            {
                break;
            }
        }
        while (true);
        if (position.row == 7 || position.column == 7)
        {
            Console.WriteLine("{0} {1}", lenght, turns);
        }
        else
        {
            Console.WriteLine("No {0}", lenght);
        }
    }

    private static void ClearBlocks()
    {
        downBlock = upBlock = leftBlock = false;
    }
}