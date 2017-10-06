/*
Create a program to calculate an approximation for PI using the 
expression

pi/4 = 1/1 - 1/3 + 1/5 -1/7 + 1/9 - 1/11 + 1/13 ...

The user will indicate how many terms must be used, and the program 
will display all the results until that amount of terms.
*/

using System;

public class PiLeibniz
{
    public static void Main()
    {
        int terms;
        int numerator = 1000000;
        int denominator = 1;
        int piFourths = 0;
        
        Console.Write("How many terms to estimate PI? ");
        terms = Convert.ToInt32( Console.ReadLine() );
        
        for (int i = 0; i < terms; i++ )
        {
            piFourths += numerator / denominator;
            numerator = -numerator;
            denominator += 2;
        }
        Console.WriteLine( piFourths * 4 / 1000000.0 );
    }
}
