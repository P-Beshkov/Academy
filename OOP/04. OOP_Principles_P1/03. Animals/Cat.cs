using System;

abstract public class Cat : Animal, ISound
{
    public Cat(string name, bool isFemale) : base(name,isFemale)
    {
    }

    public Cat(string name, bool isFemale, int age) : base(name, isFemale, age)
    {
    }

    public void ProduceSound()
    {
        Console.WriteLine("Miaaayyy");
    }
}