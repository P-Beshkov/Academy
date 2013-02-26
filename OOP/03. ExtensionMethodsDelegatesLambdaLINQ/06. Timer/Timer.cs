/*07. Using delegates write a class Timer that has can execute
 * certain method at each t seconds. */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
public delegate void FirstDelegate(int sleep);
internal class Timer
{
    static int counter = 1;
    public void SampleMethod(int sleep)
    {
        Thread.Sleep(sleep);
        Console.WriteLine("{0} times called by delegate" ,counter++);
    }
    private FirstDelegate del;
    public void Execute(int sleep)
    {
        del = SampleMethod;
        do
        {
            del(sleep);
        } while (true);
        
    }
}