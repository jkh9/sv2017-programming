// Contact with if (3) : if + else

using System;

class If3
{
    static void Main()
    {
        int x;

        Console.WriteLine("Enter a number: ");
        x = Convert.ToInt32(Console.ReadLine());

        if (x > 0)
            Console.WriteLine("It's a positive number");
        else
            Console.WriteLine("It's a negative number or zero");
    }
}
