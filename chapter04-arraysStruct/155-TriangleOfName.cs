// Exercise 155: Triangle of a name

using System;

class Ex155
{
    static void Main()
    {
        Console.WriteLine("Name? ");
        string name = Console.ReadLine();

        for (int i = 1; i <= name.Length; i++)
        {
            Console.WriteLine(name.Substring(0,i));
        }

    }
}
