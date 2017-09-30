// Count 1 to 25, while (starting at 0)

using System;
public class Count1To25a
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
