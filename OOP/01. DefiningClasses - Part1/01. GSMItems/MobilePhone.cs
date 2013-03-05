/*01. Define a class that holds information about a mobile phone device: model, 
* manufacturer, price, owner, battery characteristics (model, hours idle and hours talk) 
* and display characteristics (size and number of colors). Define 3 separate classes 
* (class MobilePhone holding instances of the classes Battery and Display). 
02. Define several constructors for the defined classes that take different sets of arguments 
* (the full information for the class or part of it). Assume that model and manufacturer are 
* mandatory (the others are optional). All unknown data fill with null. 
03. Add an enumeration BatteryType (Li-Ion, NiMH, NiCd, …) and use it as a new field for the batteries.
04. Add a method in the MobilePhone class for displaying all information about it. Try to override ToString().
05. Use properties to encapsulate the data fields inside the MobilePhone, Battery and 
* Display classes. Ensure all fields hold correct data at any given time.
06. Add a static field and a property IPhone4S in the MobilePhone class to hold the information about iPhone 4S.
09. Add a property CallHistory in the MobilePhone class to hold a list of the performed calls. 
* Try to use the system class List<Call>.
10. Add methods in the MobilePhone class for adding and deleting calls from the calls 
* history. Add a method to clear the call history.
11. Add a method that calculates the total price of the calls in the call history. 
* Assume the price per minute is fixed and is provided as a parameter. */

using System;
using System.Collections.Generic;

public class MobilePhone
{
    private static MobilePhone iPhone = new MobilePhone("Apple", "4S", "Pesho", 999);
    private Battery battery;
    private Display display;
    private List<Call> callHistory;    
    private string model;

    public string CallHistory
    {
        get
        {
            string result = String.Empty;
            int index = 1;
            foreach (Call item in callHistory)
            {
                result +=string.Format("{0}. {1}\n", index, item);
                index++;
            }
            return result;
        }
    }

    public static MobilePhone IPhone
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
            if (value!=null && value.Length!=0)
            {
                this.model = value;
            }
            else
            {
                throw new ArgumentNullException("Model must not be null");
            }
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
            if (value!=null && value.Length!=0)
            {
                this.manufacturer = value;
            }
            else
            {
                throw new ArgumentNullException("Manufacturer must not be null");
            }
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
            else
            {
                throw new ArgumentOutOfRangeException("Price must be positive");
            }
        }
    }

    private MobilePhone()
    {        
        this.Owner = null;
        callHistory = new List<Call>();
        battery = new Battery();
        display = new Display();
    }

    public MobilePhone(string manufacturer, string model) : this()
    {
        this.Model = model;
        this.Manufacturer = manufacturer;
    }

    public MobilePhone(string manufacturer, string model, string owner) : this(manufacturer, model)
    {
        this.Owner = owner;
    }

    public MobilePhone(string manufacturer, string model, string owner, decimal price) : this(manufacturer, model, owner)
    {
        this.Price = price;
    }

    public override string ToString()
    {
        string result = string.Format(
            "{0} - {1}\nOwner - {2}\nBattery hours[talk/idle] - {3}/{4}\nDisplay[size/colors] - {5}/{6}", 
            this.Manufacturer, this.Model, this.Owner,this.battery.HoursTalk,this.battery.HoursIdle,this.display.Size,this.display.ColorsCount);
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
        Console.WriteLine(this.CallHistory);
        Console.Write("Call to remove: ");
        int index = int.Parse(Console.ReadLine());
        index--;
        callHistory.RemoveAt(index);
    }

    public void ClearCallHistory()
    {
        callHistory.Clear();
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
}