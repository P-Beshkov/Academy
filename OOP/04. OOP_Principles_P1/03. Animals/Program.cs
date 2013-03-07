/* 03. Create a hierarchy Dog, Frog, Cat, Kitten, Tomcat and define useful constructors 
* and methods. Dogs, frogs and cats are Animals. All animals can produce sound 
* (specified by the ISound interface). Kittens and tomcats are cats. All animals are 
* described by age, name and sex. Kittens can be only female and tomcats can be only male. 
* Each animal produces a specific sound. Create arrays of different kinds of animals and 
* calculate the average age of each kind of animal using a static method (you may use LINQ). */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        Animal[] animals = new Animal[]
        {
            new Kitten("Lucky",2),
            new Tomcat("Goshko",3),
            new Frog("Pesho",true,5),
            new Frog("Kermit",false,100)
        };

        double average = 0;
        foreach (Animal item in animals)
        {
            average += item.Age;
        }
        average /= animals.Length;
        Console.WriteLine("Average from for each = "+average);
        average =
            (from animal in animals
             select animal.Age).Average();
        Console.WriteLine("Average from LINQ = "+average);
    }
}