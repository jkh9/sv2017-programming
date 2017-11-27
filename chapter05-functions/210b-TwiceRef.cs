using System;
public class NumberDoubled2b
{
    public static void Twice(ref int n)
    {
        n = n * 2;
        Console.WriteLine("In the function: "+n);
    }

    public static void Main()
    {
        Console.Write("Number? ");
        int n = Convert.ToInt32(Console.ReadLine());

        Twice(ref n);
        Console.WriteLine("In Main: " + n);
    }
}

