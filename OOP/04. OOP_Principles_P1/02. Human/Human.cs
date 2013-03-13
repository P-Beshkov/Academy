/*02. Define abstract class Human with first name and last name. 
* Define the proper constructors and properties for this hierarchy. Initialize a list 
* of 10 students and sort them by grade in ascending order 
* (use LINQ or OrderBy() extension method). Initialize a list of 10 
* workers and sort them by money per hour in descending order. Merge 
* the lists and sort them by first name and last name. */

using System;
using System.Collections.Generic;
using System.Linq;

abstract class Human
{
    private string firstName;
    private string lastName;

    public string FirstName
    {
        get
        {
            return this.firstName;
        }
    }

    public string LastName
    {
        get
        {
            return this.lastName;
        }
    }

    public Human(string first, string second)
    {
        this.firstName = first;
        this.lastName = second;
    }
}

class Test
{
    static void Main(string[] args)
    {
        List<Student> groupStudents = new List<Student>()
        {
            new Student("Nikolaj","Nachev",7),
            new Student("Boyan","Dimitrov",10),
            new Student("Robin","Maurus",8),
            new Student("Atanas","Zlatanov",5),
            new Student("Paolo","Ferra",11)
        };
        groupStudents.OrderBy((st) => st.Grade);
        foreach (Student item in groupStudents)
        {
            Console.WriteLine(item.FirstName + " " + item.LastName + " - Grade " + item.Grade);
        }
        Console.WriteLine();
        List<Worker> workers = new List<Worker>()
        {
            new Worker("Anton","Vondenicharov",90,5),
            new Worker("Dimitar","Bosilkov",200,6),
            new Worker("Dean","Malinov",1000,4),
            new Worker("Georgi","Metodiev",120,4),
            new Worker("Dimitar","Borisov",100,5),
            
        };

        workers.OrderByDescending((worker) => worker.MoneyPerHour());
        foreach (Worker item in workers)
        {
            Console.WriteLine("{0} {1} - Week Salary = {2}, Work hour = {3}",
                item.FirstName, item.LastName, item.WeekSalary, item.WorkHoursPerDay);
        }
        Console.WriteLine();
        List<Human> humans = new List<Human>();
        humans.AddRange(groupStudents);
        humans.AddRange(workers);
        humans.OrderBy((human) => human.FirstName).ThenBy((human) => human.LastName);
        foreach (Human item in humans)
        {
            Console.WriteLine("{0} {1}", item.FirstName, item.LastName);
        }
    }
}