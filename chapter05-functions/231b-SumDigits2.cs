// Function SumDigits
// Javier Cases

using System;

public class Ex231
{
    public static int SumDigits(int n)
    {
        int sum = 0;
        foreach (char d in n.ToString())
        {
            sum += Convert.ToInt32(d.ToString());
        }
        return sum;
    }


    public static void Main()
    {
        Console.WriteLine(SumDigits(123));
    }
}

