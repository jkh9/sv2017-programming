// Countdown, 10 to 0, even numbers, for

using System;
public class CountdownFor2
{
    public static void Main()
    {
        for (int i = 10; i >= 0; i -= 2)
            Console.Write("{0} ",i);
        Console.WriteLine();
    }
}
