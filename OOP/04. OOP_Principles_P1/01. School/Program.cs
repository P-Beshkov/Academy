using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{

    static void Main(string[] args)
    {
        Group firtsGroup = Group.CreateGroup();
    }
}

public class Human
{
    private string name;
    public string Name
    {
        get
        {
            return this.name;
        }
        protected set
        {
            if (value != null)
            {
                this.name = value;
            }
            else
            {
                throw new ArgumentNullException("Name can't be null");
            }

        }
    }
    public Human(string name)
    {
        this.Name = name;
    }
}
public struct Discipline
{
    public string name;
    public int numberLectures;
    public int numberExercises;
    public Discipline(string name, int lec, int exer)
    {
        this.name = name;
        this.numberLectures = lec;
        this.numberExercises = exer;
    }
}
public static class DisciplineSet
{
    private static List<Discipline> disciplines=new List<Discipline>();
    public static void Add()
    {
        Console.Write("Discipline name = ");
        string name = Console.ReadLine();
        Console.Write("Lectures = ");
        int lecCount = int.Parse(Console.ReadLine());
        Console.Write("Exercises = ");
        int exerCount = int.Parse(Console.ReadLine());
        disciplines.Add(new Discipline(name, lecCount, exerCount));
    }
    public static void ShowAllDisciplines()
    {
        int index = 0;
        foreach (Discipline item in disciplines)
        {
            Console.WriteLine("{0}. {1} - {2}/{3}",index++,item.name,item.numberLectures,item.numberExercises);
        }
    }
    public static Discipline GetItem(int index)
    {
        return disciplines[index];
    }
}