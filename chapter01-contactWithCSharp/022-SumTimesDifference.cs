// Sum times difference

using System;

public class SumTimesDifference
{
    public static void Main()
    {
        int a, b;

        Console.Write("Enter a: ");
        a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter b:");
        b = Convert.ToInt32(Console.ReadLine());

        Console.Write("(a+b)*(a-b) = ");
        Console.WriteLine ((a+b)*(a-b));
        Console.Write("(a*a-b*b) = ");
        Console.WriteLine (a*a-b*b);
    }
}
