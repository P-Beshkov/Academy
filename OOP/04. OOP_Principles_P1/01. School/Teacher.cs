using System;
using System.Collections.Generic;
using System.Linq;

public class Teacher : Human
{
    private List<Discipline> disciplines;    

    public Teacher(string name) : base(name)
    {
    }

    public Teacher(string name, string comment) : base(name,comment)
    {
    }

    public Teacher(string name, List<Discipline> disciplines) : base(name)
    {
        this.disciplines = disciplines;
    }
   
    public void AddDisciplines()
    {
        DisciplineSet.ShowAllDisciplines();
        Console.WriteLine("Disciplines to add[empty line for end]:");
        string input = Console.ReadLine();
        while (input != "")
        {
            int number = int.Parse(input);
            disciplines.Add(DisciplineSet.GetItem(number));
            input = Console.ReadLine();
        }
    }
}

public static class TeacherSet
{
    private static List<Teacher> teachers = new List<Teacher>();

    public static int Available
    {
        get
        {
            return teachers.Count;
        }
    }

    public static void ShowAllTeachers()
    {
        int index = 0;
        foreach (Teacher item in teachers)
        {
            Console.WriteLine("{0}. {1}", index, item.Name);
        }
    }

    public static Teacher GetItem(int index)
    {
        return teachers[index];
    }
}