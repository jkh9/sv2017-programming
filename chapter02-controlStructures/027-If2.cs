// Contact with if (2) : two "if" statements

using System;

class If2
{
    static void Main()
    {
        int x;

        Console.WriteLine("Enter a number: ");
        x = Convert.ToInt32(Console.ReadLine());

        if (x > 0)
            Console.WriteLine("It's a positive number");

        if (x <= 0)
            Console.WriteLine("It's a negative number or zero");
    }
}
