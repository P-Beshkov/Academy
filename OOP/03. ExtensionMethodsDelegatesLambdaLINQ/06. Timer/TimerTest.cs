using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class TimerTest
{
    static void Main()
    {
        Timer timer = new Timer();
        timer.Execute(1000);
    }
}