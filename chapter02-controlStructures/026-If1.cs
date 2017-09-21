// Contact with if : one "if" statement

using System;

class If1
{
    static void Main()
    {
        int x;

        Console.WriteLine("Enter a number: ");
        x = Convert.ToInt32(Console.ReadLine());

        if (x > 0)
            Console.WriteLine("It's a positive number");
    }
}
