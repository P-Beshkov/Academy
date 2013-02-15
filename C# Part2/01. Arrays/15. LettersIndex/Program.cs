//15. Да се напише програма, която създава масив с всички букви от латинската 
//азбука. Да се даде възможност на потребител да въвежда дума от конзолата и 
//в резултат да се извеждат индексите на буквите от думата.
using System;
class Program
{
    static void Main()
    {
        char[] allLetters = new char[58];
        for (char i = 'A'; i <= 'z'; i++)
        {
            if (i > 'Z' && i < 'a')
                continue;
            allLetters[i - 'A'] = i;
        }
        //foreach (char item in allLetters)
        //{
        //    Console.WriteLine(item);
        //}
        Console.Write("Въведете дума = ");
        String word = Console.ReadLine();
        foreach (char letter in word)
        {
            foreach (char item in allLetters)
            {
                if (item == letter)
                {
                    Console.WriteLine("{0} = {1}",letter,(int)letter);
                }
            }            
        }
    }
}

