/*
Function Power, recursive version
*/

using System;

public class FunctionPowerRecursive
{
    public static int Power(int b, int e)
    {
        // Base case
        if (e == 0)
            return 1;
        
        // General case
        return b * Power(b, e-1);
    }
    
    public static void Main()
    {
        int x = Power(2,3);
        Console.WriteLine("The 3rd power of 2 is: "+x);
    }
}
