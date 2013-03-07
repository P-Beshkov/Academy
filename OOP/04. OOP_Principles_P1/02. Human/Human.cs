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
        List<Student> groupStudents = new List<Student>();
        groupStudents.OrderBy((st) => st.Grade);
        List<Worker> workers = new List<Worker>();
        workers.OrderByDescending((worker) => worker.MoneyPerHour());
        List<Human> humans = new List<Human>();
        humans.AddRange(groupStudents);
        humans.AddRange(workers);
        humans.OrderBy((human) => human.FirstName).ThenBy((human) => human.LastName);
    }
}