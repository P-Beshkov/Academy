/*01. Define a class that holds information about a mobile phone device: model, 
* manufacturer, price, owner, battery characteristics (model, hours idle and hours talk) 
* and display characteristics (size and number of colors). Define 3 separate classes 
* (class GSM holding instances of the classes Battery and Display). 
02. Define several constructors for the defined classes that take different sets of arguments 
* (the full information for the class or part of it). Assume that model and manufacturer are 
* mandatory (the others are optional). All unknown data fill with null. 
03. Add an enumeration BatteryType (Li-Ion, NiMH, NiCd, …) and use it as a new field for the batteries.
04. Add a method in the GSM class for displaying all information about it. Try to override ToString().
05. Use properties to encapsulate the data fields inside the GSM, Battery and 
* Display classes. Ensure all fields hold correct data at any given time.
06. Add a static field and a property IPhone4S in the GSM class to hold the information about iPhone 4S.
09. Add a property CallHistory in the GSM class to hold a list of the performed calls. 
* Try to use the system class List<Call>.
10. Add methods in the GSM class for adding and deleting calls from the calls 
* history. Add a method to clear the call history.
11. Add a method that calculates the total price of the calls in the call history. 
* Assume the price per minute is fixed and is provided as a parameter. */

using System;
using System.Collections.Generic;
using System.Linq;

public class GSM
{
    private static GSM iPhone = new GSM("Apple", "4S", "Pesho", 999);
    private List<Call> callHistory;    
    private string model;

    public string CallHistory
    {
        get
        {
            string result = String.Empty;
            foreach (Call item in callHistory)
            {
                result += item;
            }
            return result;
        }
    }

    public static GSM IPhone
    {
        get
        {
            return iPhone;
        }
    }

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

    private string manufacturer;

    public string Manufacturer
    {
        get
        {
            return this.manufacturer;
        }
        set
        {
            this.manufacturer = value;
        }
    }

    private string owner;

    public string Owner
    {
        get
        {
            return this.owner;
        }
        set
        {
            this.owner = value;
        }
    }

    private decimal price;

    public decimal Price
    {
        get
        {
            return this.price;
        }
        set
        {
            if (value > 0.0M)
            {
                this.price = value;
            }
        }
    }

    public GSM()
    {
        this.Model = null;
        this.Manufacturer = null;
        this.Owner = null;
        callHistory = new List<Call>();
    }

    public GSM(string manufacturer, string model) : this()
    {
        this.Model = model;
        this.Manufacturer = manufacturer;
    }

    public GSM(string manufacturer, string model, string owner) : this(manufacturer, model)
    {
        this.Owner = owner;
    }

    public GSM(string manufacturer, string model, string owner, decimal price) : this(manufacturer, model, owner)
    {
        this.Price = price;
    }

    public override string ToString()
    {
        string result = string.Format("{0} - {1}\nOwner - {2}", this.Manufacturer, this.Model, this.Owner);
        return result;
    }

    public void AddCall()
    {
        Console.Write("Phone you dialed: ");
        string dialed = Console.ReadLine();
        Console.Write("Duration[in seconds]: ");
        int duration = int.Parse(Console.ReadLine());
        callHistory.Add(new Call(DateTime.Now, dialed, duration));
    }

    public void DeleteCall()
    {
        DisplayCallHistory();
        Console.Write("Call to remove: ");
        int index = int.Parse(Console.ReadLine());
        index--;
        callHistory.RemoveAt(index);
    }

    public void ClearCallHistory()
    {
        callHistory.Clear();
    }

    public void DisplayCallHistory()
    {
        int index = 1;
        foreach (Call item in callHistory)
        {
            Console.WriteLine("{0}. {1}", index, item);
            index++;
        }
    }

    public decimal CalculateBill(decimal ForMinute)
    {
        decimal bill = 0;
        foreach (Call item in callHistory)
        {
            int minutes = item.Duration / 60;
            if (item.Duration % 60 != 0)
            {
                minutes++;
            }
            bill += minutes * ForMinute;
        }
        return bill;
    }

    internal class Battery
    {
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
            this.HoursIdle = 0;
            this.HoursTalk = 0;
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

    private class Display
    {
        internal decimal Size { get; private set; }

        internal long ColorsCount { get; private set; }

        public Display()
        {
            this.Size = 0;
            this.ColorsCount = 0;
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
}