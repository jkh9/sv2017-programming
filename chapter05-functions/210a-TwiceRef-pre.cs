using System;
public class NumberDoubled2
{
    public static void Twice(int n)
    {
        n = n * 2;
        Console.WriteLine("In the function: "+n);
    }

    public static void Main()
    {
        Console.Write("Number? ");
        int n = Convert.ToInt32(Console.ReadLine());

        Twice(n);
        Console.WriteLine("In Main: " + n);
    }
}

