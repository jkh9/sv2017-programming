/*
Use "virtual" and "override" instead of "new" and test the behavior 
of your array of dogs.
*/


using System;

public class Dog
{
    public virtual void Bark()
    {
        Console.WriteLine("Woof!");
    }
}

public class Dalmatian : Dog
{
    public override void Bark()
    {
        Console.WriteLine("Awww");
    }
}


public class DogsMakingNoise1
{
    public static void Main()
    {
        Dog[] dogs = new Dog[3];
        dogs[0] = new Dog();
        dogs[1] = new Dalmatian();
        dogs[2] = new Dog();

        // Let's test it...
        for (int i = 0; i < 3; i++)
        {
            dogs[i].Bark();
        }
    }
}
