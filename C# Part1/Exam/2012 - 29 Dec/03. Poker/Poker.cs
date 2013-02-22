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
        bool result = false;

        int count = 1;
        for (int i = 0; i < 4; i++)
        {
            if (cards[i] == cards[i + 1])
            {
                count++;
            }
            else
            {
                count = 1;
            }
            if (count == 4)
            {
                return true;
            }
        }
        return false;
    }

    static bool CheckFullHouse()
    {
        bool result = false;
        if (cards[0] == cards[1] && cards[1] == cards[2] && cards[3] == cards[4])
        {
            result = true;
        }
        if (cards[2] == cards[3] && cards[3] == cards[4] && cards[0] == cards[1])
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
        bool result = false;
        bool foundOne = false;
        int count = 1;
        for (int i = 0; i < 4; i++)
        {
            if (cards[i] == cards[i + 1])
            {
                count++;
            }
            else
            {
                count = 1;
            }
            if (count==2 && foundOne)
            {
                return true;
            }
            if (count == 2)
            {
                foundOne = true;
            }
        }
        return false;
    }
    static bool CheckOnePair()
    {
        bool result = false;

        int count = 1;
        for (int i = 0; i < 4; i++)
        {
            if (cards[i] == cards[i + 1])
            {
                count++;
            }
            else
            {
                count = 1;
            }
            if (count == 2)
            {
                return true;
            }
        }
        return false;
    }
    static void Main()
    {

        for (int i = 0; i < 5; i++)
        {
            string card = Console.ReadLine();
            switch (card)
            {
                case "10": cards.Add(':');
                    break;
                case "J": cards.Add(';');
                    break;
                case "Q": cards.Add('<');
                    break;
                case "K": cards.Add('=');
                    break;
                case "A": cards.Add('>');
                    break;
                default: cards.Add(card[0]);
                    break;
            }
        }
        cards.Sort();
        if (CheckImpossible())
        {
            Console.WriteLine("Impossible");
        }
        else if (CheckFourKind())
        {
            Console.WriteLine("Four of a Kind");
        }
        else if(CheckFullHouse())
        {
            Console.WriteLine("Full House");
        }
        else if (CheckStraight())
        {
            Console.WriteLine("Straight");
        }
        else if (CheckThreeOfKind())
        {
            Console.WriteLine("Three of a Kind");
        }
        else if (CheckTwoPairs())
        {
            Console.WriteLine("Two Pairs");
        }
        else if(CheckOnePair())
        {
            Console.WriteLine("One Pair");
        }
        else
        {
            Console.WriteLine("Nothing");
        }

    }
}