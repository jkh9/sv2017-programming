// Count down, 10 to 0, even numbers

using System;
public class Ex50
{
    public static void Main()
    {
        int count = 10;
        
        while (count >= 0)
        {
            Console.Write("{0} ",count);
            count = count - 2;
        }
        Console.WriteLine();
    }
}
