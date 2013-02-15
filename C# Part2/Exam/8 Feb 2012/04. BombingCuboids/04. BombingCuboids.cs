using System;

class Program
{
    struct Position
	{
        int width=0;
        int heght=0;
        int deepth=0;
	}
    class Cube
    {
        private char[, ,] cube;
        private int destroyed;
        private int[] blasted;
        private void FallDown(Position around, int power)
        {

        }
        public void BlastBomb(Position at, int power)
        {

        }
    }
    static char[, ,] cube;
    static int[] blasted = new int[26];
    static int destroyed = 0;
    static void FallDown(int bombWidth, int bombHeight, int bombDeepth, int bombPower)
    {
        int blastMinWidth = bombWidth - bombPower < 0 ? 0 : bombWidth - bombPower,
            blastMaxWidth = bombWidth + bombPower >= cube.GetLength(0) ? cube.GetLength(0) - 1 : bombWidth + bombPower,
            blastMinDeepth = bombDeepth - bombPower < 0 ? 0 : bombDeepth - bombPower,
            blastMaxDeepth = bombDeepth + bombPower >= cube.GetLength(2) ? cube.GetLength(2) - 1 : bombDeepth + bombPower;

        for (int width = blastMinWidth; width <= blastMaxWidth; width++)
        {
            for (int deepth = blastMinDeepth; deepth <= blastMaxDeepth; deepth++)
            {
                for (int checks = 0; checks < bombPower * 2; checks++)
                {
                    for (int i = 0; i < cube.GetLength(1) - 1; i++)
                    {
                        if (cube[width, i, deepth] == '0' && cube[width, i + 1, deepth] != '0')
                        {
                            cube[width, i, deepth] = cube[width, i + 1, deepth];
                            cube[width, i + 1, deepth] = '0';
                        }
                    }
                }

            }
        }
    }
    static void BlastBomb(int bombWidth, int bombHeight, int bombDeepth, int bombPower)
    {
        int blastMinWidth = bombWidth - bombPower < 0 ? 0 : bombWidth - bombPower,
            blastMaxWidth = bombWidth + bombPower >= cube.GetLength(0) ? cube.GetLength(0) - 1 : bombWidth + bombPower,
            blastMinHeight = bombHeight - bombPower < 0 ? 0 : bombHeight - bombPower,
            blastMaxHeight = bombHeight + bombPower >= cube.GetLength(1) ? cube.GetLength(1) - 1 : bombHeight + bombPower,
            blastMinDeepth = bombDeepth - bombPower < 0 ? 0 : bombDeepth - bombPower,
            blastMaxDeepth = bombDeepth + bombPower >= cube.GetLength(2) ? cube.GetLength(2) - 1 : bombDeepth + bombPower;

        for (int width = blastMinWidth; width <= blastMaxWidth; width++)
        {
            for (int height = blastMinHeight; height <= blastMaxHeight; height++)
            {
                for (int deepth = blastMinDeepth; deepth <= blastMaxDeepth; deepth++)
                {
                    double dist = CalculateDistance(bombWidth, bombHeight, bombDeepth, width, height, deepth);
                    if (dist <= (double)bombPower)
                    {
                        if (cube[width, height, deepth] != '0')
                        {
                            destroyed++;
                            blasted[cube[width, height, deepth] - 'A']++;
                        }
                        cube[width, height, deepth] = '0';
                    }
                }
            }
        }
    }
    static double CalculateDistance(params int[] coordinates)
    {
        int width = Math.Abs(coordinates[3] - coordinates[0]);
        int heigth = Math.Abs(coordinates[4] - coordinates[1]);
        int deepth = Math.Abs(coordinates[5] - coordinates[2]);
        double dist = Math.Sqrt(width * width + heigth * heigth + deepth * deepth);
        return dist;
    }
    static void Main()
    {
        int width = 5, height = 4, deepth = 3;

        string line = Console.ReadLine();
        string[] split = line.Split(' ');
        width = int.Parse(split[0]);
        height = int.Parse(split[1]);
        deepth = int.Parse(split[2]);
        cube = new char[width, height, deepth];

        for (int h = 0; h < height; h++)
        {
            line = Console.ReadLine();
            int index = 0;
            for (int d = 0; d < deepth; d++)
            {
                for (int w = 0; w < width; w++)
                {
                    cube[w, h, d] = line[index];
                    index++;
                }
                index++;
            }
        }
        int numberOFBombs = int.Parse(Console.ReadLine());
        int[,] bombs = new int[numberOFBombs, 4];
        for (int i = 0; i < numberOFBombs; i++)
        {
            line = Console.ReadLine();
            string[] bombData = line.Split(new Char[] { ' ', ',', '.', ':', '\t' });
            bombs[i, 0] = int.Parse(bombData[0]);
            bombs[i, 1] = int.Parse(bombData[1]);
            bombs[i, 2] = int.Parse(bombData[2]);
            bombs[i, 3] = int.Parse(bombData[3]);
        }
        for (int i = 0; i < numberOFBombs; i++)
        {
            BlastBomb(bombs[i, 0], bombs[i, 1], bombs[i, 2], bombs[i, 3]);
            FallDown(bombs[i, 0], bombs[i, 1], bombs[i, 2], bombs[i, 3]);
        }
        Console.WriteLine(destroyed);
        for (int i = 0; i < blasted.Length; i++)
        {
            if (blasted[i] != 0)
            {
                Console.WriteLine((char)(i + 'A') + " " + blasted[i]);
            }
        }
        Console.ReadKey();
    }    
}