/*08. Create a class Call to hold a call performed through a MobilePhone. It should contain date, time, 
* dialed phone number and duration (in seconds). */

using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class Call
{
    private static int defaultDuration = 60;
    private DateTime date;
    private string phoneDialed;
    private int duration;
   
    public Call()
    {
        this.Duration = defaultDuration;
    }

    public Call(DateTime date, string phoneDialed) : this()
    {
        this.Date = date;
        this.PhoneDialed = phoneDialed;
    }

    public Call(DateTime date, string phoneDialed, int duration) : this(date,phoneDialed)
    {
        this.Duration = duration;        
    }

    public override string ToString()
    {
        return string.Format("Date: {0}, PhoneDialed: {1}, Duration: {2}", this.Date, this.PhoneDialed, this.Duration);
    }

    public int Duration
    {
        get
        {
            return this.duration;
        }
        set
        {
            if (value>0)
            {
                this.duration = value;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Duration must be positive");
            }
            
        }
    }

    public string PhoneDialed
    {
        get
        {
            return this.phoneDialed;
        }
        set
        {
            MatchCollection matches = Regex.Matches(@"08[7,8,9]\d{7}", value);
            if (matches.Count != 0)
            {
                this.phoneDialed = matches[0].ToString();
            }
            else
            {
                throw new ArgumentException("Given data is not a phone number");
            }
        }
    }

    public DateTime Date
    {
        get
        {
            return this.date;
        }
        set
        {
            this.date = value;
        }
    }
}