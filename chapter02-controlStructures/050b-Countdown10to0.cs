// Count down, 10 to 0, even numbers

using System;
public class Ex50b
{
    public static void Main()
    {
        int count = 10;
        
        do
        {
            Console.Write("{0} ",count);
            count = count - 2;
        }
        while (count >= 0);
        Console.WriteLine();
    }
}
