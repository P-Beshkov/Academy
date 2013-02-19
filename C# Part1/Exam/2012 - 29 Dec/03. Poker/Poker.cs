using System;

class Program
{
    static char[] cards = new char[5];
    static bool CheckImpossible()
    {
        bool result = true;
        for (int i = 0; i < 4; i++)
        {
            if (cards[i]!=cards[i+1])
            {
                result = false;
            }
        }
        return result;
    }
    static bool CheckFourKind()
    {
        bool result = true;
        int differentCount = 1;
        for (int i = 0; i < 4; i++)
        {
            if (cards[i]!=cards[i+1])
            {
                differentCount++;
            }
        }
        if (differentCount>=3)
        {
            result = false;
        }
        return result;
    }

    static bool CheckFullHouse()
    {
        bool result = false;
        if (cards[0]==cards[1]==cards[2] && cards[3]==cards[4])
        {
            result = true;
        }
        if (cards[2] == cards[3] == cards[4] && cards[0] == cards[1])
        {
            result = true;
        }
        return result;
    }

    static bool CheckStraight()
    {
        bool result = false;
        for (int i = 0; i < 5; i++)
        {
            if (Char.IsDigit(cards[0]))
            {
                if (cards[i+1]!=cards[i]+1)
                {

                }
            }
            
        }
        


        return result;
    }
    static void Main()
    {

    }
}