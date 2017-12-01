/*
Functions Multiply and MultiplyR

Create two functions, Multiply and MultiplyR, to calculate the product 
of two non-negative integer numbers using sums. The first version must 
be iterative, and the second one must be recursive.
*/

using System;

public class MultiplyFunctions
{
    public static int Multiply(int number1, int number2)
    {
        int sum=0;
        
        for(int i = 0 ;i < number2 ; i++)
            sum += number1;
        
        return sum;
    }
    
    
    public static int MultiplyR(int number1, int number2)
    {
        if(number2 == 0)
            return 0;
        else
            return number1 + MultiplyR( number1, number2-1 );
    }
    
    
    public static void Main(string [] args)
    {
        int  number1= 5, number2= 3;
        
        Console.WriteLine( Multiply(number1,number2) );
        Console.WriteLine( MultiplyR(number1,number2) );
    }
    
}
