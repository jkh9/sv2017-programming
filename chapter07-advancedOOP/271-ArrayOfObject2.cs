/*
Create a class "Dog" with a method "Bark", which will display 
"Woof" on screen.
 
Create a class "Dalmatian", inheriting from "Dog". Its "Bark", 
which will display "Awww" on screen.

Create in Main an array of 3 dogs, one of which will be a 
Dalmatian, and make them bark.
*/

using System;

public class Dog
{
    public void Bark()
    {
        Console.WriteLine("Woof!");
    }
}

public class Dalmatian : Dog
{
    public new void Bark()
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
