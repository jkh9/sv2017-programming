/*
 Querubin Santana
 Findind the dividers of a number
*/

using System;

public class Dividers
{
    public static void Main()
    {
        int n;
        int cont = 1;
        
        Console.Write("Enter a number please: ");
        n = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("The dividers of {0} are ", n);
        
        while(cont < n)
        {
            if(n % cont == 0)
                Console.WriteLine(cont);
            cont = cont + 1;
        }
        
    }
}
