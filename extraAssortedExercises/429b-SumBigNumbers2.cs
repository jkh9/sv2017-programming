// Sum big numbers 2

using System;
using System.Numerics;

public class SumBigNumbers2
{
    public static void Main()
    {
        string num1 = Console.ReadLine();
        string num2 = Console.ReadLine();
        BigInteger n1 = BigInteger.Parse(num1);
        BigInteger n2 = BigInteger.Parse(num2);
        Console.WriteLine( n1 + n2 );
    }
}
