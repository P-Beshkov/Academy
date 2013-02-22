using System;

class AngryBits
{
    static int[,] field = new int[8, 16];
    static int result = 0;
    static void FillField(int[] numbers)
    {       
        for (int x = 0; x <= 7; x++)
        {
            int y = 0;
            do
            {
                int juniorBit = 1 & numbers[x];
                if (juniorBit == 1)
                {
                    field[x, y] = 1;
                }
                numbers[x] >>= 1;
                y++;
            }
            while (numbers[x] != 0);
        }       
    }
    static void MoveBird(int row, int col, int cellsTraveled, bool downWards)
    {
        if (row==-1 && !downWards)
        {
            row = 1;
        }
        if (col==-1)
        {
            return;
        }
        if (row==8 && downWards)
        {
            row = 6;
        }

        if (field[row,col]==1)
        {
            int pigsBlown = BlowPigsAround(row, col);
            result += pigsBlown * cellsTraveled;   
        }
        return;
    }

    private static int BlowPigsAround(int row, int col)
    {
        int result = 0;
        for (int i = row-1; i <= row+1; i++)
        {
            for (int j = col-1; j <= col+1; j++)
            {
                if (IsIndexInRange(i,j))
                {
                    if (field[i,j]==1)
                    {
                        result++;
                        field[i, j] = 0;
                    }
                }
            }
        }
        return result;        
    }
    private static bool IsIndexInRange(int row, int col)
    {
        if (row<0 || row>7)
        {
            return false;
        }
        if (col<0 || col>15)
        {
            return false;
        }

        return true;
    }
    static void Main()
    {
        int[] numbers = new int[8];
        for (int i = 0; i < 8; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }
        FillField(numbers);
        for (int col = 8; col < 16; col++)
        {
            for (int row = 0; row < 8; row++)
            {
                if (field[row,col]==1)
                {

                }
            }

        }
    }
}