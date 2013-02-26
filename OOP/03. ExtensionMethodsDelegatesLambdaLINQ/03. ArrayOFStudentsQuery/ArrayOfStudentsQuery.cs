/*01. Write a method that from a given array of students finds all 
 * students whose first name is before its last name alphabetically.
 * Use LINQ query operators. 
04. Write a LINQ query that finds the first name and last name of
 * all students with age between 18 and 24. */

using System;
using System.Collections.Generic;
using System.Linq;

class ArrayOfStudentsQuery
{
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Student(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }
    }
    static void Main()
    {
        List<Student> students = new List<Student>();
        students.Add(new Student("Angel", "Petkov"));
        students.Add(new Student("Petyr", "Angelov"));
        students.Add(new Student("Gosho", "Popov"));
        students.Add(new Student("Ivan", "Karagiozov"));
        var selected =
            from item in students
            where item.FirstName.CompareTo(item.LastName) < 0
            select item;
        foreach (var item in selected)
        {
            Console.WriteLine(item.FirstName+" "+item.LastName);
        }
    }
}
