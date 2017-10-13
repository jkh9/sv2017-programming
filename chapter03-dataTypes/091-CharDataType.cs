//Pedro Luis Coloma

using System;

public class Square
{
    public static void Main()
    {
        char a,b,c;

        Console.WriteLine("First letter: ");
        a = Convert.ToChar(Console.ReadLine());
        Console.WriteLine("second letter: ");
        b = Convert.ToChar(Console.ReadLine());
        Console.WriteLine("third letter: ");
        c = Convert.ToChar(Console.ReadLine());
        Console.Write("You said \"{0}{1}{2}\"",a,b,c);
    }
}
