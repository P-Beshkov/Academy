using System;
using System.Collections.Generic;
class Program
{
    static List<char> cards = new List<char>();
    static bool CheckImpossible()
    {
        bool result = true;
        for (int i = 0; i < 4; i++)
        {
            if (cards[i] != cards[i + 1])
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
            if (cards[i] != cards[i + 1])
            {
                differentCount++;
            }
        }
        if (differentCount >= 3)
        {
            result = false;
        }
        return result;
    }

    static bool CheckFullHouse()
    {
        bool result = false;
        if (cards[0] == cards[1] == cards[2] && cards[3] == cards[4])
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
        if (cards.Contains('>'))
        {
            cards.Insert(0, '1');
            cards.RemoveAt(cards.Count - 1);
        }
        for (int i = 0; i < 3; i++)
        {
            if (cards[i] + 1 != cards[i + 1])
            {
                return false;
            }
        }
        return true;

    }
    static bool CheckThreeOfKind()
    {
        bool result = false;

        int count = 1;
        for (int i = 0; i < 4; i++)
        {
            if (cards[i]==cards[i+1])
            {
                count++;
            }
            else
            {
                count = 1;
            }
            if (count==3)
            {
                return true;
            }
        }
        return false;
    }
    static bool CheckTwoPairs()
    {

    }
    static void Main()
    {

    }
}