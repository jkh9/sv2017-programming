// Contact with if (4)

using System;

class If4
{
    static void Main()
    {
        int x;

        Console.WriteLine("Enter a number: ");
        x = Convert.ToInt32(Console.ReadLine());

        if (x > 0)
            Console.WriteLine("It's a positive number");
        else if (x < 0)
            Console.WriteLine("It's a negative number");
        else
            Console.WriteLine("It's zero");
    }
}
