using System;

public class Ex207
{
    public static void MaxMinArray(int[] x, 
        ref int max, ref int min)
    {
        max = x[0];
        min = x[0];
        foreach (int n in x)
        {
            max = n > max ? n : max;
            min = n < min ? n : min;
        }
    }
    
    public static void Main()
    {
        int[] data = { 10, 15, -5 };
        int maximum = 0, minimum = 0;
        MaxMinArray(data, ref maximum, ref minimum);
        Console.WriteLine("max = "+ maximum);
        Console.WriteLine("min = "+ minimum);
    }
}
