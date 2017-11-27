using System;
public class NumberDoubled
{
    public static int Twice(int n)
    {
        return n * 2;
    }

    public static void Main()
    {
        Console.Write("Number? ");
        int n = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(Twice(n));
    }
}

