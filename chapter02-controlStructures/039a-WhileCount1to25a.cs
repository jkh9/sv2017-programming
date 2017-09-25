// Count 1 to 25

using System;
public class Ex038
{
    public static void Main()
    {
        int count = 0;
        
        while (count < 25)
        {
            count = count + 1;
            Console.Write("{0} ",count);
        }
        Console.WriteLine();
    }
}
