//Miguel García Gil

using System;

public class AbsoluteValue
{
    public static void Main()
    {
        int x, abs;
        
        Console.Write ("Enter a number: ");
        x = Convert.ToInt32 (Console.ReadLine());
        
        if (x > 0)
            abs = x;
        else
            abs = -x;        
        Console.WriteLine ("Its absolute value is {0}", abs);
        
        abs = x > 0 ? x : -x;        
        Console.WriteLine ("Its absolute value is {0}", abs);
    }
}
