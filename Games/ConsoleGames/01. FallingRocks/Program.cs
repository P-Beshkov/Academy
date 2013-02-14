//* Implement the "Falling Rocks" game in the text console. A small dwarf stays at the bottom 
//of the screen and can move left and right (by the arrows keys). A number of rocks of different 
//sizes and forms constantly fall down and you need to avoid a crash.
//Rocks are the symbols ^, @, *, &, +, %, $, #, !, ., ;, - distributed with appropriate density. 
//The dwarf is (O). Ensure a constant game speed by Thread.Sleep(150).
//Implement collision detection and scoring system.

using System;

class FallingRocks
{
    static int dwarfPosition = Console.WindowWidth / 2;
    static Random randomGenerator = new Random();
    static int activeRocks = 0;
    static int score = -200;
    static int maxNumberOfRocksPerRow = 0;

    public class RowOfRocks
    {
        struct RocksData
        {
            public int x;
            public int y;
            public char? symbol;
            public int colour;
        };

        RocksData[] rocks = new RocksData[260];

        readonly char[] typeOfRock = { '^', '@', '*', '&', '+', '%', '$', '#', '!', '.', ';', '-' };

        public void AddRow()
        {
            int i, j;
            int numberOfRocksPerRow = randomGenerator.Next(1, maxNumberOfRocksPerRow + 1);

            for (j = 1; j <= numberOfRocksPerRow; j++)
            {
                rocks[0].x = randomGenerator.Next(0, Console.WindowWidth);  //Генериране на параметрите за елемента
                rocks[0].y = 1;
                rocks[0].symbol = typeOfRock[randomGenerator.Next(0, 12)];
                rocks[0].colour = randomGenerator.Next(1, 6);
                activeRocks++;

                for (i = activeRocks; i > 0; i--)                           //Освобождаване на индекс 0
                {
                    rocks[i].x = rocks[(i - 1)].x;
                    rocks[i].y = rocks[(i - 1)].y;
                    rocks[i].symbol = rocks[(i - 1)].symbol;
                    rocks[i].colour = rocks[(i - 1)].colour;
                }
            }
            for (i = 1; i <= activeRocks; i++)                 //Преместване с 1 ред надолу
                rocks[i].y++;
        }

        public void PrintAllRows()
        {
            int i;

            for (i = 1; i <= activeRocks; i++)
            {
                switch (rocks[i].colour)
                {
                    case 1:
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        break;
                    case 2:
                        Console.ForegroundColor = ConsoleColor.Blue;
                        break;
                    case 3:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        break;
                    case 4:
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        break;
                    case 5:
                        Console.ForegroundColor = ConsoleColor.Green;
                        break;
                }
                Console.SetCursorPosition(rocks[i].x, rocks[i].y);
                Console.Write(rocks[i].symbol);
            }
            Console.ResetColor();
        }

        public void CheckCollision()
        {
            int i, p = activeRocks - 10;
            for (i = activeRocks; i >= p && i >= 1; i--)    //Проверяване на последните 10 елемента за сблъсък с джуджето
            {
                if (rocks[i].y == 24 && rocks[i].x >= dwarfPosition && rocks[i].x <= (dwarfPosition + 2))
                {
                    Console.SetCursorPosition(0, 0);
                    Console.WriteLine("Game over!\nYour Score:{0}", score);
                    Console.Write("Press any key to continue...");
                    Console.ReadKey();
                    activeRocks = 0;
                    score = -240;
                    dwarfPosition = Console.WindowWidth / 2 - 1;
                }
                else if (rocks[i].y == 24)
                {
                    rocks[i].symbol = null;
                    rocks[i].y = 0;
                    activeRocks--;
                }
            }
        }
    }

    public class Dwarf
    {
        readonly string dwarfBody = "(0)";

        public void PrintDwarf()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(dwarfPosition, 24);
            Console.Write(dwarfBody);
        }

        public void MoveDwarfLeft()
        {
            if (dwarfPosition > 0)
                dwarfPosition--;
        }

        public void MoveDwarfRight()
        {
            if (dwarfPosition < Console.WindowWidth - 3)
                dwarfPosition++;
        }
    }
    static void RemoveScrollBars()
    {
        Console.BufferHeight = Console.WindowHeight;
        Console.BufferWidth = Console.WindowWidth;
    }

    static void Main()
    {
        RowOfRocks rock = new RowOfRocks();
        Dwarf henry = new Dwarf();
        Console.ResetColor();
        RemoveScrollBars();
        Console.Write("Max number of rocks per row[1-10]: ");
        maxNumberOfRocksPerRow = int.Parse(Console.ReadLine());
        Console.Write("Press any key to start...");
        henry.PrintDwarf();
        Console.ReadKey();

        while (true)
        {
            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo keyInfo = Console.ReadKey();
                if (keyInfo.Key == ConsoleKey.LeftArrow)
                {
                    henry.MoveDwarfLeft();
                }
                if (keyInfo.Key == ConsoleKey.RightArrow)
                {
                    henry.MoveDwarfRight();
                }
            }
            Console.Clear();
            henry.PrintDwarf();
            rock.AddRow();
            rock.PrintAllRows();
            rock.CheckCollision();
            Console.SetCursorPosition(0, 0);
            Console.Write("Score: " + score);
            //Thread.Sleep(150);
            score += 10;
        }
    }
}