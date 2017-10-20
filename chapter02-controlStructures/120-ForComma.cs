// "for" + comma operator
// angel rebollo berna

using System;

public class Ex
{
    public static void Main()
    {
        for (byte i = 1,j = 20; (i <= 10) && (j <= 30) ; i++, j+=2)
            Console.WriteLine("{0} {1}",i,j);
    }
}
