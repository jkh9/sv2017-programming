// Rectangle with a certain numeric char
// Javier Herreros Pozo
using System;

class Rectangle2
{
    static void Main()
    {
        int number;

        Console.WriteLine("what number : ?");
        number = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("{0}{0}{0}{0}{0}{0}", number);
        Console.WriteLine("{0}    {0}", number);
        Console.WriteLine("{0}    {0}", number);
        Console.WriteLine("{0}{0}{0}{0}{0}{0}", number);
    }
}
