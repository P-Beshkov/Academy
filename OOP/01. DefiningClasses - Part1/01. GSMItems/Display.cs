using System;
using System.Collections.Generic;
internal class Display
{
    
    private static decimal defaultSize = 4;
    private static long defaultColorsCount = 256;
    private static List<Tuple<string, decimal, long>> DisplayData = new List<Tuple<string, decimal, long>>()
    {
        new Tuple<string, decimal, long>("NokiaN95",3.7M,16000000L),
        new Tuple<string, decimal, long>("SamsungNote2",5.3M,16000000L),       
    };   
    
    public decimal Size { get; private set; }

    public long ColorsCount { get; private set; }

    public Display()
    {
        this.Size = Display.defaultSize;
        this.ColorsCount = Display.defaultColorsCount;     
    }

    public Display(decimal size) : this()
    {
        this.Size = size;
    }

    public Display(decimal size, long colorsCount) : this(size)
    {
        this.ColorsCount = colorsCount;
    }
}