using System;

class UKFlag
{
    static void Main()
    {
        int height = int.Parse(Console.ReadLine());

        int sizeDotsCount = (height - 1) / 2;
        sizeDotsCount--;

        for (int i = 0; i < height/2; i++)
        {
            Console.Write(new String('.',i));
            Console.Write("\\");
            Console.Write(new String('.',sizeDotsCount-i));
            Console.Write("|");
            Console.Write(new String('.', sizeDotsCount - i));
            Console.Write("/");
            Console.Write(new String('.', i));
            Console.WriteLine();
        }
        Console.WriteLine(new String('-', sizeDotsCount + 1) + "*" + new String('-', sizeDotsCount + 1));
        for (int i = 0; i < height / 2; i++)
        {
            Console.Write(new String('.', sizeDotsCount - i));            
            Console.Write("/");
            Console.Write(new String('.', i));
            Console.Write("|");
            Console.Write(new String('.', i));
            Console.Write("\\");
            Console.Write(new String('.', sizeDotsCount - i));   
            Console.WriteLine();
        }
    }
}