/*
Create a class "Dog" with a method "Bark", which will 
display "Woof" on screen.

Create in Main an array of 3 dogs and make them bark.
*/

using System;

public class Dog
{
    public void Bark()
    {
        Console.WriteLine("Woof!");
    }
}

public class DogsMakingNoise1
{
    public static void Main()
    {
        Dog[] dogs = new Dog[3];
        for (int i = 0; i < 3; i++)
        {
            dogs[i] = new Dog();
        }

        // Let's test it...
        for (int i = 0; i < 3; i++)
        {
            dogs[i].Bark();
        }
    }
}
