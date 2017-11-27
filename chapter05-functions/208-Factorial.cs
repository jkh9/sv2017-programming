//Javier herreros pozo

using System;
public class Factorial
{
    public static int Fact(int n)
    {
        int result = 1;
        for(int i=n; i>=1; i--)
            result *= i;
        return result;
    }

    public static void Main()
    {
        Console.Write("Number? ");
        int n = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(Fact(n));
    }
}

