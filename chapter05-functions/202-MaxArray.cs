using System;

public class Ex202
{
    public static int Max(int[] x)
    {
        int max = x[0];
        foreach (int n in x)
            max = n > max ? n : max;
        return max;
    }
    
    public static void Main()
    {
        int[] x = { 10, 15, -5 };
        Console.WriteLine(Max(x));
    }
}
