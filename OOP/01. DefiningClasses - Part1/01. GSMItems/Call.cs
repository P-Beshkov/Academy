/*08. Create a class Call to hold a call performed through a GSM. It should contain date, time, 
* dialed phone number and duration (in seconds). */
using System;
using System.Collections.Generic;

class Call
{
    private static int defaultDuration=60;
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
        this.phoneDialed = phoneDialed;
    }
    public Call(DateTime date, string phoneDialed,int duration) : this(date,phoneDialed)
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
            this.duration = value;
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
            this.phoneDialed = value;
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
