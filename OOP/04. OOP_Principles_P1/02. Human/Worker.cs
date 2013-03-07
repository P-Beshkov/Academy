/* Define class Worker derived from Human with 
* new property WeekSalary and WorkHoursPerDay and method MoneyPerHour() 
* that returns money earned by hour by the worker. */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Worker : Human
{
    private decimal weekSalary;
    private int workHoursPerDay;

    public decimal WeekSalary
    {
        get
        {
            return this.weekSalary;
        }
        set
        {
            if (value > 80)
            {
                this.weekSalary = value;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Week salary must be bigger than 80");
            }
        }
    }

    public int WorkHoursPerDay
    {
        get
        {
            return this.workHoursPerDay;
        }
        set
        {
            if (value > 2)
            {
                this.workHoursPerDay = value;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Work hours per day must be [2-12]");
            }
        }
    }

    public decimal MoneyPerHour()
    {
        return weekSalary / (5 * workHoursPerDay);
    }
    public Worker () : base("Not defined","Not defined")
    {
        this.WorkHoursPerDay = 8;
        this.WeekSalary = 100;
    }
    public Worker(string first, string second) : base(first,second)
    {
        this.WorkHoursPerDay = 8;
        this.WeekSalary = 100;
    }

    public Worker(string first, string second, decimal weekSalary, int workHoursPerDay) : base(first,second)
    {
        this.WeekSalary = weekSalary;
        this.WorkHoursPerDay = workHoursPerDay;
    }
}