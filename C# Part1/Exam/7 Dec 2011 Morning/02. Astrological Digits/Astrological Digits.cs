using System;

class Program
{
    static void Main()
    {
        int astrologicalForm = 0,n=0;
        char symbol;        
        do
        {
            
            symbol = (char)Console.Read();
            if (symbol == '\r')
                break;
            if (symbol == '-' || symbol=='.')
                continue;
            astrologicalForm += ((int)symbol - 48);
        }
        while (true);        
        do
        {
            n = astrologicalForm;
            astrologicalForm = 0;
            do
            {
                astrologicalForm += n % 10;
                n /= 10;
            }
            while (n != 0);
        }
        while (astrologicalForm > 9);
        Console.WriteLine(astrologicalForm);
    }
}