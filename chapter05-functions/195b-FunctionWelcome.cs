using System;

public class Ex195
{
    public static void Welcome(string name)
    {
        Console.WriteLine("Hello, " + name);
    }

    public static void Main()
    {
        Console.WriteLine("1");
        Welcome("Cualquiera");
        Console.WriteLine("2");

        Console.Write("Enter your name: ");
        string t = Console.ReadLine();
        Welcome(t);
    }

}
