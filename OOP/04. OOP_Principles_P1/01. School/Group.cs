using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Group
{
    private static int number = 1;
    private List<Student> students;
    private List<Teacher> teachers;
    public string comment;
    private int groupNumber;

    public int GroupNumber
    {
        get
        {
            return this.groupNumber;
        }
        private set
        {
            this.groupNumber = value;
        }
    }

    public int Count
    {
        get
        {
            return students.Count;
        }
    }

    public Group()
    {
        this.GroupNumber = number++;
        this.students = new List<Student>();
        this.teachers = new List<Teacher>();
    }

    public Group(List<Student> students, List<Teacher> teachers)
    {
        this.students = students;
        this.teachers = teachers;
        this.GroupNumber = number++;
    }

    public static Group CreateGroup()
    {
        Group group = new Group();
        Console.WriteLine("Group size = ");
        int groupCount = int.Parse(Console.ReadLine());
        for (int i = 0; i < groupCount; i++)
        {
            Student newPupil = Student.CreateStudent(i + 1);
            group.students.Add(newPupil);
        }
        TeacherSet.ShowAllTeachers();
        Console.WriteLine("Teachers for this group = ");
        int teachersCount = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter teacher number to add [empty line for end]:");
        for (int i = 0; i < teachersCount; i++)
        {
            string input = Console.ReadLine();
            if (input != "")
            {
                int number = int.Parse(input);
                group.teachers.Add(TeacherSet.GetItem(number));
            }
        }

        return group;
    }
}