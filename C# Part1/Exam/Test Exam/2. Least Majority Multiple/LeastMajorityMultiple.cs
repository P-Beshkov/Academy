using System;
  
class Program
{
    static void Main()
    { 
        byte br=0,i,neededNumbers=3;
        int j;        
        byte[] numbers = new byte[5];

        for (i = 0; i <= 4; i++)
            numbers[i] = byte.Parse(Console.ReadLine());
        for (i = 0; i <= 4; i++)
            if (numbers[i] == 1)
            {
                neededNumbers--;
                numbers[i] = 0;
            }
        for (j = 1; ;j++ )
        {
            for (i = 0; i <= 4; i++) 
                if (numbers[i]!=0)
                if (j % numbers[i] == 0)                
                    br++;                       
            if (br >= neededNumbers)
            {
                Console.WriteLine(j);
                return;
            }
            br = 0;
        }
    }
}

        //bool firstReady = false;
        //bool secondReady = false;
        //bool thirdReady = false;
        //numbers.CopyTo(numbersOriginal, 0);
        //for (i = 0; i <= 2; i++)
        //    for (j = (byte)(i+1); j <= 3; j++)
        //        for (p = (byte)(j+1); p <= 4; p++)
        //        {
        //            for (m = 1; !(numbers[i] == 1 && numbers[j] == 1 && numbers[p] == 1);)
        //            {
        //                if (numbers[i] % m == 0)
        //                    numbers[i] /= m;
        //                else
        //                    firstReady = true;
        //                if (numbers[j] % m == 0)
        //                    numbers[j] /= m;
        //                else
        //                    secondReady = true;
        //                if (numbers[p] % m == 0)
        //                    numbers[p] /= m;
        //                else
        //                    thirdReady = true;
        //                if (firstReady && secondReady && thirdReady)
        //                {
        //                    firstReady = secondReady = thirdReady = false;
        //                    m++;
        //                    continue;
        //                }
        //                nokNew *= m;
        //            }
        //            if (nokNew <= nokOld)
        //                nokOld = nokNew;
        //            nokNew = 1;
        //            numbersOriginal.CopyTo(numbers,0);
        //        }
        //Console.Write(nokOld);
    

    
//byte a = 30;// byte.Parse(Console.ReadLine());
//byte b = 42;//byte.Parse(Console.ReadLine());
//byte c = 35;// byte.Parse(Console.ReadLine());
//byte d = 70;// byte.Parse(Console.ReadLine());
//byte e = 90;// byte.Parse(Console.ReadLine());
//int NOK = 1;
//bool aReady, bReady, cReady, dReady, eReady;
//byte delitel;
//int br = 0, br2 = 0;
//aReady = bReady = cReady = dReady = eReady = false;
//for (delitel = 2; br2 <= 2;) 
//{
//    if (a % delitel == 0 && a != 0)
//        a = (byte)(a / delitel);
//    else
//        aReady = true;
//    if (c % delitel == 0 && c != 0)
//        c = (byte)(c / delitel);
//    else
//        cReady = true;
//    if (d % delitel == 0 && d != 0)
//        d = (byte)(d / delitel);
//    else
//        dReady = true;
//    if (e % delitel == 0 && e != 0)
//        e = (byte)(e / delitel);
//    else
//        eReady = true;
//    if (b % delitel == 0 && b != 0)
//        b = (byte)(b / delitel);
//    else
//        bReady = true;
//    if (aReady && bReady && cReady && dReady && eReady)
//    {
//        delitel++;
//        aReady = bReady = cReady = dReady = eReady = false;
//    }
//    else
//        NOK *= delitel;
//    if (a == 1)
//    {
//        br2++;
//        a = 0;
//    }
//    if (b == 1)
//    {
//        br2++;
//        b = 0;
//    }
//    if (c == 1)
//    {
//        br2++;
//        c = 0;
//    }
//    if (d == 1)
//    {
//        br2++;
//        d = 0;
//    }
//    if (e == 1)
//    {
//        br2++;
//        e = 0;
//    }
//}
//Console.WriteLine(NOK);