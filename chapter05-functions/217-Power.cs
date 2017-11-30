/*
Function Power
Luis Selles
*/

using System;

public class FunctionPower
{
    public static int Power(int b, int e)
    {
        int result = 1;
        for(int i = 0; i < e; i++)
        {
            result *= b;
        }
        return result;
    }
    
    public static void Main()
    {
        int x = Power(2,3);
        Console.WriteLine("The 3rd power of 2 is: "+x);
    }
}
