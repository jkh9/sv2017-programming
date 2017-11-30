// Factorial, recursion
// Javier herreros pozo

using System;
public class FactorialRecursion
{
    public static long Factorial(long n)
    {
        if (n == 0)
            return 1;
        return n * Factorial(n - 1);
    }
    
    public static void Main()
    {
        Console.Write("Num? ");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Factorial = " + Factorial(n));
    }
}
