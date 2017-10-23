// Fibonacci
// Miguel Puerta

using System;

public class myCs
{
    public static void Main()
    {
        long term, num1 = 0, num2 = 1, result = 0;
        double division;
        
        Console.Write("Which term of the Fibonacci series? ");
        term = Convert.ToInt64(Console.ReadLine());
        // I supose the number 21 is the 7th term, not the 8th
        term--;
        
        for( int i = 0; i < term; i++ )
        {
            result = Convert.ToByte( num1 + num2 );
            num1 = num2;
            num2 = result;
        }
        
        Console.Write("The term is ");
        Console.WriteLine(num2);
        Console.Write("And divided byte the previous term is ");
        division = (double) result / num1;
        Console.WriteLine(division);
    }
}
