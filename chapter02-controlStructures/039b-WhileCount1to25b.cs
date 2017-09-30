// Count 1 to 25, while (starting at 1)

using System;
public class Count1To25b
{
    public static void Main()
    {
        int count = 1;
        
        while (count <= 25)
        {
            Console.Write("{0} ",count);
            count = count + 1;
        }
        Console.WriteLine();
    }
}
