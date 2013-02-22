using System.Collections.Generic;
internal class Battery
{
    private static int defaultHoursIdle = 400;
    private static int defaultHoursTalk = 10;
    private static List<KeyValuePair<string, BatteryType>> BatteryData = new List<KeyValuePair<string, BatteryType>>()
    {
        new KeyValuePair<string,BatteryType>("NokiaN95",BatteryType.LiIon),
        new KeyValuePair<string,BatteryType>("SamsungNote2",BatteryType.LiPoly),
    };
    
    public enum BatteryType
    {
        LiIon,
        LiPoly,
        NiMh,
        NiCd
    }
    private string model;

    public string Model
    {
        get
        {
            return this.model;
        }
        set
        {
            this.model = value;
        }
    }

    private int hoursIdle;

    public int HoursIdle
    {
        get
        {
            return this.hoursIdle;
        }
        set
        {
            this.hoursIdle = value;
        }
    }

    private int hoursTalk;

    public int HoursTalk
    {
        get
        {
            return this.hoursTalk;
        }
        set
        {
            this.hoursTalk = value;
        }
    }

    private BatteryType type;

    public BatteryType Type
    {
        get
        {
            return this.type;
        }
        set
        {
            this.type = value;
        }
    }

    public Battery()
    {
        this.Model = null;
        this.HoursIdle = Battery.defaultHoursIdle;
        this.HoursTalk = Battery.defaultHoursTalk;        
    }

    public Battery(string model) : this()
    {
        this.model = model;
    }

    public Battery(string model, int hoursIdle, int hoursTalk) : this(model)
    {
        this.HoursTalk = hoursTalk;
        this.HoursIdle = hoursIdle;
    }

    public Battery(string model, int hoursIdle, int hoursTalk, BatteryType type) : this(model, hoursIdle, hoursTalk)
    {
        this.Type = type;
    }
}