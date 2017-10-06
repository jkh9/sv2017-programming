// David Israel Muñoz Salinas
/*
 * Write a C# program to display the even numbers 
 * from 2 to 20 except 4, using "for" and "continue".
 * Then do it again usin "while" and "if".
 */

using System;
public class Ex74
{
    public static void Main()
    {
        // even numbers 2 to 20 except 4, using "for" and "continue"
        for (int i = 2; i <= 20; i += 2)
        {
            if (i == 4)
                continue;
            Console.Write("{0} ",i);
        }
        Console.WriteLine();
        
        // even numbers 2 to 20 except 4, using "while"
        int j=2;
        while (j<=20)
        {
            if (j != 4)
                Console.Write("{0} ",j);
            j += 2;
        }
    }
}
