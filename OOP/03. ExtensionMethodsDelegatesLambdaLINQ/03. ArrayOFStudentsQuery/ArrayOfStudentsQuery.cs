/*01. Write a method that from a given array of students finds all 
* students whose first name is before its last name alphabetically.
* Use LINQ query operators. 
04. Write a LINQ query that finds the first name and last name of
* all students with age between 18 and 24. 
05. Using the extension methods OrderBy() and ThenBy() with lambda 
* expressions sort the students by first name and last name in
* descending order. Rewrite the same with LINQ.
*/

using System;
using System.Collections.Generic;
using System.Linq;

class ArrayOfStudentsQuery
{
    class Student
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; private set; }
        
        public Student(string firstName, string lastName, int age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
        }
    }
    static void Main()
    {
        List<Student> students = new List<Student>();
        students.Add(new Student("Angel", "Petkov",20));
        students.Add(new Student("Petyr", "Angelov",26));
        students.Add(new Student("Gosho", "Popov",16));
        students.Add(new Student("Petyr", "Karagiozov",18));

        var selected =
                      from item in students
                      where item.FirstName.CompareTo(item.LastName) < 0
                      select item;
        foreach (var item in selected)
        {
            Console.WriteLine(item.FirstName + " " + item.LastName);
        }
        Console.WriteLine();

        Console.WriteLine("Within age [18-24]");
        selected =
                  from student in students
                  where student.Age >= 18 && student.Age <= 24
                  select student;
        foreach (var item in selected)
        {
            Console.WriteLine(item.FirstName + " " + item.LastName + " - " + item.Age);
        }
        Console.WriteLine();

        Console.WriteLine("Sorted students with Lambda Expression");
        selected = students.OrderBy((st) => st.FirstName).ThenBy((st) => st.LastName);
        foreach (var item in selected)
        {
            Console.WriteLine(item.FirstName + " " + item.LastName + " - " + item.Age);
        }
        Console.WriteLine();

        selected =
                  from student in students
                  orderby student.FirstName + student.LastName
                  select student;
        Console.WriteLine("Sorted students with LINQ");
        selected = students.OrderBy((st) => st.FirstName).ThenBy((st) => st.LastName);
        foreach (var item in selected)
        {
            Console.WriteLine(item.FirstName + " " + item.LastName + " - " + item.Age);
        }
        Console.WriteLine(); 
    }
}