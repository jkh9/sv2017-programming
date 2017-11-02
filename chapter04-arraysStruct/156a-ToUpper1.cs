// Exercise 156: ToUpper (version 1)

using System;

class Ex156a
{
    static void Main()
    {
        Console.WriteLine("Name? ");
        string name = Console.ReadLine();

        name = name.ToUpper();
        Console.WriteLine(name);
    }
}
