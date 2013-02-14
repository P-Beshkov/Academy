using System;

class LeastMajorityMultiple
{
    static void Main()
    {
        int a, b, c, d, e;
        int.TryParse(Console.ReadLine(), out a);
        int.TryParse(Console.ReadLine(), out b);
        int.TryParse(Console.ReadLine(), out c);
        int.TryParse(Console.ReadLine(), out d);
        int.TryParse(Console.ReadLine(), out e);
        int counter = 0;
        int[] inputValues = 
        {
            a,
            b,
            c,
            d,
            e
        };
        //int min = inputValues[0];
        //for (int i = 0; i < 5; i++)
        //{
        //    if (inputValues[i] < min)
        //    {
        //        min = inputValues[i];
        //    }
        //}

        for (int j = 0; ; j++)
        {
            counter=0;
            for (int i = 0; i < 5; i++)
            {
                if (j >= i)
                {
                    if (j % inputValues[i] == 0)
                    {
                        counter++;
                        if (counter == 3)
                        {
                            Console.Write(j);
                            return;
                        }
                    }
                }
            }
        }
    }
}
