/*
Ex.328) - Function writePowers3

Two functions to display the first n+1 powers of 3, ending with n = 0. The 
first function must do it in an iterative way (NOT recursive, but using  “for” 
o “while”), and must be called “writePowers3”. The second function must do it 
in a recursive way, and must be called “writePowers3r”. (2 points). An example 
of use might be:

WritePowers3( 4 );

81 27 9 3 1

WritePowers3r( 4 );

81 27 9 3 1
*/

//Javier Herreros Pozo

using System;
public class writepower
{
    public static void WritePowers3(int num)
    {
        for(int i = num ; i >= 0 ; i --)
            Console.Write("{0} ", Math.Pow(3,i) );
    }
    
    public static void WritePowers3r(int num)
    {
        if (num == 0)
            Console.Write("1 ");
        else
        {
            Console.Write("{0} ", Math.Pow(3,num) );
            WritePowers3r(num-1);
        }
    }
    
    public static void Main()
    {
        WritePowers3(4);
        Console.WriteLine();
        
        WritePowers3r(4);
        Console.WriteLine();
    }
}
