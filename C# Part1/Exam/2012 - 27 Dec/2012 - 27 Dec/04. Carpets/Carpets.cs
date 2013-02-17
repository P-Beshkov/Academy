using System;

class Carpets
{
    static void Main()
    {
        int lineLenght = int.Parse(Console.ReadLine());
        int sideDotsCount = lineLenght / 2;
        sideDotsCount--;
        int positionsLeft;
        for (int i = 0; i < lineLenght/2; i++)
        {
            string row = new String('.',sideDotsCount);
            positionsLeft = lineLenght - 2 * sideDotsCount;           
            
            int rombsCount = positionsLeft / 4;
            for (int j = 0; j < rombsCount; j++)
            {
                row += "/ ";
            }
            if (i%2==1)
            {
                row += '\r';
            }
            else
            {
                row += ' ';
            }
            for (int j = 0; j < rombsCount; j++)
            {
                row += "\\ ";
            }
            row += '\r';
            row += new String('.', sideDotsCount);
            Console.WriteLine(row);
            sideDotsCount--;            
        }
    }
}