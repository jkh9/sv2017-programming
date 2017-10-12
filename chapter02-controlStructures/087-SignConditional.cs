/*
Create a program which assigns an integer variable named "sign" the 
value "1", "-1" or "0", depending on if an integer number n (entered by 
the user) is positive, negative or zero.

Do it in two different ways: first using "if" and then using the 
"conditional operator" (?)
*/

using System;
public class Sign
{
    public static void Main()
    {
        int n, sign;
        
        Console.Write("Enter a number: ");
        n = Convert.ToInt32( Console.ReadLine() );
        
        if (n > 0)
            sign = 1;
        else if (n == 0)
            sign = 0;
        else
            sign = -1;
        Console.WriteLine("Sign = {0} ", sign);
            
        sign = n > 0 ? 1 : ( n == 0 ? 0 : -1);
        Console.WriteLine("Sign = {0} ", sign);
    }
}
